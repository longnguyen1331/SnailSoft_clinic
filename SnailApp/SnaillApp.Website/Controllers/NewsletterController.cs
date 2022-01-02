using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChinoPet.ViewModels.Common;
using ChinoPet.ApiIntegration;
using ChinoPet.ViewModels.News.Newsletters;

namespace ChinoPet.Website.Controllers
{
    public class NewsletterController : Controller
    {
        private readonly INewsletterApiClient _newsletterApiClient;

        public NewsletterController(INewsletterApiClient newsletterApiClient)
        {
            _newsletterApiClient = newsletterApiClient;
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] AddEditRequest<NewsletterRequest> rq)
        {
            ApiResult<int> result = null;

            if (rq != null)
            {
                result = await _newsletterApiClient.PublicAddOrUpdateAsync(rq.Data);
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
