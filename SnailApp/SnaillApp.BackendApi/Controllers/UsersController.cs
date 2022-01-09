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
        [HttpPost("addorupdatestaff")]
        public async Task<IActionResult> AddOrUpdateStaff([FromForm] UserRequest request)
        {
            ApiResult<string> res = await _userService.AddOrUpdateAsync(request);

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
        public async Task<IActionResult> GetStaffManageListPaging([FromQuery] ManageUserPagingRequest request)
        {
            var user = await _userService.GetStaffManageListPaging(request);

            return Ok(user);
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


        [HttpPost("changepassword")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequest request)
        {
            ApiResult<int> res = await _userService.ChangePasswordAsync(request);
            return Ok(res);
        }
    }
}