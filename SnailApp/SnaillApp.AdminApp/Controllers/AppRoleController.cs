using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ApiIntegration;
using SnailApp.ViewModels.System.AppRoles;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.System.Menus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Session;
using SnailApp.AdminApp.Models;
using SnailApp.ViewModels.System.Users;

namespace SnailApp.AdminApp.Controllers
{
    public class AppRoleController : BaseController
    {
        private readonly IAppRoleApiClient _appRoleApiClient;
        private readonly IMenuApiClient _menuApiClient;
        public AppRoleController(IAppRoleApiClient appRoleApiClient, IMenuApiClient menuApiClient)
        {
            _appRoleApiClient = appRoleApiClient;
            _menuApiClient = menuApiClient;
        }

        public async Task<IActionResult> Index()
        {
            AppRoleViewModel model = new AppRoleViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);
            ViewBag.Title = "Role";
            model.PageTitle = "Role";
            model.Breadcrumbs = new List<string>() { "Setting", "Role" };

            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));

            var menuApiClient = await _menuApiClient.GetAll(new ManageMenuPagingRequest()
            {
                LanguageId = languageId
            });

            if (menuApiClient.IsSuccessed)
            {
                model.Menus = menuApiClient.ResultObj;
            }

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

            var request = new ManageAppRolePagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var appRoleApiClient = await _appRoleApiClient.GetManageListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = appRoleApiClient.TotalRecords,
                recordsTotal = appRoleApiClient.TotalRecords,
                data = appRoleApiClient.Items
            });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] AppRoleDeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _appRoleApiClient.DeleteByIds(request);

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
        public async Task<IActionResult> Save([FromBody] AddEditAppRoleRequest<AppRoleRequest> rq)
        {
            ApiResult<string> result = null;

            Guid userGuid = Guid.Parse(HttpContext.Session.GetString(SystemConstants.AppConstants.UserId));

            if (rq != null)
            {
                rq.Data.LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
                if (string.IsNullOrEmpty(rq.Id))
                {
                    rq.Data.CreatedUserId = userGuid;
                    rq.Data.ModifiedUserId = userGuid;
                }
                else
                {
                    rq.Data.ModifiedUserId = userGuid;
                    rq.Data.Id = rq.Id;
                }
                result = await _appRoleApiClient.AddOrUpdateAsync(rq.Data);
            }
            else
            {
                result = new ApiResult<string>()
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

            var request = new ManageAppRolePagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = 1,
                PageSize = 20,
                LanguageId = languageId,
                OrderCol = "Id",
                OrderDir = "desc"
            };

            var appUserStatusApiClient = await _appRoleApiClient.GetManageListPaging(request);
            return Ok(appUserStatusApiClient);
        }
      
    }
}
