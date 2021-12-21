﻿using System;
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
    public class SummaryOfReceiptPaymentController : BaseController
    {
        private readonly IReportCashBookApiClient _reportCashBookApiClient;

        public SummaryOfReceiptPaymentController(
            IReportCashBookApiClient reportCashBookApiClient
        )
        {
            _reportCashBookApiClient = reportCashBookApiClient;
        }

        public IActionResult Index()
        {
            SummaryOfReceiptPaymentModel model = new SummaryOfReceiptPaymentModel();

            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(
                                                                    SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                    (ControllerContext.ActionDescriptor).ControllerName,
                                                                    (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Tổng quan dòng tiền";
            model.Breadcrumbs = new List<string>() { "Tiền bạc", "Tổng quan dòng tiền" };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> GetReport([FromBody] ManageReportCashBookPagingRequest rq)
        {
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManageReportCashBookPagingRequest()
            {
                StoreId = storeId,
                LanguageId = languageId,
                FromDate = rq.FromDate,
                ToDate = rq.ToDate,
            };

            var data = await _reportCashBookApiClient.GetReport(request);

            return Json(new
            {
                data = data
            });
        }
    }
}