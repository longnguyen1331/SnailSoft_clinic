using System;
using System.Linq;
using Snail.ViewModels.Catalog.ProductSKUs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Snail.Application.Catalog.ProductSKUs;
using Snail.ViewModels.Common;
using Snail.ViewModels.Catalog.Products;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductSKUsController : ControllerBase
    {
        private readonly IProductSKUService _productSKUService;
        public ProductSKUsController(IProductSKUService productSKUService)
        {
            _productSKUService = productSKUService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageProductSKUPagingRequest request)
        {
            var productSKUs = await _productSKUService.GetManageListPaging(request);
            return Ok(productSKUs);
        }

        [HttpGet("{productSKUId}")]
        public async Task<IActionResult> GetById(int productSKUId)
        {
            var productSKU = await _productSKUService.GetById(productSKUId);
            if (productSKU.IsSuccessed)
                if (productSKU.ResultObj == null)
                    return BadRequest("Cannot find productSKU");
            return Ok(productSKU);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] ProductSKURequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _productSKUService.UpdateAsync(request);
            }
            else
            {
                res = await _productSKUService.CreateAsync(request);
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
            var result = await _productSKUService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }



        
    }
}
