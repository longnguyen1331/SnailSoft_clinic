using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using ChinoPet.ApiIntegration;
using ChinoPet.Utilities.Constants;
using ChinoPet.Website.Models;
using ChinoPet.ViewModels.Website.WebsiteUIs;

namespace ChinoPet.Website.Controllers.Components
{
    public class TopHeaderViewComponent : ViewComponent
    {
        private readonly IWebsiteUIApiClient _websiteUIApiClient;
        private readonly IConfiguration _configuration;

        public TopHeaderViewComponent(IWebsiteUIApiClient websiteUIApiClient, IConfiguration configuration)
        {
            _websiteUIApiClient = websiteUIApiClient;
            _configuration = configuration;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            int languageId = Convert.ToInt32(_configuration[SystemConstants.AppConstants.DefaultLanguageId]);
            var str = HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId);
            if(!string.IsNullOrEmpty(str))
            {
                languageId = Convert.ToInt32(str);
            }    

            var model = new TopHeaderViewModel()
            {
                CurrentLanguageId = languageId
            };

            var websiteUIApiClient = await _websiteUIApiClient.GetTopHeaderObjects(new WebsiteUIRequest()
            {
                LanguageId = model.CurrentLanguageId
            });

            if (websiteUIApiClient.IsSuccessed)
            {
                model.Logo = _configuration[SystemConstants.AppConstants.BaseAddress] + websiteUIApiClient.ResultObj.Logo;
                model.Menus = websiteUIApiClient.ResultObj.Menus;
                model.ContactInformation = websiteUIApiClient.ResultObj.ContactInformation;
            }

            return View("Default", model);
        }
    }
}
