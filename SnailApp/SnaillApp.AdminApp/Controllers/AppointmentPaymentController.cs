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
using SnailApp.Application.Catalog.Appointment_Services;
using SnailApp.ViewModels.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SnailApp.AdminApp.Controllers
{
    public class AppointmentPaymentController : BaseController
    {
        private readonly IAppointmentPaymentApiClient _appointmentPaymentApiClient;
        private readonly IAppointment_ServiceApiClient _appointment_ServiceService;
        private readonly IMenuApiClient _menuApiClient;
        private readonly IConfiguration _configuration;
        public AppointmentPaymentController(
            IAppointment_ServiceApiClient appointment_ServiceService,
            IMenuApiClient menuApiClient,
            IAppointmentPaymentApiClient appointmentPaymentApiClient,
                                    IConfiguration configuration)
        {
            _appointment_ServiceService = appointment_ServiceService;
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
            ViewBag.Title = "Payment";
            model.Breadcrumbs = new List<string>() {  "Appointments", "Payment" };
            return View(model);
        }


        public async Task<IActionResult> Update(int id)
        {
            AppointmentPaymentViewModel model = new AppointmentPaymentViewModel();
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);
            ViewBag.Tiltle = "Payment"; 
            model.Breadcrumbs = new List<string>() { "Appointments", "Payment" };

            var result = await _appointmentPaymentApiClient.GetById(new AppointmentPaymentRequest() { Id = id });
            if (result.IsSuccessed)
            {
                model.AppointmentPayment = result.ResultObj;
                model.AppointmentPayment.PatientAvatar = _configuration[SystemConstants.AppConstants.BaseAddress] + _configuration[SystemConstants.UserConstants.UserImagePath] + "/" + result.ResultObj.PatientAvatar;
                model.Appointment_Services = await _appointment_ServiceService.GetByAppointmentId(new ViewModels.Catalog.Appointments.Appointment_ServiceRequest() { AppointmentId = model.AppointmentPayment.AppointmentId });


                var dictionary = new Dictionary<int, string>
                {
                    { (int)PaymentMethod.Cash,PaymentMethod.Cash.ToString() },
                    { (int)PaymentMethod.Bank, PaymentMethod.Bank.ToString() },
                    { (int)PaymentMethod.Transfer, PaymentMethod.Transfer.ToString() },
                    { (int)PaymentMethod.Debit, PaymentMethod.Debit.ToString() },
                    { (int)PaymentMethod.MembershipCard, PaymentMethod.MembershipCard.ToString() }
                };

                model.PaymentMethods = new SelectList(dictionary, "Key", "Value");
                model.PaymentMethod = (int)model.AppointmentPayment.PaymentMethod;

                var statuses = new Dictionary<int, string>
                {
                    { (int)PaymentStatus.Unpaid,PaymentStatus.Unpaid.ToString() },
                    { (int)PaymentStatus.Paid, PaymentStatus.Paid.ToString() },
                    { (int)PaymentStatus.Debit, PaymentStatus.Debit.ToString() },
                };

                model.ListStatus = new SelectList(statuses, "Key", "Value");
                model.Status = model.AppointmentPayment.Status;
            }

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> DataTableGetList(int? draw, int? start, int? length, string textSearch, int status, string fDate, string tDate)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;

            var request = new ManageAppointmentPagingRequest()
            {
                TextSearch = textSearch,
                Status = status,
                FromDate = fDate,
                ToDate = tDate,  
                ClinicId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultClinicId)),
                PageIndex = skip,
                PageSize = pageSize,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var appointmentApiClient = await _appointmentPaymentApiClient.GetManageListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = appointmentApiClient.TotalRecords,
                recordsTotal = appointmentApiClient.TotalRecords,
                data = appointmentApiClient.Items
            });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] DeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _appointmentPaymentApiClient.DeleteByIds(request);

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
        public async Task<IActionResult> Save([FromBody] AppointmentPaymentRequest rq)
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
