using SnailApp.ViewModels.Common;
using System;

namespace SnailApp.ViewModels.Catalog.ExaminationsResults
{
    public class ManageExaminationsResulttPagingRequest : PagingRequestBase
    {
        public int Status { set; get; }
        public string FromDate { set; get; }
        public string ToDate { set; get; }
        public int ClinicId { set; get; }
        public string DoctorId { set; get; }
    }
}
