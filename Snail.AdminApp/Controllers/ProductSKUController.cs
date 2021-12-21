using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BHSNetCoreLib.ExcelUtil;
using Snail.ApiIntegration;
using Snail.ViewModels.Catalog.ProductSKUs;
using Snail.ViewModels.Common;
using Snail.ViewModels.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Snail.Utilities.Constants;
using Snail.AdminApp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Rendering;
using Snail.ViewModels.System.Users;
using Snail.Utilities.Session;

namespace Snail.AdminApp.Controllers
{
    public class ProductSKUController : Controller
    {
        private readonly IProductSKUApiClient _productSKUApiClient;
        private readonly IUserApiClient _userApiClient;
        public ProductSKUController(IProductSKUApiClient productSKUApiClient, IUserApiClient userApiClient)
        {
            _productSKUApiClient = productSKUApiClient;
            _userApiClient = userApiClient;
        }

        public IActionResult Index()
        {
            var model = new ProductSKUViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);
            model.PageTitle = "Khổ giấy";
            model.Breadcrumbs = new List<string>() { "Cài đặt", "Danh mục hệ thống", "Khổ giấy" };

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

            var request = new ManageProductSKUPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var productSKUApiClient = await _productSKUApiClient.GetManageListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = productSKUApiClient.TotalRecords,
                recordsTotal = productSKUApiClient.TotalRecords,
                data = productSKUApiClient.Items
            });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] DeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _productSKUApiClient.DeleteByIds(request);

            if (!result.IsSuccessed)
            {
                resultMessage = "Lỗi";
            }

            return Json(new
            {
                isSuccessed = result.IsSuccessed,
                message = resultMessage
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] AddEditRequest<ProductSKURequest> rq)
        {
            ApiResult<int> result = null;

            string userGuid = HttpContext.Session.GetString(SystemConstants.AppConstants.UserId);

            if (rq != null)
            {
                if (rq.Id == null)
                {
                    rq.Data.CreatedUserId = userGuid;
                    rq.Data.ModifiedUserId = userGuid;
                }
                else
                {
                    rq.Data.ModifiedUserId = userGuid;
                    rq.Data.Id = rq.Id.Value;
                }
                result = await _productSKUApiClient.AddOrUpdateAsync(rq.Data);
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


        [HttpGet]
        public async Task<IActionResult> Filter(string textSearch, string productId)
        {
            var request = new ManageProductSKUPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = 1,
                StoreId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId)),
                LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)),
                PageSize = 20,
                OrderCol = "Id",
                OrderDir = "desc",
                ProductId = (!string.IsNullOrEmpty(productId) ? Convert.ToInt32(productId) : new Nullable<int>())
            };

            var productSKUApiClient = await _productSKUApiClient.GetManageListPaging(request);
            return Ok(productSKUApiClient);
        }


        [HttpGet]
        public async Task<IActionResult> GetByProductId([FromQuery] int productId)
        {
            var request = new ManageProductSKUPagingRequest()
            {
                PageIndex = 1,
                StoreId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId)),
                LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)),
                PageSize = 100,
                OrderCol = "Id",
                OrderDir = "desc",
                ProductId = productId > 0 ? productId : new Nullable<int>()
            };

            var productSKUApiClient = await _productSKUApiClient.GetManageListPaging(request);
            return Ok(productSKUApiClient);
        }
    }
}
