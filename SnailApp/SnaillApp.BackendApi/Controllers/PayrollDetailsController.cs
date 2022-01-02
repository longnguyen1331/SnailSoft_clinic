using System;
using System.Linq;
using SnailApp.ViewModels.HR.PayrollDetails;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.HR.PayrollDetails;
using SnailApp.ViewModels.Common;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PayrollDetailsController : ControllerBase
    {
        private readonly IPayrollDetailService _payrollDetailService;

        public PayrollDetailsController(IPayrollDetailService payrollDetailService)
        {
            _payrollDetailService = payrollDetailService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManagePayrollDetailPagingRequest request)
        {
            var payrollDetails = await _payrollDetailService.GetManageListPaging(request);
            return Ok(payrollDetails);
        }
    }
}
