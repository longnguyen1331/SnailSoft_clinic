using System;
using System.Linq;
using SnailApp.ViewModels.Catalog.Clinics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.Catalog.Clinics;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.System.User_Clinics;
using SnailApp.Application.SystemApplication.Users;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClinicsController : ControllerBase
    {
        private readonly IClinicService _clinicService;
        private readonly IUser_ClinicService _user_ClinicService;

        public ClinicsController(IClinicService clinicService,
            IUser_ClinicService user_ClinicService
            )
        {
            _clinicService = clinicService;
            _user_ClinicService = user_ClinicService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageClinicPagingRequest request)
        {
            var clinics = await _clinicService.GetManageListPaging(request);
            return Ok(clinics);
        }

        [HttpGet("clinicId")]
        public async Task<IActionResult> GetById(ClinicRequest request)
        {
            var clinic = await _clinicService.GetById(request);
            if (clinic.IsSuccessed)
            {
                if (clinic.ResultObj == null)
                {
                    return BadRequest("Cannot find clinic");
                }
            }
            
            return Ok(clinic);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromForm] ClinicRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id > 0)
            {
                res = await _clinicService.UpdateAsync(request);
            }
            else
            {
                res = await _clinicService.CreateAsync(request);
            }

            if (res.IsSuccessed)
            {
                if (res.ResultObj == 0)
                    return BadRequest();
            }    

            return Ok(res);
        }


        [HttpDelete("{ids}")]
        public async Task<IActionResult> DeleteByIds(string ids)
        {
            var result = await _clinicService.DeleteByIds(new DeleteRequest() { 
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }


        [HttpPost("addusertoclinic")]
        public async Task<IActionResult> AddUserToClinic([FromBody] User_ClinicDto request)
        {
            ApiResult<int> res =  await _user_ClinicService.AddAsync(request);
            if (res.IsSuccessed)
            {
                if (res.ResultObj == 0)
                    return BadRequest();
            }

            return Ok(res);
        }

        [HttpDelete("deleteuserfromclinic/{ids}")]
        public async Task<IActionResult> DeleteUserFromClinic(string ids)
        {
            var result = await _user_ClinicService.DeleteByIds(new User_ClinicDeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }

        [HttpGet("GetUserByClinicIdManageListPaging")]
        public async Task<IActionResult> GetUserByClinicIdManageListPaging([FromQuery] ManageUser_ClinicPagingRequest request)
        {
            var clinics = await _user_ClinicService.GetUserByClinicIdManageListPaging(request);
            return Ok(clinics);
        }
    }
}
