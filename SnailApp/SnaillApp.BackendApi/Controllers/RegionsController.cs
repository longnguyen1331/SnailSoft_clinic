using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.ViewModels.Common;
using SnailApp.Application.Catalog.Regions;
using SnailApp.ViewModels.Catalog.Regions;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RegionsController : ControllerBase
    {
        private readonly IRegionService _regionService;

        public RegionsController(IRegionService regionService
            )
        {
            _regionService = regionService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageRegionPagingRequest request)
        {
            var regions = await _regionService.GetManageListPaging(request);
            return Ok(regions);
        }

        [HttpGet("regionId")]
        public async Task<IActionResult> GetById(RegionRequest request)
        {
            var region = await _regionService.GetById(request);
            if (region.IsSuccessed)
            {
                if (region.ResultObj == null)
                {
                    return BadRequest("Cannot find region");
                }
            }
            
            return Ok(region);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] RegionRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id > 0)
            {
                res = await _regionService.UpdateAsync(request);
            }
            else
            {
                res = await _regionService.CreateAsync(request);
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
            var result = await _regionService.DeleteByIds(new DeleteRequest() { 
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });
            return Ok(result);
        }
    }
}
