using System;
using System.Linq;
using Snail.ViewModels.HR.Payrolls;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Snail.Application.HR.Payrolls;
using Snail.ViewModels.Common;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PayrollsController : ControllerBase
    {
        private readonly IPayrollService _payrollService;

        public PayrollsController(IPayrollService payrollService)
        {
            _payrollService = payrollService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManagePayrollPagingRequest request)
        {
            var payrolls = await _payrollService.GetManageListPaging(request);
            return Ok(payrolls);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] PayrollRequest request)
        {
            var payroll = await _payrollService.GetById(request);
            if (payroll.IsSuccessed)
                if (payroll.ResultObj == null)
                    return BadRequest("Cannot find payroll");
            return Ok(payroll);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] PayrollRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = await _payrollService.AddOrUpdateAsync(request); ;
         
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
            var result = await _payrollService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }

        [HttpPost("calculatepayroll")]
        public async Task<IActionResult> CalculatePayroll(PayrollRequest request)
        {
            return Ok(await _payrollService.CalculatePayroll(request));
        }
    }
}
