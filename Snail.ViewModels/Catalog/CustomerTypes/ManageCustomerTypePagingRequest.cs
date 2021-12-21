using Snail.ViewModels.Common;

namespace Snail.ViewModels.Catalog.CustomerTypes
{
    public class ManageCustomerTypePagingRequest : PagingRequestBase
    {
        public int StoreId { set; get; }
    }
}
