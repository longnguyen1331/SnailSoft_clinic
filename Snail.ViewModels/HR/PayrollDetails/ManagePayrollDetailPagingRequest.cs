using Snail.ViewModels.Common;

namespace Snail.ViewModels.HR.PayrollDetails
{
    public class ManagePayrollDetailPagingRequest: PagingRequestBase
    {
        public string AppUserId { set; get; }
        public int? PayrollId { set; get; }
    }
}
