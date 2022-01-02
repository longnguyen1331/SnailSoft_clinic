using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Catalog.Attributes
{
    public class ManageAttributePagingRequest : PagingRequestBase
    {
        public int StoreId { set; get; }
    }
}
