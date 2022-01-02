using ChinoPet.Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ChinoPet.ApiIntegration;

namespace ChinoPet.Website.Controllers
{
    public class AboutController : Controller
    {
        private readonly IContactInformationApiClient _contactInformationApiClient;

        public AboutController(IContactInformationApiClient contactInformationApiClient)
        {
            _contactInformationApiClient = contactInformationApiClient;
        }
        [Route("about-us")]
        public async Task<IActionResult> Index()
        {
            var model = new AboutViewModel();

            var contactInformationApiClient = await _contactInformationApiClient.GetPublicDefault();

            if (contactInformationApiClient.IsSuccessed)
            {
                model.ContactInformation = contactInformationApiClient.ResultObj;
            }

            return View(model);
        }

        
    }
}
