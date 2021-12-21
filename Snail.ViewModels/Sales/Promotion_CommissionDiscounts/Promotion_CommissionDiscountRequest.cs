using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.ViewModels.Sales.Promotion_CommissionDiscounts
{
    public class Promotion_CommissionDiscountRequest
    {
        public int? Id { set; get; }
        public int CommissionDiscountId { set; get; }
        public int PromotionId { set; get; }
        public int LanguageId { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
    }
}
