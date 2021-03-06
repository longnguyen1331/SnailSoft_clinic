using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;

namespace SnailApp.ViewModels.Catalog.Appointments
{
    public class AppointmentRequest : BaseRequest
    {
        public string Date { set; get; }
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
        public int Status { set; get; }
        public int ClinicId { set; get; }
        public List<Appointment_ServiceRequest> Appointment_ServiceRequests { set; get; }   
    }
}