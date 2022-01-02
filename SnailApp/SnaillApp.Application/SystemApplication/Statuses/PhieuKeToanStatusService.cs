using SnailApp.Application.Common;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SnailApp.ViewModels.System.Statuses.PhieuKeToanStatus;

namespace SnailApp.Application.SystemApplication.Statuses
{
    public interface IPhieuKeToanStatusService
    {
        Task<ApiResult<List<PhieuKeToanStatusDto>>> GetAll(ManagePhieuKeToanStatusPagingRequest request);
        Task<PagedResult<PhieuKeToanStatusDto>> GetManageListPaging(ManagePhieuKeToanStatusPagingRequest request);
        Task<ApiResult<int>> CreateAsync(PhieuKeToanStatusRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<PhieuKeToanStatusDto>> GetById(int phieuKeToanStatusId, int languageId);
        Task<ApiResult<int>> UpdateAsync(PhieuKeToanStatusRequest request);
    }
    public class PhieuKeToanStatusService : IPhieuKeToanStatusService
    {
        private readonly EShopDbContext _context;

        public PhieuKeToanStatusService(EShopDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<PhieuKeToanStatusDto>>> GetAll(ManagePhieuKeToanStatusPagingRequest request)
        {
            var query = from s in _context.PhieuKeToanStatuses
                        join st in _context.PhieuKeToanStatusTranslations on s.Id equals st.PhieuKeToanStatusId
                        where st.LanguageId == request.LanguageId
                        select new { s, st };

            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.s.Code.Contains(request.TextSearch)
                                    || x.st.Name.Contains(request.TextSearch));
            }

            return new ApiSuccessResult<List<PhieuKeToanStatusDto>>(await query.Select(x => new PhieuKeToanStatusDto()
            {
                Id = x.s.Id,
                SortOrder = x.s.SortOrder,
                Code = x.s.Code,
                Name = x.st.Name,
                CreatedDate = x.s.CreatedDate,
                Description = x.st.Description,
                LanguageId = x.st.LanguageId
            }).AsNoTracking().ToListAsync());
        }
        public async Task<ApiResult<int>> CreateAsync(PhieuKeToanStatusRequest request)
        {
            var languages = _context.Languages;
            var translations = new List<PhieuKeToanStatusTranslation>();
            foreach (var language in languages)
            {
                if (language.Id == request.LanguageId)
                {
                    translations.Add(new PhieuKeToanStatusTranslation()
                    {
                        Name = request.Name,
                        LanguageId = request.LanguageId
                    });
                }
                else
                {
                    translations.Add(new PhieuKeToanStatusTranslation()
                    {
                        Name = SystemConstants.AppConstants.NA,
                        LanguageId = language.Id
                    });
                }
            }
            var phieuKeToanStatus = new PhieuKeToanStatus()
            {
                SortOrder = request.SortOrder,
                Code = request.Code,
                PhieuKeToanStatusTranslations = translations
            };

            _context.PhieuKeToanStatuses.Add(phieuKeToanStatus);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(phieuKeToanStatus.Id);
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var phieuKeToanStatuses = await _context.PhieuKeToanStatuses.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (phieuKeToanStatuses == null) throw new EShopException($"Cannot find PhieuKeToanStatus: {request.Ids.ToString()}");

                List<int> phieuKeToanStatusIds = phieuKeToanStatuses.Select(m => m.Id).ToList();
                var phieuKeToanStatusTranslations = _context.PhieuKeToanStatusTranslations.Where(m => phieuKeToanStatusIds.Contains(m.PhieuKeToanStatusId)).ToList();
                if (phieuKeToanStatusTranslations != null)
                {
                    _context.PhieuKeToanStatusTranslations.RemoveRange(phieuKeToanStatusTranslations);
                }

                _context.PhieuKeToanStatuses.RemoveRange(phieuKeToanStatuses);

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

        public async Task<PagedResult<PhieuKeToanStatusDto>> GetManageListPaging(ManagePhieuKeToanStatusPagingRequest request)
        {
            //1. Select join
            var query = from s in _context.PhieuKeToanStatuses
                        join st in _context.PhieuKeToanStatusTranslations on s.Id equals st.PhieuKeToanStatusId into sst
                        from st in sst.DefaultIfEmpty()
                        where st.LanguageId == request.LanguageId
                        select new { s, st };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.st.Name.Contains(request.TextSearch));
            }

            //3.Sort
            if (!string.IsNullOrEmpty(request.OrderCol))
            {
                switch (request.OrderCol)
                {
                    case "id":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.s.Id) :
                            query.OrderByDescending(x => x.s.Id);

                        break;

                    case "code":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.s.Code) :
                            query.OrderByDescending(x => x.s.Code);

                        break;

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.st.Name) :
                            query.OrderByDescending(x => x.st.Name);

                        break;
                }
            }

            //4. Paging
            int totalRow = await query.CountAsync();

            if (request.PageIndex != null)
            {
                query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                            .Take(request.PageSize);
            }
            var data = await query.Select(x => new PhieuKeToanStatusDto()
            {
                Id = x.s.Id,
                SortOrder = x.s.SortOrder,
                Code = x.s.Code,
                Name = x.st.Name,
                CreatedDate = x.s.CreatedDate,
                Description = x.st.Description,
                LanguageId = x.st.LanguageId
            }).AsNoTracking().ToListAsync();

            //5. Select and projection
            var pagedResult = new PagedResult<PhieuKeToanStatusDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<PhieuKeToanStatusDto>> GetById(int phieuKeToanStatusId, int languageId)
        {
            var phieuKeToanStatus = await _context.PhieuKeToanStatuses.FindAsync(phieuKeToanStatusId);
            var phieuKeToanStatusTranslation = await _context.PhieuKeToanStatusTranslations.FirstOrDefaultAsync(x => x.PhieuKeToanStatusId == phieuKeToanStatusId
                                                                                            && x.LanguageId == languageId);

            var phieuKeToanStatusDto = new PhieuKeToanStatusDto()
            {
                Id = phieuKeToanStatus.Id,
                CreatedDate = phieuKeToanStatus.CreatedDate,
                Description = phieuKeToanStatusTranslation != null ? phieuKeToanStatusTranslation.Description : string.Empty,
                LanguageId = phieuKeToanStatusTranslation.LanguageId,
                SortOrder = phieuKeToanStatus.SortOrder,
                Code = phieuKeToanStatus.Code,
                Name = phieuKeToanStatusTranslation != null ? phieuKeToanStatusTranslation.Name : string.Empty
            };

            return new ApiSuccessResult<PhieuKeToanStatusDto>(phieuKeToanStatusDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(PhieuKeToanStatusRequest request)
        {
            var phieuKeToanStatus = await _context.PhieuKeToanStatuses.FindAsync(request.Id);
            var phieuKeToanStatusTranslations = await _context.PhieuKeToanStatusTranslations.FirstOrDefaultAsync(x => x.PhieuKeToanStatusId == request.Id
            && x.LanguageId == request.LanguageId);

            if (phieuKeToanStatus == null || phieuKeToanStatusTranslations == null) throw new EShopException($"Cannot find a phieuKeToanStatus with id: {request.Id}");

            phieuKeToanStatusTranslations.Name = request.Name;
            phieuKeToanStatus.SortOrder = request.SortOrder;
            phieuKeToanStatus.Code = request.Code;
            phieuKeToanStatus.ModifiedDate = DateTime.Now;

            return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
        }
    }
}
