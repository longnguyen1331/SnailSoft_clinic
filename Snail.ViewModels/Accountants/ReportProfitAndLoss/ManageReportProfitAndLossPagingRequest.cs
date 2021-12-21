using Snail.ViewModels.Common;
using System.Collections.Generic;

namespace Snail.ViewModels.Accountants.PhieuKeToans
{
    public class ManageReportProfitAndLossPagingRequest : PagingRequestBase
    {
        public int DateType { set; get; }
        public int StoreId { set; get; }
        public string FromDate{ set; get; }
        public string ToDate { set; get; }
        public string FromDatePast { set; get; }
        public string ToDatePast { set; get; }

    }
}
