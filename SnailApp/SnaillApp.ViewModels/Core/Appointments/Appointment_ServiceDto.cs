using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;

namespace SnailApp.ViewModels.Catalog.Appointments
{
    public class Appointment_ServiceDto : BaseDto
    {
        public int AppointmentId { set; get; }
        public string Date { set; get; }
        public decimal Charges { get; set; }
        public int Quantity { get; set; }
        public string ServiceName { get; set; }
        public int ServiceId { get; set; }
        public Guid DoctorId { get; set; }
        public string DoctorFullName { get; set; }
        public string PatientFullName { get; set; }
        public string PatientAvatar { get; set; }
        public string PatientAddress { get; set; }
        public string PatientEmail { get; set; }
        public string PatientCode { get; set; }
        public string PatientPhone { get; set; }
        public string ServiceFile { get; set; }
        public bool ServiceStatus { set; get; }
        public string ServiceResult { set; get; }
        public string PatientDob { set; get; }
    }
}
