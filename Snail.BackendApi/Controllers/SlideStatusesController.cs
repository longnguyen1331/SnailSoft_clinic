using System;
using System.Linq;
using Snail.ViewModels.System.Statuses.SlideStatus;
using Snail.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Snail.Application.SystemApplication.Statuses;
using Snail.ViewModels.Common;
using Microsoft.Extensions.Configuration;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SlideStatusesController : ControllerBase
    {
        private readonly ISlideStatusService _slideStatusService;
        private readonly IConfiguration _configuration;

        public SlideStatusesController(ISlideStatusService slideStatusService, IConfiguration configuration)
        {
            _slideStatusService = slideStatusService;
            _configuration = configuration;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageSlideStatusPagingRequest request)
        {
            var result = await _slideStatusService.GetManageListPaging(request);
            return Ok(result);
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] ManageSlideStatusPagingRequest request)
        {
            var stores = await _slideStatusService.GetManageListPaging(request);
            return Ok(stores);
        }
        [HttpGet("{slideStatusId}")]
        public async Task<IActionResult> GetById(int slideStatusId, int languageId)
        {
            var result = await _slideStatusService.GetById(slideStatusId, languageId);
            if (result.IsSuccessed)
            {
                if (result.ResultObj == null)
                {
                    return BadRequest("Cannot find slideStatus");
                }                    
            }
            
            return Ok(result);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] SlideStatusRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _slideStatusService.UpdateAsync(request);
            }
            else
            {
                res = await _slideStatusService.CreateAsync(request);
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
            var result = await _slideStatusService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
