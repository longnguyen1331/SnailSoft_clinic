using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;

namespace SnailApp.ViewModels.Catalog.Appointments
{
    public class Appointment_ServiceRequest 
    {
        public string Description { set; get; }
        public string Date { set; get; }
        public decimal Charges { get; set; }
        public int Quantity { get; set; }
        public int ServiceId { get; set; }
        public Guid DoctorId { get; set; }
    }

}