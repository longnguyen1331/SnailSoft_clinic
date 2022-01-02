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
using SnailApp.ViewModels.System.Statuses.AppUserStatus;

namespace SnailApp.Application.SystemApplication.Statuses
{
    public interface IAppUserStatusService
    {
        Task<ApiResult<List<AppUserStatusDto>>> GetAll(ManageAppUserStatusPagingRequest request);
        Task<PagedResult<AppUserStatusDto>> GetManageListPaging(ManageAppUserStatusPagingRequest request);
        Task<ApiResult<int>> CreateAsync(AppUserStatusRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<AppUserStatusDto>> GetById(int appUserStatusId, int languageId);
        Task<ApiResult<int>> UpdateAsync(AppUserStatusRequest request);
    }
    public class AppUserStatusService : IAppUserStatusService
    {
        private readonly EShopDbContext _context;

        public AppUserStatusService(EShopDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<AppUserStatusDto>>> GetAll(ManageAppUserStatusPagingRequest request)
        {
            var query = from s in _context.AppUserStatuses
                        join st in _context.AppUserStatusTranslations on s.Id equals st.AppUserStatusId
                        where st.LanguageId == request.LanguageId
                        select new { s, st };

            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.s.Code.Contains(request.TextSearch)
                                    || x.st.Name.Contains(request.TextSearch));
            }

            return new ApiSuccessResult<List<AppUserStatusDto>>(await query.Select(x => new AppUserStatusDto()
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
        public async Task<ApiResult<int>> CreateAsync(AppUserStatusRequest request)
        {
            var languages = _context.Languages;
            var translations = new List<AppUserStatusTranslation>();
            foreach (var language in languages)
            {
                if (language.Id == request.LanguageId)
                {
                    translations.Add(new AppUserStatusTranslation()
                    {
                        Name = request.Name,
                        LanguageId = request.LanguageId
                    });
                }
                else
                {
                    translations.Add(new AppUserStatusTranslation()
                    {
                        Name = SystemConstants.AppConstants.NA,
                        LanguageId = language.Id
                    });
                }
            }
            var appUserStatus = new AppUserStatus()
            {
                SortOrder = request.SortOrder,
                Code = request.Code,
                AppUserStatusTranslations = translations
            };

            _context.AppUserStatuses.Add(appUserStatus);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(appUserStatus.Id);
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var appUserStatuses = await _context.AppUserStatuses.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (appUserStatuses == null) throw new EShopException($"Cannot find AppUserStatus: {request.Ids.ToString()}");

                List<int> appUserStatusIds = appUserStatuses.Select(m => m.Id).ToList();
                var appUserStatusTranslations = _context.AppUserStatusTranslations.Where(m => appUserStatusIds.Contains(m.AppUserStatusId)).ToList();
                if (appUserStatusTranslations != null)
                {
                    _context.AppUserStatusTranslations.RemoveRange(appUserStatusTranslations);
                }

                _context.AppUserStatuses.RemoveRange(appUserStatuses);

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

        public async Task<PagedResult<AppUserStatusDto>> GetManageListPaging(ManageAppUserStatusPagingRequest request)
        {
            //1. Select join
            var query = from s in _context.AppUserStatuses
                        join st in _context.AppUserStatusTranslations on s.Id equals st.AppUserStatusId into sst
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
            var data = await query.Select(x => new AppUserStatusDto()
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
            var pagedResult = new PagedResult<AppUserStatusDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<AppUserStatusDto>> GetById(int appUserStatusId, int languageId)
        {
            var appUserStatus = await _context.AppUserStatuses.FindAsync(appUserStatusId);
            var appUserStatusTranslation = await _context.AppUserStatusTranslations.FirstOrDefaultAsync(x => x.AppUserStatusId == appUserStatusId
                                                                                            && x.LanguageId == languageId);

            var appUserStatusDto = new AppUserStatusDto()
            {
                Id = appUserStatus.Id,
                CreatedDate = appUserStatus.CreatedDate,
                Description = appUserStatusTranslation != null ? appUserStatusTranslation.Description : string.Empty,
                LanguageId = appUserStatusTranslation.LanguageId,
                SortOrder = appUserStatus.SortOrder,
                Code = appUserStatus.Code,
                Name = appUserStatusTranslation != null ? appUserStatusTranslation.Name : string.Empty
            };

            return new ApiSuccessResult<AppUserStatusDto>(appUserStatusDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(AppUserStatusRequest request)
        {
            var appUserStatus = await _context.AppUserStatuses.FindAsync(request.Id);
            var appUserStatusTranslations = await _context.AppUserStatusTranslations.FirstOrDefaultAsync(x => x.AppUserStatusId == request.Id
            && x.LanguageId == request.LanguageId);

            if (appUserStatus == null || appUserStatusTranslations == null) throw new EShopException($"Cannot find a appUserStatus with id: {request.Id}");

            appUserStatusTranslations.Name = request.Name;
            appUserStatus.SortOrder = request.SortOrder;
            appUserStatus.Code = request.Code;
            appUserStatus.ModifiedDate = DateTime.Now;

            return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
        }
    }
}
