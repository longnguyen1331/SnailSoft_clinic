using SnailApp.ViewModels.Common;
using System.Collections.Generic;

namespace SnailApp.ViewModels.Accountants.PhieuKeToans
{
    public class ManageReportProfitPagingRequest : PagingRequestBase
    {
        public int StoreId { set; get; }
        public string FromDate{ set; get; }
        public string ToDate { set; get; }
    }
}
