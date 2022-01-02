using System;
using System.Linq;
using SnailApp.ViewModels.System.Statuses.PhieuKeToanStatus;
using SnailApp.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.SystemApplication.Statuses;
using SnailApp.ViewModels.Common;
using Microsoft.Extensions.Configuration;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PhieuKeToanStatusesController : ControllerBase
    {
        private readonly IPhieuKeToanStatusService _phieuKeToanStatusService;
        private readonly IConfiguration _configuration;

        public PhieuKeToanStatusesController(IPhieuKeToanStatusService phieuKeToanStatusService, IConfiguration configuration)
        {
            _phieuKeToanStatusService = phieuKeToanStatusService;
            _configuration = configuration;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManagePhieuKeToanStatusPagingRequest request)
        {
            var result = await _phieuKeToanStatusService.GetManageListPaging(request);
            return Ok(result);
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] ManagePhieuKeToanStatusPagingRequest request)
        {
            var result = await _phieuKeToanStatusService.GetManageListPaging(request);
            return Ok(result);
        }
        [HttpGet("{phieuKeToanStatusId}")]
        public async Task<IActionResult> GetById(int phieuKeToanStatusId, int languageId)
        {
            var result = await _phieuKeToanStatusService.GetById(phieuKeToanStatusId, languageId);
            if (result.IsSuccessed)
            {
                if (result.ResultObj == null) 
                {
                    return BadRequest("Cannot find phieuKeToanStatus");
                }                    
            }
                
            return Ok(result);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] PhieuKeToanStatusRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _phieuKeToanStatusService.UpdateAsync(request);
            }
            else
            {
                res = await _phieuKeToanStatusService.CreateAsync(request);
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
            var result = await _phieuKeToanStatusService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
