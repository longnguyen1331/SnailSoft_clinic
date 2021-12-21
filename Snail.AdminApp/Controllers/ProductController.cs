using System;
using System.Linq;
using System.Threading.Tasks;
using Snail.AdminApp.Models;
using Snail.ApiIntegration;
using Snail.Utilities.Constants;
using Snail.Utilities.Session;
using Snail.ViewModels.Catalog.Products;
using Snail.ViewModels.System.Users;
using Snail.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Collections.Generic;
using Snail.ViewModels.Catalog.ProductSKUs;
using BarcodeLib;
using System.Drawing;
using QRCoder;
using Snail.ViewModels.System.DocTemplates;
using SelectPdf;

namespace Snail.AdminApp.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductApiClient _productApiClient;
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly IStoreApiClient _storeApiClient;
        private readonly IProductTypeApiClient _productTypeApiClient;
        private readonly IDocTemplateApiClient _docTemplateApiClient;

        public ProductController(IProductApiClient productApiClient,
            IConfiguration configuration,
            IProductTypeApiClient productTypeApiClient,
            IWebHostEnvironment hostEnvironment,
            IStoreApiClient storeApiClient,
            IDocTemplateApiClient docTemplateApiClient
            )
        {
            _hostEnvironment = hostEnvironment;
            _storeApiClient = storeApiClient;
            _docTemplateApiClient = docTemplateApiClient;
            _configuration = configuration;
            _productApiClient = productApiClient;
            _productTypeApiClient = productTypeApiClient;
        }

        public IActionResult Index()
        {
            var model = new ProductViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Hàng hóa";
            model.Breadcrumbs = new List<string>() { "Hàng hóa & dịch vụ", "Hàng hóa" };

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> DataTableGetList(int? draw, int? start, int? length, string textSearch)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManageProductPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                StoreId = storeId,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var data = await _productApiClient.GetManageListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = data.TotalRecords,
                recordsTotal = data.TotalRecords,
                data = data.Items
            });
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ProductTypeAssign(int id)
        {
            var roleAssignRequest = await GetProductTypeAssignRequest(id);
            return View(roleAssignRequest);
        }

        [HttpPost]
        public async Task<IActionResult> ProductTypeAssign(ProductTypeAssignRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _productApiClient.ProductTypeAssign(request.Id, request);

            if (result.IsSuccessed)
            {
                TempData["result"] = "Cập nhật danh mục thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Message);
            var roleAssignRequest = await GetProductTypeAssignRequest(request.Id);

            return View(roleAssignRequest);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id, bool isProduct)
        {

            var languageId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            ProductViewModel model = new ProductViewModel()
            {
                IsProduct = isProduct
            };

            if (id != null)
            {
                model.Product = await _productApiClient.GetProductById(id.Value, languageId);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] AddEditRequest<ProductRequest> rq)
        {
            ApiResult<int> result = null;

            string userGuid = HttpContext.Session.GetString(SystemConstants.AppConstants.UserId);

            if (rq != null)
            {
                rq.Data.LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
                if (rq.Id == null || rq.Id.Value <= 0)
                {
                    rq.Data.CreatedUserId = userGuid;
                    rq.Data.ModifiedUserId = userGuid;
                }
                else
                {
                    rq.Data.ModifiedUserId = userGuid;
                    rq.Data.Id = rq.Id.Value;
                }
                result = await _productApiClient.AddOrUpdateAsync(rq.Data);
            }
            else
            {
                result = new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = "Không có dữ liệu"
                };
            }

            return Ok(result);
        }

        private async Task<ProductTypeAssignRequest> GetProductTypeAssignRequest(int id)
        {
            int languageId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));

            var productObj = await _productApiClient.GetProductById(id, languageId);
            var categories = await _productTypeApiClient.GetAll(languageId);
            var productTypeAssignRequest = new ProductTypeAssignRequest();
            foreach (var role in categories.ResultObj)
            {
                productTypeAssignRequest.ProductTypes.Add(new SelectItem()
                {
                    Id = role.Id.ToString(),
                    Name = role.Name,
                    //Selected = productObj.ProductTypes.Contains(role.Name)
                });
            }
            return productTypeAssignRequest;
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] DeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _productApiClient.DeleteByIds(request);

            if (!result.IsSuccessed)
            {
                resultMessage = "Lỗi";
            }

            return Json(new
            {
                message = resultMessage
            });
        }

        [HttpPost]
        public async Task<IActionResult> UploadImage([FromForm] string fileNameOld, IFormFile upload)
        {
            string path = string.Empty;
            string fileUrl = string.Empty;
            long size = 0;
            var productApiClient = await _productApiClient.UploadFile(upload);

            if (productApiClient.IsSuccessed)
            {
                fileUrl = _configuration[SystemConstants.AppConstants.BaseAddress] + "/" + productApiClient.ResultObj.ImagePath;
                size = productApiClient.ResultObj.FileSize;
            }

            return new JsonResult(
                new
                {
                    uploaded = 1,
                    fileName = upload.FileName,
                    url = fileUrl,
                    size = size
                }
            );
        }


        [HttpPost]
        public async Task<IActionResult> GetSKU_AttributeById([FromBody] AddEditRequest<ProductRequest> rq)
        {
            ApiResult<List<ProductSKU_AttributeValueDto>> result = null;

            string userGuid = HttpContext.Session.GetString(SystemConstants.AppConstants.UserId);
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            try
            {

                result = new ApiResult<List<ProductSKU_AttributeValueDto>>()
                {
                    IsSuccessed = true,
                    Message = "Thành công",
                    ResultObj = await _productApiClient.GetSKU_AttributeById(rq.Id.Value, languageId)
                };
            }
            catch (Exception ex)
            {
                result = new ApiResult<List<ProductSKU_AttributeValueDto>>()
                {
                    IsSuccessed = false,
                    Message = ex.Message,
                    ResultObj = null
                };
            }

            return Ok(result);
        }


        [HttpGet]
        public IActionResult GenerateBarcode(string productSkUCode)
        {

            Barcode barcode = new Barcode();
            Image img = barcode.Encode(TYPE.CODE39, productSkUCode, Color.Black, Color.White, 350, 50);
            var data =  ConvertImageToBytes(img);
            return Ok(data);
        }

        private byte[] ConvertImageToBytes(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                 img.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();    
            }
        }

        [HttpGet]
        public async Task<IActionResult> Filter(string textSearch)
        {
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManageProductPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = 1,
                StoreId = storeId,
                PageSize = 20,
                LanguageId = languageId,
                OrderCol = "Id",
                OrderDir = "desc"
            };

            var data = await _productApiClient.GetManageListPaging(request);
            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> ImportExcel()
        {
            string resultMessage = String.Empty;
            try
            {
                int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
                int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));
                string createdUserId = HttpContext.Session.GetString(SystemConstants.AppConstants.UserId);

                ProductImportRequest request = new ProductImportRequest()
                {
                    File = Request.Form.Files.First(),  
                    LanguageId = languageId,
                    StoreId = storeId,  
                    CreatedUserId  = Guid.Parse(createdUserId)   
                };

                var productApiClient = await _productApiClient.ImportExcel(request);
                return Ok(productApiClient);
            }
            catch (Exception ex)
            {
                resultMessage = ex.Message;
                return Ok(resultMessage);
            }
        }

        [HttpPost]
        public async Task<IActionResult> ImportExcelPrint()
        {
            string resultMessage = String.Empty;
            try
            {
                int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
                int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));
                string createdUserId = HttpContext.Session.GetString(SystemConstants.AppConstants.UserId);

                ProductImportRequest request = new ProductImportRequest()
                {
                    File = Request.Form.Files.First(),
                    LanguageId = languageId,
                    StoreId = storeId,
                    CreatedUserId = Guid.Parse(createdUserId)
                };

                var productApiClient = await _productApiClient.ImportExcelPrint(request);
                return Ok(productApiClient);
            }
            catch (Exception ex)
            {
                resultMessage = ex.Message;
                return Ok(resultMessage);
            }
        }


        public IActionResult Print()
        {
            var model = new ProductViewModel();

            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "In Nhãn QR";
            model.Breadcrumbs = new List<string>() { "Hàng hóa & dịch vụ", "In Nhãn QR" };

            return View(model);
        }


        [HttpPost]
        public async Task<ActionResult> PrintQRCode([FromBody] AddEditRequest<PrintQRCodeRequest> rq)
        {
            rq.Data.Logo = HttpContext.Session.GetString(SystemConstants.AppConstants.Logo);
            rq.Data.StoreName = HttpContext.Session.GetString(SystemConstants.AppConstants.StoreName);
            var link = await _productApiClient.PrintQRCode(rq.Data);
            link.Message = _configuration[SystemConstants.AppConstants.BaseAddress];
            return Ok(link);
        }

        [HttpGet]
        public async Task<ActionResult> DeleteFileQRCode(string link)
        {
           
            return Ok(await _productApiClient.DeleteFileQRCode(link));
        }

        private byte[] ConvertBitmapToBytes(Bitmap bitmap)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}