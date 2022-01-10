using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Catalog.Services
{
    public class ServiceDto : BaseDto
    {
        public decimal Charges { set; get; }
        public string Image { set; get; }
        public int ClinicId { set; get; }
        public string ServiceTypeName { set; get; }
        public int ServiceTypeId { set; get; }
    }
}
