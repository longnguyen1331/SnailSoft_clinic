using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.ViewModels.Common;
using SnailApp.Application.Catalog.Clinics;
using SnailApp.Application.Catalog.Appointments;
using SnailApp.ViewModels.Catalog.Appointments;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentsController(IAppointmentService appointmentService
            )
        {
            _appointmentService = appointmentService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageAppointmentPagingRequest request)
        {
            var appointments = await _appointmentService.GetManageListPaging(request);
            return Ok(appointments);
        }

        [HttpGet("appointmentId")]
        public async Task<IActionResult> GetById([FromQuery] AppointmentRequest request)
        {
            var appointment = await _appointmentService.GetById(request);
            if (appointment.IsSuccessed)
            {
                if (appointment.ResultObj == null)
                {
                    return BadRequest("Cannot find appointment");
                }
            }
            
            return Ok(appointment);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] AppointmentRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id > 0)
            {
                res = await _appointmentService.UpdateAsync(request);
            }
            else
            {
                res = await _appointmentService.CreateAsync(request);
            }

            if (res.IsSuccessed)
            {
                if (res.ResultObj == 0)
                    return BadRequest();
            }    

            return Ok(res);
        }

        [HttpPost("changeStatus")]
        public async Task<IActionResult> ChangeStatus([FromBody] AppointmentRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id > 0)
            {
                res = await _appointmentService.ChangeStatus(request);
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
            var result = await _appointmentService.DeleteByIds(new DeleteRequest() { 
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
