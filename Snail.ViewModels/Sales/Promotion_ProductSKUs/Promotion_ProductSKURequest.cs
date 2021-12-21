using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.ViewModels.Sales.Promotion_ProductSKUs
{
    public class Promotion_ProductSKURequest
    {
        public int? Id { set; get; }
        public int ProductSKUId { set; get; }
        public int PromotionId { set; get; }
        public int LanguageId { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
        public double Discount { set; get; }
        public double DiscountPercent { set; get; }
        public double Commission { set; get; }
        public double CommissionPercent { set; get; }
    }
}
