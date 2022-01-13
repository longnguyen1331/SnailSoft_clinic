using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.ViewModels.Common;
using SnailApp.Application.Catalog.Services;
using SnailApp.ViewModels.Catalog.Services;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServicesController(IServiceService serviceService
            )
        {
            _serviceService = serviceService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageServicePagingRequest request)
        {
            var services = await _serviceService.GetManageListPaging(request);
            return Ok(services);
        }

        [HttpGet("GetManageListFilterPaging")]
        public async Task<IActionResult> GetManageListFilterPaging([FromQuery] ManageServicePagingRequest request)
        {
            var services = await _serviceService.GetManageListFilterPaging(request);
            return Ok(services);
        }

        [HttpGet("serviceId")]
        public async Task<IActionResult> GetById([FromQuery] ServiceRequest request)
        {
            var service = await _serviceService.GetById(request);
            if (service.IsSuccessed)
            {
                if (service.ResultObj == null)
                {
                    return BadRequest("Cannot find service");
                }
            }
            
            return Ok(service);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromForm] ServiceRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id > 0)
            {
                res = await _serviceService.UpdateAsync(request);
            }
            else
            {
                res = await _serviceService.CreateAsync(request);
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
            var result = await _serviceService.DeleteByIds(new DeleteRequest() { 
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
