using System;
using System.Linq;
using SnailApp.ViewModels.System.Statuses.OrderStatus;
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
    public class OrderStatusesController : ControllerBase
    {
        private readonly IOrderStatusService _orderStatusService;
        private readonly IConfiguration _configuration;

        public OrderStatusesController(IOrderStatusService orderStatusService, IConfiguration configuration)
        {
            _orderStatusService = orderStatusService;
            _configuration = configuration;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageOrderStatusPagingRequest request)
        {
            var result = await _orderStatusService.GetManageListPaging(request);
            return Ok(result);
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] ManageOrderStatusPagingRequest request)
        {
            var stores = await _orderStatusService.GetManageListPaging(request);
            return Ok(stores);
        }
        [HttpGet("{orderStatusId}")]
        public async Task<IActionResult> GetById(int orderStatusId, int languageId)
        {
            var result = await _orderStatusService.GetById(orderStatusId, languageId);
            if (result.IsSuccessed)
            {
                if (result.ResultObj == null)
                {
                    return BadRequest("Cannot find orderStatus");
                }
            }            
                    
            return Ok(result);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] OrderStatusRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _orderStatusService.UpdateAsync(request);
            }
            else
            {
                res = await _orderStatusService.CreateAsync(request);
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
            var result = await _orderStatusService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
