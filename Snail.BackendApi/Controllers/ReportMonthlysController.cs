using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Snail.Application.Accountants;
using Snail.ViewModels.Accountants.PhieuKeToans;

namespace Snail.BackendApi.Controllers
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
