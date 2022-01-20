using Microsoft.AspNetCore.Mvc.Rendering;
using SnailApp.ViewModels.Catalog.Appointments;
using SnailApp.ViewModels.Enums;
using System.Collections.Generic;

namespace SnailApp.AdminApp.Models
{
    public class AppointmentPaymentViewModel : BaseViewModel
    {
        public SelectList PaymentMethods { set; get; }
        public int PaymentMethod { set; get; }

        public SelectList ListStatus { set; get; }
        public int Status { set; get; }

        public AppointmentPaymentDto AppointmentPayment { set; get; }
        public List<Appointment_ServiceDto> Appointment_Services { set; get; }
    }
}
