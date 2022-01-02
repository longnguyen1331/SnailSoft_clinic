using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BHSNetCoreLib.ExcelUtil;
using SnailApp.ApiIntegration;
using SnailApp.ViewModels.Sales.CommissionDiscounts;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SnailApp.Utilities.Constants;
using SnailApp.AdminApp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Rendering;
using SnailApp.ViewModels.System.Users;
using SnailApp.Utilities.Session;

namespace SnailApp.AdminApp.Controllers
{
    public class CommissionDiscountController : Controller
    {
        private readonly ICommissionDiscountApiClient _commissionDiscountApiClient;

        public CommissionDiscountController(ICommissionDiscountApiClient commissionDiscountApiClient)
        {
            _commissionDiscountApiClient = commissionDiscountApiClient;
        }

        public IActionResult Index()
        {
            CommissionDiscountViewModel model = new CommissionDiscountViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Hoa hồng - Giảm giá";
            model.Breadcrumbs = new List<string>() { "Bán hàng", "Hoa hồng - Giảm giá" };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DataTableGetList(int? draw, int? start, int? length, string textSearch)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));

            var request = new ManageCommissionDiscountPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var commissionDiscountApiClient = await _commissionDiscountApiClient.GetManageListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = commissionDiscountApiClient.TotalRecords,
                recordsTotal = commissionDiscountApiClient.TotalRecords,
                data = commissionDiscountApiClient.Items
            });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] DeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _commissionDiscountApiClient.DeleteByIds(request);

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
        public async Task<IActionResult> Save([FromBody] AddEditRequest<CommissionDiscountRequest> rq)
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
                result = await _commissionDiscountApiClient.AddOrUpdateAsync(rq.Data);
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

        [HttpGet]
        public async Task<IActionResult> Filter(string textSearch)
        {
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));

            var request = new ManageCommissionDiscountPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = 1,
                PageSize = 20,
                LanguageId = languageId,
                OrderCol = "Id"
            };

            var data = await _commissionDiscountApiClient.GetManageListPaging(request);
            return Ok(data);
        }
    }
}
