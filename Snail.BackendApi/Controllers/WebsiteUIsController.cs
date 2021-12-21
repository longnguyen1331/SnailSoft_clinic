using System.Threading.Tasks;
using Snail.Application.Utilities.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Snail.ViewModels.Website.WebsiteUIs;
using Snail.Application.Website.WebsiteUIs;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class WebsiteUIsController : ControllerBase
    {
        private readonly IWebsiteUIService _websiteUIService;

        public WebsiteUIsController(IWebsiteUIService websiteUIService)
        {
            _websiteUIService = websiteUIService;
        }
        [HttpGet("GetTopHeaderObjects")]
        [AllowAnonymous]
        public async Task<IActionResult> GetTopHeaderObjects([FromQuery]WebsiteUIRequest request)
        {
            var data = await _websiteUIService.GetTopHeaderObjects(request);
            return Ok(data);
        }
        [HttpGet("GetFooterObjects")]
        [AllowAnonymous]
        public async Task<IActionResult> GetFooterObjects([FromQuery] WebsiteUIRequest request)
        {
            var data = await _websiteUIService.GetFooterObjects(request);
            return Ok(data);
        }
    }
}
