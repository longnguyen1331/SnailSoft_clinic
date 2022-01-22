using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;

namespace SnailApp.ViewModels.Catalog.Appointments
{
    public class AppointmentDto : BaseDto
    {
        public string Date { set; get; }
        public string PatientAvatar { get; set; }
        public string PatientEmail { get; set; }
        public string PatientAddress { get; set; }
        public string PatientPhone { get; set; }
        public string PatientCode { get; set; }
        public string PatientFullName { get; set; }
        public string PatientDob { get; set; }
        public Guid PatientId { get; set; }
        public string DoctorFullName { get; set; }
        public Guid DoctorId { get; set; }
        public AppointmentStatus Status { set; get; }
        public int ClinicId { set; get; }
        public List<Appointment_ServiceDto> Appointment_Services { set; get; }   
        public AppointmentPaymentDto AppointmentPayments { set; get; }
    }
    
}