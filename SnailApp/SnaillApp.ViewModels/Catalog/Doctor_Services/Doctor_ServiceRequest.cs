using Microsoft.AspNetCore.Http;
using SnailApp.ViewModels.Common;
using System;

namespace SnailApp.ViewModels.Catalog.Doctor_Services
{
    public class Doctor_ServiceRequest : BaseRequest
    {
        public Guid DoctorId { set; get; }
        public int ServiceId { set; get; }
        public int ClinicId { set; get; }
    }
}
