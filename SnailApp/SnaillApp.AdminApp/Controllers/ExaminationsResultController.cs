using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ApiIntegration;
using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Session;
using SnailApp.ViewModels.System.Users;
using SnailApp.AdminApp.Models;
using SnailApp.ViewModels.Catalog.ExaminationsResults;
using Microsoft.Extensions.Configuration;

namespace SnailApp.AdminApp.Controllers
{
    public class ExaminationsResultController : BaseController
    {
        private readonly IAppointmentApiClient _appointmentApiClient;
        private readonly IExaminationsResultApiClient _examinationsResultApiClient;
        private readonly IMenuApiClient _menuApiClient;
        private readonly IConfiguration _configuration;
        public ExaminationsResultController(IAppointmentApiClient appointmentApiClient, IExaminationsResultApiClient examinationsResultApiClient,
            IMenuApiClient menuApiClient,
                                    IConfiguration configuration)
        {
            _appointmentApiClient = appointmentApiClient;
            _examinationsResultApiClient = examinationsResultApiClient;
            _menuApiClient = menuApiClient;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ExaminationViewModel model = new ExaminationViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);
            ViewBag.Tiltle = "Examination Result";
            model.Breadcrumbs = new List<string>() {  "Examinations", "Examination Result" };
            return View(model);
        }

        public async Task<IActionResult> Update(int appointmentId)
        {
            ExaminationViewModel model = new ExaminationViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);
            ViewBag.Tiltle = "Examination Result";
            model.Breadcrumbs = new List<string>() { "Examinations", "Examination Result" };
            var result = await _examinationsResultApiClient.GetByAppointmentId(new ExaminationsResultRequest() { AppointmentId = appointmentId });
            if (result.IsSuccessed)
            {
                model.ExaminationsResult = result.ResultObj;
                model.ExaminationsResult.Examination_File = !string.IsNullOrEmpty(model.ExaminationsResult.Examination_File) ?  _configuration[SystemConstants.AppConstants.BaseAddress] + "/" + model.ExaminationsResult.Examination_File : string.Empty;
            }

            var appointment = await _appointmentApiClient.GetById(new ViewModels.Catalog.Appointments.AppointmentRequest() { Id = appointmentId });
            if (appointment.IsSuccessed)
            {
                model.Appointment = appointment.ResultObj;
                model.Appointment.PatientAvatar = _configuration[SystemConstants.AppConstants.BaseAddress] + "/" + appointment.ResultObj.PatientAvatar;

            }


            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> DataTableGetList(int? draw, int? start, int? length, int status, string fDate, string tDate, string doctorId)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;

            var request = new ManageExaminationsResulttPagingRequest()
            {
                Status = status,
                FromDate = fDate,
                DoctorId = doctorId,
                ToDate = tDate,  
                ClinicId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultClinicId)),
                PageIndex = skip,
                PageSize = pageSize,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var examinationsResultApiClient = await _examinationsResultApiClient.GetManageListPaging(request);


            return Json(new
            {
                draw = draw,
                recordsFiltered = examinationsResultApiClient.TotalRecords,
                recordsTotal = examinationsResultApiClient.TotalRecords,
                data = examinationsResultApiClient.Items
            });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] DeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _examinationsResultApiClient.DeleteByIds(request);

            if (!result.IsSuccessed)
            {
                resultMessage = "Error";
            }

            return Json(new
            {
                isSuccessed = result.IsSuccessed,
                message = resultMessage
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromForm] ExaminationsResultRequest rq)
        {
            ApiResult<int> result = null;

            Guid userGuid = Guid.Parse(HttpContext.Session.GetString(SystemConstants.AppConstants.UserId));

            if (rq != null)
            {
                rq.ClinicId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultClinicId));
                rq.CreatedUserId = userGuid;
                rq.ModifiedUserId = userGuid;
                result = await _examinationsResultApiClient.AddOrUpdateAsync(rq);
            }
            else
            {
                result = new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = "Not found"
                };
            }

            return Ok(result);
        }

    
        public async Task<IActionResult> CKEditorUploadImage()
        {
            string fileUrl = string.Empty;
            var urls = new List<string>();
            if (Request.Form.Files != null && Request.Form.Files.Count > 0)
            {
                var postApiClient = await _examinationsResultApiClient.CKEditorUploadFile(Request.Form.Files[0]);

                if (postApiClient.IsSuccessed)
                {
                    fileUrl = _configuration[SystemConstants.AppConstants.BaseAddress] + "/" + postApiClient.ResultObj;
                }

                return new JsonResult(new
                {
                    uploaded = 1,
                    fileName = Request.Form.Files[0].FileName,
                    url = fileUrl
                });
            }

            return new JsonResult(new
            {
                uploaded = 0,
                fileName = "",
                url = ""
            });
        }

       

    }
}
