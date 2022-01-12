using SnailApp.ViewModels.Common;
using System;

namespace SnailApp.ViewModels.Catalog.Doctor_Services
{
    public class ManageDoctor_ServicePagingRequest : PagingRequestBase
    {
        public Guid DoctorId { set; get; }
        public int ServiceId { set; get; }
        public int ClinicId { set; get; }
    }
}
