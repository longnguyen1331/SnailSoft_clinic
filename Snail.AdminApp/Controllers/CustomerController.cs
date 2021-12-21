using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BHSNetCoreLib.ExcelUtil;
using Snail.ApiIntegration;
using Snail.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Snail.Utilities.Constants;
using Snail.Utilities.Session;
using Snail.AdminApp.Models;
using Snail.ViewModels.System.Users;
using Snail.ViewModels.Accountants.PhieuKeToans;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace Snail.AdminApp.Controllers
{
    public class CustomerController : BaseController
    {
        private readonly IUserApiClient _customerApiClient;
        private readonly IPhieuKeToanApiClient _phieuKeToanApiClient;
        private readonly IConfiguration _configuration;
        public CustomerController(IUserApiClient customerApiClient,
            IPhieuKeToanApiClient phieuKeToanApiClient,
            IConfiguration configuration
)
{
            _configuration = configuration;
            _customerApiClient = customerApiClient;
            _phieuKeToanApiClient = phieuKeToanApiClient;
        }

        public IActionResult Index()
        {
            CustomerViewModel model = new CustomerViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<ViewModels.System.Users.UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Khách hàng";
            model.Breadcrumbs = new List<string>() { "Khách hàng", "Khách hàng" };

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> SecurityEdit(string id)
        {
            var model = new CustomerViewModel();
            var languageId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Khách hàng";
            model.Breadcrumbs = new List<string>() { "Khách hàng", "Khách hàng" };
            
            if (id != null)
            {
                var customerApiClient = await _customerApiClient.GetCustomerSecurityByUserId(new UserRequest
                {
                    LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)),
                    Id = id
                });

                if (customerApiClient.IsSuccessed)
                {
                    model.Customer = customerApiClient.ResultObj;
                    model.Customer.FullName = (languageId.ToString().Equals(_configuration[SystemConstants.AppConstants.DefaultLanguageId]) ? (model.Customer.LastName + " " + model.Customer.FirstName) : (model.Customer.FirstName + " " + model.Customer.LastName));
                    if (!string.IsNullOrEmpty(model.Customer.Avatar))
                    {
                        model.Customer.Avatar = _configuration[SystemConstants.AppConstants.BaseAddress] + "/" + model.Customer.Avatar;
                    }
                }
            }

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> ProfileDetailEdit(string id)
        {
            var model = new CustomerViewModel();
            var languageId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Khách hàng";
            model.Breadcrumbs = new List<string>() { "Khách hàng", "Khách hàng" };
            model.FileNoImagePerson = _configuration[SystemConstants.AppConstants.BaseAddress] + _configuration[SystemConstants.AppConstants.FileNoImagePerson];

            if (id != null)
            {
                var userApiClient = await _customerApiClient.GetCustomerProfileDetailByUserId(new UserRequest
                {
                    LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)),
                    Id = id
                });

                if (userApiClient.IsSuccessed)
                {
                    model.Customer = userApiClient.ResultObj;
                    model.Customer.FullName = (languageId.ToString().Equals(_configuration[SystemConstants.AppConstants.DefaultLanguageId]) ? (model.Customer.LastName + " " + model.Customer.FirstName) : (model.Customer.FirstName + " " + model.Customer.LastName));
                    if (!string.IsNullOrEmpty(model.Customer.Avatar))
                    {
                        model.Customer.Avatar = _configuration[SystemConstants.AppConstants.BaseAddress] + model.Customer.Avatar;
                    }
                }
            }

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> OrderEdit(string id)
        {
            var model = new CustomerViewModel();
            var languageId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Khách hàng";
            model.Breadcrumbs = new List<string>() { "Khách hàng", "Khách hàng" };
            model.FileNoImagePerson = _configuration[SystemConstants.AppConstants.BaseAddress] + _configuration[SystemConstants.AppConstants.FileNoImagePerson];

            if (id != null)
            {
                var userApiClient = await _customerApiClient.GetStaffProfileDetailByUserId(new UserRequest
                {
                    LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)),
                    Id = id
                });

                if (userApiClient.IsSuccessed)
                {
                    model.Customer = userApiClient.ResultObj;
                    model.Customer.FullName = (languageId.ToString().Equals(_configuration[SystemConstants.AppConstants.DefaultLanguageId]) ? (model.Customer.LastName + " " + model.Customer.FirstName) : (model.Customer.FirstName + " " + model.Customer.LastName));
                    if (!string.IsNullOrEmpty(model.Customer.Avatar))
                    {
                        model.Customer.Avatar = _configuration[SystemConstants.AppConstants.BaseAddress] + model.Customer.Avatar;
                    }
                }
            }

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> BoughtProductEdit(string id)
        {
            var model = new CustomerViewModel();
            var languageId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Khách hàng";
            model.Breadcrumbs = new List<string>() { "Khách hàng", "Khách hàng" };
            model.FileNoImagePerson = _configuration[SystemConstants.AppConstants.BaseAddress] + _configuration[SystemConstants.AppConstants.FileNoImagePerson];

            if (id != null)
            {
                var userApiClient = await _customerApiClient.GetStaffProfileDetailByUserId(new UserRequest
                {
                    LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)),
                    Id = id
                });

                if (userApiClient.IsSuccessed)
                {
                    model.Customer = userApiClient.ResultObj;
                    model.Customer.FullName = (languageId.ToString().Equals(_configuration[SystemConstants.AppConstants.DefaultLanguageId]) ? (model.Customer.LastName + " " + model.Customer.FirstName) : (model.Customer.FirstName + " " + model.Customer.LastName));
                    if (!string.IsNullOrEmpty(model.Customer.Avatar))
                    {
                        model.Customer.Avatar = _configuration[SystemConstants.AppConstants.BaseAddress] + model.Customer.Avatar;
                    }
                }
            }

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> ProductReturnEdit(string id)
        {
            var model = new CustomerViewModel();
            var languageId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Khách hàng";
            model.Breadcrumbs = new List<string>() { "Khách hàng", "Khách hàng" };
            model.FileNoImagePerson = _configuration[SystemConstants.AppConstants.BaseAddress] + _configuration[SystemConstants.AppConstants.FileNoImagePerson];

            if (id != null)
            {
                var userApiClient = await _customerApiClient.GetStaffProfileDetailByUserId(new UserRequest
                {
                    LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)),
                    Id = id
                });

                if (userApiClient.IsSuccessed)
                {
                    model.Customer = userApiClient.ResultObj;
                    model.Customer.FullName = (languageId.ToString().Equals(_configuration[SystemConstants.AppConstants.DefaultLanguageId]) ? (model.Customer.LastName + " " + model.Customer.FirstName) : (model.Customer.FirstName + " " + model.Customer.LastName));
                    if (!string.IsNullOrEmpty(model.Customer.Avatar))
                    {
                        model.Customer.Avatar = _configuration[SystemConstants.AppConstants.BaseAddress] + model.Customer.Avatar;
                    }
                }
            }

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> CashBookEdit(string id)
        {
            var model = new CustomerViewModel();
            var languageId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Khách hàng";
            model.Breadcrumbs = new List<string>() { "Khách hàng", "Khách hàng" };
            model.FileNoImagePerson = _configuration[SystemConstants.AppConstants.BaseAddress] + _configuration[SystemConstants.AppConstants.FileNoImagePerson];

            if (id != null)
            {
                var userApiClient = await _customerApiClient.GetStaffProfileDetailByUserId(new UserRequest
                {
                    LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)),
                    Id = id
                });

                if (userApiClient.IsSuccessed)
                {
                    model.Customer = userApiClient.ResultObj;
                    model.Customer.FullName = (languageId.ToString().Equals(_configuration[SystemConstants.AppConstants.DefaultLanguageId]) ? (model.Customer.LastName + " " + model.Customer.FirstName) : (model.Customer.FirstName + " " + model.Customer.LastName));
                    if (!string.IsNullOrEmpty(model.Customer.Avatar))
                    {
                        model.Customer.Avatar = _configuration[SystemConstants.AppConstants.BaseAddress] + model.Customer.Avatar;
                    }
                }
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DataTableGetList(int? draw, int? start, int? length, string textSearch, string fromDate, string toDate)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManageUserPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc",
                FromDate = fromDate,
                ToDate = toDate
            };

            var customerApiClient = await _customerApiClient.GetCustomerManageListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = customerApiClient.TotalRecords,
                recordsTotal = customerApiClient.TotalRecords,
                data = customerApiClient.Items
            });
        }

        [HttpPost]
        public async Task<IActionResult> DataTableGetListInfomationByType(int? draw, int? start, int? length, string id, int type)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManagePhieuKeToanPagingRequest()
            {
                PageIndex = skip,
                PageSize = pageSize,
                CustomerId = !string.IsNullOrEmpty(id) ? Guid.Parse(id) : Guid.Empty,
                Type = type,
                StoreId = storeId,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var data = await _phieuKeToanApiClient.GetManageListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = data.TotalRecords,
                recordsTotal = data.TotalRecords,
                data = data.Items
            });
        }

        [HttpPost]
        public async Task<IActionResult> DataTableGetListCashBook(int? draw, int? start, int? length, string id)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManagePhieuKeToanPagingRequest()
            {
                PageIndex = skip,
                PageSize = pageSize,
                CustomerId = !string.IsNullOrEmpty(id) ? Guid.Parse(id) : Guid.Empty,
                StoreId = storeId,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var data = await _phieuKeToanApiClient.GetManageListCashBookPaging(request);


            return Json(new
            {
                draw = draw,
                recordsFiltered = data.TotalRecords,
                recordsTotal = data.TotalRecords,
                data = data.Items
            });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] UserDeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _customerApiClient.DeleteByIds(request);

            if (!result.IsSuccessed)
            {
                resultMessage = result.Message;
            }

            return Json(new
            {
                isSuccessed = result.IsSuccessed,
                message = resultMessage
            });
        }
        [HttpPost]
        public async Task<IActionResult> SaveSecurity([FromBody] AddEditUserRequest<UserRequest> rq)
        {
            ApiResult<string> result = null;

            string userGuid = HttpContext.Session.GetString(SystemConstants.AppConstants.UserId);

            if (rq != null)
            {
                if (string.IsNullOrEmpty(rq.Id))
                {
                    rq.Data.CreatedUserId = userGuid;
                    rq.Data.ModifiedUserId = userGuid;
                }
                else
                {
                    rq.Data.ModifiedUserId = userGuid;
                    rq.Data.Id = rq.Id;
                }
                result = await _customerApiClient.AddOrUpdateCustomerSecurity(rq.Data);
            }
            else
            {
                result = new ApiResult<string>()
                {
                    IsSuccessed = false,
                    Message = "Không có dữ liệu"
                };
            }

            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> SaveProfileDetail([FromForm] UserRequest rq)
        {
            ApiResult<string> result = null;

            string userGuid = HttpContext.Session.GetString(SystemConstants.AppConstants.UserId);

            if (rq != null)
            {
                if (string.IsNullOrEmpty(rq.Id))
                {
                    rq.CreatedUserId = userGuid;
                    rq.ModifiedUserId = userGuid;
                }
                else
                {
                    rq.ModifiedUserId = userGuid;
                    rq.Id = rq.Id;
                }

                result = await _customerApiClient.AddOrUpdateCustomerProfileDetailAsync(rq);
            }
            else
            {
                result = new ApiResult<string>()
                {
                    IsSuccessed = false,
                    Message = "Không có dữ liệu"
                };
            }

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(string textSearch)
        {
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManageUserPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = 1,
                PageSize = 20,
                LanguageId = languageId,
                OrderCol = "Id",
                OrderDir = "desc"
            };

            var data = await _customerApiClient.GetCustomerManageListPaging(request);
            return Ok(data);
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
                Code = "Phone",
                Name = "SĐT"
            });

            exportedFields.Add(new BaseDto()
            {
                Code = "Email",
                Name = "Email "
            });



            exportedFields.Add(new BaseDto()
            {
                Code = "Address",
                Name = "Địa chỉ"
            });



            exportedFields.Add(new BaseDto()
            {
                Code = "LastimePurchase",
                Name = "Lần cuối mua hàng"
            });

            var request = new ManageUserPagingRequest()
            {
                TextSearch = string.Empty,
                PageIndex = null,
                LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId))
            };

            foreach (BaseDto item in exportedFields)
            {
                dc = new System.Data.DataColumn(item.Name);
                dt.Columns.Add(dc);
            }

            var data = await _customerApiClient.GetCustomerManageListPaging(request);

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
                            propertyInfo = typeof(UserDto).GetProperty(exportedField.Code);
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
                    byte[] fileBytes = ExcelExportHelper.ExportExcel(dt, "Nhà cung cấp", false, columnsToTake.ToArray());

                    if (fileBytes == null || !fileBytes.Any())
                    {
                        throw new Exception(String.Format("Không có dữ liệu."));
                    }


                    return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, "NhaCungCap.xlsx");
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

        [HttpGet]
        public async Task<IActionResult> Filter(string textSearch)
        {
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManageUserPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = 1,
                PageSize = 20,
                LanguageId = languageId,
                OrderCol = "Id",
                OrderDir = "desc"
            };

            var data = await _customerApiClient.GetCustomerManageListPaging(request);
            return Ok(data);
        }
        [HttpPost]
        public async Task<IActionResult> ImportDataFromExcelFile()
        {
            var customerApiClient = await _customerApiClient.ImportDataCustomerFromExcelFileAsyn(new UserRequest()
            {
                ImportDataExcelFiles = Request.Form.Files
            });
           
            return Ok(customerApiClient);
        }
    }
}
