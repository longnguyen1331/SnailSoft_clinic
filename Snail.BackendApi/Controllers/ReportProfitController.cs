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
    public class ReportProfitsController : ControllerBase
    {
        private readonly IReportProfitService _reportProfitService;

        public ReportProfitsController(IReportProfitService reportProfitService)
        {
            _reportProfitService = reportProfitService;
        }

        [HttpGet("GetReport")]
        public async Task<IActionResult> GetReport([FromQuery] ManageReportProfitPagingRequest request)
        {
            var reportProfits = await _reportProfitService.GetReport(request);
            return Ok(reportProfits);
        }
    }
}
