using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Snail.Utilities.Constants;
using Snail.Utilities.Session;
using Snail.ViewModels.System.MenuAppRoles;
using Snail.ViewModels.System.Users;
using Snail.ViewModels.Enums;
using Snail.ViewModels.Common;
using Microsoft.Extensions.Configuration;
using Snail.ApiIntegration;
using Newtonsoft.Json;

namespace Snail.AdminApp.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var actionName = ((Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor)context.ActionDescriptor).ActionName;
            var controllerName = ((Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor)context.ActionDescriptor).ControllerName;

            if (!controllerName.Trim().ToLower().Equals("login")
                && !actionName.Trim().ToLower().Equals("logout"))
            {
                var currentUserRole = HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession);
                var sessions = context.HttpContext.Session.GetString("Token");
                if (sessions == null || currentUserRole == null)
                {
                    context.Result = new RedirectToActionResult("Index", "Login", new { message = "Bạn không được cấp quyền truy cập." });
                }
                else
                {
                    currentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession), controllerName, actionName);

                    if (currentUserRole.IsAllowView == false)
                    {
                        context.Result = new RedirectToActionResult("Index", "Login", new { message = "Bạn không được cấp quyền truy cập."});
                    }
                }
            }

            base.OnActionExecuting(context);
        }
    }
}