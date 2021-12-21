﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BHSNetCoreLib.ExcelUtil;
using Snail.ApiIntegration;
using Snail.ViewModels.Accountants.PhieuKeToans;
using Snail.ViewModels.Common;
using Snail.ViewModels.System.Statuses.PhieuKeToanStatus;
using Snail.ViewModels.System.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Snail.Utilities.Constants;
using Snail.Utilities.Session;
using Snail.AdminApp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Snail.AdminApp.Controllers
{
    public class ReceiptController : BaseController
    {
        private readonly IPhieuKeToanApiClient _receiptApiClient;
        private readonly IPhieuKeToanStatusApiClient _receiptStatusApiClient;
        public ReceiptController(IPhieuKeToanApiClient receiptApiClient, IPhieuKeToanStatusApiClient receiptStatusApiClient)
        {
            _receiptApiClient = receiptApiClient;
            _receiptStatusApiClient = receiptStatusApiClient;
        }

        public IActionResult Index()
        {
            var model = new ReceiptViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Thu";
            model.Breadcrumbs = new List<string>() { "Tiền bạc", "Thu" };

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
            int receiptId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManagePhieuKeToanPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                StoreId = receiptId,
                Type = (int)ViewModels.Enums.LoaiPhieuKeToan.PT,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn: "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var receiptApiClient = await _receiptApiClient.GetManageListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = receiptApiClient.TotalRecords,
                recordsTotal = receiptApiClient.TotalRecords,
                data = receiptApiClient.Items
            });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] DeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _receiptApiClient.DeleteByIds(request);

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
                rq.Data.Type = (int)ViewModels.Enums.LoaiPhieuKeToan.PT;
                if (rq.Id == null)
                {
                    rq.Data.CreatedUserId = userGuid;
                    rq.Data.ModifiedUserId = userGuid;
                    rq.Data.SaleStaffId = userGuid;
                }
                else
                {
                    rq.Data.ModifiedUserId = userGuid;
                    rq.Data.Id = rq.Id.Value;                    
                }
                result = await _receiptApiClient.AddOrUpdateAsync(rq.Data);
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

            int receiptId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManagePhieuKeToanPagingRequest()
            {
                TextSearch = string.Empty,
                PageIndex = null,
                PageSize = 0,
                StoreId = receiptId,
                Type = (int)ViewModels.Enums.LoaiPhieuKeToan.PT,
                LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId))
            };

            var data = await _receiptApiClient.GetManageListPaging(request);

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

                    byte[] fileBytes = ExcelExportHelper.ExportExcel(dt, "Thu", false, columnsToTake.ToArray());

                    if (fileBytes == null || !fileBytes.Any())
                    {
                        throw new Exception(String.Format("Không có dữ liệu."));
                    }


                    return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, "Thu.xlsx");
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
