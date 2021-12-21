using System;
using System.Linq;
using Snail.ViewModels.System.AppUser_AppUserTypes;
using Snail.Application.SystemApplication.AppUser_AppUserTypes;
using Snail.ViewModels.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AppUser_AppUserTypesController : ControllerBase
    {
        private readonly IAppUser_AppUserTypeService _appUser_AppUserTypeService;

        public AppUser_AppUserTypesController(IAppUser_AppUserTypeService appUser_AppUserTypeService)
        {
            _appUser_AppUserTypeService = appUser_AppUserTypeService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] ManageAppUser_AppUserTypePagingRequest request)
        {
            var appUser_AppUserTypes = await _appUser_AppUserTypeService.GetAll(request);
            return Ok(appUser_AppUserTypes);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] AppUser_AppUserTypeRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = await _appUser_AppUserTypeService.AddOrUpdateAsync(request);

            if (res.IsSuccessed)
            {
                if (res.ResultObj == 0)
                {
                    return BadRequest();
                }
            }

            return Ok(res);
        }
    }
}
