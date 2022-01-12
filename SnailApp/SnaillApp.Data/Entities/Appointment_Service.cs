using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Enums;
using System.ComponentModel.DataAnnotations;

namespace SnailApp.Data.Entities
{
    public class Appointment_Service : BaseEntity
    {
        public int ServiceId { get; set; }
        public int AppointmentId { set; get; }
        public Guid DoctorId { get; set; }
        public decimal Charges { set; get; }
        public int Quantity { set; get; }
        public bool ServiceStatus { set; get; }
        public string ServiceResult { set; get; }
        public string ServiceFile { set; get; }
        public DateTime Date { set; get; }
    }
}
