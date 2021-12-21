using Snail.Application.Common;
using Snail.Data.EF;
using Snail.Data.Entities;
using Snail.Utilities.Constants;
using Snail.Utilities.Exceptions;
using Snail.ViewModels.Common;
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
using Snail.ViewModels.Sales.CommissionDiscounts;

namespace Snail.Application.Sales.CommissionDiscounts
{
    public interface ICommissionDiscountService
    {
        Task<ApiResult<List<CommissionDiscountDto>>> GetAll(ManageCommissionDiscountPagingRequest request);
        Task<PagedResult<CommissionDiscountDto>> GetManageListPaging(ManageCommissionDiscountPagingRequest request);
        Task<ApiResult<int>> CreateAsync(CommissionDiscountRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<CommissionDiscountDto>> GetById(CommissionDiscountRequest request);
        Task<ApiResult<int>> UpdateAsync(CommissionDiscountRequest request);
    }
    public class CommissionDiscountService : ICommissionDiscountService
    {
        private readonly EShopDbContext _context;
        private readonly IConfiguration _configuration;

        public CommissionDiscountService(EShopDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<ApiResult<List<CommissionDiscountDto>>> GetAll(ManageCommissionDiscountPagingRequest request)
        {
            try
            {
                var query = from p in _context.CommissionDiscounts
                            join pt in _context.CommissionDiscountTranslations on p.Id equals pt.CommissionDiscountId
                            where pt.LanguageId == request.LanguageId
                            select new { p, pt };

                if (!string.IsNullOrEmpty(request.TextSearch))
                {
                    query = query.Where(x => x.pt.Name.Contains(request.TextSearch));
                }

                return new ApiSuccessResult<List<CommissionDiscountDto>>(await query.Select(x => new CommissionDiscountDto()
                {
                    Id = x.p.Id,
                    Code = x.p.Code,
                    Name = x.pt.Name,
                    Description = x.pt.Description,
                    Commission = x.p.Commission,
                    CommissionPercent = x.p.CommissionPercent,
                    Discount = x.p.Discount,
                    DiscountPercent = x.p.DiscountPercent,
                    FromDate = x.p.FromDate,
                    ToDate = x.p.ToDate,
                    IsApply = x.p.IsApply
                }).AsNoTracking().ToListAsync());
            }
            catch(Exception ex)
            {
                return new ApiErrorResult<List<CommissionDiscountDto>> (ex.Message);
            }
            
        }
        public async Task<ApiResult<int>> CreateAsync(CommissionDiscountRequest request)
        {
            DateTime ngayValue;

            try
            {
                var languages = _context.Languages;
                var translations = new List<CommissionDiscountTranslation>();
                foreach (var language in languages)
                {
                    if (language.Id == request.LanguageId)
                    {
                        translations.Add(new CommissionDiscountTranslation()
                        {
                            Name = request.Name,
                            Description = request.Description,
                            LanguageId = request.LanguageId
                        });
                    }
                    else
                    {
                        translations.Add(new CommissionDiscountTranslation()
                        {
                            Name = SystemConstants.AppConstants.NA,
                            Description = SystemConstants.AppConstants.NA,
                            LanguageId = language.Id
                        });
                    }
                }
                var commissionDiscount = new CommissionDiscount()
                {
                    CommissionDiscountTranslations = translations,
                    Code = request.Code,
                    Commission = request.Commission,
                    CommissionPercent = request.CommissionPercent,
                    Discount = request.Discount,
                    DiscountPercent = request.DiscountPercent,
                    FromDate = (DateTime.TryParseExact(request.FromDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : DateTime.Now),
                    ToDate = (DateTime.TryParseExact(request.ToDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : new Nullable<DateTime>()),
                    IsApply = request.IsApply
                };

                _context.CommissionDiscounts.Add(commissionDiscount);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(commissionDiscount.Id);
            }
            catch(Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }            
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var commissionDiscounts = await _context.CommissionDiscounts.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (commissionDiscounts == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                List<int> commissionDiscountIds = commissionDiscounts.Select(m => m.Id).ToList();
                var commissionDiscountTranslations = _context.CommissionDiscountTranslations.Where(m => commissionDiscountIds.Contains(m.CommissionDiscountId.Value)).ToList();
                if (commissionDiscountTranslations != null)
                {
                    _context.CommissionDiscountTranslations.RemoveRange(commissionDiscountTranslations);
                }

                _context.CommissionDiscounts.RemoveRange(commissionDiscounts);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }

        public async Task<PagedResult<CommissionDiscountDto>> GetManageListPaging(ManageCommissionDiscountPagingRequest request)
        {
            try
            {
                //1. Select join
                var query = from p in _context.CommissionDiscounts
                            join pt in _context.CommissionDiscountTranslations on p.Id equals pt.CommissionDiscountId into ppt
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
                var data = await query.Select(x => new CommissionDiscountDto()
                {
                    Id = x.p.Id,
                    Code = x.p.Code,
                    Name = x.pt.Name,
                    Description = x.pt.Description,
                    Commission = x.p.Commission,
                    CommissionPercent = x.p.CommissionPercent,
                    Discount = x.p.Discount,
                    DiscountPercent = x.p.DiscountPercent,
                    StrFromDate = x.p.FromDate.ToString("dd/MM/yyyy"),
                    StrToDate = (x.p.ToDate != null ? x.p.ToDate.Value.ToString("dd/MM/yyyy") : string.Empty),
                    IsApply = x.p.IsApply
                }).AsNoTracking().ToListAsync();

                //4. Select and projection
                var pagedResult = new PagedResult<CommissionDiscountDto>()
                {
                    TotalRecords = totalRow,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = data
                };
                return pagedResult;
            }
            catch(Exception ex)
            {
                return new PagedResult<CommissionDiscountDto>()
                {
                    Message = ex.Message
                };
            }
            
        }

        public async Task<ApiResult<CommissionDiscountDto>> GetById(CommissionDiscountRequest request)
        {
            try
            {
                var commissionDiscount = await _context.CommissionDiscounts.FindAsync(request.Id);
                var commissionDiscountTranslation = await _context.CommissionDiscountTranslations.FirstOrDefaultAsync(x => x.CommissionDiscountId == request.Id
                                                                                                                        && x.LanguageId == request.LanguageId);

                var commissionDiscountDto = new CommissionDiscountDto()
                {
                    Id = commissionDiscount.Id,
                    Code = commissionDiscount.Code,
                    Name = commissionDiscountTranslation.Name,
                    Description = commissionDiscountTranslation.Description,
                    Commission = commissionDiscount.Commission,
                    CommissionPercent = commissionDiscount.CommissionPercent,
                    Discount = commissionDiscount.Discount,
                    DiscountPercent = commissionDiscount.DiscountPercent,
                    FromDate = commissionDiscount.FromDate,
                    ToDate = commissionDiscount.ToDate,
                    IsApply = commissionDiscount.IsApply
                };

                return new ApiSuccessResult<CommissionDiscountDto>(commissionDiscountDto);
            }
            catch(Exception ex)
            {
                return new ApiErrorResult<CommissionDiscountDto>(ex.Message);
            }            
        }

        public async Task<ApiResult<int>> UpdateAsync(CommissionDiscountRequest request)
        {
            DateTime ngayValue;

            try
            {
                var commissionDiscount = await _context.CommissionDiscounts.FindAsync(request.Id);
                var commissionDiscountTranslations = await _context.CommissionDiscountTranslations.FirstOrDefaultAsync(x => x.CommissionDiscountId == request.Id
                && x.LanguageId == request.LanguageId);

                if (commissionDiscount == null || commissionDiscountTranslations == null) throw new EShopException($"Cannot find a commissionDiscount with id: {request.Id}");

                commissionDiscount.Code = request.Code;
                commissionDiscount.Commission = request.Commission;
                commissionDiscount.CommissionPercent = request.CommissionPercent;
                commissionDiscount.Discount = request.Discount;
                commissionDiscount.DiscountPercent = request.DiscountPercent;
                commissionDiscount.FromDate = (DateTime.TryParseExact(request.FromDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : DateTime.Now);
                commissionDiscount.ToDate = (DateTime.TryParseExact(request.ToDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : new Nullable<DateTime>());
                commissionDiscount.IsApply = request.IsApply;
                _context.CommissionDiscounts.Update(commissionDiscount);

                commissionDiscountTranslations.Name = request.Name;
                commissionDiscountTranslations.Description = request.Description;
                _context.CommissionDiscountTranslations.Update(commissionDiscountTranslations);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }
    }
}
