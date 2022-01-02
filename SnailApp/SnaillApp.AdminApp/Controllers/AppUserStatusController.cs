using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BHSNetCoreLib.ExcelUtil;
using SnailApp.ApiIntegration;
using SnailApp.ViewModels.System.Statuses.AppUserStatus;
using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Session;
using Microsoft.Extensions.Configuration;
using SnailApp.AdminApp.Models;
using SnailApp.ViewModels.System.Users;

namespace SnailApp.AdminApp.Controllers
{
    public class AppUserStatusController : BaseController
    {
        private readonly IAppUserStatusApiClient _appUserStatusApiClient;
        public AppUserStatusController(IAppUserStatusApiClient appUserStatusApiClient)
        {
            _appUserStatusApiClient = appUserStatusApiClient;
        }

        public IActionResult Index()
        {
            AppUserStatusViewModel model = new AppUserStatusViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);
            model.PageTitle = "Trạng thái Người sử dụng";
            model.Breadcrumbs = new List<string>() { "Cài đặt", "Danh mục hệ thống", "Trạng thái", "Trạng thái Người sử dụng" };

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

            var request = new ManageAppUserStatusPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var appUserStatusApiClient = await _appUserStatusApiClient.GetManageListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = appUserStatusApiClient.TotalRecords,
                recordsTotal = appUserStatusApiClient.TotalRecords,
                data = appUserStatusApiClient.Items
            });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] DeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _appUserStatusApiClient.DeleteByIds(request);

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
        public async Task<IActionResult> Save([FromBody] AddEditRequest<AppUserStatusRequest> rq)
        {
            ApiResult<int> result = null;

            Guid userGuid = Guid.Parse(HttpContext.Session.GetString(SystemConstants.AppConstants.UserId));

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
                result = await _appUserStatusApiClient.AddOrUpdateAsync(rq.Data);
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

        public async Task<IActionResult> Filter(string textSearch)
        {
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));

            var request = new ManageAppUserStatusPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = 1,
                PageSize = 20,
                LanguageId = languageId,
                OrderCol = "Id",
                OrderDir = "desc"
            };

            var appUserStatusApiClient = await _appUserStatusApiClient.GetManageListPaging(request);
            return Ok(appUserStatusApiClient);
        }
    }
}
