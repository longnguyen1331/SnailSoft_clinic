using System;
using System.Linq;
using Snail.ViewModels.Catalog.AppUserTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Snail.Application.Catalog.AppUserTypes;
using Snail.ViewModels.Common;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AppUserTypesController : ControllerBase
    {
        private readonly IAppUserTypeService _appUserTypeService;

        public AppUserTypesController(IAppUserTypeService appUserTypeService)
        {
            _appUserTypeService = appUserTypeService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageAppUserTypePagingRequest request)
        {
            var appUserTypes = await _appUserTypeService.GetManageListPaging(request);
            return Ok(appUserTypes);
        }

        [HttpGet("{appUserTypeId}")]
        public async Task<IActionResult> GetById(int appUserTypeId, int languageId)
        {
            var appUserType = await _appUserTypeService.GetById(appUserTypeId, languageId);
            if (appUserType.IsSuccessed)
                if (appUserType.ResultObj == null)
                    return BadRequest("Cannot find appUserType");
            return Ok(appUserType);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] AppUserTypeRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _appUserTypeService.UpdateAsync(request);
            }
            else
            {
                res = await _appUserTypeService.CreateAsync(request);
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
            var result = await _appUserTypeService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
