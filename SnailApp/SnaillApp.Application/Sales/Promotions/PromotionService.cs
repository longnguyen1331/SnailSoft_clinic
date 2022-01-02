using SnailApp.Application.Common;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SnailApp.ViewModels.Sales.Promotions;

namespace SnailApp.Application.Sales.Promotions
{
    public interface IPromotionService
    {
        Task<PagedResult<PromotionDto>> GetManageListPaging(ManagePromotionPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateBasicInfoAsync(PromotionRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<PromotionDto>> GetBasicInfoAsyncById(PromotionRequest request);
    }
    public class PromotionService : IPromotionService
    {
        private readonly EShopDbContext _context;
        private readonly IConfiguration _configuration;

        public PromotionService(EShopDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<ApiResult<int>> AddOrUpdateBasicInfoAsync(PromotionRequest request)
        {
            DateTime ngayValue;

            try
            {
                var languages = _context.Languages;
                bool isNew = (request.Id == null);
                Promotion promotion = null;
                PromotionTranslation promotionTranslation = null;
                List<PromotionTranslation> translations = null;

                if (isNew == true)
                {
                    translations = new List<PromotionTranslation>();
                    foreach (var language in languages)
                    {
                        if (language.Id == request.LanguageId)
                        {
                            translations.Add(new PromotionTranslation()
                            {
                                Name = request.Name,
                                Description = request.Description,
                                LanguageId = request.LanguageId
                            });
                        }
                        else
                        {
                            translations.Add(new PromotionTranslation()
                            {
                                Name = SystemConstants.AppConstants.NA,
                                Description = SystemConstants.AppConstants.NA,
                                LanguageId = language.Id
                            });
                        }
                    }

                    promotion = new Promotion()
                    {
                        CreatedUserId = Guid.Parse(request.CreatedUserId),
                        ModifiedUserId = Guid.Parse(request.ModifiedUserId),
                        PromotionTranslations = translations
                    };
                }
                else
                {
                    promotion = await _context.Promotions.FindAsync(request.Id);
                    promotionTranslation = await _context.PromotionTranslations.FirstOrDefaultAsync(x => x.PromotionId == request.Id
                                                                                                        && x.LanguageId == request.LanguageId);

                    if (promotion == null || promotionTranslation == null) throw new EShopException($"Cannot find a promotion with id: {request.Id}");

                    promotionTranslation.Name = request.Name;
                    promotionTranslation.Description = request.Description;                    
                }

                promotion.Code = request.Code;
                promotion.FromDate = (DateTime.TryParseExact(request.FromDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : DateTime.Now);
                promotion.ToDate = (DateTime.TryParseExact(request.ToDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : new Nullable<DateTime>());
                promotion.IsApply = request.IsApply;
                promotion.ModifiedDate = DateTime.Now;

                if (isNew == true) 
                {
                    _context.Promotions.Add(promotion);
                }
                else
                {
                    _context.PromotionTranslations.Update(promotionTranslation);
                    _context.Promotions.Update(promotion);
                }
                
                await _context.SaveChangesAsync();

                return new ApiSuccessResult<int>(promotion.Id);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }            
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var promotions = await _context.Promotions.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (promotions == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                List<int> promotionIds = promotions.Select(m => m.Id).ToList();
                var promotionTranslations = _context.PromotionTranslations.Where(m => promotionIds.Contains(m.PromotionId)).ToList();
                if (promotionTranslations != null)
                {
                    _context.PromotionTranslations.RemoveRange(promotionTranslations);
                }

                _context.Promotions.RemoveRange(promotions);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }
        public async Task<PagedResult<PromotionDto>> GetManageListPaging(ManagePromotionPagingRequest request)
        {
            //1. Select join
            var query = from p in _context.Promotions
                        join pt in _context.PromotionTranslations on p.Id equals pt.PromotionId into ppt
                            from pt in ppt.DefaultIfEmpty()
                        where pt.LanguageId == request.LanguageId
                        select new { p, pt };
            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.pt.Name.Contains(request.TextSearch));

            //3. Paging
            int totalRow = await query.CountAsync();

            if (request.PageIndex != null)
            {
                query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                            .Take(request.PageSize);
            }
            var data = await query.Select(x => new PromotionDto()
            {
                Id = x.p.Id,
                Code = x.p.Code,
                Name = x.pt.Name,
                Description = x.pt.Description,
                CreatedDate = x.p.CreatedDate,
                LanguageId = x.pt.LanguageId
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<PromotionDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }
        public async Task<ApiResult<PromotionDto>> GetBasicInfoAsyncById(PromotionRequest request)
        {
            var promotion = await (from p in _context.Promotions
                                   join pt in _context.PromotionTranslations on p.Id equals pt.PromotionId into p_pt
                                   from pt in p_pt.DefaultIfEmpty()
                                   where p.Id == request.Id && pt.LanguageId == request.LanguageId
                                   select new PromotionDto() {
                                       Id = p.Id,
                                       Code = p.Code,
                                       Name = pt.Name,
                                       Description = pt.Description,
                                       FromDate = p.FromDate,
                                       ToDate = p.ToDate,
                                       IsApply = p.IsApply
                                   }
                                ).AsNoTracking().FirstOrDefaultAsync();

            if (promotion == null)
            {
                return new ApiErrorResult<PromotionDto>("Chương trình khuyến mãi không tồn tại.");
            }

            return new ApiSuccessResult<PromotionDto>(promotion);
        }
    }
}
