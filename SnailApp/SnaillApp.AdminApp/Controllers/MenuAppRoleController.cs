using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BHSNetCoreLib.ExcelUtil;
using SnailApp.ApiIntegration;
using SnailApp.ViewModels.System.MenuAppRoles;
using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SnailApp.Utilities.Constants;
using SnailApp.AdminApp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SnailApp.AdminApp.Controllers
{
    public class MenuAppRoleController : BaseController
    {
        private readonly IMenuAppRoleApiClient _menuAppRoleApiClient;
        
        public MenuAppRoleController(IMenuAppRoleApiClient menuAppRoleApiClient)
        {
            _menuAppRoleApiClient = menuAppRoleApiClient;
        }
        [HttpGet]
        public async Task<IActionResult> GetByAppRoleId(string appRoleId)
        {
            var request = new ManageMenuAppRolePagingRequest()
            {
                AppRoleId = appRoleId
            };

            var menuAppRoleApiClient = await _menuAppRoleApiClient.GetAll(request);

            return Ok(menuAppRoleApiClient);
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] MenuAppRoleRequest rq)
        {
            ApiResult<int> result = null;

            string userGuid = HttpContext.Session.GetString(SystemConstants.AppConstants.UserId);

            if (rq != null)
            {
                rq.CreatedUserId = userGuid;
                rq.ModifiedUserId = userGuid;
                result = await _menuAppRoleApiClient.AddOrUpdateAsync(rq);
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
    }
}
