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
using SnailApp.ViewModels.Catalog.Regions;

namespace SnailApp.AdminApp.Controllers
{
    public class DistrictController : BaseController
    {
        private readonly IRegionApiClient _regionApiClient;
        private readonly IMenuApiClient _menuApiClient;
        public DistrictController(IRegionApiClient regionApiClient, IMenuApiClient menuApiClient)
        {
            _regionApiClient = regionApiClient;
            _menuApiClient = menuApiClient;
        }

        public IActionResult Index()
        {
            BaseViewModel model = new BaseViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);
            ViewBag.Title = "District";
            model.Breadcrumbs = new List<string>() { "Category", "District" };
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

            var request = new ManageRegionPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                Level = 2,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var regionApiClient = await _regionApiClient.GetManageListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = regionApiClient.TotalRecords,
                recordsTotal = regionApiClient.TotalRecords,
                data = regionApiClient.Items
            });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] DeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _regionApiClient.DeleteByIds(request);

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
        public async Task<IActionResult> Save([FromBody] AddEditRequest<RegionRequest> rq)
        {
            ApiResult<int> result = null;

            Guid userGuid = Guid.Parse(HttpContext.Session.GetString(SystemConstants.AppConstants.UserId));

            if (rq != null)
            {
                rq.Data.CreatedUserId = userGuid;
                rq.Data.ModifiedUserId = userGuid;
                rq.Data.Level = 2;
                rq.Data.Id = rq.Id;
                result = await _regionApiClient.AddOrUpdateAsync(rq.Data);
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

        public async Task<IActionResult> Filter(string textSearch, int parentId)
        {
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));

            var request = new ManageRegionPagingRequest()
            {
                ParentId = parentId,
                TextSearch = textSearch,
                PageIndex = 1,
                PageSize = 20,
                Level = 2,
                LanguageId = languageId,
                OrderCol = "Id",
                OrderDir = "desc"
            };

            var appUserStatusApiClient = await _regionApiClient.GetManageListPaging(request);
            return Ok(appUserStatusApiClient);
        }
    }
}
