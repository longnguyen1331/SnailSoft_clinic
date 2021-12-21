using Snail.ViewModels.Common;

namespace Snail.ViewModels.Sales.Promotion_ProductSKUs
{
    public class ManagePromotion_ProductSKUPagingRequest: PagingRequestBase
    {
        public int? PromotionId { set; get; }
    }
}
