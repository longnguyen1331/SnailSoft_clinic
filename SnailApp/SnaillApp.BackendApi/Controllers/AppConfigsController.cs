using System;
using System.Linq;
using SnailApp.ViewModels.System.AppConfigs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.SystemApplication.AppConfigs;
using SnailApp.ViewModels.Common;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AppConfigsController : ControllerBase
    {
        private readonly IAppConfigService _appConfigService;

        public AppConfigsController(IAppConfigService appConfigService)
        {
            _appConfigService = appConfigService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageAppConfigPagingRequest request)
        {
            var appConfigs = await _appConfigService.GetManageListPaging(request);
            return Ok(appConfigs);
        }

        [HttpGet("{appConfigId}")]
        public async Task<IActionResult> GetById(int appConfigId)
        {
            var appConfig = await _appConfigService.GetById(appConfigId);
            if (appConfig.IsSuccessed)
                if (appConfig.ResultObj == null)
                    return BadRequest("Cannot find AppConfig");
            return Ok(appConfig);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] AppConfigRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _appConfigService.UpdateAsync(request);
            }
            else
            {
                res = await _appConfigService.CreateAsync(request);
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
            var result = await _appConfigService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
