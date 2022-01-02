using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using SnailApp.ApiIntegration;
using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.System.Users;
using SnailApp.ViewModels.System.AppRoles;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;

namespace SnailApp.AdminApp.Controllers
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