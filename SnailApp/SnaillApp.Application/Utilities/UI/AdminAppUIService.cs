using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SnailApp.Utilities.Constants;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;
using SnailApp.ViewModels.Utilities.UI.AdminApp;
using SnailApp.ViewModels.System.Languages;
using SnailApp.ViewModels.System.Menus;

namespace SnailApp.Application.Utilities.UI
{
    public interface IAdminAppUIService
    {
        Task<ApiResult<AdminAppHeaderDto>> GetHeaderObjects(AdminAppHeaderRequest request);
        ApiResult<AdminAppLoginDto> GetLoginObjects();
        Task<ApiResult<AdminAppLeftSideBarDto>> GetLeftSideBarObjects(AdminAppLeftSideBarRequest request);
    }
    public class AdminAppUIService: IAdminAppUIService
    {
        private readonly IConfiguration _configuration;
        private readonly ClinicDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public AdminAppUIService(ClinicDbContext context, IConfiguration configuration,
                                UserManager<AppUser> userManager)
        {
            _configuration = configuration;
            _context = context;
            _userManager = userManager;
        }
        public async Task<ApiResult<AdminAppHeaderDto>> GetHeaderObjects(AdminAppHeaderRequest request)
        {
            var adminAppHeaderViewModel = new AdminAppHeaderDto();
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user != null)
            {
                adminAppHeaderViewModel.Email = user.Email;
                adminAppHeaderViewModel.FullName = user.FirstName + " "+ user.LastName;
                adminAppHeaderViewModel.UserImage = (!string.IsNullOrEmpty(user.Avatar) ? (_configuration[SystemConstants.UserConstants.UserImagePath] + "/" + user.Avatar) : _configuration[SystemConstants.AppConstants.FileNoImagePerson]);
            }

            var languages = await _context.Languages.Select(x => new LanguageDto()
            {
                Id = x.Id,
                Code = x.Code,
                Name = x.Name,
                IsDefault = x.IsDefault
            }).AsNoTracking().ToListAsync();

            adminAppHeaderViewModel.Languages = languages;

            return new ApiSuccessResult<AdminAppHeaderDto>(adminAppHeaderViewModel);
        }
        public ApiResult<AdminAppLoginDto> GetLoginObjects()
        {
            var adminAppLoginViewModel = new AdminAppLoginDto()
            {
                Logo = _configuration[SystemConstants.AppConstants.LogoFile2]
            };
            
            return new ApiSuccessResult<AdminAppLoginDto>(adminAppLoginViewModel);
        }
        public async Task<ApiResult<AdminAppLeftSideBarDto>> GetLeftSideBarObjects(AdminAppLeftSideBarRequest request)
        {
            var adminAppLeftSideBarViewModel = new AdminAppLeftSideBarDto()
            {
                Logo = _configuration[SystemConstants.AppConstants.LogoFile1],
                Menus = await (from m in _context.Menus
                               join mt in _context.MenuTranslations on m.Id equals mt.MenuId into mmt
                               from mt in mmt.DefaultIfEmpty()
                               join mar in _context.MenuAppRoles on m.Id equals mar.MenuId
                               join r in _context.Roles on mar.AppRoleId equals r.Id
                               join ur in _context.UserRoles on r.Id equals ur.RoleId
                               join u in _context.Users on ur.UserId equals u.Id
                               where mt.LanguageId == request.LanguageId && m.IsVisibled == true
                                        && u.Id == Guid.Parse(request.UserId)
                                        && ((mar.MenuAppRoleType == MenuAppRoleType.GlobalDataView && mar.IsAllow == true)
                                                || (mar.MenuAppRoleType == MenuAppRoleType.SystemDataView && mar.IsAllow == true)
                                                || (mar.MenuAppRoleType == MenuAppRoleType.PersonalDataView && mar.IsAllow == true))
                               select new MenuDto()
                               {
                                   Id = m.Id,
                                   SortOrder = m.SortOrder,
                                   Code = m.Code,
                                   Name = mt.Name,
                                   ParentId = m.ParentId,
                                   Link = m.Link,
                                   Icon = m.Icon,
                                   LanguageId = mt.LanguageId
                               }).AsNoTracking().ToListAsync()
            };

            return new ApiSuccessResult<AdminAppLeftSideBarDto>(adminAppLeftSideBarViewModel);
        }
    }
}
