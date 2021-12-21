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

namespace Snail.AdminApp.Controllers
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