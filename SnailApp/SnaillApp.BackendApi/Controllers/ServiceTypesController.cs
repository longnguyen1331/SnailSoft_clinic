using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.ViewModels.Common;
using SnailApp.Application.Catalog.Services;
using SnailApp.ViewModels.Catalog.ServiceTypes;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ServiceTypesController : ControllerBase
    {
        private readonly IServiceTypeService _serviceTypeService;

        public ServiceTypesController(IServiceTypeService serviceTypeService
            )
        {
            _serviceTypeService = serviceTypeService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageServiceTypePagingRequest request)
        {
            var serviceTypes = await _serviceTypeService.GetManageListPaging(request);
            return Ok(serviceTypes);
        }

        [HttpGet("serviceTypeId")]
        public async Task<IActionResult> GetById(ServiceTypeRequest request)
        {
            var serviceType = await _serviceTypeService.GetById(request);
            if (serviceType.IsSuccessed)
            {
                if (serviceType.ResultObj == null)
                {
                    return BadRequest("Cannot find serviceType");
                }
            }
            
            return Ok(serviceType);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromForm] ServiceTypeRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id > 0)
            {
                res = await _serviceTypeService.UpdateAsync(request);
            }
            else
            {
                res = await _serviceTypeService.CreateAsync(request);
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
            var result = await _serviceTypeService.DeleteByIds(new DeleteRequest() { 
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
