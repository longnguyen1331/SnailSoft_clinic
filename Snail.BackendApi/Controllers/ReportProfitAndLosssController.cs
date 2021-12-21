using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Snail.Application.Accountants;
using Snail.ViewModels.Common;
using Snail.ViewModels.Accountants.PhieuKeToans;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReportProfitAndLosssController : ControllerBase
    {
        private readonly IReportProfitAndLossService _reportProfitAndLossService;

        public ReportProfitAndLosssController(IReportProfitAndLossService reportProfitAndLossService)
        {
            _reportProfitAndLossService = reportProfitAndLossService;
        }

        [HttpGet("GetReport")]
        public async Task<IActionResult> GetReport([FromQuery] ManageReportProfitAndLossPagingRequest request)
        {
            var reportProfitAndLosss = await _reportProfitAndLossService.GetReport(request);
            return Ok(reportProfitAndLosss);
        }
    }
}
