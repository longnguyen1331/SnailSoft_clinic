using Snail.ViewModels.Common;

namespace Snail.ViewModels.Catalog.ProductTypes
{
    public class ManageProductTypePagingRequest : PagingRequestBase
    {
        public int StoreId { set; get; }
    }
}
