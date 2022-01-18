using SnailApp.ViewModels.Common;
using System;

namespace SnailApp.ViewModels.Catalog.Appointments
{
    public class ManageAppointment_ServicePagingRequest : PagingRequestBase
    {
        public string FromDate { set; get; }
        public string ToDate { set; get; }
        public int ClinicId { set; get; }
        public Guid DoctorId { set; get; }
        public bool? Status { set; get; }
    }
}
