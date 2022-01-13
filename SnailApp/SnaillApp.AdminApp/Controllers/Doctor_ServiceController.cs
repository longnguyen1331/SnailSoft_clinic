using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ApiIntegration;
using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Catalog.Doctor_Services;
using Microsoft.Extensions.Configuration;

namespace SnailApp.AdminApp.Controllers
{
    public class Doctor_ServiceController : Controller
    {
        private readonly IDoctor_ServiceApiClient _doctor_ServiceApiClient;
        public Doctor_ServiceController(IDoctor_ServiceApiClient doctor_ServiceApiClient)
        {
            _doctor_ServiceApiClient = doctor_ServiceApiClient;
        }

        [HttpPost]
        public async Task<IActionResult> DataTableGetUserList(int? draw, int? start, int? length, string textSearch, int serviceId)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));

            var request = new ManageDoctor_ServicePagingRequest()
            {
                DoctorId = new Guid(),
                ServiceId = serviceId,
                TextSearch = textSearch,
                ClinicId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultClinicId)),
                PageIndex = skip,
                PageSize = pageSize,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var doctor_ServiceApiClient = await _doctor_ServiceApiClient.GetManageUserByServiceListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = doctor_ServiceApiClient.TotalRecords,
                recordsTotal = doctor_ServiceApiClient.TotalRecords,
                data = doctor_ServiceApiClient.Items
            });
        }

        [HttpPost]
        public async Task<IActionResult> DataTableGetServiceList(int? draw, int? start, int? length, string textSearch, string userId)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));

            var request = new ManageDoctor_ServicePagingRequest()
            {
                DoctorId = !string.IsNullOrEmpty(userId) ?  Guid.Parse(userId) : Guid.Parse("00000000-0000-0000-0000-000000000000"),
                ServiceId = 0,
                TextSearch = textSearch,
                ClinicId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultClinicId)),
                PageIndex = skip,
                PageSize = pageSize,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var doctor_ServiceApiClient = await _doctor_ServiceApiClient.GetManageServiceByUserListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = doctor_ServiceApiClient.TotalRecords,
                recordsTotal = doctor_ServiceApiClient.TotalRecords,
                data = doctor_ServiceApiClient.Items
            });
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] DeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _doctor_ServiceApiClient.DeleteByIds(request);

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
        public async Task<IActionResult> Save([FromBody] Doctor_ServiceRequest rq)
        {
            ApiResult<int> result = null;

            Guid userGuid = Guid.Parse(HttpContext.Session.GetString(SystemConstants.AppConstants.UserId));

            if (rq != null)
            {
                rq.LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
                rq.ClinicId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultClinicId));
                rq.CreatedUserId = userGuid;
                rq.ModifiedUserId = userGuid;
                result = await _doctor_ServiceApiClient.AddOrUpdateAsync(rq);
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
        public async Task<IActionResult> FilterServiceByUser(string textSearch, string doctorId)
        {
            var request = new ManageDoctor_ServicePagingRequest()
            {
                DoctorId = Guid.Parse(doctorId),
                ServiceId =0,
                ClinicId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultClinicId)),
                TextSearch = textSearch,
                PageIndex = 1,
                PageSize = 20,
                LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)),
                OrderCol = "Id",
                OrderDir = "desc"
            };

            var data = await _doctor_ServiceApiClient.GetManageServiceByUserListPaging(request);
            return Ok(data);
        }

        public async Task<IActionResult> FilterDoctorByService(string textSearch)
        {
            var request = new ManageDoctor_ServicePagingRequest()
            {
                DoctorId = Guid.Parse("00000000-0000-0000-0000-000000000000"),
                ServiceId = 0,
                ClinicId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultClinicId)),
                TextSearch = textSearch,
                PageIndex = 1,
                PageSize = 20,
                LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)),
                OrderCol = "Id",
                OrderDir = "desc"
            };

            var data = await _doctor_ServiceApiClient.GetUserFilterService(request);
            return Ok(data);
        }
    }
}
