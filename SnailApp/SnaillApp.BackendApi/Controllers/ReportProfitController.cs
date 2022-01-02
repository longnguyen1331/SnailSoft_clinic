using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.Accountants;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Accountants.PhieuKeToans;

namespace SnailApp.BackendApi.Controllers
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
