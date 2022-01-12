using SnailApp.ViewModels.Common;
using System;

namespace SnailApp.ViewModels.Catalog.Appointments
{
    public class ManageAppointmentPagingRequest : PagingRequestBase
    {
        public string FromDate { set; get; }
        public string ToDate { set; get; }
        public int ClinicId { set; get; }
    }
}
