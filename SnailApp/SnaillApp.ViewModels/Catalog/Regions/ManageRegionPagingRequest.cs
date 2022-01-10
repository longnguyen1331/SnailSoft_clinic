using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Catalog.Regions
{
    public class ManageRegionPagingRequest: PagingRequestBase
    {
        public int Level { get; set; }
        public int? ParentId { get; set; }
    }
}
