using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class Promotion_CommissionDiscount: BaseEntity
    {
        public int PromotionId { set; get; }
        public Promotion Promotion { set; get; }
        public int CommissionDiscountId { set; get; }
        public CommissionDiscount CommissionDiscount { set; get; }
    }
}
