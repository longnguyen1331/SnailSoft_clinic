using System;
using System.Linq;
using SnailApp.ViewModels.Sales.Carts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.Sales.Carts;
using SnailApp.ViewModels.Common;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CartsController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartsController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageCartPagingRequest request)
        {
            var carts = await _cartService.GetManageListPaging(request);
            return Ok(carts);
        }

        [HttpGet("{cartId}")]
        public async Task<IActionResult> GetById(int cartId)
        {
            var cart = await _cartService.GetById(cartId);
            if (cart.IsSuccessed)
                if (cart.ResultObj == null)
                    return BadRequest("Cannot find cart");
            return Ok(cart);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] CartRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _cartService.UpdateAsync(request);

            }
            else
            {
                res = await _cartService.CreateAsync(request);
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
            var result = await _cartService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
