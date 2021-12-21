using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BHSNetCoreLib.ExcelUtil;
using Snail.ApiIntegration;
using Snail.ViewModels.Accountants.PhieuKeToans;
using Snail.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Snail.Utilities.Constants;
using Snail.Utilities.Session;
using Snail.ViewModels.System.Users;
using Snail.AdminApp.Models;
using Snail.ViewModels.Accountants.PhieuKeToanChiTiets;
using Snail.ViewModels.Catalog.Products;
using Snail.ViewModels.Catalog.ProductSKUs;

namespace Snail.AdminApp.Controllers
{
    public class OrderController : BaseController
    {
        private readonly IPhieuKeToanApiClient _orderApiClient;
        public OrderController(IPhieuKeToanApiClient orderApiClient)
        {
            _orderApiClient = orderApiClient;
        }

        public IActionResult Index()
        {
            OrderViewModel model = new OrderViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Đơn hàng";
            model.Breadcrumbs = new List<string>() { "Tổng quan", "Đơn hàng" };

            return View(model);
        }

        public IActionResult Edit()
        {
            OrderViewModel model = new OrderViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Đặt hàng";
            model.Breadcrumbs = new List<string>() { "Đơn hàng", "Đặ hàng" };

            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            var model = new OrderViewModel();
            var languageId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);
            model.PageTitle = "Đơn hàng";
            model.Breadcrumbs = new List<string>() { "Tổng quan", "Đơn hàng", "Chi tiết" };

            if (id != null)
            {
                var orderApiClient = await _orderApiClient.GetById(id.Value);

                if (orderApiClient.IsSuccessed)
                {
                    model.PhieuKeToan = orderApiClient.ResultObj;
                }
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> GetById([FromBody] AddEditRequest<PhieuKeToanRequest> rq)
        {
            ApiResult<PhieuKeToanDto> result = null;
            try
            {
                result = await _orderApiClient.GetById(rq.Id.Value);
            }
            catch (Exception ex)
            {
                result = new ApiResult<PhieuKeToanDto>()
                {
                    IsSuccessed = false,
                    Message = ex.Message,
                    ResultObj = null
                };
            }
            return Ok(result);
        }



        [HttpPost]
        public async Task<IActionResult> DataTableGetList(int? draw, int? start, int? length, string searchBy, string textSearch, string fromDate, string toDate)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManagePhieuKeToanPagingRequest()
            {
                SearchBy = searchBy,
                FromDate = fromDate,
                ToDate = toDate,
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                StoreId = storeId,
                Type = (int)ViewModels.Enums.LoaiPhieuKeToan.PX,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn: "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var orderApiClient = await _orderApiClient.GetManageListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = orderApiClient.TotalRecords,
                recordsTotal = orderApiClient.TotalRecords,
                data = orderApiClient.Items
            });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] DeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _orderApiClient.DeleteByIds(request);

            if (!result.IsSuccessed)
            {
                resultMessage = "Lỗi";
            }

            return Json(new {
                isSuccessed = result.IsSuccessed,
                message = resultMessage
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] AddEditRequest<PhieuKeToanRequest> rq)
        {
            ApiResult<int> result = null;

            Guid userGuid = Guid.Parse(HttpContext.Session.GetString(SystemConstants.AppConstants.UserId));

            if (rq != null)
            {
                rq.Data.StoreId = Int32.Parse(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));
                rq.Data.Type = (int)ViewModels.Enums.LoaiPhieuKeToan.PX;
                if (rq.Id == null)
                {
                    rq.Data.CreatedUserId = userGuid;
                    rq.Data.ModifiedUserId = userGuid;
                    //rq.Data.SaleStaffId = userGuid;
                }
                else
                {
                    rq.Data.ModifiedUserId = userGuid;
                    rq.Data.Id = rq.Id.Value;                    
                }
                result = await _orderApiClient.AddOrUpdateAsync(rq.Data);
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


        public async Task<FileResult> ExportToExcel()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            System.Data.DataColumn dc;
            List<string> columnsToTake;
            System.Reflection.PropertyInfo propertyInfo;
            List<BaseDto> exportedFields = new List<BaseDto>();

            exportedFields.Add(new BaseDto()
            {
                Code = "Code",
                Name = "Mã"
            });

            exportedFields.Add(new BaseDto()
            {
                Code = "DateString",
                Name = "Ngày"
            });


            exportedFields.Add(new BaseDto()
            {
                Code = "CustomerName",
                Name = "Khách hàng"
            });


            exportedFields.Add(new BaseDto()
            {
                Code = "SaleStaffName",
                Name = "NV bán hàng "
            });

            exportedFields.Add(new BaseDto()
            {
                Code = "TotalMoney",
                Name = "Tổng tiền"
            });


            foreach (BaseDto item in exportedFields)
            {
                switch (item.Code)
                {
                    case "TotalMoney":
                        dc = new System.Data.DataColumn(item.Name, typeof(float));
                        break;

                    case "DateString":
                        dc = new System.Data.DataColumn(item.Name, typeof(DateTime));
                        break;

                    default:
                        dc = new System.Data.DataColumn(item.Name);
                        break;
                }
                dt.Columns.Add(dc);
            }

            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManagePhieuKeToanPagingRequest()
            {
                TextSearch = string.Empty,
                PageIndex = null,
                PageSize = 0,
                StoreId = storeId,
                Type = (int)ViewModels.Enums.LoaiPhieuKeToan.PX,
                LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId))
            };

            var data = await _orderApiClient.GetManageListPaging(request);

            if (data != null)
            {
                
                try
                {
                    columnsToTake = new List<string>();

                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        columnsToTake.Add(dt.Columns[i].ColumnName);
                    }

                    if (data.Items.Count() > 0)
                    {
                        foreach (var item in data.Items)
                        {

                            System.Data.DataRow dataRow = dt.NewRow();
                            foreach (BaseDto exportedField in exportedFields)
                            {
                                propertyInfo = typeof(PhieuKeToanDto).GetProperty(exportedField.Code);
                                dataRow[exportedField.Name] = propertyInfo.GetValue(item, null);
                            }

                            dt.Rows.Add(dataRow);
                        }
                    }
                    else
                    {
                        System.Data.DataRow dataRow = dt.NewRow();
                        dt.Rows.Add(dataRow);
                    }

                    byte[] fileBytes = ExcelExportHelper.ExportExcel(dt, "Đơn hàng", false, columnsToTake.ToArray());

                    if (fileBytes == null || !fileBytes.Any())
                    {
                        throw new Exception(String.Format("Không có dữ liệu."));
                    }


                    return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, "DonHang.xlsx");
                }
                catch (Exception ex)
                {
                    throw new Exception(String.Format("ERROR: " + ex.Message));
                }
            }
            else
            {
                throw new Exception(String.Format("NOT FOUND"));
            }
        }


        [HttpPost]
        public async Task<IActionResult> GetManageListDetailPaging([FromBody] AddEditRequest<PhieuKeToanRequest> rq)
        {
            ApiResult<List<PhieuKeToanChiTietDto>> result = null;

            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));
            try
            {
                var request = new ManagePhieuKeToanPagingRequest()
                {
                    PageIndex = 1,
                    StoreId = storeId,
                    PageSize = -1,
                    PhieuKeToanId = rq.Id.Value,
                    OrderCol = "Id",
                    OrderDir = "desc"
                };
                var data = await _orderApiClient.GetManageListDetailPaging(request);
                result = new ApiResult<List<PhieuKeToanChiTietDto>>()
                {
                    IsSuccessed = true,
                    Message = "Thành công",
                    ResultObj = data.Items
                };
            }
            catch (Exception ex)
            {
                result = new ApiResult<List<PhieuKeToanChiTietDto>>()
                {
                    IsSuccessed = false,
                    Message = ex.Message,
                    ResultObj = null
                };
            }

            return Ok(result);
        }

    }
}
