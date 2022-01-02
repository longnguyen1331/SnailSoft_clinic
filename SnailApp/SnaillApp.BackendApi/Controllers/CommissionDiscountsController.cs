using System;
using System.Linq;
using SnailApp.ViewModels.Sales.CommissionDiscounts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.Sales.CommissionDiscounts;
using SnailApp.ViewModels.Common;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CommissionDiscountsController : Controller
    {
        private readonly ICommissionDiscountService _commissionDiscountService;

        public CommissionDiscountsController(ICommissionDiscountService commissionDiscountService)
        {
            _commissionDiscountService = commissionDiscountService;
        }

        [HttpGet("getmanagelistpaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageCommissionDiscountPagingRequest request)
        {
            var commissionDiscounts = await _commissionDiscountService.GetManageListPaging(request);
            return Ok(commissionDiscounts);
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] ManageCommissionDiscountPagingRequest request)
        {
            var commissionDiscounts = await _commissionDiscountService.GetAll(request);
            return Ok(commissionDiscounts);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById(CommissionDiscountRequest request)
        {
            var commissionDiscount = await _commissionDiscountService.GetById(request);
            if (commissionDiscount.IsSuccessed)
            {
                if (commissionDiscount.ResultObj == null)
                {
                    return BadRequest("Cannot find commissionDiscount");
                }
            }

            return Ok(commissionDiscount);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] CommissionDiscountRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _commissionDiscountService.UpdateAsync(request);
            }
            else
            {
                res = await _commissionDiscountService.CreateAsync(request);
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
            var result = await _commissionDiscountService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}

