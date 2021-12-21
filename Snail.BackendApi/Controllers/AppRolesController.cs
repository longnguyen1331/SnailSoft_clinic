using System;
using System.Linq;
using System.Collections.Generic;
using Snail.ViewModels.System.AppRoles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Snail.Application.SystemApplication.AppRoles;
using Snail.ViewModels.Common;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AppRolesController : ControllerBase
    {

        private readonly IAppRoleService _appRoleService;

        public AppRolesController(IAppRoleService appRoleService)
        {
            _appRoleService = appRoleService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] ManageAppRolePagingRequest request)
        {
            var appRoles = await _appRoleService.GetAll(request);
            return Ok(appRoles);
        }
        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageAppRolePagingRequest request)
        {
            var appRoles = await _appRoleService.GetManageListPaging(request);
            return Ok(appRoles);
        }

        [HttpGet("{appRoleId}")]
        public async Task<IActionResult> GetById(string appRoleId, int languageId)
        {
            var appRole = await _appRoleService.GetById(appRoleId, languageId);
            if (appRole.IsSuccessed)
            {
                if (appRole.ResultObj == null)
                {
                    return BadRequest("Cannot find appRole");
                }
            }                
                    
            return Ok(appRole);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] AppRoleRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<string> res = null;
            if (!string.IsNullOrEmpty(request.Id))
            {
                res = await _appRoleService.UpdateAsync(request);

            }
            else
            {
                res = await _appRoleService.CreateAsync(request);
            }

            if (res.IsSuccessed)
            {
                if (string.IsNullOrEmpty(res.ResultObj))
                {
                    return BadRequest();
                }
            }

            return Ok(res);
        }


        [HttpDelete("{ids}")]
        public async Task<IActionResult> DeleteByIds(string ids)
        {
            var result = await _appRoleService.DeleteByIds(new AppRoleDeleteRequest()
            {
                Ids = ids.Split("|").ToList()
            });
            return Ok(result);
        }
    }
}
