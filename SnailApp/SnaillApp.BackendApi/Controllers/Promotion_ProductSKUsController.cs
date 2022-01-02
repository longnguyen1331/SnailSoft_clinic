using System;
using System.Linq;
using SnailApp.ViewModels.Sales.Promotion_ProductSKUs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.Sales.Promotion_ProductSKUs;
using SnailApp.ViewModels.Common;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class Promotion_ProductSKUsController : ControllerBase
    {
        private readonly IPromotion_ProductSKUService _promotion_ProductSKUService;

        public Promotion_ProductSKUsController(IPromotion_ProductSKUService promotion_ProductSKUService)
        {
            _promotion_ProductSKUService = promotion_ProductSKUService;
        }

        [HttpGet("getmanagelistpaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManagePromotion_ProductSKUPagingRequest request)
        {
            var promotion_ProductSKUs = await _promotion_ProductSKUService.GetManageListPaging(request);
            return Ok(promotion_ProductSKUs);
        }
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] Promotion_ProductSKURequest request)
        {
            var promotion_ProductSKU = await _promotion_ProductSKUService.GetById(request);
            if (promotion_ProductSKU.IsSuccessed)
            {
                if (promotion_ProductSKU.ResultObj == null)
                {
                    return BadRequest("Cannot find promotion_ProductSKU");
                }
            }

            return Ok(promotion_ProductSKU);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] Promotion_ProductSKURequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _promotion_ProductSKUService.UpdateAsync(request);
            }
            else
            {
                res = await _promotion_ProductSKUService.CreateAsync(request);
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
            var result = await _promotion_ProductSKUService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
