using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.ViewModels.Enums;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.System.AppRoles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace SnailApp.Application.SystemApplication.AppRoles
{
    public interface IAppRoleService
    {
        Task<ApiResult<List<AppRoleDto>>> GetAll(ManageAppRolePagingRequest request);
        Task<PagedResult<AppRoleDto>> GetManageListPaging(ManageAppRolePagingRequest request);
        Task<ApiResult<string>> CreateAsync(AppRoleRequest request);
        Task<ApiResult<int>> DeleteByIds(AppRoleDeleteRequest request);
        Task<ApiResult<AppRoleDto>> GetById(string roleId, int languageId);
        Task<ApiResult<string>> UpdateAsync(AppRoleRequest request);
    }
    public class AppRoleService : IAppRoleService
    {
        private readonly ClinicDbContext _context;
        private readonly RoleManager<AppRole> _roleManager;

        public AppRoleService(ClinicDbContext context, RoleManager<AppRole> roleManager)
        {
            _context = context;
            _roleManager = roleManager;
        }
        public async Task<ApiResult<List<AppRoleDto>>> GetAll(ManageAppRolePagingRequest request)
        {
            var query = from r in _context.Roles
                        join rt in _context.AppRoleTranslations on r.Id equals rt.AppRoleId
                        where rt.LanguageId == request.LanguageId
                        select new { r, rt };

            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.rt.Name.Contains(request.TextSearch));
            }

            return new ApiSuccessResult<List<AppRoleDto>>(await query.Select(x => new AppRoleDto()
            {
                Id = x.r.Id.ToString(),
                Code = x.r.Name,
                Type = x.r.Type,
                Name = x.rt.Name,
                Description = x.rt.Description
            }).AsNoTracking().ToListAsync());
        }
        public async Task<ApiResult<string>> CreateAsync(AppRoleRequest request)
        {
            var languages = _context.Languages;
            var translations = new List<AppRoleTranslation>();
            foreach (var language in languages)
            {
                if (language.Id == request.LanguageId)
                {
                    translations.Add(new AppRoleTranslation()
                    {
                        Name = request.Name,
                        Description = request.Description,
                        LanguageId = request.LanguageId
                    });
                }
                else
                {
                    translations.Add(new AppRoleTranslation()
                    {
                        Name = SystemConstants.AppConstants.NA,
                        Description = SystemConstants.AppConstants.NA,
                        LanguageId = language.Id
                    });
                }
            }
            var appRole = new AppRole()
            {
                AppRoleTranslations = translations,
                Name = request.Code,
                Type = request.Type,
                Description = request.Description
            };

            _context.Roles.Add(appRole);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<string>(appRole.Id.ToString());
        }

        public async Task<ApiResult<int>> DeleteByIds(AppRoleDeleteRequest request)
        {
            try
            {
                var roles = await _context.Roles.Where(m => request.Ids.Contains(m.Id.ToString())).ToListAsync();
                if (roles == null) throw new EShopException($"Cannot find Id: {String.Join(";", request.Ids)}");

                List<Guid> roleIds = roles.Select(m => m.Id).ToList();
                var roleTranslations = _context.AppRoleTranslations.Where(m => roleIds.Contains(m.AppRoleId)).ToList();
                if (roleTranslations != null)
                {
                    _context.AppRoleTranslations.RemoveRange(roleTranslations);
                }

                var menuRoles = _context.MenuAppRoles.Where(m => roleIds.Contains(m.AppRoleId)).ToList();
                if (menuRoles != null)
                {
                    _context.MenuAppRoles.RemoveRange(menuRoles);
                }

                _context.Roles.RemoveRange(roles);

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

        public async Task<PagedResult<AppRoleDto>> GetManageListPaging(ManageAppRolePagingRequest request)
        {
            //1. Select join
            var query = from r in _context.Roles
                        join rt in _context.AppRoleTranslations on r.Id equals rt.AppRoleId into rrt
                        from rt in rrt.DefaultIfEmpty()
                        where rt.LanguageId == request.LanguageId
                        select new { r, rt };
            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.rt.Name.Contains(request.TextSearch));

            //3. Paging
            int totalRow = await query.CountAsync();

            if (request.PageIndex != null)
            {
                query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                            .Take(request.PageSize);
            }
            var data = await query.Select(x => new AppRoleDto()
            {
                Id = x.r.Id.ToString(),
                Code = x.r.Name,
                Name = x.rt.Name,
                Description = x.rt.Description,
                Type = x.r.Type,
                LanguageId = x.rt.LanguageId
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<AppRoleDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<AppRoleDto>> GetById(string appRoleId, int languageId)
        {
            var appRoleIdValue = Guid.Parse(appRoleId);
            var role = await _context.Roles.FindAsync(appRoleIdValue);
            var roleTranslation = await _context.AppRoleTranslations.FirstOrDefaultAsync(x => x.AppRoleId == appRoleIdValue
                                                                                        && x.LanguageId == languageId);

            var roleDto = new AppRoleDto()
            {
                Id = role.Id.ToString(),
                LanguageId = roleTranslation.LanguageId,
                Code = role.Name,
                Name = roleTranslation != null ? roleTranslation.Name : string.Empty,                
                Description = roleTranslation != null ? roleTranslation.Description : string.Empty
            };

            return new ApiSuccessResult<AppRoleDto>(roleDto);
        }

        public async Task<ApiResult<string>> UpdateAsync(AppRoleRequest request)
        {
            var appRole = await _roleManager.FindByIdAsync(request.Id);
            Guid appRoleId = Guid.Parse(request.Id);
            var roleTranslations = await _context.AppRoleTranslations.FirstOrDefaultAsync(x => x.AppRoleId == appRoleId
                                                                                                && x.LanguageId == request.LanguageId);

            if (appRole == null || roleTranslations == null) throw new EShopException($"Cannot find a role with id: {request.Id}");
            
            roleTranslations.Name = request.Name;
            roleTranslations.Description = request.Description;
            appRole.Name = request.Code;
            appRole.Type = request.Type;
            appRole.Description = request.Description;
            
            _context.AppRoleTranslations.Update(roleTranslations);
            await _context.SaveChangesAsync();
            await _roleManager.UpdateAsync(appRole);

            return new ApiSuccessResult<string>(request.Id);
        }
    }
}