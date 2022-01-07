using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using SnailApp.ApiIntegration;
using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.System.Menus;
using SnailApp.AdminApp.Models;
using SnailApp.ViewModels.Utilities.UI.AdminApp;

namespace SnailApp.AdminApp.Controllers.Components
{
    public class LeftSideBarViewComponent : ViewComponent
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

            if (leftSideBarApiClient.IsSuccessed)
            {
                leftSideBarViewModel.Logo = _configuration[SystemConstants.AppConstants.BaseAddress] + leftSideBarApiClient.ResultObj.Logo;
                leftSideBarViewModel.Menus = leftSideBarApiClient.ResultObj.Menus;
            }

            return View("Default", leftSideBarViewModel);
        }
    }
}
