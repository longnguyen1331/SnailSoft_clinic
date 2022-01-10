using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Catalog.ServiceTypes
{
    public class ServiceTypeDto : BaseDto
    {
        public string Image { set; get; }
        public int ClinicId { set; get; }
    }
}
