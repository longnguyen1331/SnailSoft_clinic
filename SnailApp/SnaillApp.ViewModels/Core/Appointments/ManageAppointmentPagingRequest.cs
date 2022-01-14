using SnailApp.ViewModels.Common;
using System;

namespace SnailApp.ViewModels.Catalog.Appointments
{
    public class ManageAppointmentPagingRequest : PagingRequestBase
    {
        public int Status { set; get; }
        public string FromDate { set; get; }
        public string ToDate { set; get; }
        public int ClinicId { set; get; }
    }
}
