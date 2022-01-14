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
    }
    
}