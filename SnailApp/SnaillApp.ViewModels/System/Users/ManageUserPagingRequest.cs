using SnailApp.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.ViewModels.System.Users
{
    public class ManageUserPagingRequest : PagingRequestBase
    {
        public int? Type { set; get; }
        public int? ClinicId { set; get; }
        public string AppUserId { set; get; }
        public string FromDate { set; get; }
        public string ToDate { set; get; }
    }
}