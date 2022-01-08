using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using SnailApp.ApiIntegration;
using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.System.Users;
using SnailApp.AdminApp.Models;
using SnailApp.Utilities.Session;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using SnailApp.Application.SystemApplication.Users;
using SnailApp.ViewModels.System.User_Clinics;

namespace SnailApp.AdminApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly IClinicApiClient _clinicApiClient;
        private readonly IUserApiClient _userApiClient;
        private readonly IConfiguration _configuration;
        private readonly IAdminAppUIApiClient _adminAppUIApiClient;

        public LoginController(IUserApiClient userApiClient, 
                                IConfiguration configuration,
                                IAdminAppUIApiClient adminAppUIApiClient,
                                IClinicApiClient clinicApiClient
            )
        {
            _userApiClient = userApiClient;
            _configuration = configuration;
            _adminAppUIApiClient = adminAppUIApiClient;
            _clinicApiClient = clinicApiClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string message)
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var model = new LoginViewModel()
            {
                Logo = string.Empty,
                Message = message
            };

            var adminAppUIApiClient = await _adminAppUIApiClient.GetLoginObjects();
            if (adminAppUIApiClient.IsSuccessed)
            {
                model.Logo = _configuration[SystemConstants.AppConstants.BaseAddress] + adminAppUIApiClient.ResultObj.Logo;
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Message = "Tên truy cập hoặc mật khẩu không hợp lệ.";
                return View(model);
            }               

            var result = await _userApiClient.Authenticate(new LoginRequest() {
                UserName = model.UserName,
                Password = model.Password,
                RememberMe = model.RememberMe
            });


           
            if (!result.IsSuccessed)
            {
                model.Message = "Tên truy cập hoặc mật khẩu không đúng.";
                return View(model);
            }
            else
            {
                if (result.ResultObj == null)
                {
                    model.Message = result.Message;
                    return View(model);
                }
            }



         
            var userPrincipal = this.ValidateToken(result.ResultObj);
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                IsPersistent = false
            };

            int languageId = Convert.ToInt32(_configuration[SystemConstants.AppConstants.DefaultLanguageId]);
            string userId = userPrincipal.Claims.Where(c => c.Type == ClaimTypes.PrimarySid).Select(c => c.Value).SingleOrDefault();
            string username = userPrincipal.Claims.Where(c => c.Type == ClaimTypes.Email).Select(c => c.Value).SingleOrDefault();
            List<User_ClinicDto> clinics = null;
            if (username != "admin@gmail.com")
            {
                clinics = await _clinicApiClient.GetClinicByUser(
                new ViewModels.System.User_Clinics.ManageUser_ClinicPagingRequest() { UserId = Guid.Parse(userId) });
                if (clinics == null || clinics.Count == 0)
                {
                    model.Message = "No clinic management.";
                    return View(model);
                }
            }
            else
            {
                clinics = await _clinicApiClient.GetAll();
            }

            HttpContext.Session.SetString(SystemConstants.AppConstants.DefaultLanguageId, languageId.ToString());
            HttpContext.Session.SetString(SystemConstants.AppConstants.Token, result.ResultObj);
            HttpContext.Session.SetString(SystemConstants.AppConstants.UserId, userId);
            HttpContext.Session.SetString(SystemConstants.AppConstants.DefaultClinicId, clinics[0].ClinicId.ToString());

            var userApiClient = await _userApiClient.GetAllRoleByUserId(new UserRoleRequest() {
                LanguageId = languageId,
                UserId = userId
            });

            if (userApiClient.IsSuccessed)
            {
                HttpContext.Session.SetObject(SystemConstants.AppConstants.CurrentUserRoleSession, userApiClient.ResultObj);
            }

            await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        userPrincipal,
                        authProperties);

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
        private ClaimsPrincipal ValidateToken(string jwtToken)
        {
            IdentityModelEventSource.ShowPII = true;

            SecurityToken validatedToken;
            TokenValidationParameters validationParameters = new TokenValidationParameters();

            validationParameters.ValidateLifetime = true;

            validationParameters.ValidAudience = _configuration["Tokens:Issuer"];
            validationParameters.ValidIssuer = _configuration["Tokens:Issuer"];
            validationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));

            ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(jwtToken, validationParameters, out validatedToken);

            return principal;
        }
    }
}