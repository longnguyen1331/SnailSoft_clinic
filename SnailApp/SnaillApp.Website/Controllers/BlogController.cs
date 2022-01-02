using ChinoPet.ApiIntegration;
using ChinoPet.Utilities.Constants;
using ChinoPet.ViewModels.News.Posts;
using ChinoPet.Website.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ChinoPet.ViewModels.Catalog.PetServiceSelections;

namespace ChinoPet.Website.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<BlogController> _logger;
        private readonly IPostApiClient _postApiClient;
        private readonly IConfiguration _configuration;
        private readonly IPetServiceSelectionApiClient _petServiceSelectionApiClient;
        private readonly IContactInformationApiClient _contactInformationApiClient;

        public BlogController(ILogger<BlogController> logger,
            IPostApiClient postApiClient, 
            IConfiguration configuration,
            IPetServiceSelectionApiClient petServiceSelectionApiClient,
            IContactInformationApiClient contactInformationApiClient)
        {
            _logger = logger;
            _configuration = configuration;
            _postApiClient = postApiClient;
            _petServiceSelectionApiClient = petServiceSelectionApiClient;
            _contactInformationApiClient = contactInformationApiClient;
        }


        public async Task<IActionResult> Index(int? page = 1, int? pageSize = 5, string search = "")
        {
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            var request = new PublicPostPagingRequest()
            {
                TextSearch = search,
                PageIndex = page,
                PageSize = pageSize.Value,
                LanguageId = languageId,
                OrderCol = "CreateDate",
                OrderDir = "desc"
            };
            BlogViewModel model = new BlogViewModel();

            model.Data = await _postApiClient.GetPublicListPaging(request);
            model.UrlServer = _configuration[SystemConstants.AppConstants.BaseAddress];

            var petServiceSelectionApiClient = await _petServiceSelectionApiClient.GetPublicAll(new ManagePetServiceSelectionPagingRequest()
            {
                LanguageId = languageId
            });

            if (petServiceSelectionApiClient.IsSuccessed)
            {
                model.PetServiceSelections = petServiceSelectionApiClient.ResultObj;
            }

            var contactInformationApiClient = await _contactInformationApiClient.GetPublicDefault();

            if (contactInformationApiClient.IsSuccessed)
            {
                model.ContactInformation = contactInformationApiClient.ResultObj;
            }

            return View(model);
        }


        public async Task<IActionResult> Category(string category, int? page = 1, int? pageSize = 10, string search = "")
        {
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            var request = new PublicPostPagingRequest()
            {
                TextSearch = search,
                PageIndex = page,
                PageSize = pageSize.Value,
                PostTypeAlias = !string.IsNullOrEmpty(category) ? category : null,
                LanguageId = languageId,
                OrderCol = "CreateDate",
                OrderDir = "desc"
            };

            var postApiClient = await _postApiClient.GetPublicListPaging(request);
            BlogViewModel model = new BlogViewModel();
            model.Posts = postApiClient?.Items;
            model.UrlServer = _configuration[SystemConstants.AppConstants.BaseAddress];
            return View(model);
        }
    }
}
