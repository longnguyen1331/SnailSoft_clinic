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
using SnailApp.ViewModels.Sales.AppUser_CommissionDiscounts;
using SnailApp.ViewModels.Sales.CommissionDiscounts;
using SnailApp.ViewModels.Enums;

namespace SnailApp.Application.Sales.AppUser_CommissionDiscounts
{
    public interface IAppUser_CommissionDiscountService
    {
        Task<PagedResult<AppUser_CommissionDiscountDto>> GetManageListPaging(ManageAppUser_CommissionDiscountPagingRequest request);
        Task<PagedResult<AppUser_CommissionDiscountDto>> GetManageListDetailPaging(ManageAppUser_CommissionDiscountPagingRequest request);
        Task<ApiResult<int>> CreateAsync(AppUser_CommissionDiscountRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<AppUser_CommissionDiscountDto>> GetById(AppUser_CommissionDiscountRequest request);
        Task<ApiResult<int>> UpdateAsync(AppUser_CommissionDiscountRequest request);
    }
    public class AppUser_CommissionDiscountService : IAppUser_CommissionDiscountService
    {
        private readonly EShopDbContext _context;
        private readonly IConfiguration _configuration;

        public AppUser_CommissionDiscountService(EShopDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        
        public async Task<ApiResult<int>> CreateAsync(AppUser_CommissionDiscountRequest request)
        {
            DateTime ngayValue;

            try
            {               
                var appUser_CommissionDiscount = new AppUser_CommissionDiscount()
                {
                    AppUserId = Guid.Parse(request.AppUserId),
                    CommissionDiscountId = request.CommissionDiscountId,
                    FromDate = (DateTime.TryParseExact(request.FromDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : new Nullable<DateTime>()),
                    ToDate = (DateTime.TryParseExact(request.ToDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : new Nullable<DateTime>()),
                    IsApply = request.IsApply
                };

                _context.AppUser_CommissionDiscounts.Add(appUser_CommissionDiscount);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(appUser_CommissionDiscount.Id);
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
                var appUser_CommissionDiscounts = await _context.AppUser_CommissionDiscounts.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (appUser_CommissionDiscounts == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                _context.AppUser_CommissionDiscounts.RemoveRange(appUser_CommissionDiscounts);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }

        public async Task<PagedResult<AppUser_CommissionDiscountDto>> GetManageListPaging(ManageAppUser_CommissionDiscountPagingRequest request)
        {
            try
            {
                //1. Select join
                var query = from au_cd in _context.AppUser_CommissionDiscounts
                            join cd in _context.CommissionDiscounts on au_cd.CommissionDiscountId equals cd.Id
                                join cdt in _context.CommissionDiscountTranslations on cd.Id equals cdt.CommissionDiscountId into cd_cdt
                                from cdt in cd_cdt.DefaultIfEmpty()
                            where cdt.LanguageId == request.LanguageId
                            select new { au_cd, cd, cdt};

                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                {
                    query = query.Where(x => x.cd.Name.Contains(request.TextSearch));
                }

                if (!string.IsNullOrEmpty(request.AppUserId))
                {
                    query = query.Where(x => x.au_cd.AppUserId == Guid.Parse(request.AppUserId));
                }

                //3. Paging
                int totalRow = await query.CountAsync();

                if (request.PageIndex != null)
                {
                    query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                                .Take(request.PageSize);
                }
                var data = await query.Select(x => new AppUser_CommissionDiscountDto()
                {
                    Id = x.au_cd.Id,
                    CommissionDiscountId = x.cd.Id,
                    CommissionDiscountCode = x.cd.Code,
                    CommissionDiscountName = x.cdt.Name,
                    CommissionDiscountDiscount = x.cd.Discount,
                    CommissionDiscountDiscountPercent = x.cd.DiscountPercent,
                    CommissionDiscountCommission = x.cd.Commission,
                    CommissionDiscountCommissionPercent = x.cd.CommissionPercent,
                    StrFromDate = (x.au_cd.FromDate != null ? x.au_cd.FromDate.Value.ToString("dd/MM/yyyy") : string.Empty),
                    StrToDate = (x.au_cd.ToDate != null ? x.au_cd.ToDate.Value.ToString("dd/MM/yyyy") : string.Empty),
                    IsApply = x.au_cd.IsApply
                }).AsNoTracking().ToListAsync();

                //4. Select and projection
                var pagedResult = new PagedResult<AppUser_CommissionDiscountDto>()
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
                return new PagedResult<AppUser_CommissionDiscountDto>()
                {
                    Message = ex.Message
                };
            }
        }
        public async Task<PagedResult<AppUser_CommissionDiscountDto>> GetManageListDetailPaging(ManageAppUser_CommissionDiscountPagingRequest request)
        {
            DateTime fromDate, toDate;
            try
            {
                //1. Select join
                var query = from p in _context.PhieuKeToans
                            where p.LoaiPhieuKeToan == ViewModels.Enums.LoaiPhieuKeToan.PX
                                    && (p.SaleStaffId == Guid.Parse(request.AppUserId)
                                        || p.CustomerId == Guid.Parse(request.AppUserId))
                            select new { p };

                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                {
                    query = query.Where(x => x.p.Code.Contains(request.TextSearch));
                }

                if (!string.IsNullOrEmpty(request.FilterByFromDate))
                {
                    if (DateTime.TryParseExact(request.FilterByFromDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out fromDate))
                    {
                        query = query.Where(x => x.p.Date >= new DateTime(fromDate.Year, fromDate.Month, fromDate.Day));
                    }
                }

                if (!string.IsNullOrEmpty(request.FilterByToDate))
                {
                    if (DateTime.TryParseExact(request.FilterByToDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out toDate))
                    {
                        query = query.Where(x => x.p.Date <= new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 0));
                    }
                }

                //3.Sort
                if (!string.IsNullOrEmpty(request.OrderCol))
                {
                    switch (request.OrderCol)
                    {
                        case "code":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.p.Code) :
                                query.OrderByDescending(x => x.p.Code);

                            break;

                        default:
                            query = query.OrderByDescending(x => x.p.Id);

                            break; ;
                    }
                }

                //4. Paging
                int totalRow = await query.CountAsync();

                if (request.PageIndex != null)
                {
                    query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                                .Take(request.PageSize);
                }
                var data = await query.Select(x => new AppUser_CommissionDiscountDto()
                {
                    Id = x.p.Id,
                    Code = x.p.Code,
                    Commission = x.p.TotalCommission,
                    Discount = x.p.TotalDiscount
                }).AsNoTracking().ToListAsync();

                //5. Select and projection
                var pagedResult = new PagedResult<AppUser_CommissionDiscountDto>()
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
                return new PagedResult<AppUser_CommissionDiscountDto>()
                {
                    Message = ex.Message
                };
            }
        }
        
        public async Task<ApiResult<AppUser_CommissionDiscountDto>> GetById(AppUser_CommissionDiscountRequest request)
        {
            try
            {
                var appUser_CommissionDiscount = await (from au_cd in _context.AppUser_CommissionDiscounts
                                                        join cd in _context.CommissionDiscounts on au_cd.CommissionDiscountId equals cd.Id
                                                        join cdt in _context.CommissionDiscountTranslations on cd.Id equals cdt.CommissionDiscountId into cd_cdt
                                                        from cdt in cd_cdt.DefaultIfEmpty()
                                                        where au_cd.Id == request.Id && cdt.LanguageId == request.LanguageId
                                                        select new AppUser_CommissionDiscountDto()
                                                        {
                                                            Id = au_cd.Id,
                                                            CommissionDiscount = new CommissionDiscountDto() {
                                                                Id = cd.Id,
                                                                Code = cd.Code,
                                                                Name = cdt.Name,
                                                                Discount = cd.Discount,
                                                                DiscountPercent = cd.DiscountPercent,
                                                                Commission = cd.Commission,
                                                                CommissionPercent = cd.CommissionPercent
                                                            },
                                                            FromDate = au_cd.FromDate,
                                                            ToDate = au_cd.ToDate,
                                                            IsApply = au_cd.IsApply
                                                        }).AsNoTracking().FirstOrDefaultAsync();

                if (appUser_CommissionDiscount == null)
                {
                    return new ApiErrorResult<AppUser_CommissionDiscountDto>("Không tồn tại.");
                }

                return new ApiSuccessResult<AppUser_CommissionDiscountDto>(appUser_CommissionDiscount);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<AppUser_CommissionDiscountDto>(ex.Message);
            }
        }
        public async Task<ApiResult<int>> UpdateAsync(AppUser_CommissionDiscountRequest request)
        {
            DateTime ngayValue;

            try
            {
                var appUser_CommissionDiscount = await _context.AppUser_CommissionDiscounts.FindAsync(request.Id);
                
                if (appUser_CommissionDiscount == null) throw new EShopException($"Cannot find a appUser_CommissionDiscount with id: {request.Id}");

                appUser_CommissionDiscount.AppUserId = Guid.Parse(request.AppUserId);
                appUser_CommissionDiscount.CommissionDiscountId = request.CommissionDiscountId;
                appUser_CommissionDiscount.FromDate = (DateTime.TryParseExact(request.FromDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : new Nullable<DateTime>());
                appUser_CommissionDiscount.ToDate = (DateTime.TryParseExact(request.ToDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : new Nullable<DateTime>());
                appUser_CommissionDiscount.IsApply = request.IsApply;
                
                _context.AppUser_CommissionDiscounts.Update(appUser_CommissionDiscount);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }
    }
}
