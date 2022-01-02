using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.HR.PayrollDetails
{
    public class ManagePayrollDetailPagingRequest: PagingRequestBase
    {
        public string AppUserId { set; get; }
        public int? PayrollId { set; get; }
    }
}
