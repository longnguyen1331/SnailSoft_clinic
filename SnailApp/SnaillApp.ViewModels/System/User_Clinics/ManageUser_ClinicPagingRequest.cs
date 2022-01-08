using SnailApp.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.ViewModels.System.User_Clinics
{
    public class ManageUser_ClinicPagingRequest : PagingRequestBase
    {
        public int ClinicId { set; get; }
        public Guid UserId { set; get; }
    }
}