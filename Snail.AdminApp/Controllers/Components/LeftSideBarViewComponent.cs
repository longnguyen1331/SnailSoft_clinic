using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Snail.ApiIntegration;
using Snail.Utilities.Constants;
using Snail.ViewModels.System.Menus;
using Snail.AdminApp.Models;
using Snail.ViewModels.Utilities.UI.AdminApp;

namespace Snail.AdminApp.Controllers.Components
{
    public class LeftSideBarViewComponent: ViewComponent
    {
        private readonly IAdminAppUIApiClient _adminAppUIApiClient;
        private readonly IConfiguration _configuration;
        private readonly ILanguageApiClient _languageApiClient;

        public LeftSideBarViewComponent(IAdminAppUIApiClient adminAppUIApiClient, IConfiguration configuration,
                                        ILanguageApiClient languageApiClient)
        {
            _adminAppUIApiClient = adminAppUIApiClient;
            _configuration = configuration;
            _languageApiClient = languageApiClient;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var leftSideBarViewModel = new LeftSideBarViewModel();
            var currentLanguageId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            var request = new AdminAppLeftSideBarRequest()
            {
                LanguageId = currentLanguageId,
                UserId = HttpContext.Session.GetString(SystemConstants.AppConstants.UserId)
            };

            var leftSideBarApiClient = await _adminAppUIApiClient.GetLeftSideBarObjects(request);

            if(leftSideBarApiClient.IsSuccessed)
            {
                leftSideBarViewModel.HtmlMenus = GenerateHtmlMenu(leftSideBarApiClient.ResultObj.Menus);
                leftSideBarViewModel.Logo = _configuration[SystemConstants.AppConstants.BaseAddress] + leftSideBarApiClient.ResultObj.Logo;
            }            

            return View("Default", leftSideBarViewModel);
        }

        private string GenerateHtmlMenu(List<MenuDto> menus)
        {
            string result = string.Empty;

            foreach(var menu in menus.Where(m => m.ParentId == null).OrderBy(m => m.SortOrder))
            {           
                result += GenerateHtmlMenuNode(menu, menus);
            }

            return result;
        }
        public static string GenerateHtmlMenuNode(MenuDto currentMenu, List<MenuDto> menus)
        {
            string str = string.Empty;

            if (menus.Count(m => m.ParentId != null && m.ParentId == currentMenu.Id) > 0)
            {

                str += $@"<div data-kt-menu-trigger='click' class='menu-item menu-accordion'>";
                str += $@"<span class='menu-link'>";
                //str += $@"<span class='menu-bullet'>";
                //str += $@"<span class='bullet bullet-dot'></span>";
                //str += $@"</span>";

                str += currentMenu.Icon;
                str += $@"<span class='menu-title'>" + currentMenu.Name + "</span>";
                str += $@"<span class='menu-arrow'></span>";
                str += $@"</span>";

                foreach (var subMenu in menus.Where(m => m.ParentId != null && m.ParentId == currentMenu.Id).OrderBy(m => m.SortOrder))
                {
                    str += $@"<div class='menu-sub menu-sub-accordion menu-active-bg'>";
                        str += GenerateHtmlMenuNode(subMenu, menus);
                    str += $@"</div>";
                }
                str += $@"</div>";
            }
            else
            {
                str += $@"<div class='menu-item'>";
                str += $@"<a class='menu-link' href='" + currentMenu.Link + "' data-menuid='" + currentMenu.Id.ToString() + "'>";
                str += $@"<span class='menu-bullet'>";
                str += $@"<span class='bullet bullet-dot'></span>";
                str += $@"</span>";
                str += $@"<span class='menu-title'>" + currentMenu.Name + "</span>";
                str += $@"</a>";
                str += $@"</div>";
            }

            return str;
        }
    }
}