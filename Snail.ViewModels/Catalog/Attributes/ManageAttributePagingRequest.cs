using Snail.ViewModels.Common;

namespace Snail.ViewModels.Catalog.Attributes
{
    public class ManageAttributePagingRequest : PagingRequestBase
    {
        public int StoreId { set; get; }
    }
}
