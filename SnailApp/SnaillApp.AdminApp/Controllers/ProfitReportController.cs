using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SnailApp.AdminApp.Models;
using Microsoft.AspNetCore.Authorization;
using SnailApp.Utilities.Constants;
using Microsoft.AspNetCore.Http;
using SnailApp.ViewModels.Accountants.PhieuKeToans;
using SnailApp.ApiIntegration;
using SnailApp.Utilities.Session;
using SnailApp.ViewModels.System.Users;
using SnailApp.ViewModels.Common;
using BHSNetCoreLib.ExcelUtil;

namespace SnailApp.AdminApp.Controllers
{
    public class ProfitReportController : BaseController
    {
        private readonly IReportProfitApiClient _reportProfitApiClient;

        public ProfitReportController(
            IReportProfitApiClient reportProfitApiClient
        )
        {
            _reportProfitApiClient = reportProfitApiClient;
        }

        public IActionResult Index()
        {
            BaseViewModel model = new BaseViewModel();

            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(
                SystemConstants.AppConstants.CurrentUserRoleSession),
                (ControllerContext.ActionDescriptor).ControllerName,
                (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Báo cáo";
            model.Breadcrumbs = new List<string>() { "Trang chủ", "Báo cáo", "Lợi nhuận", "Báo cáo" };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DataTableGetList(int? draw, int? start, int? length, string fDate, string tDate)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManageReportProfitPagingRequest()
            {
                FromDate = !string.IsNullOrEmpty(fDate) ? fDate : "01/01/" + DateTime.Now.Year.ToString(),
                ToDate = !string.IsNullOrEmpty(tDate) ? tDate : DateTime.Now.ToString("dd/MM/yyyy"),
                PageIndex = skip,
                PageSize = pageSize,
                StoreId = storeId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var orderApiClient = await _reportProfitApiClient.GetReport(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = orderApiClient.TotalRecords,
                recordsTotal = orderApiClient.TotalRecords,
                data = orderApiClient.Items
            });
        }
    }
}