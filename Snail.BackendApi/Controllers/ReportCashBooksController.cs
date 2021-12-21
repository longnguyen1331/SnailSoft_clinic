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
    public class ReportCashBooksController : ControllerBase
    {
        private readonly IReportCashBookService _reportCashBookService;

        public ReportCashBooksController(IReportCashBookService reportCashBookService)
        {
            _reportCashBookService = reportCashBookService;
        }

        [HttpGet("GetReport")]
        public async Task<IActionResult> GetReport([FromQuery] ManageReportCashBookPagingRequest request)
        {
            var reportCashBooks = await _reportCashBookService.GetReport(request);
            return Ok(reportCashBooks);
        }
    }
}
