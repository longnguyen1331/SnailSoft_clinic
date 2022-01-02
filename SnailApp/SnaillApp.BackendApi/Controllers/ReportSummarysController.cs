using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.Accountants;
using SnailApp.ViewModels.Accountants.PhieuKeToans;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReportSummarysController : ControllerBase
    {
        private readonly IReportSummaryService _reportSummaryService;

        public ReportSummarysController(IReportSummaryService reportSummaryService)
        {
            _reportSummaryService = reportSummaryService;
        }

        [HttpGet("GetReport")]
        public async Task<IActionResult> GetReport([FromQuery] ManageReportSummaryPagingRequest request)
        {
            var reportSummarys = await _reportSummaryService.GetReport(request);
            return Ok(reportSummarys);
        }
    }
}
