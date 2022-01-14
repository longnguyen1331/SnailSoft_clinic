using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.ViewModels.Common;
using SnailApp.Application.Catalog.AppointmentPayments;
using SnailApp.ViewModels.Catalog.Appointments;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AppointmentPaymentsController : ControllerBase
    {
        private readonly IAppointmentPaymentService _appointmentPaymentService;

        public AppointmentPaymentsController(IAppointmentPaymentService appointmentPaymentService
            )
        {
            _appointmentPaymentService = appointmentPaymentService;
        }

      
        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] AppointmentPaymentRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id > 0)
            {
                //res = await _appointmentPaymentService.UpdateAsync(request);
            }
            else
            {
                res = await _appointmentPaymentService.CreateAsync(request);
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
            var result = await _appointmentPaymentService.DeleteByIds(new DeleteRequest() { 
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
