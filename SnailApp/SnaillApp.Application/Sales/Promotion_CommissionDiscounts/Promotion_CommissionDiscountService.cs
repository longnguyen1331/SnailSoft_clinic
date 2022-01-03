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
using SnailApp.ViewModels.Sales.Promotion_CommissionDiscounts;
using SnailApp.ViewModels.Sales.CommissionDiscounts;

namespace SnailApp.Application.Sales.Promotion_CommissionDiscounts
{
    public interface IPromotion_CommissionDiscountService
    {
        Task<PagedResult<Promotion_CommissionDiscountDto>> GetManageListPaging(ManagePromotion_CommissionDiscountPagingRequest request);
        Task<ApiResult<int>> CreateAsync(Promotion_CommissionDiscountRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<Promotion_CommissionDiscountDto>> GetById(Promotion_CommissionDiscountRequest request);
        Task<ApiResult<int>> UpdateAsync(Promotion_CommissionDiscountRequest request);
    }
    public class Promotion_CommissionDiscountService : IPromotion_CommissionDiscountService
    {
        private readonly ClinicDbContext _context;
        private readonly IConfiguration _configuration;

        public Promotion_CommissionDiscountService(ClinicDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<ApiResult<int>> CreateAsync(Promotion_CommissionDiscountRequest request)
        {
            try
            {
                var promotion_CommissionDiscount = new Promotion_CommissionDiscount()
                {
                    PromotionId = request.PromotionId,
                    CommissionDiscountId = request.CommissionDiscountId
                };

                _context.Promotion_CommissionDiscounts.Add(promotion_CommissionDiscount);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(promotion_CommissionDiscount.Id);
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
                var promotion_CommissionDiscounts = await _context.Promotion_CommissionDiscounts.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (promotion_CommissionDiscounts == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                _context.Promotion_CommissionDiscounts.RemoveRange(promotion_CommissionDiscounts);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }

        public async Task<PagedResult<Promotion_CommissionDiscountDto>> GetManageListPaging(ManagePromotion_CommissionDiscountPagingRequest request)
        {
            try
            {
                //1. Select join
                var query = from p_cd in _context.Promotion_CommissionDiscounts
                            join cd in _context.CommissionDiscounts on p_cd.CommissionDiscountId equals cd.Id
                            join cdt in _context.CommissionDiscountTranslations on cd.Id equals cdt.CommissionDiscountId into cd_cdt
                            from cdt in cd_cdt.DefaultIfEmpty()
                            where cdt.LanguageId == request.LanguageId
                            select new { p_cd, cd, cdt };

                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                {
                    query = query.Where(x => x.cd.Name.Contains(request.TextSearch));
                }

                if (request.PromotionId != null)
                {
                    query = query.Where(x => x.p_cd.PromotionId == request.PromotionId);
                }

                //3. Paging
                int totalRow = await query.CountAsync();

                if (request.PageIndex != null)
                {
                    query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                                .Take(request.PageSize);
                }
                var data = await query.Select(x => new Promotion_CommissionDiscountDto()
                {
                    Id = x.p_cd.Id,
                    CommissionDiscountId = x.cd.Id,
                    CommissionDiscountCode = x.cd.Code,
                    CommissionDiscountName = x.cdt.Name,
                    CommissionDiscountDiscount = x.cd.Discount,
                    CommissionDiscountDiscountPercent = x.cd.DiscountPercent,
                    CommissionDiscountCommission = x.cd.Commission,
                    CommissionDiscountCommissionPercent = x.cd.CommissionPercent
                }).AsNoTracking().ToListAsync();

                //4. Select and projection
                var pagedResult = new PagedResult<Promotion_CommissionDiscountDto>()
                {
                    TotalRecords = totalRow,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = data
                };

                return pagedResult;
            }
            catch (Exception ex)
            {
                return new PagedResult<Promotion_CommissionDiscountDto>()
                {
                    Message = ex.Message
                };
            }
        }

        public async Task<ApiResult<Promotion_CommissionDiscountDto>> GetById(Promotion_CommissionDiscountRequest request)
        {
            try
            {
                var promotion_CommissionDiscount = await (from p_cd in _context.Promotion_CommissionDiscounts
                                                        join cd in _context.CommissionDiscounts on p_cd.CommissionDiscountId equals cd.Id
                                                        join cdt in _context.CommissionDiscountTranslations on cd.Id equals cdt.CommissionDiscountId into cd_cdt
                                                        from cdt in cd_cdt.DefaultIfEmpty()
                                                        where p_cd.Id == request.Id && cdt.LanguageId == request.LanguageId
                                                        select new Promotion_CommissionDiscountDto()
                                                        {
                                                            Id = p_cd.Id,
                                                            CommissionDiscount = new CommissionDiscountDto()
                                                            {
                                                                Id = cd.Id,
                                                                Code = cd.Code,
                                                                Name = cdt.Name,
                                                                Discount = cd.Discount,
                                                                DiscountPercent = cd.DiscountPercent,
                                                                Commission = cd.Commission,
                                                                CommissionPercent = cd.CommissionPercent
                                                            }
                                                        }).AsNoTracking().FirstOrDefaultAsync();

                if (promotion_CommissionDiscount == null)
                {
                    return new ApiErrorResult<Promotion_CommissionDiscountDto>("Không tồn tại.");
                }

                return new ApiSuccessResult<Promotion_CommissionDiscountDto>(promotion_CommissionDiscount);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<Promotion_CommissionDiscountDto>(ex.Message);
            }
        }
        public async Task<ApiResult<int>> UpdateAsync(Promotion_CommissionDiscountRequest request)
        {
            try
            {
                var promotion_CommissionDiscount = await _context.Promotion_CommissionDiscounts.FindAsync(request.Id);

                if (promotion_CommissionDiscount == null) throw new EShopException($"Cannot find a promotion_CommissionDiscount with id: {request.Id}");

                promotion_CommissionDiscount.PromotionId = request.PromotionId;
                promotion_CommissionDiscount.CommissionDiscountId = request.CommissionDiscountId;

                _context.Promotion_CommissionDiscounts.Update(promotion_CommissionDiscount);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }
    }
}
