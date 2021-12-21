using System.Threading.Tasks;
using Snail.Application.Utilities.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Snail.ViewModels.Utilities.UI.AdminApp;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AdminAppUIsController : ControllerBase
    {
        private readonly IAdminAppUIService _adminAppUIService;

        public AdminAppUIsController(IAdminAppUIService adminAppUIService)
        {
            _adminAppUIService = adminAppUIService;
        }
        [HttpGet("getHeaderObjects")]
        [AllowAnonymous]
        public async Task<IActionResult> GetHeaderObjects(string userName)
        {
            var data = await _adminAppUIService.GetHeaderObjects(new AdminAppHeaderRequest() { UserName = userName} );
            return Ok(data);
        }
        [HttpGet("getLoginObjects")]
        [AllowAnonymous]
        public IActionResult GetLoginObjects()
        {
            var data = _adminAppUIService.GetLoginObjects();
            return Ok(data);
        }
        [HttpGet("getLeftSideBarObjects")]
        [AllowAnonymous]
        public async Task<IActionResult> GetLeftSideBarObjects([FromQuery] AdminAppLeftSideBarRequest request)
        {
            var data = await _adminAppUIService.GetLeftSideBarObjects(request);
            return Ok(data);
        }
    }
}
