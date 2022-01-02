using System;
using System.Linq;
using SnailApp.ViewModels.HR.BasicSalaries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.HR.BasicSalaries;
using SnailApp.ViewModels.Common;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BasicSalariesController : ControllerBase
    {
        private readonly IBasicSalaryService _basicSalaryService;

        public BasicSalariesController(IBasicSalaryService basicSalaryService)
        {
            _basicSalaryService = basicSalaryService;
        }

        [HttpGet("getmanagelistpaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageBasicSalaryPagingRequest request)
        {
            var basicSalarys = await _basicSalaryService.GetManageListPaging(request);
            return Ok(basicSalarys);
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] ManageBasicSalaryPagingRequest request)
        {
            var basicSalarys = await _basicSalaryService.GetAll(request);
            return Ok(basicSalarys);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById(BasicSalaryRequest request)
        {
            var basicSalary = await _basicSalaryService.GetById(request);
            if (basicSalary.IsSuccessed)
            {
                if (basicSalary.ResultObj == null)
                {
                    return BadRequest("Cannot find basicSalary");
                }
            }

            return Ok(basicSalary);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] BasicSalaryRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _basicSalaryService.UpdateAsync(request);
            }
            else
            {
                res = await _basicSalaryService.CreateAsync(request);
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
            var result = await _basicSalaryService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
