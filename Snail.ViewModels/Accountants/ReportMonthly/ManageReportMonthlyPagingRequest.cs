using Snail.ViewModels.Common;
using System.Collections.Generic;

namespace Snail.ViewModels.Accountants.PhieuKeToans
{
    public class ManageReportMonthlyPagingRequest : PagingRequestBase
    {
        public int StoreId { set; get; }
        public int Year{ set; get; }
    }
}
