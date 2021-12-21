using Snail.ViewModels.Common;
using System.Collections.Generic;

namespace Snail.ViewModels.Accountants.PhieuKeToans
{
    public class ManageReportProfitPagingRequest : PagingRequestBase
    {
        public int StoreId { set; get; }
        public string FromDate{ set; get; }
        public string ToDate { set; get; }
    }
}
