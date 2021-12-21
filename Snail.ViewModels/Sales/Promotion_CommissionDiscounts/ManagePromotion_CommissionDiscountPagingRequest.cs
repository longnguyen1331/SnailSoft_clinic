using Snail.ViewModels.Common;

namespace Snail.ViewModels.Sales.Promotion_CommissionDiscounts
{
    public class ManagePromotion_CommissionDiscountPagingRequest : PagingRequestBase
    {
        public int? PromotionId { set; get; }
    }
}
