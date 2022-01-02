
namespace SnailApp.Data.Entities
{
    public class SoDuDauKyHangHoa : BaseEntity
    {
        public int Year { set; get; }
        public int QtyInStock { set; get; }
        public int? ProductSKUId{ set; get; }
        public ProductSKU ProductSKU { set; get; }
        public int? StoreId { set; get; }
        public Store Store { set; get; }
    }
}
