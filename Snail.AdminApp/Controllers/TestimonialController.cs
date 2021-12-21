using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BHSNetCoreLib.ExcelUtil;
using Snail.ApiIntegration;
using Snail.ViewModels.News.Testimonials;
using Snail.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Snail.Utilities.Constants;
using Snail.AdminApp.Models;
using Snail.ViewModels.System.Users;
using Snail.Utilities.Session;

namespace Snail.AdminApp.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly ITestimonialApiClient _testimonialApiClient;
        private readonly IConfiguration _configuration;
        public TestimonialController(ITestimonialApiClient testimonialApiClient,
                                        IConfiguration configuration)
        {
            _testimonialApiClient = testimonialApiClient;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            TestimonialViewModel model = new TestimonialViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Testimonial";
            model.Breadcrumbs = new List<string>() { "Website", "Testimonial" };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            var model = new TestimonialViewModel();
            var languageId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Testimonial";
            model.Breadcrumbs = new List<string>() { "Website", "Testimonial" };

            if (id != null)
            {
                var testimonialApiClient = await _testimonialApiClient.GetById(new TestimonialRequest
                {
                    Id = id
                });

                if (testimonialApiClient.IsSuccessed)
                {
                    model.Testimonial = testimonialApiClient.ResultObj;
                    if (!string.IsNullOrEmpty(model.Testimonial.Image))
                    {
                        model.Testimonial.Image = _configuration[SystemConstants.AppConstants.BaseAddress] + "/" + model.Testimonial.Image;
                    }
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

            var request = new ManageTestimonialPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var testimonialApiClient = await _testimonialApiClient.GetManageListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = testimonialApiClient.TotalRecords,
                recordsTotal = testimonialApiClient.TotalRecords,
                data = testimonialApiClient.Items
            });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] DeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _testimonialApiClient.DeleteByIds(request);

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
        public async Task<IActionResult> Save([FromForm] TestimonialRequest rq)
        {
            ApiResult<int> result = null;

            string userGuid = HttpContext.Session.GetString(SystemConstants.AppConstants.UserId);

            if (rq != null)
            {
                if (rq.Id == null)
                {
                    rq.CreatedUserId = userGuid;
                    rq.ModifiedUserId = userGuid;
                }
                else
                {
                    rq.ModifiedUserId = userGuid;
                    rq.Id = rq.Id.Value;
                }
                result = await _testimonialApiClient.AddOrUpdateAsync(rq);
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
        public async Task<IActionResult> DeleteImageByTestimonialId(int testimonialId)
        {
            var testimonialApiClient = await _testimonialApiClient.DeleteImageByTestimonialId(testimonialId);

            if (testimonialApiClient.IsSuccessed)
            {
                testimonialApiClient.ResultObj = _configuration[SystemConstants.AppConstants.BaseAddress] + "/" + testimonialApiClient.ResultObj;
            }

            return Ok(testimonialApiClient);
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


            var request = new ManageTestimonialPagingRequest()
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

            var data = await _testimonialApiClient.GetManageListPaging(request);

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
                            propertyInfo = typeof(TestimonialDto).GetProperty(exportedField.Code);
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
