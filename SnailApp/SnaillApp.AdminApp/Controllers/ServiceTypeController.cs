using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ApiIntegration;
using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Session;
using SnailApp.ViewModels.System.Users;
using SnailApp.AdminApp.Models;
using SnailApp.ViewModels.Catalog.ServiceTypes;
using Microsoft.Extensions.Configuration;

namespace SnailApp.AdminApp.Controllers
{
    public class ServiceTypeController : BaseController
    {
        private readonly IServiceTypeApiClient _serviceTypeApiClient;
        private readonly IMenuApiClient _menuApiClient;
        private readonly IConfiguration _configuration;
        public ServiceTypeController(IServiceTypeApiClient serviceTypeApiClient, IMenuApiClient menuApiClient,
                                    IConfiguration configuration)
        {
            _serviceTypeApiClient = serviceTypeApiClient;
            _menuApiClient = menuApiClient;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            BaseViewModel model = new BaseViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);
            ViewBag.Title = "Service Type";
            model.Breadcrumbs = new List<string>() { "Services", "Service Type" };
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

            var request = new ManageServiceTypePagingRequest()
            {
                TextSearch = textSearch,
                ClinicId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultClinicId)),
                PageIndex = skip,
                PageSize = pageSize,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var serviceTypeApiClient = await _serviceTypeApiClient.GetManageListPaging(request);


            foreach (var item in serviceTypeApiClient.Items)
            {
                item.Image = _configuration[SystemConstants.AppConstants.BaseAddress] + item.Image;
            }

            return Json(new
            {
                draw = draw,
                recordsFiltered = serviceTypeApiClient.TotalRecords,
                recordsTotal = serviceTypeApiClient.TotalRecords,
                data = serviceTypeApiClient.Items
            });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] DeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _serviceTypeApiClient.DeleteByIds(request);

            if (!result.IsSuccessed)
            {
                resultMessage = "Error";
            }

            return Json(new
            {
                isSuccessed = result.IsSuccessed,
                message = resultMessage
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromForm] ServiceTypeRequest rq)
        {
            ApiResult<int> result = null;

            Guid userGuid = Guid.Parse(HttpContext.Session.GetString(SystemConstants.AppConstants.UserId));

            if (rq != null)
            {
                rq.LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
                rq.ClinicId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultClinicId));
                rq.CreatedUserId = userGuid;
                rq.ModifiedUserId = userGuid;
                result = await _serviceTypeApiClient.AddOrUpdateAsync(rq);
            }
            else
            {
                result = new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = "Not found"
                };
            }

            return Ok(result);
        }

        public async Task<IActionResult> Filter(string textSearch)
        {
            var request = new ManageServiceTypePagingRequest()
            {
                ClinicId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultClinicId)),
                TextSearch = textSearch,
                PageIndex = 1,
                PageSize = 20,
                LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)),
                OrderCol = "Id",
                OrderDir = "desc"
            };

            var data = await _serviceTypeApiClient.GetManageListPaging(request);
            return Ok(data);
        }
    }
}
