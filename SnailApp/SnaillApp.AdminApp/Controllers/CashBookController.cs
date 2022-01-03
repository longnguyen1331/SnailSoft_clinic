﻿using System;
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

namespace SnailApp.AdminApp.Controllers
{
    public class CashBookController : BaseController
    {
        private readonly IPhieuKeToanApiClient _cashBookApiClient;
        public CashBookController(IPhieuKeToanApiClient cashBookApiClient)
        {
            _cashBookApiClient = cashBookApiClient;
        }

        public IActionResult Index()
        {
            BaseViewModel model = new BaseViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Sổ quỹ";
            model.Breadcrumbs = new List<string>() { "Tiền bạc", "Sổ quỹ", "Loại người sử dụng" };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DataTableGetList(int? draw, int? start, int? length, string textSearch, string fDate, string tDate)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManagePhieuKeToanPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                StoreId = storeId,
                FromDate = fDate,
                ToDate = tDate,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn: "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var cashBookApiClient = await _cashBookApiClient.GetManageListCashBookPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = cashBookApiClient.TotalRecords,
                recordsTotal = cashBookApiClient.TotalRecords,
                data = cashBookApiClient.Items
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

            int cashBookId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManagePhieuKeToanPagingRequest()
            {
                TextSearch = string.Empty,
                PageIndex = null,
                PageSize = 0,
                StoreId = cashBookId,
                FromDate = string.Empty,
                ToDate = string.Empty,
                LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId))
            };

            var data = await _cashBookApiClient.GetManageListCashBookPaging(request);

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

                    byte[] fileBytes = ExcelExportHelper.ExportExcel(dt, "Sổ quỹ", false, columnsToTake.ToArray());

                    if (fileBytes == null || !fileBytes.Any())
                    {
                        throw new Exception(String.Format("Không có dữ liệu."));
                    }


                    return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, "SoQuy.xlsx");
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