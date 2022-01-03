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
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SnailApp.ViewModels.System.Menus;

namespace SnailApp.Application.SystemApplication.Menus
{
    public interface IMenuService
    {
        Task<ApiResult<List<MenuDto>>> GetAll(ManageMenuPagingRequest request);
        Task<PagedResult<MenuDto>> GetManageListPaging(ManageMenuPagingRequest request);
        Task<ApiResult<int>> CreateAsync(MenuRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<MenuDto>> GetById(MenuRequest request);
        Task<ApiResult<int>> UpdateAsync(MenuRequest request);
    }
    public class MenuService : IMenuService
    {
        private readonly ClinicDbContext _context;

        public MenuService(ClinicDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<MenuDto>>> GetAll(ManageMenuPagingRequest request)
        {
            //1. Select join
            var query = from m in _context.Menus
                        join mt in _context.MenuTranslations on m.Id equals mt.MenuId
                        where mt.LanguageId == request.LanguageId 
                        select new { m, mt };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.mt.Name.Contains(request.TextSearch));

            return new ApiSuccessResult<List<MenuDto>>(await query.Select(x => new MenuDto()
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
                MenuType = x.m.MenuType,
                Link = x.m.Link
            }).AsNoTracking().ToListAsync());
        }
        public async Task<ApiResult<int>> CreateAsync(MenuRequest request)
        {
            var languages = _context.Languages;
            var translations = new List<MenuTranslation>();
            foreach (var language in languages)
            {
                if (language.Id == request.LanguageId)
                {
                    translations.Add(new MenuTranslation()
                    {
                        Name = request.Name,
                        Description = request.Description,
                        LanguageId = request.LanguageId
                    });
                }
                else
                {
                    translations.Add(new MenuTranslation()
                    {
                        Name = SystemConstants.AppConstants.NA,
                        Description = SystemConstants.AppConstants.NA,
                        LanguageId = language.Id
                    });
                }
            }
            var menu = new Menu()
            {
                SortOrder = request.SortOrder,
                Code = request.Code,
                MenuTranslations = translations,
                ParentId = request.ParentId,
                Icon = request.Icon,
                MenuType = request.MenuType,
                Link = request.Link
            };

            _context.Menus.Add(menu);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(menu.Id);
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var menus = await _context.Menus.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (menus == null) throw new EShopException($"Cannot find store: {request.Ids.ToString()}");

                List<int> menuIds = menus.Select(m => m.Id).ToList();
                var menuTranslations = _context.MenuTranslations.Where(m => menuIds.Contains(m.MenuId)).ToList();
                if (menuTranslations != null)
                {
                    _context.MenuTranslations.RemoveRange(menuTranslations);
                }

                var menuAppRoles = _context.MenuAppRoles.Where(i => menuIds.Contains(i.MenuId)).ToList();
                if (menuAppRoles != null)
                {
                    _context.MenuAppRoles.RemoveRange(menuAppRoles);
                }

                _context.Menus.RemoveRange(menus);

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

        public async Task<PagedResult<MenuDto>> GetManageListPaging(ManageMenuPagingRequest request)
        {
            //1. Select join
            var query = from m in _context.Menus
                        join mt in _context.MenuTranslations on m.Id equals mt.MenuId into mmt
                        from mt in mmt.DefaultIfEmpty()
                        where mt.LanguageId == request.LanguageId
                        select new { m, mt };
            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.mt.Name.Contains(request.TextSearch));

            //3. Paging
            int totalRow = await query.CountAsync();

            if (request.PageIndex != null)
            {
                query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                            .Take(request.PageSize);
            }
            var data = await query.Select(x => new MenuDto()
            {
                Id = x.m.Id,
                SortOrder = x.m.SortOrder,
                Code = x.m.Code,
                Name = x.mt.Name,
                ParentId = x.m.ParentId,
                CreatedDate = x.m.CreatedDate,
                Description = x.mt.Description,
                LanguageId = x.mt.LanguageId
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<MenuDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<MenuDto>> GetById(MenuRequest request)
        {
            var menu = await _context.Menus.FindAsync(request.Id);
            var menuTranslation = await _context.MenuTranslations.FirstOrDefaultAsync(x => x.MenuId == request.Id
                                                                                        && x.LanguageId == request.LanguageId);

            var menuDto = new MenuDto()
            {
                Id = menu.Id,
                CreatedDate = menu.CreatedDate,
                Description = menuTranslation != null ? menuTranslation.Description : string.Empty,
                LanguageId = menuTranslation.LanguageId,
                SortOrder = menu.SortOrder,
                Code = menu.Code,
                Name = menuTranslation != null ? menuTranslation.Name : string.Empty,
                ParentId = menu.ParentId,
                Icon = menu.Icon,
                MenuType = menu.MenuType,
                Link = menu.Link
            };

            return new ApiSuccessResult<MenuDto>(menuDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(MenuRequest request)
        {
            var menu = await _context.Menus.FindAsync(request.Id);
            var menuTranslations = await _context.MenuTranslations.FirstOrDefaultAsync(x => x.MenuId == request.Id
            && x.LanguageId == request.LanguageId);

            if (menu == null || menuTranslations == null) throw new EShopException($"Cannot find a menu with id: {request.Id}");

            menuTranslations.Name = request.Name;
            menuTranslations.Description = request.Description;
            menu.SortOrder = request.SortOrder;
            menu.Code = request.Code;
            menu.ParentId = request.ParentId;
            menu.Icon = request.Icon;
            menu.MenuType = request.MenuType;
            menu.ModifiedDate = DateTime.Now;
            menu.Link = request.Link;

            return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
        }
    }
}
