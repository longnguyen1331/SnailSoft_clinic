using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BHSNetCoreLib.ExcelUtil;
using SnailApp.ApiIntegration;
using SnailApp.ViewModels.Accountants.PhieuKeToans;
using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Session;
using SnailApp.ViewModels.System.Users;
using SnailApp.AdminApp.Models;
using SnailApp.ViewModels.Accountants.PhieuKeToanChiTiets;

namespace SnailApp.AdminApp.Controllers
{
    public class SaleReportController : Controller  //BaseController
    {
        private readonly IPhieuKeToanApiClient _saleReportApiClient;
        public SaleReportController(IPhieuKeToanApiClient saleReportApiClient)
        {
            _saleReportApiClient = saleReportApiClient;
        }

        public IActionResult Index()
        {
            SaleReportViewModel model = new SaleReportViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Doanh số";
            model.Breadcrumbs = new List<string>() { "Trang chủ", "Báo cáo", "Doanh số" };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DataTableGetList(int? draw, int? start, int? length, string fDate, string tDate, string textSearch)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["saleReport[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["saleReport[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManagePhieuKeToanPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                FromDate = fDate,
                ToDate = tDate,
                StoreId = storeId,
                Type = (int)ViewModels.Enums.LoaiPhieuKeToan.PX,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn: "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var saleReportApiClient = await _saleReportApiClient.GetManageListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = saleReportApiClient.TotalRecords,
                recordsTotal = saleReportApiClient.TotalRecords,
                data = saleReportApiClient.Items,
                totolMoney = saleReportApiClient.Items.Sum(x=>x.TotalMoney)
            });
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

            var data = await _saleReportApiClient.GetManageListPaging(request);

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
                var data = await _saleReportApiClient.GetManageListDetailPaging(request);
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
