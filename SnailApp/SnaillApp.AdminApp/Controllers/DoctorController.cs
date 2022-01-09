using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ApiIntegration;
using SnailApp.ViewModels.System.Users;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.System.AppRoles;
using SnailApp.AdminApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Session;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;

namespace SnailApp.AdminApp.Controllers
{
    public class DoctorController : BaseController
    {
        private readonly IUserApiClient _userApiClient;
        private readonly IAppRoleApiClient _appRoleApiClient;
        private readonly IConfiguration _configuration;
        
        public DoctorController(IUserApiClient userApiClient, IAppRoleApiClient appRoleApiClient,
                                    IConfiguration configuration)
        {
            _userApiClient = userApiClient;
            _appRoleApiClient = appRoleApiClient;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            StaffViewModel model = new StaffViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            ViewBag.Title = "Doctor";
            model.Breadcrumbs = new List<string>(){ "Doctor" };
            int languageId = Convert.ToInt32(System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)));
            var appRoleApiClient = await _appRoleApiClient.GetAll(new ManageAppRolePagingRequest(){LanguageId = languageId});

            if (appRoleApiClient.IsSuccessed)
            {
                model.AppRoles = appRoleApiClient.ResultObj.Select(x => new SelectListItem()
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList();
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
            int clinicId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultClinicId));

            var request = new ManageUserPagingRequest()
            {
                Type = (int)ViewModels.Enums.RoleType.DoctorRole,
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                LanguageId = languageId,
                ClinicId = clinicId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var userApiClient = await _userApiClient.GetStaffManageListPaging(request);
            if(userApiClient.TotalRecords > 0)
            {
                foreach (var item in userApiClient.Items)
                {
                    item.Avatar = _configuration[SystemConstants.AppConstants.BaseAddress] + item.Avatar;
                }
            }
        

            return Json(new
            {
                draw = draw,
                recordsFiltered = userApiClient.TotalRecords,
                recordsTotal = userApiClient.TotalRecords,
                data = userApiClient.Items
            });
        }
       
        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] UserDeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _userApiClient.DeleteByIds(request);

            if (!result.IsSuccessed)
            {
                resultMessage = "Lỗi: " + result.Message;
            }

            return Json(new
            {
                isSuccessed = result.IsSuccessed,
                message = resultMessage
            });
        }

        [HttpPost]
        public async Task<IActionResult> SaveProfileDetail([FromForm] UserRequest rq)
        {
            ApiResult<string> result = null;

            string userGuid = HttpContext.Session.GetString(SystemConstants.AppConstants.UserId);
            int clinicId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultClinicId));

            if (rq != null)
            {
                rq.Type = (int)ViewModels.Enums.RoleType.DoctorRole;
                rq.ClinicId = clinicId;

                if (string.IsNullOrEmpty(rq.Id))
                {
                    rq.CreatedUserId = userGuid;
                    rq.ModifiedUserId = userGuid;
                }
                else
                {
                    rq.ModifiedUserId = userGuid;
                    rq.Id = rq.Id;
                }

                result = await _userApiClient.AddOrUpdateStaffProfileDetail(rq);
            }
            else
            {
                result = new ApiResult<string>()
                {
                    IsSuccessed = false,
                    Message = "Not found"
                };
            }

            return Ok(result);
        }
       
        [HttpGet]
        public async Task<IActionResult> DeleteAvatarByUserId(int userId)
        {
            var userApiClient = await _userApiClient.DeleteAvatarByUserIdAsync(userId);

            if (userApiClient.IsSuccessed)
            {
                userApiClient.ResultObj = _configuration[SystemConstants.AppConstants.BaseAddress] + "/" + userApiClient.ResultObj;
            }

            return Ok(userApiClient);
        }

        [HttpGet]
        public async Task<IActionResult> Filter(string textSearch)
        {
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            int clinicId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultClinicId));

            var request = new ManageUserPagingRequest()
            {
                Type = (int)ViewModels.Enums.RoleType.DoctorRole,
                ClinicId = clinicId,
                TextSearch = textSearch,
                PageIndex = 1,
                PageSize = 20,
                LanguageId = languageId,
                OrderCol = "Id",
                OrderDir = "desc"
            };

            var data = await _userApiClient.GetStaffManageListPaging(request);
            return Ok(data);
        }
    }
}
