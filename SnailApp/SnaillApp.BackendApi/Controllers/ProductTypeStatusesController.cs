using System;
using System.Linq;
using SnailApp.ViewModels.System.Statuses.ProductTypeStatus;
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
    public class ProductTypeStatusesController : ControllerBase
    {
        private readonly IProductTypeStatusService _productTypeStatusService;
        private readonly IConfiguration _configuration;

        public ProductTypeStatusesController(IProductTypeStatusService productTypeStatusService, IConfiguration configuration)
        {
            _productTypeStatusService = productTypeStatusService;
            _configuration = configuration;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageProductTypeStatusPagingRequest request)
        {
            var result = await _productTypeStatusService.GetManageListPaging(request);
            return Ok(result);
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] ManageProductTypeStatusPagingRequest request)
        {
            var stores = await _productTypeStatusService.GetManageListPaging(request);
            return Ok(stores);
        }
        [HttpGet("{productTypeStatusId}")]
        public async Task<IActionResult> GetById(int productTypeStatusId, int languageId)
        {
            var result = await _productTypeStatusService.GetById(productTypeStatusId, languageId);
            if (result.IsSuccessed)
            {
                if (result.ResultObj == null)
                {
                    return BadRequest("Cannot find productTypeStatus");
                }
            }
            
            return Ok(result);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] ProductTypeStatusRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _productTypeStatusService.UpdateAsync(request);
            }
            else
            {
                res = await _productTypeStatusService.CreateAsync(request);
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
            var result = await _productTypeStatusService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
