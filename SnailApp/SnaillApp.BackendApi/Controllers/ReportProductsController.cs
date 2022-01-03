﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.Accountants;
using SnailApp.ViewModels.Accountants.PhieuKeToans;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReportProductsController : ControllerBase
    {
        private readonly IReportProductService _reportProductService;

        public ReportProductsController(IReportProductService reportProductService)
        {
            _reportProductService = reportProductService;
        }

        [HttpGet("GetReport")]
        public async Task<IActionResult> GetReport([FromQuery] ManageReportWarehousePagingRequest request)
        {
            var reportWarehouses = await _reportProductService.GetReport(request);
            return Ok(reportWarehouses);
        }

        [HttpGet("GetTotalReport")]
        public async Task<IActionResult> GetTotalReport([FromQuery] ManageReportWarehousePagingRequest request)
        {
            var reportWarehouses = await _reportProductService.GetTotalReport(request);
            return Ok(reportWarehouses);
        }
    }
}