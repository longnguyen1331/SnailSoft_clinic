using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BHSNetCoreLib.ExcelUtil;
using SnailApp.ApiIntegration;
using SnailApp.ViewModels.Sales.Promotions;
using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SnailApp.Utilities.Constants;
using SnailApp.AdminApp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Rendering;
using SnailApp.ViewModels.System.Users;
using SnailApp.Utilities.Session;

namespace SnailApp.AdminApp.Controllers
{
    public class PromotionController : Controller
    {
        private readonly IPromotionApiClient _promotionApiClient;
        private readonly IConfiguration _configuration;
        public PromotionController(IPromotionApiClient promotionApiClient, IConfiguration configuration)
        {
            _promotionApiClient = promotionApiClient;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            PromotionViewModel model = new PromotionViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Khuyến mãi";
            model.Breadcrumbs = new List<string>() { "Bán hàng", "Khuyến mãi" };

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

            var request = new ManagePromotionPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var promotionApiClient = await _promotionApiClient.GetManageListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = promotionApiClient.TotalRecords,
                recordsTotal = promotionApiClient.TotalRecords,
                data = promotionApiClient.Items
            });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] DeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _promotionApiClient.DeleteByIds(request);

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

        [HttpGet]
        public async Task<IActionResult> BasicInfoEdit(int? id)
        {
            var model = new PromotionViewModel();
            var languageId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Khuyến mãi";
            model.Breadcrumbs = new List<string>() { "Bán hàng", "Khuyến mãi" };

            model.NoImageAvailable = _configuration[SystemConstants.AppConstants.BaseAddress] + _configuration[SystemConstants.AppConstants.NoImageAvailable];

            if (id != null)
            {
                var promotionApiClient = await _promotionApiClient.GetBasicInfoAsyncById(new PromotionRequest
                {
                    LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)),
                    Id = id
                });

                if (promotionApiClient.IsSuccessed)
                {
                    model.Promotion = promotionApiClient.ResultObj;                   
                }
            }

            return View(model);
        }
        public async Task<IActionResult> CommissionDiscountEdit(int? id)
        {
            var model = new PromotionViewModel();
            var languageId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Khuyến mãi";
            model.Breadcrumbs = new List<string>() { "Bán hàng", "Khuyến mãi" };

            model.NoImageAvailable = _configuration[SystemConstants.AppConstants.BaseAddress] + _configuration[SystemConstants.AppConstants.NoImageAvailable];

            if (id != null)
            {
                var promotionApiClient = await _promotionApiClient.GetBasicInfoAsyncById(new PromotionRequest
                {
                    LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)),
                    Id = id
                });

                if (promotionApiClient.IsSuccessed)
                {
                    model.Promotion = promotionApiClient.ResultObj;
                }
            }

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> ProductSKUEdit(int? id)
        {
            var model = new PromotionViewModel();
            var languageId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Khuyến mãi";
            model.Breadcrumbs = new List<string>() { "Bán hàng", "Khuyến mãi" };

            model.NoImageAvailable = _configuration[SystemConstants.AppConstants.BaseAddress] + _configuration[SystemConstants.AppConstants.NoImageAvailable];

            if (id != null)
            {
                var promotionApiClient = await _promotionApiClient.GetBasicInfoAsyncById(new PromotionRequest
                {
                    LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)),
                    Id = id
                });

                if (promotionApiClient.IsSuccessed)
                {
                    model.Promotion = promotionApiClient.ResultObj;
                }
            }

            return View(model);
        }
        
        [HttpPost]
        public async Task<IActionResult> SaveBasicInfo([FromBody] AddEditRequest<PromotionRequest> rq)
        {
            ApiResult<int> result = null;

            string userGuid = HttpContext.Session.GetString(SystemConstants.AppConstants.UserId);

            if (rq != null)
            {
                rq.Data.LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
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
                result = await _promotionApiClient.AddOrUpdateBasicInfoAsync(rq.Data);
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
    }
}
