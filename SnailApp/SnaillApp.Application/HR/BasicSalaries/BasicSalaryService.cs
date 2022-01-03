using SnailApp.Application.Common;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SnailApp.ViewModels.HR.BasicSalaries;
using SnailApp.ViewModels.Enums;

namespace SnailApp.Application.HR.BasicSalaries
{
    public interface IBasicSalaryService
    {
        Task<ApiResult<int>> CreateAsync(BasicSalaryRequest request);
        Task<ApiResult<int>> UpdateAsync(BasicSalaryRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<BasicSalaryDto>> GetById(BasicSalaryRequest request);
        Task<PagedResult<BasicSalaryDto>> GetManageListPaging(ManageBasicSalaryPagingRequest request);
        Task<PagedResult<BasicSalaryDto>> GetAll(ManageBasicSalaryPagingRequest request);
    }
    public class BasicSalaryService : IBasicSalaryService
    {
        private readonly ClinicDbContext _context;
        private readonly IConfiguration _configuration;

        public BasicSalaryService(ClinicDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<ApiResult<int>> CreateAsync(BasicSalaryRequest request)
        {
            DateTime ngayValue;

            try
            {
                var languages = _context.Languages;
                var translations = new List<BasicSalaryTranslation>();
                foreach (var language in languages)
                {
                    if (language.Id == request.LanguageId)
                    {
                        translations.Add(new BasicSalaryTranslation()
                        {
                            Name = request.Name,
                            Description = request.Description,
                            LanguageId = request.LanguageId
                        });
                    }
                    else
                    {
                        translations.Add(new BasicSalaryTranslation()
                        {
                            Name = SystemConstants.AppConstants.NA,
                            Description = SystemConstants.AppConstants.NA,
                            LanguageId = language.Id
                        });
                    }
                }

                var basicSalary = new BasicSalary()
                {
                    Code = request.Code,
                    Value = request.Value,
                    FromDate = (DateTime.TryParseExact(request.FromDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : DateTime.Now),
                    ToDate = (DateTime.TryParseExact(request.ToDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : DateTime.Now),
                    IsApply = request.IsApply,
                    CreatedDate = DateTime.Now,
                    CreatedUserId = Guid.Parse(request.CreatedUserId),
                    ModifiedUserId = Guid.Parse(request.ModifiedUserId),
                    BasicSalaryTranslations = translations
                };

                _context.BasicSalarys.Add(basicSalary);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(basicSalary.Id);
            }
            catch (Exception ex)
            {
                return new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<ApiResult<int>> UpdateAsync(BasicSalaryRequest request)
        {
            DateTime ngayValue;

            try
            {
                var basicSalary = await _context.BasicSalarys.FindAsync(request.Id);


                var basicSalaryTranslations = await _context.BasicSalaryTranslations.FirstOrDefaultAsync(x => x.BasicSalaryId == request.Id
                    && x.LanguageId == request.LanguageId);

                if (basicSalary == null || basicSalaryTranslations == null) throw new EShopException($"Cannot find a product with id: {request.Id}");


                basicSalaryTranslations.Name = request.Name;
                basicSalaryTranslations.Description = request.Description;

                basicSalary.Code = request.Code;
                basicSalary.Value = request.Value;
                basicSalary.FromDate = (DateTime.TryParseExact(request.FromDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : DateTime.Now);
                basicSalary.ToDate = (DateTime.TryParseExact(request.ToDate, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : DateTime.Now);
                basicSalary.IsApply = request.IsApply;
                basicSalary.ModifiedDate = DateTime.Now;
                basicSalary.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(basicSalary.Id);
            }
            catch (Exception ex)
            {
                return new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var basicSalarys = await _context.BasicSalarys.Where(m => request.Ids.Contains(m.Id)).ToListAsync();

                if (basicSalarys == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");


                var basicSalaryIds = basicSalarys.Select(m => m.Id).ToList();
                var basicSalaryTranslations = _context.BasicSalaryTranslations.Where(i => basicSalaryIds.Contains(i.BasicSalaryId)).ToList();
                if (basicSalaryTranslations != null)
                {
                    _context.BasicSalaryTranslations.RemoveRange(basicSalaryTranslations);
                }

                _context.BasicSalarys.RemoveRange(basicSalarys);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch (Exception ex)
            {
                return new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = ex.Message
                };
            }
        }
        public async Task<PagedResult<BasicSalaryDto>> GetManageListPaging(ManageBasicSalaryPagingRequest request)

        {
            //1. Select join
            var query = from bs in _context.BasicSalarys
                        join bst in _context.BasicSalaryTranslations on bs.Id equals bst.BasicSalaryId into sst
                        from bst in sst.DefaultIfEmpty()
                        where bst.LanguageId == request.LanguageId
                        select new { bs, bst };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.bst.Name.Contains(request.TextSearch)
                || x.bs.Code.Contains(request.TextSearch));

            //3.Sort

            if (!string.IsNullOrEmpty(request.OrderCol))
            {
                switch (request.OrderCol)
                {
                    case "id":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.bs.Id) :
                            query.OrderByDescending(x => x.bs.Id);

                        break;

                    case "code":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.bs.Code) :
                            query.OrderByDescending(x => x.bs.Code);

                        break;

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.bst.Name) :
                            query.OrderByDescending(x => x.bst.Name);

                        break;

                    case "phone":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.bs.Name) :
                            query.OrderByDescending(x => x.bs.Name);

                        break;

                    case "address":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.bst.Name) :
                            query.OrderByDescending(x => x.bst.Name);

                        break;

                    default: break;
                }
            }

            //4. Paging
            int totalRow = await query.CountAsync();

            if (request.PageIndex != null && request.PageIndex.Value != 0 && request.PageSize != 0)
            {
                query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                                .Take(request.PageSize);
            }

            var data = await query.Select(x => new BasicSalaryDto()
            {
                Id = x.bs.Id,
                Code = x.bs.Code,
                Name = x.bst.Name,
                Value = x.bs.Value,
                StrFromDate = x.bs.FromDate.ToString("dd/MM/yyyy"),
                StrToDate = (x.bs.ToDate != null ? x.bs.ToDate.Value.ToString("dd/MM/yyyy") : string.Empty),
                IsApply = x.bs.IsApply
            }).AsNoTracking().ToListAsync();

            //5. Select and projection
            var pagedResult = new PagedResult<BasicSalaryDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }
        public async Task<PagedResult<BasicSalaryDto>> GetAll(ManageBasicSalaryPagingRequest request)
        {
            //1. Select join
            var query = from bs in _context.BasicSalarys
                        join bst in _context.BasicSalaryTranslations on bs.Id equals bst.BasicSalaryId
                        where bst.LanguageId == request.LanguageId
                        select new { bs, bst };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.bst.Name.Contains(request.TextSearch)
                || x.bs.Code.Contains(request.TextSearch));

            //3.Sort

            if (!string.IsNullOrEmpty(request.OrderCol))
            {
                switch (request.OrderCol)
                {
                    case "id":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.bs.Id) :
                            query.OrderByDescending(x => x.bs.Id);

                        break;

                    case "code":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.bs.Code) :
                            query.OrderByDescending(x => x.bs.Code);

                        break;

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.bst.Name) :
                            query.OrderByDescending(x => x.bst.Name);

                        break;

                    default: break;
                }
            }

            var data = await query.Select(x => new BasicSalaryDto()
            {
                Id = x.bs.Id,
                Code = x.bs.Code,
                Name = x.bst.Name,
                Value = x.bs.Value,
                FromDate = x.bs.FromDate,
                ToDate = x.bs.ToDate,
                IsApply = x.bs.IsApply
            }).AsNoTracking().ToListAsync();

            var pagedResult = new PagedResult<BasicSalaryDto>()
            {
                TotalRecords = 0,
                PageSize = 0,
                PageIndex = 0,
                Items = data
            };
            return pagedResult;

        }
        public async Task<ApiResult<BasicSalaryDto>> GetById(BasicSalaryRequest request)
        {
            var basicSalary = await _context.BasicSalarys.FindAsync(request.Id);
            var basicSalaryTranslation = await _context.BasicSalaryTranslations.FirstOrDefaultAsync(x => x.BasicSalaryId == request.Id
                                                                                                    && x.LanguageId == request.LanguageId);

            var basicSalaryDto = new BasicSalaryDto()
            {
                Id = basicSalary.Id,
                CreatedDate = basicSalary.CreatedDate,
                LanguageId = (basicSalaryTranslation != null ? basicSalaryTranslation.LanguageId : 0),
                Code = basicSalary.Code,
                Name = (basicSalaryTranslation != null ? basicSalaryTranslation.Name : string.Empty),
                Value = basicSalary.Value,
                FromDate = basicSalary.FromDate,
                ToDate = basicSalary.ToDate,
                IsApply = basicSalary.IsApply
            };

            return new ApiSuccessResult<BasicSalaryDto>(basicSalaryDto);
        }
    }
}