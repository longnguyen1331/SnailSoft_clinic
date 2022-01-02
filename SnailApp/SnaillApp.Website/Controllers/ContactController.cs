using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChinoPet.ViewModels.Common;
using ChinoPet.ApiIntegration;
using ChinoPet.ViewModels.Sales.Contacts;
using ChinoPet.Website.Models;

namespace ChinoPet.Website.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactApiClient _contactApiClient;
        private readonly IContactInformationApiClient _contactInformationApiClient;

        public ContactController(IContactApiClient contactApiClient,
                                IContactInformationApiClient contactInformationApiClient)
        {
            _contactApiClient = contactApiClient;
            _contactInformationApiClient = contactInformationApiClient;
        }

        public async Task<IActionResult> Index()
        {
            var model = new ContactViewModel();
            
            var contactInformationApiClient = await _contactInformationApiClient.GetPublicDefault();

            if (contactInformationApiClient.IsSuccessed)
            {
                model.ContactInformation = contactInformationApiClient.ResultObj;
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] AddEditRequest<ContactRequest> rq)
        {
            ApiResult<int> result = null;

            if (rq != null)
            {
                result = await _contactApiClient.PublicAddOrUpdateAsync(rq.Data);
            }
            else
            {
                result = new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = "Không có dữ liệu"
                };
            }

            return Ok(result);
        }

    }
}
