using SnailApp.ViewModels.Common;
using System;
using System.Collections.Generic;

namespace SnailApp.ViewModels.Accountants.PhieuKeToans
{
    public class ManagePhieuKeToanPagingRequest : PagingRequestBase
    {
        public int PhieuKeToanId { set; get; }
        public int StoreId { set; get; }
        public int Type { set; get; }
        public Guid AppUserId { set; get; }
        public Guid? CustomerId { set; get; }
        public string FromDate{ set; get; }
        public string ToDate { set; get; }
    }
}
