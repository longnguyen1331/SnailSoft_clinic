using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Catalog.Attributes
{
    public class ManageAttributeValuePagingRequest : PagingRequestBase
    {
        public int? AttributeId { set; get; }
    }
}
