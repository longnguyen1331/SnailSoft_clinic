using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ApiIntegration;
using SnailApp.ViewModels.System.Users;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.System.AppRoles;
using SnailApp.ViewModels.Sales.AppUser_CommissionDiscounts;
using SnailApp.AdminApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Session;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;

namespace SnailApp.AdminApp.Controllers
{
    public class AppUser_CommissionDiscountController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IAppUser_CommissionDiscountApiClient _appUser_CommissionDiscountApiClient;

        public AppUser_CommissionDiscountController(IConfiguration configuration, 
                                                    IAppUser_CommissionDiscountApiClient appUser_CommissionDiscountApiClient)
        {
            _configuration = configuration;
            _appUser_CommissionDiscountApiClient = appUser_CommissionDiscountApiClient;
        }

        [HttpPost]
        public async Task<IActionResult> DataTableGetList(int? draw, int? start, int? length, string textSearch, string filterByAppUserId)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));

            var userApiClient = await _appUser_CommissionDiscountApiClient.GetManageListPaging(new ManageAppUser_CommissionDiscountPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc",
                AppUserId = filterByAppUserId
            });

            return Json(new
            {
                draw = draw,
                recordsFiltered = userApiClient.TotalRecords,
                recordsTotal = userApiClient.TotalRecords,
                data = userApiClient.Items
            });
        }
        [HttpPost]
        public async Task<IActionResult> Save([FromBody] AddEditRequest<AppUser_CommissionDiscountRequest> rq)
        {
            ApiResult<int> result = null;

            string userGuid = HttpContext.Session.GetString(SystemConstants.AppConstants.UserId);

            if (rq != null)
            {
                rq.Data.LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
                if (rq.Id == null)
                {
                    rq.Data.CreatedUserId = userGuid;
                    rq.Data.ModifiedUserId = userGuid;
                }
                else
                {
                    rq.Data.ModifiedUserId = userGuid;
                    rq.Data.Id = rq.Id.Value;
                }
                result = await _appUser_CommissionDiscountApiClient.AddOrUpdateAsync(rq.Data);
            }
            else
            {
                result = new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = "Không có dữ liệu"
                };
            }

            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] DeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _appUser_CommissionDiscountApiClient.DeleteByIds(request);

            if (!result.IsSuccessed)
            {
                resultMessage = "Lỗi";
            }

            return Json(new
            {
                isSuccessed = result.IsSuccessed,
                message = resultMessage
            });
        }
        [HttpPost]
        public async Task<IActionResult> DataTableGetListDetail(int? draw, int? start, int? length, string textSearch, string filterByAppUserId,
                                                            string filterByFromDate, string filterByToDate)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));

            var userApiClient = await _appUser_CommissionDiscountApiClient.GetManageListDetailPaging(new ManageAppUser_CommissionDiscountPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc",
                AppUserId = filterByAppUserId,
                FilterByFromDate = filterByFromDate,
                FilterByToDate = filterByToDate
            });

            return Json(new
            {
                draw = draw,
                recordsFiltered = userApiClient.TotalRecords,
                recordsTotal = userApiClient.TotalRecords,
                data = userApiClient.Items
            });
        }
    }
}
