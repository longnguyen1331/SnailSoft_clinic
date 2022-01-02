using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class Promotion_ProductSKU: BaseEntity
    {
        public int PromotionId { set; get; }
        public Promotion Promotion { set; get; }
        public int ProductSKUId { set; get; }
        public ProductSKU ProductSKU { set; get; }
        public double DiscountPercent { set; get; }
        public double Discount { set; get; }
        public double CommissionPercent { set; get; }
        public double Commission { set; get; }
    }
}
