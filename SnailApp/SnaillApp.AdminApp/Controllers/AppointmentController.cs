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
using SnailApp.ViewModels.Catalog.Appointments;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;

namespace SnailApp.AdminApp.Controllers
{
    public class AppointmentController : BaseController
    {
        private readonly IAppointmentApiClient _appointmentApiClient;
        private readonly IAppointmentPaymentApiClient _appointmentPaymentApiClient;
        private readonly IMenuApiClient _menuApiClient;
        private readonly IConfiguration _configuration;
        public AppointmentController(IAppointmentApiClient appointmentApiClient,
            IMenuApiClient menuApiClient,
            IAppointmentPaymentApiClient appointmentPaymentApiClient,
                                    IConfiguration configuration)
        {
            _appointmentApiClient = appointmentApiClient;
            _menuApiClient = menuApiClient;
            _appointmentPaymentApiClient = appointmentPaymentApiClient;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            BaseViewModel model = new BaseViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);
            ViewBag.Title = "Appointments";
            model.Breadcrumbs = new List<string>() {  "Appointments" };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> DataTableGetList([FromQuery] int status, string fDate, string tDate)
        {

            var request = new ManageAppointmentPagingRequest()
            {
                Status = status,
                FromDate = fDate,
                ToDate = tDate,  
                ClinicId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultClinicId)),
                PageIndex = 1,
                PageSize = 1000,
                OrderCol = "Date",
                OrderDir = "desc"
            };

            var appointmentApiClient = await _appointmentApiClient.GetManageListPaging(request);

            return Json(new
            {
                data = appointmentApiClient.Items
            });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] DeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _appointmentApiClient.DeleteByIds(request);

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
        public async Task<IActionResult> Save([FromBody] AppointmentRequest rq)
        {
            ApiResult<int> result = null;

            Guid userGuid = Guid.Parse(HttpContext.Session.GetString(SystemConstants.AppConstants.UserId));

            if (rq != null)
            {
                rq.ClinicId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultClinicId));
                rq.CreatedUserId = userGuid;
                rq.ModifiedUserId = userGuid;
                result = await _appointmentApiClient.AddOrUpdateAsync(rq);
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

        [AllowAnonymous]
        public async Task<IActionResult> UpdateStatusCheckout([FromBody] AppointmentRequest rq)
        {
            ApiResult<int> result = null;
            Guid userGuid = Guid.Parse(HttpContext.Session.GetString(SystemConstants.AppConstants.UserId));

            if (rq != null)
            {
                rq.ModifiedDate = DateTime.Now;
                rq.ModifiedUserId = userGuid;
                rq.Status = (int)ViewModels.Enums.AppointmentStatus.Checkout;
                result = await _appointmentApiClient.ChangeStatus(rq);
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

        public async Task<IActionResult> Filter(string textSearch)
        {
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));

            var request = new ManageAppointmentPagingRequest()
            {
                ClinicId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultClinicId)),
                TextSearch = textSearch,
                PageIndex = 1,
                PageSize = 20,
                LanguageId = languageId,
                OrderCol = "Id",
                OrderDir = "desc"
            };

            var appUserStatusApiClient = await _appointmentApiClient.GetManageListPaging(request);
            return Ok(appUserStatusApiClient);
        }

        public async Task<IActionResult> GetById(int id)
        {
            var appUserStatusApiClient = await _appointmentApiClient.GetById(new AppointmentRequest() { Id = id});
            appUserStatusApiClient.ResultObj.PatientAvatar = _configuration[SystemConstants.AppConstants.BaseAddress] + "/" + appUserStatusApiClient.ResultObj.PatientAvatar;
            return Ok(appUserStatusApiClient);
        }


        [HttpPost]
        public async Task<IActionResult> SavePayment([FromBody] AppointmentPaymentRequest rq)
        {
            ApiResult<int> result = null;

            Guid userGuid = Guid.Parse(HttpContext.Session.GetString(SystemConstants.AppConstants.UserId));

            if (rq != null)
            {
                rq.CreatedUserId = userGuid;
                rq.ModifiedUserId = userGuid;
                result = await _appointmentPaymentApiClient.AddOrUpdateAsync(rq);
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

    }
}
