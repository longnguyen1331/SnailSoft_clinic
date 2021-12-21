
namespace Snail.ViewModels.Accountants.PhieuKeToans
{
    public class ReportWarehouseDto
    {
        public int  Id { set; get; }
        public int QtyInStock { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string ProductTypeName { set; get; }
        public string ProductTypeId { set; get; }
        public double Price { set; get; }
        public double BuyingPrice { set; get; }
    }
}

