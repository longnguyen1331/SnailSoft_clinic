using System;
using System.Linq;
using SnailApp.ViewModels.System.MenuAppRoles;
using SnailApp.Application.SystemApplication.MenuAppRoles;
using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MenuAppRolesController : ControllerBase
    {
        private readonly IMenuAppRoleService _menuAppRoleService;

        public MenuAppRolesController(IMenuAppRoleService menuAppRoleService)
        {
            _menuAppRoleService = menuAppRoleService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] ManageMenuAppRolePagingRequest request)
        {
            var menuAppRoles = await _menuAppRoleService.GetAll(request);
            return Ok(menuAppRoles);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] MenuAppRoleRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = await _menuAppRoleService.AddOrUpdateAsync(request);

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
