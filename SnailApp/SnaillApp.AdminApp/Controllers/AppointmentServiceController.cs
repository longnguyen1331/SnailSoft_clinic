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
using Microsoft.Extensions.Configuration;
using SnailApp.ViewModels.Catalog.Appointments;

namespace SnailApp.AdminApp.Controllers
{
    public class AppointmentServiceController : BaseController
    {
        private readonly IAppointment_ServiceApiClient _appointment_ServiceApiClient;
        private readonly IMenuApiClient _menuApiClient;
        private readonly IConfiguration _configuration;
        public AppointmentServiceController(IAppointment_ServiceApiClient appointment_ServiceApiClient, 
            IMenuApiClient menuApiClient,
                                    IConfiguration configuration)
        {
            _appointment_ServiceApiClient = appointment_ServiceApiClient;
            _menuApiClient = menuApiClient;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            AppointmentServiceViewModel model = new AppointmentServiceViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);
            ViewBag.Tiltle = "Examination Service";
            model.Breadcrumbs = new List<string>() {  "Examinations", "Examination Service" };
            return View(model);
        }

        public async Task<IActionResult> Update(int id)
        {
            AppointmentServiceViewModel model = new AppointmentServiceViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);
            model.Breadcrumbs = new List<string>() { "Examinations", "Examination Service" };
         
            var appointment = await _appointment_ServiceApiClient.GetById(new ViewModels.Catalog.Appointments.Appointment_ServiceRequest() { Id = id });
            if (appointment.IsSuccessed)
            {
                model.Appointment_Service = appointment.ResultObj;
                model.Appointment_Service.ServiceFile = !string.IsNullOrEmpty(model.Appointment_Service.ServiceFile) ?_configuration[SystemConstants.AppConstants.BaseAddress] + "/" + appointment.ResultObj.ServiceFile : ""; 
                model.Appointment_Service.PatientAvatar = _configuration[SystemConstants.AppConstants.BaseAddress] + _configuration[SystemConstants.UserConstants.UserImagePath] + "/" + appointment.ResultObj.PatientAvatar; 

            }

            ViewBag.Tiltle = "Examination Service";

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> DataTableGetList(int? draw, int? start, int? length, string textSearch,  bool? status, string fDate, string tDate, string doctorId)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;

            var request = new ManageAppointment_ServicePagingRequest()
            {
                Status = status,
                TextSearch = textSearch,
                FromDate = fDate,
                //DoctorId = doctorId,
                ToDate = tDate,  
                ClinicId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultClinicId)),
                PageIndex = skip,
                PageSize = pageSize,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var AppointmentServiceApiClient = await _appointment_ServiceApiClient.GetManageListPaging(request);


            return Json(new
            {
                draw = draw,
                recordsFiltered = AppointmentServiceApiClient.TotalRecords,
                recordsTotal = AppointmentServiceApiClient.TotalRecords,
                data = AppointmentServiceApiClient.Items
            });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] DeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _appointment_ServiceApiClient.DeleteByIds(request);

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
        public async Task<IActionResult> Save([FromForm] Appointment_ServiceRequest rq)
        {
            ApiResult<int> result = null;

            Guid userGuid = Guid.Parse(HttpContext.Session.GetString(SystemConstants.AppConstants.UserId));

            if (rq != null)
            {
                rq.CreatedUserId = userGuid;
                rq.ModifiedUserId = userGuid;
                result = await _appointment_ServiceApiClient.AddOrUpdateAsync(rq);
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
                var postApiClient = await _appointment_ServiceApiClient.CKEditorUploadFile(Request.Form.Files[0]);

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
