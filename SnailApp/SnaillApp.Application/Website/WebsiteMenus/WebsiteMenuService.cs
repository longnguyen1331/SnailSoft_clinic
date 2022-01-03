using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ViewModels.Website.WebsiteMenus;

namespace SnailApp.Application.Website.WebsiteMenus
{
    public interface IWebsiteMenuService
    {
        Task<ApiResult<List<WebsiteMenuDto>>> GetAll(ManageWebsiteMenuPagingRequest request);
        Task<PagedResult<WebsiteMenuDto>> GetManageListPaging(ManageWebsiteMenuPagingRequest request);
        Task<ApiResult<int>> CreateAsync(WebsiteMenuRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<WebsiteMenuDto>> GetById(WebsiteMenuRequest request);
        Task<ApiResult<int>> UpdateAsync(WebsiteMenuRequest request);
    }
    public class WebsiteMenuService : IWebsiteMenuService
    {
        private readonly ClinicDbContext _context;

        public WebsiteMenuService(ClinicDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<WebsiteMenuDto>>> GetAll(ManageWebsiteMenuPagingRequest request)
        {
            //1. Select join
            var query = from m in _context.WebsiteMenus
                        join mt in _context.WebsiteMenuTranslations on m.Id equals mt.WebsiteMenuId
                        where mt.LanguageId == request.LanguageId
                        select new { m, mt };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.mt.Name.Contains(request.TextSearch));
            }

            if (request.WebsiteMenuType != null)
            {
                query = query.Where(x => x.m.WebsiteMenuType == request.WebsiteMenuType.Value);
            }

            return new ApiSuccessResult<List<WebsiteMenuDto>>(await query.Select(x => new WebsiteMenuDto()
            {
                Id = x.m.Id,
                SortOrder = x.m.SortOrder,
                Code = x.m.Code,
                Name = x.mt.Name,
                ParentId = x.m.ParentId,
                Icon = x.m.Icon,
                CreatedDate = x.m.CreatedDate,
                Description = x.mt.Description,
                LanguageId = x.mt.LanguageId,
                Link = x.m.Link
            }).AsNoTracking().ToListAsync());
        }
        public async Task<ApiResult<int>> CreateAsync(WebsiteMenuRequest request)
        {
            var languages = _context.Languages;
            var translations = new List<WebsiteMenuTranslation>();
            foreach (var language in languages)
            {
                if (language.Id == request.LanguageId)
                {
                    translations.Add(new WebsiteMenuTranslation()
                    {
                        Name = request.Name,
                        Description = request.Description,
                        LanguageId = request.LanguageId
                    });
                }
                else
                {
                    translations.Add(new WebsiteMenuTranslation()
                    {
                        Name = SystemConstants.AppConstants.NA,
                        Description = SystemConstants.AppConstants.NA,
                        LanguageId = language.Id
                    });
                }
            }
            var websiteMenu = new WebsiteMenu()
            {
                SortOrder = request.SortOrder,
                Code = request.Code,
                WebsiteMenuType = request.WebsiteMenuType,
                ParentId = request.ParentId,
                Icon = request.Icon,
                Link = request.Link,
                WebsiteMenuTranslations = translations
            };

            _context.WebsiteMenus.Add(websiteMenu);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(websiteMenu.Id);
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var websiteMenus = await _context.WebsiteMenus.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (websiteMenus == null) throw new EShopException($"Cannot find store: {request.Ids.ToString()}");

                List<int> websiteMenuIds = websiteMenus.Select(m => m.Id).ToList();
                var websiteMenuTranslations = _context.WebsiteMenuTranslations.Where(m => websiteMenuIds.Contains(m.WebsiteMenuId)).ToList();
                if (websiteMenuTranslations != null)
                {
                    _context.WebsiteMenuTranslations.RemoveRange(websiteMenuTranslations);
                }

                _context.WebsiteMenus.RemoveRange(websiteMenus);

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

        public async Task<PagedResult<WebsiteMenuDto>> GetManageListPaging(ManageWebsiteMenuPagingRequest request)
        {
            //1. Select join
            var query = from m in _context.WebsiteMenus
                        join mt in _context.WebsiteMenuTranslations on m.Id equals mt.WebsiteMenuId into mmt
                        from mt in mmt.DefaultIfEmpty()
                        where mt.LanguageId == request.LanguageId
                        select new { m, mt };
            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.mt.Name.Contains(request.TextSearch));

            if (request.WebsiteMenuType != null)
            {
                query = query.Where(x => x.m.WebsiteMenuType == request.WebsiteMenuType.Value);
            }

            //3. Paging
            int totalRow = await query.CountAsync();

            if (request.PageIndex != null)
            {
                query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                            .Take(request.PageSize);
            }
            var data = await query.Select(x => new WebsiteMenuDto()
            {
                Id = x.m.Id,
                SortOrder = x.m.SortOrder,
                Code = x.m.Code,
                Name = x.mt.Name,
                ParentId = x.m.ParentId,
                Link = x.m.Link,
                Icon = x.m.Icon,
                WebsiteMenuType = x.m.WebsiteMenuType
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<WebsiteMenuDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<WebsiteMenuDto>> GetById(WebsiteMenuRequest request)
        {
            var websiteMenu = await _context.WebsiteMenus.FindAsync(request.Id);
            var websiteMenuTranslation = await _context.WebsiteMenuTranslations.FirstOrDefaultAsync(x => x.WebsiteMenuId == request.Id
                                                                                                        && x.LanguageId == request.LanguageId);

            var websiteMenuDto = new WebsiteMenuDto()
            {
                Id = websiteMenu.Id,
                CreatedDate = websiteMenu.CreatedDate,
                Description = websiteMenuTranslation != null ? websiteMenuTranslation.Description : string.Empty,
                LanguageId = websiteMenuTranslation.LanguageId,
                SortOrder = websiteMenu.SortOrder,
                Code = websiteMenu.Code,
                Name = websiteMenuTranslation != null ? websiteMenuTranslation.Name : string.Empty,
                ParentId = websiteMenu.ParentId,
                Icon = websiteMenu.Icon,
                Link = websiteMenu.Link,
                WebsiteMenuType = websiteMenu.WebsiteMenuType
            };

            return new ApiSuccessResult<WebsiteMenuDto>(websiteMenuDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(WebsiteMenuRequest request)
        {
            var websiteMenu = await _context.WebsiteMenus.FindAsync(request.Id);
            var websiteMenuTranslations = await _context.WebsiteMenuTranslations.FirstOrDefaultAsync(x => x.WebsiteMenuId == request.Id
            && x.LanguageId == request.LanguageId);

            if (websiteMenu == null || websiteMenuTranslations == null) throw new EShopException($"Cannot find a websiteMenu with id: {request.Id}");

            websiteMenuTranslations.Name = request.Name;
            websiteMenuTranslations.Description = request.Description;
            websiteMenu.SortOrder = request.SortOrder;
            websiteMenu.Code = request.Code;
            websiteMenu.ParentId = request.ParentId;
            websiteMenu.Icon = request.Icon;
            websiteMenu.ModifiedDate = DateTime.Now;
            websiteMenu.Link = request.Link;
            websiteMenu.WebsiteMenuType = request.WebsiteMenuType;

            return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
        }
    }
}
