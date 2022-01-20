using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;

namespace SnailApp.ViewModels.Catalog.Appointments
{
    public class AppointmentPaymentDto : BaseDto
    {
        public int AppointmentId { set; get; }
        public decimal Total { set; get; }
        public decimal Discount { set; get; }
        public decimal AmountDue { set; get; }
        public int PaymentMethodId { get; set; }
        public string Date { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public string PaymentMethodNote { set; get; }
        public string DoctorFullName { set; get; }
        public string PatientFullName { set; get; }
        public string PatientCode { set; get; }
        public string PatientEmail { set; get; }
        public string PatientPhoneNumber { set; get; }
        public string PatientAddress { set; get; }
        public string PatientAvatar { set; get; }
        public int Status { set; get; }
        public AppointmentStatus AppointmentStatus { set; get; }
    }

}