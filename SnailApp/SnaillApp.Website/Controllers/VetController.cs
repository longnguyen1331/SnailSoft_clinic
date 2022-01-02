using ChinoPet.ApiIntegration;
using ChinoPet.Utilities.Constants;
using ChinoPet.Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ChinoPet.Website.Controllers
{
    public class VetController : Controller
    {
        private readonly ILogger<VetController> _logger;
        private readonly IConfiguration _configuration;
        private readonly ITestimonialApiClient _testimonialApiClient;

        public VetController(ILogger<VetController> logger,
                                IConfiguration configuration,
                                ITestimonialApiClient testimonialApiClient
            )
        {
            _logger = logger;
            _testimonialApiClient = testimonialApiClient;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            var model = new VetViewModel();

            var testimonialApiClient = await _testimonialApiClient.GetPublicAll(new ViewModels.News.Testimonials.ManageTestimonialPagingRequest()
            {
                OrderCol = "sortOrder",
                OrderDir = "asc"
            });

            if (testimonialApiClient.IsSuccessed)
            {
                model.Testimonials = testimonialApiClient.ResultObj;
                foreach (var item in model.Testimonials)
                {
                    item.Image = _configuration[SystemConstants.AppConstants.BaseAddress] + "/" + item.Image;
                }
            }
            return View(model);
        }


    }
}
