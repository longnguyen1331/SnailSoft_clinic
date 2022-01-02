using System;
using System.Linq;
using SnailApp.ViewModels.System.Statuses.StoreStatus;
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
    public class StoreStatusesController : ControllerBase
    {
        private readonly IStoreStatusService _storeStatusService;
        private readonly IConfiguration _configuration;

        public StoreStatusesController(IStoreStatusService storeStatusService, IConfiguration configuration)
        {
            _storeStatusService = storeStatusService;
            _configuration = configuration;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageStoreStatusPagingRequest request)
        {
            var result = await _storeStatusService.GetManageListPaging(request);
            return Ok(result);
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] ManageStoreStatusPagingRequest request)
        {
            var stores = await _storeStatusService.GetManageListPaging(request);
            return Ok(stores);
        }
        [HttpGet("{storeStatusId}")]
        public async Task<IActionResult> GetById(int storeStatusId, int languageId)
        {
            var result = await _storeStatusService.GetById(storeStatusId, languageId);
            if (result.IsSuccessed)
            {
                if (result.ResultObj == null)
                {
                    return BadRequest("Cannot find storeStatus");
                }
            }            
                    
            return Ok(result);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] StoreStatusRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _storeStatusService.UpdateAsync(request);
            }
            else
            {
                res = await _storeStatusService.CreateAsync(request);
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
            var result = await _storeStatusService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
