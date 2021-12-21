using Snail.Application.Catalog.Products;
using Snail.ViewModels.Catalog.ProductImages;
using Snail.ViewModels.Catalog.Products;
using Snail.ViewModels.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Snail.BackendApi.Controllers
{
    //api/products
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(
            IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] ManageProductPagingRequest request)
        {
            var products = await _productService.GetManageListPaging(request);
            return Ok(products);
        }

        [HttpGet("GetAttributeById")]
        public async Task<IActionResult> GetSKU_AttributeById([FromQuery] int productId, int languageId)
        {
            var products = await _productService.GetSKU_AttributeById(productId, languageId);
            return Ok(products);
        }

        [HttpGet("{productId}/{languageId}")]
        public async Task<IActionResult> GetById(int productId, int languageId)
        {
            var product = await _productService.GetById(productId, languageId);
            if (product == null)
                return BadRequest("Cannot find product");
            return Ok(product);
        }

        [HttpDelete("{ids}")]
        public async Task<IActionResult> DeleteByIds(string ids)
        {
            var result = await _productService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] ProductRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            ApiResult<int> res = null;
            if (request.Id != null && request.Id.Value > 0)
            {
                res = await _productService.UpdateAsync(request);
            }
            else
            {
                res = await _productService.CreateAsync(request);
            }

            if (res.IsSuccessed)
            {
                if (res.ResultObj == 0)
                    return BadRequest();
            }

            return Ok(res);
        }

        


        [HttpGet("DeleteFileQRCode")]
        public async Task<bool> DeleteFileQRCode(string link)
        {
            var result = await _productService.DeleteFileQRCode(link);

            return result;
        }
        [HttpPost("uploadfile")]
        public async Task<IActionResult> UploadFile([FromForm] IFormFile uploadFile)
        {
            var result = await _productService.UploadFile(uploadFile);

            return Ok(result);
        }


        [HttpPost("PrintQRCode")]
        public async Task<IActionResult> PrintQRCode([FromBody] PrintQRCodeRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                ApiResult<string> res = null;
                res = await _productService.PrintQRCode(request);


                return Ok(res);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }



        [HttpPost("importexcel")]
        public async Task<IActionResult> ImportExcel([FromForm] ProductImportRequest request)
        {
            var result = await _productService.ImportExcel(request);

            return Ok(result);
        }

        [HttpPost("importexcelprint")]
        public async Task<IActionResult> ImportExcelPrint([FromForm] ProductImportRequest request)
        {
            var result = await _productService.ImportExcelPrint(request);

            return Ok(result);
        }
    }
}