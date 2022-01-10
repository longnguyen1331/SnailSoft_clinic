using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Catalog.ServiceTypes
{
    public class ManageServiceTypePagingRequest : PagingRequestBase
    {
        public int ClinicId { set; get; }
    }
}
