using SnailApp.ViewModels.Common;
using System;

namespace SnailApp.ViewModels.Catalog.Doctor_Services
{
    public class Doctor_ServiceDto : BaseDto
    {

        public string DoctorFullName { set; get; }
        public Guid DoctorId { set; get; }
        public int ClinicId { set; get; }
        public string ServiceName { set; get; }
        public int ServiceId { set; get; }
    }
}
