using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SnailApp.AdminApp.Models;
using Microsoft.AspNetCore.Authorization;
using SnailApp.Utilities.Constants;
using Microsoft.AspNetCore.Http;
using SnailApp.ViewModels.Accountants.PhieuKeToans;
using SnailApp.ApiIntegration;
using SnailApp.Utilities.Session;
using SnailApp.ViewModels.System.Users;
using SnailApp.ViewModels.Common;
using BHSNetCoreLib.ExcelUtil;

namespace SnailApp.AdminApp.Controllers
{
    public class StockReportController : BaseController
    {
        private readonly IReportWarehouseApiClient _reportStockReportApiClient;

        public StockReportController(
            IReportWarehouseApiClient reportStockReportApiClient
        )
        {
            _reportStockReportApiClient = reportStockReportApiClient;
        }

        public IActionResult Index()
        {
            WarehouseModel model = new WarehouseModel();

            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(
                SystemConstants.AppConstants.CurrentUserRoleSession),
                (ControllerContext.ActionDescriptor).ControllerName,
                (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Tồn kho";
            model.Breadcrumbs = new List<string>() { "Trang chủ", "Báo cáo", "Tồn kho" };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DataTableGetList(int? draw, int? start, int? length, string tDate)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManageReportWarehousePagingRequest()
            {
                ToDate = !string.IsNullOrEmpty(tDate) ? tDate : DateTime.Now.ToString("dd/MM/yyyy"),
                PageIndex = skip,
                PageSize = pageSize,
                StoreId = storeId,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var orderApiClient = await _reportStockReportApiClient.GetReport(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = orderApiClient.TotalRecords,
                recordsTotal = orderApiClient.TotalRecords,
                data = orderApiClient.Items
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
                Name = "Mã HH "
            });

            exportedFields.Add(new BaseDto()
            {
                Code = "Name",
                Name = "Tên HH"
            });


            exportedFields.Add(new BaseDto()
            {
                Code = "QtyInStock",
                Name = "Số lượng"
            });

            exportedFields.Add(new BaseDto()
            {
                Code = "Price",
                Name = "Vốn tồn kho"
            });


            exportedFields.Add(new BaseDto()
            {
                Code = "BuyingPrice",
                Name = "Giá trị tồn"
            });


            foreach (BaseDto item in exportedFields)
            {
                switch (item.Code)
                {
                    case "Price":
                    case "BuyingPrice":
                        dc = new System.Data.DataColumn(item.Name, typeof(float));
                        break;

                    case "QtyInStock":
                        dc = new System.Data.DataColumn(item.Name, typeof(int));
                        break;

                    default:
                        dc = new System.Data.DataColumn(item.Name);
                        break;
                }
                dt.Columns.Add(dc);
            }

            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));
            var request = new ManageReportWarehousePagingRequest()
            {
                ToDate =  DateTime.Now.ToString("dd/MM/yyyy"),
                PageIndex = -1,
                PageSize = 0,
                StoreId = storeId,
            };

            var data = await _reportStockReportApiClient.GetReport(request);

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
                                propertyInfo = typeof(ReportWarehouseDto).GetProperty(exportedField.Code);
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

                    byte[] fileBytes = ExcelExportHelper.ExportExcel(dt, "Kho hàng", false, columnsToTake.ToArray());

                    if (fileBytes == null || !fileBytes.Any())
                    {
                        throw new Exception(String.Format("Không có dữ liệu."));
                    }


                    return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, "KhoHang.xlsx");
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
    }
}