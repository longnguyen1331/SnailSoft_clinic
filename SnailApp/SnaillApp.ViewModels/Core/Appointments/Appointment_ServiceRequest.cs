using System;
using Microsoft.AspNetCore.Http;
using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Catalog.Appointments
{
    public class Appointment_ServiceRequest  : BaseRequest
    {
        public string Date { set; get; }
        public decimal Charges { get; set; }
        public int Quantity { get; set; }
        public int ServiceId { get; set; }
        public Guid DoctorId { get; set; }
        public int AppointmentId { set; get; }
        public string ServiceResult { set; get; }
        public IFormFile ServiceFile { set; get; }
    }

}