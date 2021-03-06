using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ApiIntegration;
using SnailApp.ViewModels.Catalog.Clinics;
using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SnailApp.Utilities.Constants;
using SnailApp.AdminApp.Models;
using SnailApp.ViewModels.System.Users;
using SnailApp.Utilities.Session;
using SnailApp.ViewModels.System.User_Clinics;
using Microsoft.Extensions.Configuration;

namespace SnailApp.AdminApp.Controllers
{
    public class ClinicController : BaseController
    {
        private readonly IClinicApiClient _clinicApiClient;
        private readonly IUserApiClient _userApiClient;
        private readonly IConfiguration _configuration;
        public ClinicController(IClinicApiClient clinicApiClient, 
                                IUserApiClient userApiClient,
                                    IConfiguration configuration)
        {
            _clinicApiClient = clinicApiClient;
            _configuration = configuration;
            _userApiClient = userApiClient;
        }

        public IActionResult Index()
        {
            ClinicViewModel model = new ClinicViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>
                (SystemConstants.AppConstants.CurrentUserRoleSession),
                (ControllerContext.ActionDescriptor).ControllerName,
                (ControllerContext.ActionDescriptor).ActionName);

            ViewBag.Title = "Clinic management";
            model.PageTitle = "Clinic management";
            model.Breadcrumbs = new List<string>() { "Config", "Clinic management" };
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

            var request = new ManageClinicPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var clinicApiClient = await _clinicApiClient.GetManageListPaging(request);


            foreach (var item in clinicApiClient.Items)
            {
                item.Logo = _configuration[SystemConstants.AppConstants.BaseAddress] + item.Logo;
            }

            return Json(new
            {
                draw = draw,
                recordsFiltered = clinicApiClient.TotalRecords,
                recordsTotal = clinicApiClient.TotalRecords,
                data = clinicApiClient.Items
            });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] DeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _clinicApiClient.DeleteByIds(request);

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
        public async Task<IActionResult> Save([FromForm] ClinicRequest rq)
        {
            ApiResult<int> result = null;
            Guid userGuid = Guid.Parse(HttpContext.Session.GetString(SystemConstants.AppConstants.UserId));

            if (rq != null)
            {
                rq.CreatedUserId = userGuid;
                rq.ModifiedUserId = userGuid;

                result = await _clinicApiClient.AddOrUpdateAsync(rq);
            }
            else
            {
                result = new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = "Not found data"
                };
            }

            return Ok(result);
        }





        [HttpPost]
        public async Task<IActionResult> DataTableUserClinicGetList(int? draw, int? start, int? length, int clinicId)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;

            var request = new ManageUser_ClinicPagingRequest()
            {
                ClinicId = clinicId,
                PageIndex = skip,
                PageSize = pageSize,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var clinicApiClient = await _clinicApiClient.GetUserByClinicIdManageListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = clinicApiClient.TotalRecords,
                recordsTotal = clinicApiClient.TotalRecords,
                data = clinicApiClient.Items
            });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUserByIds([FromBody] User_ClinicDeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _clinicApiClient.DeleteUserFromClinic(request);

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
        public async Task<IActionResult> AddUserToClinic([FromBody] User_ClinicDto rq)
        {
            ApiResult<int> result = null;
            Guid userGuid = Guid.Parse(HttpContext.Session.GetString(SystemConstants.AppConstants.UserId));

            if (rq != null && rq.ClinicId  > 0)
            {
                rq.CreatedUserId = userGuid;
                rq.ModifiedUserId = userGuid;

                result = await _clinicApiClient.AddUserToClinic(rq);
            }
            else
            {
                result = new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = "Not found data"
                };
            }

            return Ok(result);
        }
    }
}
