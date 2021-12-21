using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Snail.AdminApp.Models;
using Microsoft.AspNetCore.Authorization;
using Snail.Utilities.Constants;
using Microsoft.AspNetCore.Http;
using Snail.ViewModels.Accountants.PhieuKeToans;
using Snail.ApiIntegration;
using Snail.Utilities.Session;
using Snail.ViewModels.System.Users;
using Snail.ViewModels.Common;
using BHSNetCoreLib.ExcelUtil;

namespace Snail.AdminApp.Controllers
{
    public class ProductReportController : BaseController
    {
        private readonly IReportProductApiClient _reportProductApiClient;

        public ProductReportController(
            IReportProductApiClient reportProductApiClient
        )
        {
            _reportProductApiClient = reportProductApiClient;
        }

        public IActionResult Index()
        {
            var model = new WarehouseModel();

            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(
                SystemConstants.AppConstants.CurrentUserRoleSession),
                (ControllerContext.ActionDescriptor).ControllerName,
                (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Hàng hóa & dịch vụ";
            model.Breadcrumbs = new List<string>() { "Trang chủ", "Báo cáo", "Hàng hóa & dịch vụ" };
     
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DataTableGetList(int? draw, int? start, int? length,
            string fDate, string tDate)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManageReportWarehousePagingRequest()
            {
                ToDate = !string.IsNullOrEmpty(tDate) ? tDate : DateTime.Now.ToString("dd/MM/yyyy"),
                FromDate = !string.IsNullOrEmpty(fDate) ? fDate : "01/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString(),
                PageIndex = skip,
                PageSize = pageSize,
                StoreId = storeId,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var orderApiClient = await _reportProductApiClient.GetReport(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = orderApiClient.TotalRecords,
                recordsTotal = orderApiClient.TotalRecords,
                data = orderApiClient.Items
            });
        }


        [HttpPost]
        public async Task<IActionResult> GetTotalReport([FromBody] ManageReportWarehousePagingRequest rq)
        {
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));
          
            var request = new ManageReportWarehousePagingRequest()
            {
                ToDate = !string.IsNullOrEmpty(rq.ToDate) ? rq.ToDate : DateTime.Now.ToString("dd/MM/yyyy"),
                FromDate = !string.IsNullOrEmpty(rq.FromDate) ? rq.FromDate : "01/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString(),
                PageIndex = 0,
                PageSize = 10,
                StoreId = storeId,
                LanguageId = languageId,
            };

            var data = await _reportProductApiClient.GetTotalReport(request);

            return Json(new
            {
                data = data
            });
        }

    }
}