using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using SnailApp.ApiIntegration;
using SnailApp.Utilities.Constants;
using SnailApp.AdminApp.Models;
using SnailApp.ViewModels.Utilities.UI.AdminApp;

namespace SnailApp.AdminApp.Controllers.Components
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly IAdminAppUIApiClient _adminAppUIApiClient;
        private readonly IConfiguration _configuration;
        private readonly IClinicApiClient _clinicApiClient;

        public HeaderViewComponent(IAdminAppUIApiClient adminAppUIApiClient, IConfiguration configuration,
                                IClinicApiClient clinicApiClient)
        {
            _adminAppUIApiClient = adminAppUIApiClient;
            _configuration = configuration;
            _clinicApiClient = clinicApiClient;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
                string userId = HttpContext.Session.GetString(SystemConstants.AppConstants.UserId);
                var clinics = await _clinicApiClient.GetClinicByUser(new ViewModels.System.User_Clinics.ManageUser_ClinicPagingRequest() { UserId = Guid.Parse(userId) });

                var headerViewModel = new HeaderViewModel()
                {
                    Clinics = clinics,
                    CurrentClinicId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultClinicId)),
                    CurrentLanguageId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)),
                    UserImage = _configuration[SystemConstants.AppConstants.BaseAddress] + _configuration[SystemConstants.AppConstants.FileNoImagePerson]
                };

                var adminAppUIApiClient = await _adminAppUIApiClient.GetHeaderObjects(new AdminAppHeaderRequest()
                {
                    UserName = User.Identity.Name
                });
                if (adminAppUIApiClient.IsSuccessed)
                {
                    headerViewModel.Languages = adminAppUIApiClient.ResultObj.Languages;
                    foreach (var language in headerViewModel.Languages)
                    {
                        if (language.Id == headerViewModel.CurrentLanguageId)
                        {
                            language.IsDefault = true;
                        }
                        language.Flag = _configuration["flags:" + language.Code];
                    }

                    headerViewModel.UserImage = _configuration[SystemConstants.AppConstants.BaseAddress] + adminAppUIApiClient.ResultObj.UserImage;
                    headerViewModel.FullName = adminAppUIApiClient.ResultObj.FullName;
                    headerViewModel.Email = adminAppUIApiClient.ResultObj.Email;


                    var request = new AdminAppLeftSideBarRequest()
                    {
                        LanguageId = headerViewModel.CurrentLanguageId,
                        UserId = userId
                    };

                    var leftSideBarApiClient = await _adminAppUIApiClient.GetLeftSideBarObjects(request);
                    headerViewModel.Logo = _configuration[SystemConstants.AppConstants.BaseAddress] + leftSideBarApiClient.ResultObj.Logo;
                    HttpContext.Session.SetString(SystemConstants.AppConstants.Logo, _configuration[SystemConstants.AppConstants.BaseAddress] + leftSideBarApiClient.ResultObj.Logo);
                    HttpContext.Session.SetString(SystemConstants.AppConstants.Logo, _configuration[SystemConstants.AppConstants.BaseAddress] + leftSideBarApiClient.ResultObj.Logo);
                }

                return View("Default", headerViewModel);
            
        }
    }
}
