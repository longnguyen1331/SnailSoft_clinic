using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BHSNetCoreLib.ExcelUtil;
using SnailApp.ApiIntegration;
using SnailApp.ViewModels.System.DocTemplates;
using SnailApp.ViewModels.System.Users;
using SnailApp.ViewModels.Catalog.PaperSizes;
using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Session;
using Microsoft.Extensions.Configuration;
using SnailApp.AdminApp.Models;

namespace SnailApp.AdminApp.Controllers
{
    public class DocTemplateController : Controller
    {
        private readonly IDocTemplateApiClient _docTemplateApiClient;
        private readonly IPaperSizeApiClient _paperSizeApiClient;
        private readonly IConfiguration _configuration;
        

        public DocTemplateController(IDocTemplateApiClient docTemplateApiClient, IPaperSizeApiClient paperSizeApiClient,
                                    IConfiguration configuration)
        {
            _docTemplateApiClient = docTemplateApiClient;
            _paperSizeApiClient = paperSizeApiClient;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            DocTemplateViewModel model = new DocTemplateViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Mẫu in";
            model.Breadcrumbs = new List<string>() { "Cài đặt", "Mẫu in" };

            return View(model);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            DocTemplateViewModel model = new DocTemplateViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Mẫu in";
            model.Breadcrumbs = new List<string>() { "Cài đặt", "Mẫu in" };

            var paperSizeApiClient = await _paperSizeApiClient.GetManageListPaging(new ManagePaperSizePagingRequest()
            {
                PageIndex = 1,
                PageSize = 20,
                OrderCol = "Id",
                OrderDir = "desc"
            });

            model.PaperSizes = paperSizeApiClient.Items;

            if (id != null)
            {
                var docTemplateApiClient = await _docTemplateApiClient.GetById(new DocTemplateRequest()
                {
                    LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)),
                    Id = id
                });

                if (docTemplateApiClient.IsSuccessed)
                {
                    model.DocTemplate = docTemplateApiClient.ResultObj;
                }
            }
            
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> DataTableGetList(int? draw, int? start, int? length, string textSearch, int? docTemplateTypeId)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));

            var request = new ManageDocTemplatePagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                DocTemplateTypeId = docTemplateTypeId,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var docTemplateApiClient = await _docTemplateApiClient.GetManageListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = docTemplateApiClient.TotalRecords,
                recordsTotal = docTemplateApiClient.TotalRecords,
                data = docTemplateApiClient.Items
            });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] DeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _docTemplateApiClient.DeleteByIds(request);

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
        public async Task<IActionResult> Save([FromBody] AddEditRequest<DocTemplateRequest> rq)
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
                result = await _docTemplateApiClient.AddOrUpdateAsync(rq.Data);
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
                Code = "Name",
                Name = "Tên"
            });


            exportedFields.Add(new BaseDto()
            {
                Code = "Description",
                Name = "Ghi chú"
            });


            var request = new ManageDocTemplatePagingRequest()
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

            var data = await _docTemplateApiClient.GetManageListPaging(request);

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
                            propertyInfo = typeof(DocTemplateDto).GetProperty(exportedField.Code);
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
                    byte[] fileBytes = ExcelExportHelper.ExportExcel(dt, "Nhóm khách hàng", false, columnsToTake.ToArray());

                    if (fileBytes == null || !fileBytes.Any())
                    {
                        throw new Exception(String.Format("Không có dữ liệu."));
                    }


                    return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, "NhomKhachHang.xlsx");
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

        [AcceptVerbs("POST")]
        public async Task<IActionResult> CKEditorUploadImage(IFormFile upload)
        {
            string fileUrl = string.Empty;
            var docTemplateApiClient = await _docTemplateApiClient.CKEditorUploadFile(upload);

            if (docTemplateApiClient.IsSuccessed)
            {
                fileUrl = _configuration[SystemConstants.AppConstants.BaseAddress] + "/" + docTemplateApiClient.ResultObj;
            }
            
            return new JsonResult(new
            {
                uploaded = 1,
                fileName = upload.FileName,
                url = fileUrl
            });
        }



        [HttpPost]
        public async Task<IActionResult> GetContentByDocTemplateTypeCode([FromBody] AddEditRequest<DocTemplateRequest> rq)
        {
            ApiResult<DocTemplateDto> result = null;

            string userGuid = HttpContext.Session.GetString(SystemConstants.AppConstants.UserId);

            if (rq != null)
            {

                int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));
                rq.Data.LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
                rq.Data.StoreId = storeId;
                var docTemplateContent = await _docTemplateApiClient.GetContentByDocTemplateTypeCode(rq.Data);

                result = new ApiResult<DocTemplateDto>()
                {
                    IsSuccessed = true,
                    ResultObj = docTemplateContent
                };
            }
            else
            {
                result = new ApiResult<DocTemplateDto>()
                {
                    IsSuccessed = false,
                    Message = "Không có dữ liệu"
                };
            }

            return Ok(result);
        }

    }
}
