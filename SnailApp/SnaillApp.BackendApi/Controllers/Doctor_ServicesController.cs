using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Catalog.Doctor_Services;
using SnailApp.Application.Catalog.Doctor_Services;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class Doctor_ServicesController : ControllerBase
    {
        private readonly IDoctor_ServiceService _doctor_ServiceService;

        public Doctor_ServicesController(IDoctor_ServiceService doctor_ServiceService
            )
        {
            _doctor_ServiceService = doctor_ServiceService;
        }

        [HttpGet("GetManageServiceByUserListPaging")]
        public async Task<IActionResult> GetManageServiceByUserListPaging([FromQuery] ManageDoctor_ServicePagingRequest request)
        {
            var doctor_Services = await _doctor_ServiceService.GetManageServiceByUserListPaging(request);
            return Ok(doctor_Services);
        }

        [HttpGet("GetUserFilterService")]
        public async Task<IActionResult> GetUserFilterService([FromQuery] ManageDoctor_ServicePagingRequest request)
        {
            var doctor_Services = await _doctor_ServiceService.GetUserFilterService(request);
            return Ok(doctor_Services);
        }

        

        [HttpGet("GetManageUserByServiceListPaging")]
        public async Task<IActionResult> GetManageUserByServiceListPaging([FromQuery] ManageDoctor_ServicePagingRequest request)
        {
            var doctor_Services = await _doctor_ServiceService.GetManageUserByServiceListPaging(request);
            return Ok(doctor_Services);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] Doctor_ServiceRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            res = await _doctor_ServiceService.CreateAsync(request);

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
            var result = await _doctor_ServiceService.DeleteByIds(new DeleteRequest() { 
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
