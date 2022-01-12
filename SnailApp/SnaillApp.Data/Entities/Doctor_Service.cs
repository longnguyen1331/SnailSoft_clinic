
using System;

namespace SnailApp.Data.Entities
{
    public class Doctor_Service : BaseEntity
    {
        public Guid DoctorId { set; get; }
        public int ServiceId { set; get; }
        public int ClinicId { set; get; }
    }
}
