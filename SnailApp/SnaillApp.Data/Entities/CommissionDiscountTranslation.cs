using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class CommissionDiscountTranslation: BaseEntity
    {
        public int? CommissionDiscountId { set; get; }
        public CommissionDiscount CommissionDiscount { set; get; }
        public int? LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
