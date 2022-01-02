using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BHSNetCoreLib.ExcelUtil;
using SnailApp.ApiIntegration;
using SnailApp.ViewModels.HR.PayrollDetails;
using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SnailApp.Utilities.Constants;
using SnailApp.AdminApp.Models;
using SnailApp.ViewModels.System.Users;
using SnailApp.Utilities.Session;

namespace SnailApp.AdminApp.Controllers
{
    public class PayrollDetailController : Controller
    {
        private readonly IPayrollDetailApiClient _payrollDetailApiClient;

        public PayrollDetailController(IPayrollDetailApiClient payrollDetailApiClient)
        {
            _payrollDetailApiClient = payrollDetailApiClient;
        }

        [HttpPost]
        public async Task<IActionResult> DataTableGetList(int? draw, int? start, int? length, string textSearch, string filterByPayrollId)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));

            var request = new ManagePayrollDetailPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc",
                PayrollId = !string.IsNullOrEmpty(filterByPayrollId) ? Convert.ToInt32(filterByPayrollId) : new Nullable<int>()
            };

            var payrollDetailApiClient = await _payrollDetailApiClient.GetManageListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = payrollDetailApiClient.TotalRecords,
                recordsTotal = payrollDetailApiClient.TotalRecords,
                data = payrollDetailApiClient.Items
            });
        }
    }
}
