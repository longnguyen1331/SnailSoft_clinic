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
    public class ReportWarehousesController : ControllerBase
    {
        private readonly IReportWarehouseService _reportWarehouseService;

        public ReportWarehousesController(IReportWarehouseService reportWarehouseService)
        {
            _reportWarehouseService = reportWarehouseService;
        }

        [HttpGet("GetReport")]
        public async Task<IActionResult> GetReport([FromQuery] ManageReportWarehousePagingRequest request)
        {
            var reportWarehouses = await _reportWarehouseService.GetReport(request);
            return Ok(reportWarehouses);
        }
    }
}
