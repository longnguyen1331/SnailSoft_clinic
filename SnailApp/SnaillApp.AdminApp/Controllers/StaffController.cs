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
    public class StaffController : BaseController
    {
        private readonly IUserApiClient _userApiClient;
        private readonly IAppRoleApiClient _appRoleApiClient;
        private readonly IConfiguration _configuration;
        private readonly IAppUser_CommissionDiscountApiClient _appUser_CommissionDiscountApiClient;
        
        public StaffController(IUserApiClient userApiClient, IAppRoleApiClient appRoleApiClient,
                                    IConfiguration configuration, IAppUser_CommissionDiscountApiClient appUser_CommissionDiscountApiClient)
        {
            _userApiClient = userApiClient;
            _appRoleApiClient = appRoleApiClient;
            _configuration = configuration;
            _appUser_CommissionDiscountApiClient = appUser_CommissionDiscountApiClient;
        }

        public async Task<IActionResult> Index()
        {
            StaffViewModel model = new StaffViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Nhân viên";
            model.Breadcrumbs = new List<string>(){ "Cài đặt", "Nhân viên" };

            int languageId = Convert.ToInt32(System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)));
            var appRoleApiClient = await _appRoleApiClient.GetAll(new ManageAppRolePagingRequest()
            {
                LanguageId = languageId
            });

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

            var request = new ManageUserPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var userApiClient = await _userApiClient.GetStaffManageListPaging(request);

            foreach (var item in userApiClient.Items)
            {
                item.Avatar = _configuration[SystemConstants.AppConstants.BaseAddress] + item.Avatar;
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

            if (rq != null)
            {
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
                    Message = "Không có dữ liệu"
                };
            }

            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> SaveSecurity([FromBody] AddEditUserRequest<UserRequest> rq)
        {
            ApiResult<string> result = null;

            string userGuid = HttpContext.Session.GetString(SystemConstants.AppConstants.UserId);

            if (rq != null)
            {
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
                result = await _userApiClient.AddOrUpdateStaffSecurity(rq.Data);
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

        [HttpGet]
        public async Task<IActionResult> ProfileDetailEdit(string id)
        {
            var model = new StaffViewModel();
            var languageId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Nhân viên";
            model.Breadcrumbs = new List<string>() { "Cài đặt", "Nhân viên" };
            model.FileNoImagePerson = _configuration[SystemConstants.AppConstants.BaseAddress] + _configuration[SystemConstants.AppConstants.FileNoImagePerson];

            if (id != null)
            {
                var userApiClient = await _userApiClient.GetStaffProfileDetailByUserId(new UserRequest
                {
                    LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)),
                    Id = id
                });

                if (userApiClient.IsSuccessed)
                {
                    model.Staff = userApiClient.ResultObj;
                    model.Staff.FullName = (languageId.ToString().Equals(_configuration[SystemConstants.AppConstants.DefaultLanguageId]) ? (model.Staff.LastName + " " + model.Staff.FirstName) : (model.Staff.FirstName + " " + model.Staff.LastName));
                    if (!string.IsNullOrEmpty(model.Staff.Avatar))
                    {
                        model.Staff.Avatar = _configuration[SystemConstants.AppConstants.BaseAddress] + model.Staff.Avatar;
                    }
                }
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> SecurityEdit(string id)
        {
            var model = new StaffViewModel();
            var languageId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Nhân viên";
            model.Breadcrumbs = new List<string>() { "Cài đặt", "Nhân viên" };
            model.FileNoImagePerson = _configuration[SystemConstants.AppConstants.BaseAddress] + _configuration[SystemConstants.AppConstants.FileNoImagePerson];

            if (id != null)
            {
                var userApiClient = await _userApiClient.GetStaffSecurityByUserId(new UserRequest
                {
                    LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)),
                    Id = id
                });

                if (userApiClient.IsSuccessed)
                {
                    model.Staff = userApiClient.ResultObj;
                    model.Staff.FullName = (languageId.ToString().Equals(_configuration[SystemConstants.AppConstants.DefaultLanguageId]) ? (model.Staff.LastName + " " + model.Staff.FirstName) : (model.Staff.FirstName + " " + model.Staff.LastName));
                    if (!string.IsNullOrEmpty(model.Staff.Avatar))
                    {
                        model.Staff.Avatar = _configuration[SystemConstants.AppConstants.BaseAddress] + "/" + model.Staff.Avatar;
                    }
                }
            }

            return View(model);
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
            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManageUserPagingRequest()
            {
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
