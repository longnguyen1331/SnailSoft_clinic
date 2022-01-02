using System;
using System.Linq;
using SnailApp.ViewModels.Catalog.Manufacturers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.Catalog.Manufacturers;
using SnailApp.ViewModels.Common;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ManufacturersController : ControllerBase
    {
        private readonly IManufacturerService _manufacturerService;

        public ManufacturersController(IManufacturerService manufacturerService)
        {
            _manufacturerService = manufacturerService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageManufacturerPagingRequest request)
        {
            var manufacturers = await _manufacturerService.GetManageListPaging(request);
            return Ok(manufacturers);
        }

        [HttpGet("{manufacturerId}")]
        public async Task<IActionResult> GetById(int manufacturerId, int languageId)
        {
            var manufacturer = await _manufacturerService.GetById(manufacturerId, languageId);
            if (manufacturer.IsSuccessed)
                if (manufacturer.ResultObj == null)
                    return BadRequest("Cannot find manufacturer");
            return Ok(manufacturer);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] ManufacturerRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _manufacturerService.UpdateAsync(request);
            }
            else
            {
                res = await _manufacturerService.CreateAsync(request);
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
            var result = await _manufacturerService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
