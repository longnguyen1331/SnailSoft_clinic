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
using SnailApp.ViewModels.HR.Payrolls;
using SnailApp.ViewModels.Accountants.PhieuKeToans;

namespace SnailApp.Application.HR.Payrolls
{
    public interface IPayrollService
    {
        Task<PagedResult<PayrollDto>> GetManageListPaging(ManagePayrollPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(PayrollRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<PayrollDto>> GetById(PayrollRequest request);
        Task<ApiResult<int>> CalculatePayroll(PayrollRequest request);
    }
    public class PayrollService : IPayrollService
    {
        private readonly EShopDbContext _context;
        private readonly IConfiguration _configuration;

        public PayrollService(EShopDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(PayrollRequest request)
        {
            DateTime fromDateValue, toDateValue;

            try
            {
                var languages = _context.Languages;
                bool isNew = (request.Id == null);
                Payroll payroll = null;
                PayrollTranslation payrollTranslation = null;
                List<PayrollTranslation> translations = null;

                if (isNew == true)
                {
                    translations = new List<PayrollTranslation>();
                    foreach (var language in languages)
                    {
                        if (language.Id == request.LanguageId)
                        {
                            translations.Add(new PayrollTranslation()
                            {
                                Name = request.Name,
                                LanguageId = request.LanguageId
                            });
                        }
                        else
                        {
                            translations.Add(new PayrollTranslation()
                            {
                                Name = SystemConstants.AppConstants.NA,
                                LanguageId = language.Id
                            });
                        }
                    }

                    payroll = new Payroll()
                    {
                        CreatedUserId = Guid.Parse(request.CreatedUserId),
                        ModifiedUserId = Guid.Parse(request.ModifiedUserId),
                        PayrollTranslations = translations
                    };
                }
                else
                {
                    payroll = await _context.Payrolls.FindAsync(request.Id);
                    payrollTranslation = await _context.PayrollTranslations.FirstOrDefaultAsync(x => x.PayrollId == request.Id
                                                                                                        && x.LanguageId == request.LanguageId);

                    if (payroll == null || payrollTranslation == null) throw new EShopException($"Cannot find a payroll with id: {request.Id}");

                    payrollTranslation.Name = request.Name;
                }

                payroll.Code = request.Code;
                if(DateTime.TryParseExact(request.FromDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out fromDateValue))
                {
                    payroll.FromDate = fromDateValue;
                }
                else
                {
                    return new ApiErrorResult<int>("Ngày bắt đầu không hợp lệ");
                }

                if (DateTime.TryParseExact(request.ToDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out toDateValue))
                {
                    payroll.ToDate = toDateValue;
                }
                else
                {
                    return new ApiErrorResult<int>("Ngày kết thúc không hợp lệ");
                }

                payroll.ModifiedDate = DateTime.Now;

                if (isNew == true)
                {
                    _context.Payrolls.Add(payroll);
                }
                else
                {
                    _context.PayrollTranslations.Update(payrollTranslation);
                    _context.Payrolls.Update(payroll);
                }

                await _context.SaveChangesAsync();

                return new ApiSuccessResult<int>(payroll.Id);
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
                var payrolls = await _context.Payrolls.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (payrolls == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                List<int> payrollIds = payrolls.Select(m => m.Id).ToList();
                var payrollTranslations = _context.PayrollTranslations.Where(m => payrollIds.Contains(m.PayrollId)).ToList();
                if (payrollTranslations != null)
                {
                    _context.PayrollTranslations.RemoveRange(payrollTranslations);
                }

                _context.Payrolls.RemoveRange(payrolls);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }
        public async Task<PagedResult<PayrollDto>> GetManageListPaging(ManagePayrollPagingRequest request)
        {
            //1. Select join
            var query = from p in _context.Payrolls
                        join pt in _context.PayrollTranslations on p.Id equals pt.PayrollId into ppt
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
            var data = await query.Select(x => new PayrollDto()
            {
                Id = x.p.Id,
                Code = x.p.Code,
                Name = x.pt.Name,
                StrFromDate = x.p.FromDate.ToString("dd/MM/yyyy"),
                StrToDate = x.p.ToDate.ToString("dd/MM/yyyy"),
                CreatedDate = x.p.CreatedDate,
                LanguageId = x.pt.LanguageId
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<PayrollDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }
        public async Task<ApiResult<PayrollDto>> GetById(PayrollRequest request)
        {
            var payroll = await (from p in _context.Payrolls
                                   join pt in _context.PayrollTranslations on p.Id equals pt.PayrollId into p_pt
                                   from pt in p_pt.DefaultIfEmpty()
                                   where p.Id == request.Id && pt.LanguageId == request.LanguageId
                                   select new PayrollDto()
                                   {
                                       Id = p.Id,
                                       Code = p.Code,
                                       Name = pt.Name,
                                       FromDate = p.FromDate,
                                       ToDate = p.ToDate
                                   }
                                ).AsNoTracking().FirstOrDefaultAsync();

            if (payroll == null)
            {
                return new ApiErrorResult<PayrollDto>("Bản lương không tồn tại.");
            }

            return new ApiSuccessResult<PayrollDto>(payroll);
        }
        public async Task<ApiResult<int>> CalculatePayroll(PayrollRequest request)
        {
            try
            {
                var payroll = await _context.Payrolls.FindAsync(request.Id);

                if (payroll == null)
                {
                    return new ApiErrorResult<int>("Bản lương không tồn tại.");
                }

                _context.PayrollDetails.RemoveRange(await _context.PayrollDetails.Where(m => m.PayrollId == payroll.Id).AsNoTracking().ToListAsync());

                var payrollDetails = await (from au in _context.AppUsers
                                            join au_bs in _context.AppUser_BasicSalarys on au.Id equals au_bs.AppUserId
                                            join bs in _context.BasicSalarys on au_bs.BasicSalaryId equals bs.Id
                                            where (au.LeaveDate == null || (au.LeaveDate != null && au.LeaveDate.Value >= payroll.FromDate && au.LeaveDate.Value <= payroll.ToDate))
                                                && au_bs.IsApply == true && au_bs.FromDate.Value <= payroll.FromDate && (au_bs.ToDate == null || (au_bs.ToDate != null && au_bs.ToDate.Value >= payroll.FromDate))
                                            select new PayrollDetail()
                                            {
                                                AppUserId = au.Id,
                                                PayrollId = request.Id.Value,
                                                BasicSalary = bs.Value,
                                                Total = bs.Value
                                            }).AsNoTracking().ToListAsync();

                if (payrollDetails != null)
                {
                    if(payrollDetails.Count > 0)
                    {
                        var appUserIds = payrollDetails.Select(m => m.AppUserId).ToList();
                        var orders = await (from p in _context.PhieuKeToans
                                            where p.LoaiPhieuKeToan == ViewModels.Enums.LoaiPhieuKeToan.PX
                                                    && (appUserIds.Contains(p.SaleStaffId.Value) || appUserIds.Contains(p.CustomerId.Value))
                                                    && p.Date >= payroll.FromDate && p.Date <= payroll.ToDate
                                            select new PhieuKeToanDto()
                                            {
                                                SaleStaffId = p.SaleStaffId.Value,
                                                CustomerId = p.CustomerId.Value,
                                                TotalDiscount = p.TotalDiscount,
                                                TotalCommission = p.TotalCommission
                                            }).AsNoTracking().ToListAsync();

                        foreach(var payrollDetail in payrollDetails)
                        {
                            payrollDetail.Discount = orders.Where(m => m.CustomerId == payrollDetail.AppUserId).Sum(m => m.TotalDiscount);
                            payrollDetail.Commission = orders.Where(m => m.SaleStaffId == payrollDetail.AppUserId).Sum(m => m.TotalCommission);
                            payrollDetail.Total = payrollDetail.BasicSalary + payrollDetail.Discount + payrollDetail.Commission;
                        }
                    }
                }

                _context.PayrollDetails.AddRange(payrollDetails);
                await _context.SaveChangesAsync();

                return new ApiSuccessResult<int>(request.Id.Value);
            }
            catch(Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }            
        }
    }
}
