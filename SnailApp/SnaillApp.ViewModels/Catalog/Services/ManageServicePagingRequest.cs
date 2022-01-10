using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Catalog.Services
{
    public class ManageServicePagingRequest : PagingRequestBase
    {
        public int ServiceTypeId { set; get; }
        public int ClinicId { set; get; }
    }
}
