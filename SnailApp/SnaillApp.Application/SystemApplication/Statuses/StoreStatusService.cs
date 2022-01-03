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
using SnailApp.ViewModels.System.Statuses.StoreStatus;

namespace SnailApp.Application.SystemApplication.Statuses
{
    public interface IStoreStatusService
    {
        Task<ApiResult<List<StoreStatusDto>>> GetAll(ManageStoreStatusPagingRequest request);
        Task<PagedResult<StoreStatusDto>> GetManageListPaging(ManageStoreStatusPagingRequest request);
        Task<ApiResult<int>> CreateAsync(StoreStatusRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<StoreStatusDto>> GetById(int storeStatusId, int languageId);
        Task<ApiResult<int>> UpdateAsync(StoreStatusRequest request);
    }
    public class StoreStatusService : IStoreStatusService
    {
        private readonly ClinicDbContext _context;

        public StoreStatusService(ClinicDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<StoreStatusDto>>> GetAll(ManageStoreStatusPagingRequest request)
        {
            var query = from s in _context.StoreStatuses
                        join st in _context.StoreStatusTranslations on s.Id equals st.StoreStatusId
                        where st.LanguageId == request.LanguageId
                        select new { s, st };

            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.s.Code.Contains(request.TextSearch)
                                    || x.st.Name.Contains(request.TextSearch));
            }

            return new ApiSuccessResult<List<StoreStatusDto>>(await query.Select(x => new StoreStatusDto()
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
        public async Task<ApiResult<int>> CreateAsync(StoreStatusRequest request)
        {
            var languages = _context.Languages;
            var translations = new List<StoreStatusTranslation>();
            foreach (var language in languages)
            {
                if (language.Id == request.LanguageId)
                {
                    translations.Add(new StoreStatusTranslation()
                    {
                        Name = request.Name,
                        LanguageId = request.LanguageId
                    });
                }
                else
                {
                    translations.Add(new ()
                    {
                        Name = SystemConstants.AppConstants.NA,
                        LanguageId = language.Id
                    });
                }
            }
            var storeStatus = new StoreStatus()
            {
                SortOrder = request.SortOrder,
                Code = request.Code,
                StoreStatusTranslations = translations
            };

            _context.StoreStatuses.Add(storeStatus);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(storeStatus.Id);
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var storeStatuses = await _context.StoreStatuses.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (storeStatuses == null) throw new EShopException($"Cannot find StoreStatus: {request.Ids.ToString()}");

                List<int> storeStatusIds = storeStatuses.Select(m => m.Id).ToList();
                var storeStatusTranslations = _context.StoreStatusTranslations.Where(m => storeStatusIds.Contains(m.StoreStatusId)).ToList();
                if (storeStatusTranslations != null)
                {
                    _context.StoreStatusTranslations.RemoveRange(storeStatusTranslations);
                }

                _context.StoreStatuses.RemoveRange(storeStatuses);

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

        public async Task<PagedResult<StoreStatusDto>> GetManageListPaging(ManageStoreStatusPagingRequest request)
        {
            //1. Select join
            var query = from s in _context.StoreStatuses
                        join st in _context.StoreStatusTranslations on s.Id equals st.StoreStatusId into sst
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
            var data = await query.Select(x => new StoreStatusDto()
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
            var pagedResult = new PagedResult<StoreStatusDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<StoreStatusDto>> GetById(int storeStatusId, int languageId)
        {
            var storeStatus = await _context.StoreStatuses.FindAsync(storeStatusId);
            var storeStatusTranslation = await _context.StoreStatusTranslations.FirstOrDefaultAsync(x => x.StoreStatusId == storeStatusId
                                                                                            && x.LanguageId == languageId);

            var storeStatusDto = new StoreStatusDto()
            {
                Id = storeStatus.Id,
                CreatedDate = storeStatus.CreatedDate,
                Description = storeStatusTranslation != null ? storeStatusTranslation.Description : string.Empty,
                LanguageId = storeStatusTranslation.LanguageId,
                SortOrder = storeStatus.SortOrder,
                Code = storeStatus.Code,
                Name = storeStatusTranslation != null ? storeStatusTranslation.Name : string.Empty
            };

            return new ApiSuccessResult<StoreStatusDto>(storeStatusDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(StoreStatusRequest request)
        {
            var storeStatus = await _context.StoreStatuses.FindAsync(request.Id);
            var storeStatusTranslations = await _context.StoreStatusTranslations.FirstOrDefaultAsync(x => x.StoreStatusId == request.Id
            && x.LanguageId == request.LanguageId);

            if (storeStatus == null || storeStatusTranslations == null) throw new EShopException($"Cannot find a storeStatus with id: {request.Id}");

            storeStatusTranslations.Name = request.Name;
            storeStatus.SortOrder = request.SortOrder;
            storeStatus.Code = request.Code;
            storeStatus.ModifiedDate = DateTime.Now;

            return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
        }
    }
}
