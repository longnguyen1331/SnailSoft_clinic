using SnailApp.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Entities
{
    public class Promotion: BaseEntity
    {
        public DateTime FromDate { set; get; }
        public DateTime? ToDate { set; get; }
        public ICollection<PromotionTranslation> PromotionTranslations { set; get; }
        public bool IsApply { set; get; }
        public ICollection<Promotion_CommissionDiscount> Promotion_CommissionDiscounts { set; get; }
        public ICollection<Promotion_ProductSKU> Promotion_ProductSKUs { set; get; }
        public ICollection<AppUser_Promotion> AppUser_Promotions { set; get; }
    }
}
