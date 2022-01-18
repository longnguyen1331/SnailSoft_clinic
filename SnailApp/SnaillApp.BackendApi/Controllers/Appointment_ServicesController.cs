using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.ViewModels.Common;
using SnailApp.Application.Catalog.Appointment_Services;
using Microsoft.AspNetCore.Http;
using SnailApp.ViewModels.Catalog.Appointments;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class Appointment_ServicesController : ControllerBase
    {
        private readonly IAppointment_ServiceService _examinationsResultService;

        public Appointment_ServicesController(IAppointment_ServiceService examinationsResultService
            )
        {
            _examinationsResultService = examinationsResultService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageAppointment_ServicePagingRequest request)
        {
            var examinationsResults = await _examinationsResultService.GetManageListPaging(request);
            return Ok(examinationsResults);
        }
        

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById([FromQuery] Appointment_ServiceRequest request)
        {
            var examinationsResult = await _examinationsResultService.GetById(request);
            if (examinationsResult.IsSuccessed)
            {
                if (examinationsResult.ResultObj == null)
                {
                    return BadRequest("Cannot find appointmentservice");
                }
            }
            
            return Ok(examinationsResult);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromForm] Appointment_ServiceRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id > 0)
            {
                res = await _examinationsResultService.UpdateAsync(request);
            }
            else
            {
                res = await _examinationsResultService.CreateAsync(request);
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
            var result = await _examinationsResultService.DeleteByIds(new DeleteRequest() { 
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }

        [HttpPost("ckeditoruploadfile")]
        public async Task<IActionResult> CKEditorUploadFile([FromForm] IFormFile uploadFile)
        {
            var result = await _examinationsResultService.CKEditorUploadFile(uploadFile);

            return Ok(result);
        }

    }
}
