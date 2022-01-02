using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Catalog.CustomerTypes
{
    public class ManageCustomerTypePagingRequest : PagingRequestBase
    {
        public int StoreId { set; get; }
    }
}
