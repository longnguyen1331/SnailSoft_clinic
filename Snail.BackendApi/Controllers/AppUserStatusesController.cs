using System;
using System.Linq;
using Snail.ViewModels.System.Statuses.AppUserStatus;
using Snail.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Snail.Application.SystemApplication.Statuses;
using Snail.ViewModels.Common;
using Microsoft.Extensions.Configuration;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AppUserStatusesController : ControllerBase
    {
        private readonly IAppUserStatusService _appUserStatusService;
        private readonly IConfiguration _configuration;

        public AppUserStatusesController(IAppUserStatusService appUserStatusService, IConfiguration configuration)
        {
            _appUserStatusService = appUserStatusService;
            _configuration = configuration;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageAppUserStatusPagingRequest request)
        {
            var result = await _appUserStatusService.GetManageListPaging(request);
            return Ok(result);
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] ManageAppUserStatusPagingRequest request)
        {
            var stores = await _appUserStatusService.GetManageListPaging(request);
            return Ok(stores);
        }

        [HttpGet("{appUserStatusId}")]
        public async Task<IActionResult> GetById(int appUserStatusId, int languageId)
        {
            var result = await _appUserStatusService.GetById(appUserStatusId, languageId);
            if (result.IsSuccessed)
            {
                if (result.ResultObj == null)
                {
                    return BadRequest("Cannot find AppUserStatus");
                }                    
            }
            
            return Ok(result);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] AppUserStatusRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _appUserStatusService.UpdateAsync(request);
            }
            else
            {
                res = await _appUserStatusService.CreateAsync(request);
            }

            if (res.IsSuccessed)
            {
                if (res.ResultObj == 0)
                    return BadRequest();
            }

            return Ok(res);
        }

        [HttpDelete("{ids}")]
        public async Task<IActionResult> DeleteByIds(string ids)
        {
            var result = await _appUserStatusService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });
            return Ok(result);
        }
    }
}
