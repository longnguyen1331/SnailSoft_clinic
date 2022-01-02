using System;
using System.Linq;
using SnailApp.ViewModels.Catalog.Units;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.Catalog.Units;
using SnailApp.ViewModels.Common;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UnitsController : ControllerBase
    {
        private readonly IUnitService _unitService;

        public UnitsController(IUnitService unitService)
        {
            _unitService = unitService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageUnitPagingRequest request)
        {
            var units = await _unitService.GetManageListPaging(request);
            return Ok(units);
        }

        [HttpGet("{unitId}")]
        public async Task<IActionResult> GetById(int unitId, int languageId)
        {
            var unit = await _unitService.GetById(unitId, languageId);
            if (unit.IsSuccessed)
                if (unit.ResultObj == null)
                    return BadRequest("Cannot find unit");
            return Ok(unit);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] UnitRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _unitService.UpdateAsync(request);
            }
            else
            {
                res = await _unitService.CreateAsync(request);
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
            var result = await _unitService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
