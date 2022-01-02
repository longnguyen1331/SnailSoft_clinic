using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Sales.Promotion_ProductSKUs
{
    public class ManagePromotion_ProductSKUPagingRequest: PagingRequestBase
    {
        public int? PromotionId { set; get; }
    }
}
