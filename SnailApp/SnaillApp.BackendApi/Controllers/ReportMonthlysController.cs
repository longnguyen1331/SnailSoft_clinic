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
    public class ReportMonthlysController : ControllerBase
    {
        private readonly IReportMonthlyService _reportMonthlyService;

        public ReportMonthlysController(IReportMonthlyService reportMonthlyService)
        {
            _reportMonthlyService = reportMonthlyService;
        }

        [HttpGet("GetReport")]
        public async Task<IActionResult> GetReport([FromQuery] ManageReportMonthlyPagingRequest request)
        {
            var reportMonthly = await _reportMonthlyService.GetReport(request);
            return Ok(reportMonthly);
        }
    }
}
