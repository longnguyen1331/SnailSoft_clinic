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

namespace SnailApp.AdminApp.Controllers
{
    public class MonthlyReportController : BaseController
    {
        private readonly IReportMonthlyApiClient _reportMonthlyApiClient;

        public MonthlyReportController(
            IReportMonthlyApiClient reportMonthlyApiClient
        )
        {
            _reportMonthlyApiClient = reportMonthlyApiClient;
        }

        public IActionResult Index()
        {
            var model = new MonthlyReportViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Báo cáo tháng";
            model.Breadcrumbs = new List<string>() { "Trang chủ", "Báo cáo", "Báo cáo tháng" };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> GetReport([FromBody] ManageReportMonthlyPagingRequest rq)
        {
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManageReportMonthlyPagingRequest()
            {
                StoreId = storeId,
                LanguageId = languageId,
                Year = rq.Year
            };

            var data = await _reportMonthlyApiClient.GetReport(request);

            return Json(new
            {
                data = data
            });
        }


      
    }
}