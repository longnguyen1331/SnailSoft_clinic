using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class AppUser_CommissionDiscount: BaseEntity
    {
        public Guid AppUserId { set; get; }
        public AppUser AppUser { set; get; }
        public int CommissionDiscountId { set; get; }
        public CommissionDiscount CommissionDiscount { set; get; }
        public DateTime? FromDate { set; get; }
        public DateTime? ToDate { set; get; }
        public bool IsApply { set; get; }
    }
}
