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
