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
using Snail.ViewModels.HR.AppUser_BasicSalaries;
using Snail.ViewModels.HR.BasicSalaries;

namespace Snail.Application.HR.AppUser_BasicSalaries
{
    public interface IAppUser_BasicSalaryService
    {
        Task<PagedResult<AppUser_BasicSalaryDto>> GetManageListPaging(ManageAppUser_BasicSalaryPagingRequest request);
        Task<ApiResult<int>> CreateAsync(AppUser_BasicSalaryRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<AppUser_BasicSalaryDto>> GetById(AppUser_BasicSalaryRequest request);
        Task<ApiResult<int>> UpdateAsync(AppUser_BasicSalaryRequest request);
    }
    public class AppUser_BasicSalaryService : IAppUser_BasicSalaryService
    {
        private readonly EShopDbContext _context;
        private readonly IConfiguration _configuration;

        public AppUser_BasicSalaryService(EShopDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<ApiResult<int>> CreateAsync(AppUser_BasicSalaryRequest request)
        {
            DateTime ngayValue;

            try
            {
                var appUser_BasicSalary = new AppUser_BasicSalary()
                {
                    AppUserId = Guid.Parse(request.AppUserId),
                    BasicSalaryId = request.BasicSalaryId,
                    FromDate = (DateTime.TryParseExact(request.FromDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : new Nullable<DateTime>()),
                    ToDate = (DateTime.TryParseExact(request.ToDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : new Nullable<DateTime>()),
                    IsApply = request.IsApply
                };

                _context.AppUser_BasicSalarys.Add(appUser_BasicSalary);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(appUser_BasicSalary.Id);
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
                var appUser_BasicSalarys = await _context.AppUser_BasicSalarys.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (appUser_BasicSalarys == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                _context.AppUser_BasicSalarys.RemoveRange(appUser_BasicSalarys);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }

        public async Task<PagedResult<AppUser_BasicSalaryDto>> GetManageListPaging(ManageAppUser_BasicSalaryPagingRequest request)
        {
            try
            {
                //1. Select join
                var query = from au_bs in _context.AppUser_BasicSalarys
                            join bs in _context.BasicSalarys on au_bs.BasicSalaryId equals bs.Id
                                join bst in _context.BasicSalaryTranslations on bs.Id equals bst.BasicSalaryId into bs_bst
                                from bst in bs_bst.DefaultIfEmpty()
                            where bst.LanguageId == request.LanguageId
                            select new { au_bs, bs, bst };

                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                {
                    query = query.Where(x => x.bst.Name.Contains(request.TextSearch));
                }

                if (!string.IsNullOrEmpty(request.AppUserId))
                {
                    query = query.Where(x => x.au_bs.AppUserId == Guid.Parse(request.AppUserId));
                }

                //3. Paging
                int totalRow = await query.CountAsync();

                if (request.PageIndex != null)
                {
                    query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                                .Take(request.PageSize);
                }
                var data = await query.Select(x => new AppUser_BasicSalaryDto()
                {
                    Id = x.au_bs.Id,
                    BasicSalaryId = x.bs.Id,
                    BasicSalaryCode = x.bs.Code,
                    BasicSalaryName = x.bst.Name,
                    BasicSalaryValue = x.bs.Value,
                    StrFromDate =x.bs.FromDate.ToString("dd/MM/yyyy"),
                    StrToDate = (x.bs.ToDate != null ? x.bs.ToDate.Value.ToString("dd/MM/yyyy") : string.Empty),
                    IsApply = x.bs.IsApply
                }).AsNoTracking().ToListAsync();

                //4. Select and projection
                var pagedResult = new PagedResult<AppUser_BasicSalaryDto>()
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
                return new PagedResult<AppUser_BasicSalaryDto>()
                {
                    Message = ex.Message
                };
            }
        }

        public async Task<ApiResult<AppUser_BasicSalaryDto>> GetById(AppUser_BasicSalaryRequest request)
        {
            try
            {
                var appUser_BasicSalary = await (from au_bs in _context.AppUser_BasicSalarys
                                                        join bs in _context.BasicSalarys on au_bs.BasicSalaryId equals bs.Id
                                                        join bst in _context.BasicSalaryTranslations on bs.Id equals bst.BasicSalaryId into bs_bst
                                                        from bst in bs_bst.DefaultIfEmpty()
                                                        where au_bs.Id == request.Id && bst.LanguageId == request.LanguageId
                                                        select new AppUser_BasicSalaryDto()
                                                        {
                                                            Id = au_bs.Id,
                                                            BasicSalary = new BasicSalaryDto()
                                                            {
                                                                Id = bs.Id,
                                                                Code = bs.Code,
                                                                Name = bst.Name,
                                                                Value = bs.Value,
                                                                FromDate = bs.FromDate,
                                                                ToDate = bs.ToDate,
                                                                IsApply = bs.IsApply
                                                            },
                                                            FromDate = au_bs.FromDate,
                                                            ToDate = au_bs.ToDate,
                                                            IsApply = au_bs.IsApply
                                                        }).AsNoTracking().FirstOrDefaultAsync();

                if (appUser_BasicSalary == null)
                {
                    return new ApiErrorResult<AppUser_BasicSalaryDto>("Không tồn tại.");
                }

                return new ApiSuccessResult<AppUser_BasicSalaryDto>(appUser_BasicSalary);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<AppUser_BasicSalaryDto>(ex.Message);
            }
        }
        public async Task<ApiResult<int>> UpdateAsync(AppUser_BasicSalaryRequest request)
        {
            DateTime ngayValue;
            try
            {
                var appUser_BasicSalary = await _context.AppUser_BasicSalarys.FindAsync(request.Id);

                if (appUser_BasicSalary == null) throw new EShopException($"Cannot find a appUser_BasicSalary with id: {request.Id}");

                appUser_BasicSalary.AppUserId = Guid.Parse(request.AppUserId);
                appUser_BasicSalary.BasicSalaryId = request.BasicSalaryId;
                appUser_BasicSalary.FromDate = (DateTime.TryParseExact(request.FromDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : new Nullable<DateTime>());
                appUser_BasicSalary.ToDate = (DateTime.TryParseExact(request.ToDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : new Nullable<DateTime>());
                appUser_BasicSalary.IsApply = request.IsApply;

                _context.AppUser_BasicSalarys.Update(appUser_BasicSalary);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }
    }
}
