using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Snail.ApiIntegration;
using Snail.Utilities.Constants;
using Snail.ViewModels.Common;
using Snail.ViewModels.System.Users;
using Snail.ViewModels.System.AppRoles;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;

namespace Snail.AdminApp.Controllers
{
    public class UserController : BaseController
    {
        public UserController(IUserApiClient userApiClient,
            IAppRoleApiClient roleApiClient,
            IConfiguration configuration)
        {
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("Token");
            return RedirectToAction("Index", "Login");
        }
    }
}