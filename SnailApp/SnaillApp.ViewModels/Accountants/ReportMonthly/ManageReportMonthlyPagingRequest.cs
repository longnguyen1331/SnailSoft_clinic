using SnailApp.ViewModels.Common;
using System.Collections.Generic;

namespace SnailApp.ViewModels.Accountants.PhieuKeToans
{
    public class ManageReportMonthlyPagingRequest : PagingRequestBase
    {
        public int StoreId { set; get; }
        public int Year{ set; get; }
    }
}
