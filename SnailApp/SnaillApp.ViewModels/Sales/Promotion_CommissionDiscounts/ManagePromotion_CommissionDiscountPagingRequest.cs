using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Sales.Promotion_CommissionDiscounts
{
    public class ManagePromotion_CommissionDiscountPagingRequest : PagingRequestBase
    {
        public int? PromotionId { set; get; }
    }
}
