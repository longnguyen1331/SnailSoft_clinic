using System;
using System.Collections.Generic;
using SnailApp.ViewModels.Enums;

namespace SnailApp.Data.Entities
{
    public class Appointment : BaseEntity
    {
        public DateTime Date { set; get; }
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
        public AppointmentStatus Status { set; get; }
        public int ClinicId { set; get; }
        public virtual ICollection<Appointment_Service> Appointment_Services { set; get; }
        public virtual ICollection<AppointmentPayment> AppointmentPayments { set; get; }

    }
}
