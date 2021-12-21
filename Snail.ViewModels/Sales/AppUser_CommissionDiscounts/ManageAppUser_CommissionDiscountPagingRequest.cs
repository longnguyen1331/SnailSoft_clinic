using Snail.ViewModels.Common;

namespace Snail.ViewModels.Sales.AppUser_CommissionDiscounts
{
    public class ManageAppUser_CommissionDiscountPagingRequest : PagingRequestBase
    {
        public string AppUserId { set; get; }
        public string FilterByFromDate { set; get; }
        public string FilterByToDate { set; get; }
    }
}
