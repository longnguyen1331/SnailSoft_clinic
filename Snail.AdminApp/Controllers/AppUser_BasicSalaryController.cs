using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Snail.ApiIntegration;
using Snail.ViewModels.System.Users;
using Snail.ViewModels.Common;
using Snail.ViewModels.System.AppRoles;
using Snail.ViewModels.HR.AppUser_BasicSalaries;
using Snail.AdminApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Snail.Utilities.Constants;
using Snail.Utilities.Session;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;

namespace Snail.AdminApp.Controllers
{
    public class AppUser_BasicSalaryController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IAppUser_BasicSalaryApiClient _appUser_BasicSalaryApiClient;

        public AppUser_BasicSalaryController(IConfiguration configuration, 
                                                IAppUser_BasicSalaryApiClient appUser_BasicSalaryApiClient)
        {
            _configuration = configuration;
            _appUser_BasicSalaryApiClient = appUser_BasicSalaryApiClient;
        }

        [HttpPost]
        public async Task<IActionResult> DataTableGetList(int? draw, int? start, int? length, string textSearch, string filterByAppUserId)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));

            var userApiClient = await _appUser_BasicSalaryApiClient.GetManageListPaging(new ManageAppUser_BasicSalaryPagingRequest()
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
        public async Task<IActionResult> Save([FromBody] AddEditRequest<AppUser_BasicSalaryRequest> rq)
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
                result = await _appUser_BasicSalaryApiClient.AddOrUpdateAsync(rq.Data);
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
            var result = await _appUser_BasicSalaryApiClient.DeleteByIds(request);

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
    }
}
