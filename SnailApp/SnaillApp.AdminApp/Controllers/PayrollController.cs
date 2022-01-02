using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BHSNetCoreLib.ExcelUtil;
using SnailApp.ApiIntegration;
using SnailApp.ViewModels.HR.Payrolls;
using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SnailApp.Utilities.Constants;
using SnailApp.AdminApp.Models;
using SnailApp.ViewModels.System.Users;
using SnailApp.Utilities.Session;

namespace SnailApp.AdminApp.Controllers
{
    public class PayrollController : Controller
    {
        private readonly IPayrollApiClient _payrollApiClient;

        public PayrollController(IPayrollApiClient payrollApiClient)
        {
            _payrollApiClient = payrollApiClient;
        }

        public IActionResult Index()
        {
            PayrollViewModel model = new PayrollViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Bảng lương";
            model.Breadcrumbs = new List<string>() { "Nhân viên", "Bảng lương" };

            return View(model);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            var model = new PayrollViewModel();
            var languageId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Bảng lương";
            model.Breadcrumbs = new List<string>() { "Nhân viên", "Bảng lương" };

            if (id != null)
            {
                var payrollApiClient = await _payrollApiClient.GetById(new PayrollRequest
                {
                    LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)),
                    Id = id
                });

                if (payrollApiClient.IsSuccessed)
                {
                    model.Payroll = payrollApiClient.ResultObj;
                }
            }

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

            var request = new ManagePayrollPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var payrollApiClient = await _payrollApiClient.GetManageListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = payrollApiClient.TotalRecords,
                recordsTotal = payrollApiClient.TotalRecords,
                data = payrollApiClient.Items
            });
        }
        [HttpPost]
        public async Task<IActionResult> CalculatePayroll([FromBody] PayrollRequest request)
        {
            var payrollApiClient = await _payrollApiClient.CalculatePayroll(request);

            return Json(new
            {
                isSuccessed = payrollApiClient.IsSuccessed,
                message = payrollApiClient.Message
            });
        }
        
       [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] DeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _payrollApiClient.DeleteByIds(request);

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
        public async Task<IActionResult> Save([FromBody] AddEditRequest<PayrollRequest> rq)
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
                result = await _payrollApiClient.AddOrUpdateAsync(rq.Data);
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
                Code = "Name",
                Name = "Tên"
            });


            exportedFields.Add(new BaseDto()
            {
                Code = "Address",
                Name = "Địa chỉ"
            });


            exportedFields.Add(new BaseDto()
            {
                Code = "Email",
                Name = "Email "
            });

            exportedFields.Add(new BaseDto()
            {
                Code = "Phone",
                Name = "SĐT"
            });


            var request = new ManagePayrollPagingRequest()
            {
                TextSearch = string.Empty,
                PageIndex = null,
                PageSize = 0,
                LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId))
            };

            foreach (BaseDto item in exportedFields)
            {
                dc = new System.Data.DataColumn(item.Name);
                dt.Columns.Add(dc);
            }

            var data = await _payrollApiClient.GetManageListPaging(request);

            if (data != null)
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
                            propertyInfo = typeof(PayrollDto).GetProperty(exportedField.Code);
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

                try
                {
                    byte[] fileBytes = ExcelExportHelper.ExportExcel(dt, "Cửa hàng", false, columnsToTake.ToArray());

                    if (fileBytes == null || !fileBytes.Any())
                    {
                        throw new Exception(String.Format("Không có dữ liệu."));
                    }


                    return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, "CuaHang.xlsx");
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
