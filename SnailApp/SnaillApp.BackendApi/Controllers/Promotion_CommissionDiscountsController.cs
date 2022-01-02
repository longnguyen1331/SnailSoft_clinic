using System;
using System.Linq;
using SnailApp.ViewModels.Sales.Promotion_CommissionDiscounts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.Sales.Promotion_CommissionDiscounts;
using SnailApp.ViewModels.Common;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class Promotion_CommissionDiscountsController : ControllerBase
    {
        private readonly IPromotion_CommissionDiscountService _promotion_CommissionDiscountService;

        public Promotion_CommissionDiscountsController(IPromotion_CommissionDiscountService promotion_CommissionDiscountService)
        {
            _promotion_CommissionDiscountService = promotion_CommissionDiscountService;
        }

        [HttpGet("getmanagelistpaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManagePromotion_CommissionDiscountPagingRequest request)
        {
            var promotion_CommissionDiscounts = await _promotion_CommissionDiscountService.GetManageListPaging(request);
            return Ok(promotion_CommissionDiscounts);
        }
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] Promotion_CommissionDiscountRequest request)
        {
            var promotion_CommissionDiscount = await _promotion_CommissionDiscountService.GetById(request);
            if (promotion_CommissionDiscount.IsSuccessed)
            {
                if (promotion_CommissionDiscount.ResultObj == null)
                {
                    return BadRequest("Cannot find promotion_CommissionDiscount");
                }
            }

            return Ok(promotion_CommissionDiscount);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] Promotion_CommissionDiscountRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _promotion_CommissionDiscountService.UpdateAsync(request);
            }
            else
            {
                res = await _promotion_CommissionDiscountService.CreateAsync(request);
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
            var result = await _promotion_CommissionDiscountService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
