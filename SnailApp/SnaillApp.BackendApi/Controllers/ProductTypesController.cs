using System;
using System.Linq;
using SnailApp.ViewModels.Catalog.ProductTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.Catalog.ProductTypes;
using SnailApp.ViewModels.Common;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductTypesController : ControllerBase
    {
        private readonly IProductTypeService _productTypeService;

        public ProductTypesController(IProductTypeService productTypeService)
        {
            _productTypeService = productTypeService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageProductTypePagingRequest request)
        {
            var productTypes = await _productTypeService.GetManageListPaging(request);
            return Ok(productTypes);
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] ManageProductTypePagingRequest request)
        {
            var productTypes = await _productTypeService.GetAll(request);
            return Ok(productTypes);
        }


        [HttpGet("{productTypeId}")]
        public async Task<IActionResult> GetById(int productTypeId, int languageId)
        {
            var productType = await _productTypeService.GetById(productTypeId, languageId);
            if (productType.IsSuccessed)
                if (productType.ResultObj == null)
                    return BadRequest("Cannot find productType");
            return Ok(productType);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] ProductTypeRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _productTypeService.UpdateAsync(request);
            }
            else
            {
                res = await _productTypeService.CreateAsync(request);
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
            var result = await _productTypeService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}