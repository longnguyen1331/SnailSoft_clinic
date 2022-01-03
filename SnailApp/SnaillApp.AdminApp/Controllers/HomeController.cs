﻿using System;
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
using SnailApp.ApiIntegration;
using SnailApp.ViewModels.Accountants.PhieuKeToans;
using SnailApp.ViewModels.System.Users;
using SnailApp.ViewModels.Common;

namespace SnailApp.AdminApp.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IReportSummaryApiClient _reportSummaryApiClient;
        private readonly IUserApiClient _userApiClient;

        public HomeController(ILogger<HomeController> logger,
            IUserApiClient userApiClient,
            IReportSummaryApiClient reportSummaryApiClient
            )
        {
            _userApiClient = userApiClient;
            _logger = logger;
            _reportSummaryApiClient = reportSummaryApiClient;

        }

        public IActionResult Index()
        {
            var model = new HomeViewModel();
            
            model.PageTitle = "Tổng quan";
            model.Breadcrumbs = new List<string>() { "Tổng quan" };

            var user = User.Identity.Name;

            return View(model);
        }

        [HttpPost]
        public IActionResult Language(HeaderViewModel viewModel)
        {
            HttpContext.Session.SetString(SystemConstants.AppConstants.DefaultLanguageId, viewModel.CurrentLanguageId.ToString());

            return Redirect(viewModel.ReturnUrl);
        }


        [HttpPost]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequest rq)
        {
            ApiResult<int> result = null;

            if (rq != null)
            {
                rq.Id = Guid.Parse(HttpContext.Session.GetString(SystemConstants.AppConstants.UserId));
                result = await _userApiClient.ChangePassword(rq);
            }
            else
            {
                result = new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = result.Message
                };
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> GetReport([FromBody] ManageReportSummaryPagingRequest rq)
        {
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManageReportSummaryPagingRequest()
            {
                StoreId = storeId,
                LanguageId = languageId,
                FromDate = rq.FromDate,
                ToDate = rq.ToDate,
            };

            var data = await _reportSummaryApiClient.GetReport(request);

            return Json(new
            {
                data = data
            });
        }


    }
}