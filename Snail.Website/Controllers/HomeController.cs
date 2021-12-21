using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ChinoPet.Utilities.Constants;
using ChinoPet.Website.Models;
using ChinoPet.ApiIntegration;
using ChinoPet.ViewModels.Catalog.PetServiceSelections;

namespace ChinoPet.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IContactInformationApiClient _contactInformationApiClient;
        private readonly ITestimonialApiClient _testimonialApiClient;
        private readonly IPetServiceSelectionApiClient _petServiceSelectionApiClient;

        public HomeController(IConfiguration configuration, 
                                IContactInformationApiClient contactInformationApiClient,
                                ITestimonialApiClient testimonialApiClient,
                                IPetServiceSelectionApiClient petServiceSelectionApiClient)
        {
            _contactInformationApiClient = contactInformationApiClient;
            _testimonialApiClient = testimonialApiClient;
            _petServiceSelectionApiClient = petServiceSelectionApiClient;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            var model = new HomeViewModel();
            int languageId = Convert.ToInt32(_configuration[SystemConstants.AppConstants.DefaultLanguageId]);

            HttpContext.Session.SetString(SystemConstants.AppConstants.DefaultLanguageId, languageId.ToString());

            var contactInformationApiClient = await _contactInformationApiClient.GetPublicDefault();

            if (contactInformationApiClient.IsSuccessed)
            {
                model.ContactInformation = contactInformationApiClient.ResultObj;
            }

            var testimonialApiClient = await _testimonialApiClient.GetPublicAll(new ViewModels.News.Testimonials.ManageTestimonialPagingRequest() { 
                OrderCol = "sortOrder",
                OrderDir = "asc"
            });

            if (testimonialApiClient.IsSuccessed)
            {
                model.Testimonials = testimonialApiClient.ResultObj;
                foreach(var item in model.Testimonials)
                {
                    item.Image = _configuration[SystemConstants.AppConstants.BaseAddress] + "/" + item.Image;
                }    
            }

            var petServiceSelectionApiClient = await _petServiceSelectionApiClient.GetPublicAll(new ManagePetServiceSelectionPagingRequest()
            {
                LanguageId = languageId
            });

            if (petServiceSelectionApiClient.IsSuccessed)
            {
                model.PetServiceSelections = petServiceSelectionApiClient.ResultObj;
            }

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
