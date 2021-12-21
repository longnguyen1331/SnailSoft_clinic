using Snail.Utilities.Constants;
using Snail.Utilities.Exceptions;
using Snail.Data.EF;
using Snail.Data.Entities;
using Snail.ViewModels.Enums;
using Snail.ViewModels.Common;
using Snail.ViewModels.Catalog.AppUserTypes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Snail.Application.Catalog.AppUserTypes
{
    public interface IAppUserTypeService
    {
        Task<ApiResult<List<AppUserTypeDto>>> GetAll(ManageAppUserTypePagingRequest request);
        Task<PagedResult<AppUserTypeDto>> GetManageListPaging(ManageAppUserTypePagingRequest request);
        Task<ApiResult<int>> CreateAsync(AppUserTypeRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<AppUserTypeDto>> GetById(int appUserTypeId, int languageId);
        Task<ApiResult<int>> UpdateAsync(AppUserTypeRequest request);
    }
    public class AppUserTypeService : IAppUserTypeService
    {
        private readonly EShopDbContext _context;

        public AppUserTypeService(EShopDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<AppUserTypeDto>>> GetAll(ManageAppUserTypePagingRequest request)
        {
            var query = from p in _context.AppUserTypes
                        join pt in _context.AppUserTypeTranslations on p.Id equals pt.AppUserTypeId
                        where pt.LanguageId == request.LanguageId
                        select new { p, pt };

            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.pt.Name.Contains(request.TextSearch));
            }

            return new ApiSuccessResult<List<AppUserTypeDto>>(await query.Select(x => new AppUserTypeDto()
            {
                Id = x.p.Id,
                Code = x.p.Code,
                Name = x.pt.Name
            }).AsNoTracking().ToListAsync());
        }
        public async Task<ApiResult<int>> CreateAsync(AppUserTypeRequest request)
        {
            var languages = _context.Languages;
            var translations = new List<AppUserTypeTranslation>();
            foreach (var language in languages)
            {
                if (language.Id == request.LanguageId)
                {
                    translations.Add(new AppUserTypeTranslation()
                    {
                        Name = request.Name,
                        LanguageId = request.LanguageId
                    });
                }
                else
                {
                    translations.Add(new AppUserTypeTranslation()
                    {
                        Name = SystemConstants.AppConstants.NA,
                        LanguageId = language.Id
                    });
                }
            }
            var appUserType = new AppUserType()
            {
                AppUserTypeTranslations = translations,
                Code = request.Code
            };

            _context.AppUserTypes.Add(appUserType);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(appUserType.Id);
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var appUserTypes = await _context.AppUserTypes.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (appUserTypes == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                List<int> appUserTypeIds = appUserTypes.Select(m => m.Id).ToList();
                var appUserTypeTranslations = _context.AppUserTypeTranslations.Where(m => appUserTypeIds.Contains(m.AppUserTypeId)).ToList();
                if (appUserTypeTranslations != null)
                {
                    _context.AppUserTypeTranslations.RemoveRange(appUserTypeTranslations);
                }

                _context.AppUserTypes.RemoveRange(appUserTypes);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }

        public async Task<PagedResult<AppUserTypeDto>> GetManageListPaging(ManageAppUserTypePagingRequest request)
        {
            //1. Select join
            var query = from p in _context.AppUserTypes
                        join pt in _context.AppUserTypeTranslations on p.Id equals pt.AppUserTypeId into ppt
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
            var data = await query.Select(x => new AppUserTypeDto()
            {
                Id = x.p.Id,
                Code = x.p.Code,
                Name = x.pt.Name,
                CreatedDate = x.p.CreatedDate,
                LanguageId = x.pt.LanguageId
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<AppUserTypeDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<AppUserTypeDto>> GetById(int appUserTypeId, int languageId)
        {
            var appUserType = await _context.AppUserTypes.FindAsync(appUserTypeId);
            var appUserTypeTranslation = await _context.AppUserTypeTranslations.FirstOrDefaultAsync(x => x.AppUserTypeId == appUserTypeId
                                                                                                            && x.LanguageId == languageId);

            var appUserTypeDto = new AppUserTypeDto()
            {
                Id = appUserType.Id,
                CreatedDate = appUserType.CreatedDate,
                LanguageId = appUserTypeTranslation.LanguageId,
                Code = appUserType.Code,
                Name = appUserTypeTranslation != null ? appUserTypeTranslation.Name : string.Empty,
            };

            return new ApiSuccessResult<AppUserTypeDto>(appUserTypeDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(AppUserTypeRequest request)
        {
            try
            {
                var appUserType = await _context.AppUserTypes.FindAsync(request.Id);
                var appUserTypeTranslations = await _context.AppUserTypeTranslations.FirstOrDefaultAsync(x => x.AppUserTypeId == request.Id
                && x.LanguageId == request.LanguageId);

                if (appUserType == null || appUserTypeTranslations == null) throw new EShopException($"Cannot find a appUserType with id: {request.Id}");

                appUserType.Code = request.Code;
                _context.AppUserTypes.Update(appUserType);

                appUserTypeTranslations.Name = request.Name;
                _context.AppUserTypeTranslations.Update(appUserTypeTranslations);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }

        }
    }
}
