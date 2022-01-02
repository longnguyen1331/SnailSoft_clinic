using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class CommissionDiscount : BaseEntity
    {
        public double CommissionPercent { set; get; }
        public double Commission { set; get; }
        public double DiscountPercent { set; get; }
        public double Discount { set; get; }
        public DateTime FromDate { set; get; }
        public DateTime? ToDate { set; get; }
        public bool IsApply { set; get; }
        public ICollection<CommissionDiscountTranslation> CommissionDiscountTranslations { set; get; }
        public ICollection<AppUser_CommissionDiscount> AppUser_CommissionDiscounts { set; get; }
        public ICollection<Promotion_CommissionDiscount> Promotion_CommissionDiscounts { set; get; }
    }
}
