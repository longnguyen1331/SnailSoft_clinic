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
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
        public AppointmentStatus Status { set; get; }
        public int ClinicId { set; get; }
    }
    
}