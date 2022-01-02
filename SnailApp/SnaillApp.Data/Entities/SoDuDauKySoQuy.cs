
namespace SnailApp.Data.Entities
{
    public class SoDuDauKySoQuy : BaseEntity
    {
        public int Year { set; get; }
        public float Total { set; get; }
        public int? StoreId{ set; get; }
        public Store Store { set; get; }
    }
}
