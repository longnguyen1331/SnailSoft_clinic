using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Catalog.ProductTypes
{
    public class ManageProductTypePagingRequest : PagingRequestBase
    {
        public int StoreId { set; get; }
    }
}
