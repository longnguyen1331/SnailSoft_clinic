using Snail.ViewModels.Common;

namespace Snail.ViewModels.Catalog.Attributes
{
    public class ManageAttributeValuePagingRequest : PagingRequestBase
    {
        public int? AttributeId { set; get; }
    }
}
