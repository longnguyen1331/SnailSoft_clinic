using SnailApp.Application.Common;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;
using SnailApp.ViewModels.System.MenuAppRoles;
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

namespace SnailApp.Application.SystemApplication.MenuAppRoles
{
    public interface IMenuAppRoleService
    {
        Task<ApiResult<int>> AddOrUpdateAsync(MenuAppRoleRequest request);
        Task<ApiResult<List<MenuAppRoleDto>>> GetAll(ManageMenuAppRolePagingRequest request);
    }
    public class MenuAppRoleService : IMenuAppRoleService
    {
        private readonly EShopDbContext _context;

        public MenuAppRoleService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<ApiResult<List<MenuAppRoleDto>>> GetAll(ManageMenuAppRolePagingRequest request)
        {
            try
            {
                var query = from ma in _context.MenuAppRoles
                            select new { ma };

                if (!string.IsNullOrEmpty(request.AppRoleId))
                {
                    query = query.Where(m => m.ma.AppRoleId == Guid.Parse(request.AppRoleId));
                }

                if (request.MenuId != null)
                {
                    query = query.Where(m => m.ma.MenuId == request.MenuId.Value);
                }

                return new ApiSuccessResult<List<MenuAppRoleDto>>(await query.Select(x => new MenuAppRoleDto()
                {
                    Id = x.ma.Id,
                    MenuId = x.ma.MenuId,
                    AppRoleId = x.ma.AppRoleId.ToString(),
                    MenuAppRoleType = (int)x.ma.MenuAppRoleType,
                    IsAllow = x.ma.IsAllow
                }).AsNoTracking().ToListAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<List<MenuAppRoleDto>>(ex.Message);
            }
            
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(MenuAppRoleRequest request)
        {
            try
            {
                bool isNewMenuAppRole = false;

                MenuAppRole menuAppRole = _context.MenuAppRoles.FirstOrDefault(m => m.MenuId == request.MenuId
                                                                                && m.AppRoleId == Guid.Parse(request.AppRoleId)
                                                                                && m.MenuAppRoleType == (MenuAppRoleType)request.MenuAppRoleType);

                if (menuAppRole == null)
                {
                    isNewMenuAppRole = true;
                    menuAppRole = new MenuAppRole()
                    {
                        CreatedDate = DateTime.Now,
                        CreatedUserId = Guid.Parse(request.CreatedUserId),
                        AppRoleId = Guid.Parse(request.AppRoleId),
                        MenuId = request.MenuId
                    };
                }

                menuAppRole.MenuAppRoleType = (MenuAppRoleType)request.MenuAppRoleType;
                menuAppRole.IsAllow = request.IsAllow;
                menuAppRole.ModifiedDate = DateTime.Now;
                menuAppRole.ModifiedUserId = Guid.Parse(request.ModifiedUserId);

                if (isNewMenuAppRole == true)
                {
                    _context.MenuAppRoles.Add(menuAppRole);
                }
                else
                {
                    _context.MenuAppRoles.Update(menuAppRole);
                }

                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(menuAppRole.Id);
            }
            catch(Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }
    }
}
