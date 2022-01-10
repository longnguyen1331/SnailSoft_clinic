
namespace SnailApp.Data.Entities
{
    public class Service : BaseEntity
    {
        public string Image { set; get; }
        public decimal Charges { set; get; }
        public int ServiceTypeId { set; get; }
        public virtual ServiceType ServiceTypes { set; get; }
        public int ClinicId { set; get; }
    }
}
