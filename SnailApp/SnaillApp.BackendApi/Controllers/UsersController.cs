using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using SnailApp.Application.SystemApplication.Users;
using SnailApp.ViewModels.System.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Sales.AppUserFeedbacks;
using SnailApp.ViewModels.Sales.AppUserHelps;
using BHSNetCoreLib;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        public UsersController(IUserService userService,
                                IConfiguration configuration)
        {
            _userService = userService;
            _configuration = configuration;
        }

        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody]LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _userService.Authencate(request);

            if (string.IsNullOrEmpty(result.ResultObj))
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost("addorupdatestaffsecurity")]
        public async Task<IActionResult> AddOrUpdateStaffSecurity([FromBody] UserRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            request.AppUserTypeCodes = _configuration[SystemConstants.UserConstants.AppUserType_Staff];

            ApiResult<string> res = await _userService.AddOrUpdateSecurityAsync(request);

            if (res.IsSuccessed)
            {
                if (string.IsNullOrEmpty(res.ResultObj))
                {
                    return BadRequest();
                }
            }

            return Ok(res);
        }
        [HttpPost("addorupdatecustomersecurity")]
        public async Task<IActionResult> AddOrUpdateCustomerSecurity([FromBody] UserRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            request.AppUserTypeCodes = _configuration[SystemConstants.UserConstants.AppUserType_Customer];

            ApiResult<string> res = await _userService.AddOrUpdateSecurityAsync(request);

            if (res.IsSuccessed)
            {
                if (string.IsNullOrEmpty(res.ResultObj))
                {
                    return BadRequest();
                }
            }

            return Ok(res);
        }
        [HttpPost("addorupdatesuppliersecurity")]
        public async Task<IActionResult> AddOrUpdateSupplierSecurity([FromBody] UserRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            request.AppUserTypeCodes = _configuration[SystemConstants.UserConstants.AppUserType_Supplier];

            ApiResult<string> res = await _userService.AddOrUpdateSecurityAsync(request);

            if (res.IsSuccessed)
            {
                if (string.IsNullOrEmpty(res.ResultObj))
                {
                    return BadRequest();
                }
            }

            return Ok(res);
        }
        [HttpPost("addorupdatestaffprofiledetail")]
        public async Task<IActionResult> AddOrUpdateStaffProfileDetail([FromForm] UserRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<string> res = await _userService.AddOrUpdateStaffProfileDetailAsync(request);

            if (res.IsSuccessed)
            {
                if (string.IsNullOrEmpty(res.ResultObj))
                {
                    return BadRequest();
                }
            }

            return Ok(res);
        }

        [HttpPost("addorupdatecustomerprofiledetail")]
        public async Task<IActionResult> AddOrUpdateCustomerProfileDetailAsync([FromForm] UserRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<string> res = await _userService.AddOrUpdateCustomerProfileDetailAsync(request);

            if (res.IsSuccessed)
            {
                if (string.IsNullOrEmpty(res.ResultObj))
                {
                    return BadRequest();
                }
            }

            return Ok(res);
        }

        [HttpPost("addorupdatesupplierprofiledetail")]
        public async Task<IActionResult> AddOrUpdateSupplierProfileDetailAsync([FromForm] UserRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<string> res = await _userService.AddOrUpdateSupplierProfileDetailAsync(request);

            if (res.IsSuccessed)
            {
                if (string.IsNullOrEmpty(res.ResultObj))
                {
                    return BadRequest();
                }
            }

            return Ok(res);
        }
        [HttpGet("GetStaffManageListPaging")]
        public async Task<IActionResult> GetStaffManageListPaging([FromQuery]ManageUserPagingRequest request)
        {
            var users = await _userService.GetStaffManageListPaging(request);
            return Ok(users);
        }
        [HttpGet("GetStaffSalaryManageListPaging")]
        public async Task<IActionResult> GetStaffSalaryManageListPaging([FromQuery] ManageUserPagingRequest request)
        {
            var users = await _userService.GetStaffSalaryManageListPaging(request);
            return Ok(users);
        }        

        [HttpGet("GetCustomerManageListPaging")]
        public async Task<IActionResult> GetCustomerManageListPaging([FromQuery] ManageUserPagingRequest request)
        {
            var users = await _userService.GetCustomerManageListPaging(request);
            return Ok(users);
        }

        [HttpGet("GetSupplierManageListPaging")]
        public async Task<IActionResult> GetSupplierManageListPaging([FromQuery] ManageUserPagingRequest request)
        {
            var users = await _userService.GetSupplierManageListPaging(request);
            return Ok(users);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] UserRequest request)
        {
            var user = await _userService.GetById(request); 
            
            return Ok(user);
        }

        [HttpGet("getbyusername")]
        public async Task<IActionResult> GetByUserName([FromQuery] UserRequest request)
        {
            var user = await _userService.GetByUserName(request);
          
            return Ok(user);
        }

        [HttpDelete("{ids}")]
        public async Task<IActionResult> DeleteByIds(string ids)
        {
            var result = await _userService.DeleteByIds(new UserDeleteRequest()
            {
                Ids = ids.Split("|").ToList()
            });

            return Ok(result);
        }

        [HttpGet("getrolesbyuserid")]
        public async Task<IActionResult> GetRolesByUserId([FromQuery] UserRoleRequest request)
        {
            var data = await _userService.GetRolesByUserId(request);

            return Ok(data);
        }
        [HttpGet("getstaffprofiledetailbyuserid")]
        public async Task<IActionResult> GetStaffProfileDetailByUserId([FromQuery] UserRequest request)
        {
            var user = await _userService.GetStaffProfileDetailByUserId(request);
           
            return Ok(user);
        }
        [HttpGet("getcustomerprofiledetailbyuserid")]
        public async Task<IActionResult> GetCustomerProfileDetailByUserId([FromQuery] UserRequest request)
        {
            var user = await _userService.GetCustomerProfileDetailByUserId(request);

            return Ok(user);
        }
        [HttpGet("getsuppliersecuritybyuserid")]
        public async Task<IActionResult> GetSupplierSecurityByUserId([FromQuery] UserRequest request)
        {
            var user = await _userService.GetSupplierSecurityByUserId(request);

            return Ok(user);
        }
        [HttpGet("getstaffsecuritybyuserid")]
        public async Task<IActionResult> GetStaffSecurityByUserId([FromQuery] UserRequest request)
        {
            var user = await _userService.GetStaffSecurityByUserId(request);

            return Ok(user);
        }

        [HttpGet("getcustomersecuritybyuserid")]
        public async Task<IActionResult> GetCustomerSecurityByUserId([FromQuery] UserRequest request)
        {
            var user = await _userService.GetCustomerSecurityByUserId(request);

            return Ok(user);
        }
        [HttpDelete("deleteavatarbyuserid/{userId}")]
        public async Task<IActionResult> DeleteAvatarByUserId(string userId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _userService.DeleteAvatarByUserId(userId);
            if (result.IsSuccessed)
            {
                if (string.IsNullOrEmpty(result.ResultObj))
                {
                    return BadRequest();
                }
            }

            return Ok(result);
        }
        [HttpPost("mobile/customer/register")]
        [AllowAnonymous]
        public async Task<IActionResult> CustomerRegisterFromMobile([FromBody] MobileUserRegisterRequest request)
        {
            string token = string.Empty;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<string> res = await _userService.CustomerRegisterFromMobile(new UserRequest() { 
                FirstName = request.FullName,
                Email = request.Email,
                UserName = request.Email,
                Password = request.Password,
                RegisterDate = request.RegisterDate,
                IsActive = true,
                IsStillInUse = true,
                AppUserTypeCodes = _configuration[SystemConstants.UserConstants.AppUserType_Customer]
            });

            if (res.IsSuccessed)
            {
                if (string.IsNullOrEmpty(res.ResultObj))
                {
                    return BadRequest();
                }

                var userService = await _userService.Authencate(new LoginRequest() {
                    UserName = request.Email,
                    Password = request.Password,
                    RememberMe = true
                });

                token = userService.ResultObj;
            }

            return Ok(new {
                isSuccessed = res.IsSuccessed,
                message = res.Message,
                token = (res.IsSuccessed == true ? token : string.Empty)
            });
        }
        [HttpPost("mobile/login")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginFromMobile([FromBody] MobileUserLoginRequest request)
        {
            string token = string.Empty;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userService = await _userService.Authencate(new LoginRequest()
            {
                UserName = request.Username,
                Password = request.Password,
                RememberMe = true
            });

            if (userService.IsSuccessed)
            {
                if (string.IsNullOrEmpty(userService.ResultObj))
                {
                    return BadRequest();
                }

                token = userService.ResultObj;
            }

            return Ok(new
            {
                isSuccessed = userService.IsSuccessed,
                message = userService.Message,
                token = (userService.IsSuccessed == true ? token : string.Empty)
            });
        }
        [HttpPut("mobile/customer/profile")]
        public async Task<IActionResult> SaveCustomerProfileFromMobile([FromForm] MobileUserProfileRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            request.FirstName = request.FullName;

            var userService = await _userService.SaveCustomerProfileFromMobile(request);

            if (userService.IsSuccessed)
            {
                if (string.IsNullOrEmpty(userService.ResultObj))
                {
                    return BadRequest();
                }
            }

            return Ok();
        }
        [HttpGet("mobile/customer/profile/{id}")]
        public async Task<IActionResult> GetCustomerProfileFromMobile(string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userService = await _userService.GetCustomerProfileFromMobile(id);

            if (userService.IsSuccessed)
            {
                if (userService.ResultObj ==  null)
                {
                    return BadRequest();
                }
            }

            return Ok(userService);
        }
        [HttpPost("mobile/customer/feedback")]
        public async Task<IActionResult> SaveCustomerFeedbackFromMobile([FromBody] MobileAppUserFeedbackRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userService = await _userService.SaveCustomerFeedbackFromMobile(request);

            return Ok(userService);
        }
        [HttpPost("mobile/customer/help")]
        public async Task<IActionResult> SaveCustomerHelpFromMobile([FromBody] MobileAppUserHelpRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userService = await _userService.SaveCustomerHelpFromMobile(request);

            return Ok(userService);
        }
        [HttpPost("mobile/customer/security/pincheck")]
        public async Task<IActionResult> CustomerPinCheckFromMobile([FromBody] MobileUserPinCheckRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userService = await _userService.CustomerPinCheckFromMobile(request);

            return Ok(userService);
        }
        [HttpPost("ImportDataCustomerFromExcelFile")]
        public async Task<IActionResult> ImportDataCustomerFromExcelFile([FromForm] UserRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userService = await _userService.ImportDataCustomerFromExcelFile(request);

            if (userService.IsSuccessed)
            {
                if (userService.ResultObj == null)
                {
                    return BadRequest();
                }
            }

            return Ok(userService);
        }       

    }
}