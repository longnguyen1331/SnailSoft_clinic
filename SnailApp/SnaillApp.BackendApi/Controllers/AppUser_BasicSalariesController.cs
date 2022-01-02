using System;
using System.Linq;
using SnailApp.ViewModels.HR.AppUser_BasicSalaries;
using SnailApp.Application.HR.AppUser_BasicSalaries;
using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AppUser_BasicSalariesController : ControllerBase
    {
        private readonly IAppUser_BasicSalaryService _appUser_BasicSalaryService;

        public AppUser_BasicSalariesController(IAppUser_BasicSalaryService appUser_BasicSalaryService)
        {
            _appUser_BasicSalaryService = appUser_BasicSalaryService;
        }

        [HttpGet("getmanagelistpaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageAppUser_BasicSalaryPagingRequest request)
        {
            var appUser_BasicSalarys = await _appUser_BasicSalaryService.GetManageListPaging(request);
            return Ok(appUser_BasicSalarys);
        }
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] AppUser_BasicSalaryRequest request)
        {
            var appUser_BasicSalary = await _appUser_BasicSalaryService.GetById(request);
            if (appUser_BasicSalary.IsSuccessed)
            {
                if (appUser_BasicSalary.ResultObj == null)
                {
                    return BadRequest("Cannot find AppUser_BasicSalary");
                }
            }

            return Ok(appUser_BasicSalary);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] AppUser_BasicSalaryRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _appUser_BasicSalaryService.UpdateAsync(request);
            }
            else
            {
                res = await _appUser_BasicSalaryService.CreateAsync(request);
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
            var result = await _appUser_BasicSalaryService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
