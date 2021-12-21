using System;
using System.Linq;
using Snail.ViewModels.Sales.AppUser_CommissionDiscounts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Snail.Application.Sales.AppUser_CommissionDiscounts;
using Snail.ViewModels.Common;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AppUser_CommissionDiscountsController : Controller
    {
        private readonly IAppUser_CommissionDiscountService _appUser_CommissionDiscountService;

        public AppUser_CommissionDiscountsController(IAppUser_CommissionDiscountService appUser_CommissionDiscountService)
        {
            _appUser_CommissionDiscountService = appUser_CommissionDiscountService;
        }

        [HttpGet("getmanagelistpaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageAppUser_CommissionDiscountPagingRequest request)
        {
            var appUser_CommissionDiscounts = await _appUser_CommissionDiscountService.GetManageListPaging(request);
            return Ok(appUser_CommissionDiscounts);
        }
        [HttpGet("getmanagelistdetailpaging")]
        public async Task<IActionResult> GetManageListDetailPaging([FromQuery] ManageAppUser_CommissionDiscountPagingRequest request)
        {
            var appUser_CommissionDiscounts = await _appUser_CommissionDiscountService.GetManageListDetailPaging(request);
            return Ok(appUser_CommissionDiscounts);
        }
        
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] AppUser_CommissionDiscountRequest request)
        {
            var appUser_CommissionDiscount = await _appUser_CommissionDiscountService.GetById(request);
            if (appUser_CommissionDiscount.IsSuccessed)
            {
                if (appUser_CommissionDiscount.ResultObj == null)
                {
                    return BadRequest("Cannot find appUser_CommissionDiscount");
                }
            }

            return Ok(appUser_CommissionDiscount);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] AppUser_CommissionDiscountRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _appUser_CommissionDiscountService.UpdateAsync(request);
            }
            else
            {
                res = await _appUser_CommissionDiscountService.CreateAsync(request);
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
            var result = await _appUser_CommissionDiscountService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
