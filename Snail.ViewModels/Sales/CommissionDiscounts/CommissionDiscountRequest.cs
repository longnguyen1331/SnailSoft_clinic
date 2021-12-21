using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.ViewModels.Sales.CommissionDiscounts
{
    public class CommissionDiscountRequest
    {
        public int? Id { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public double CommissionPercent { set; get; }
        public double Commission { set; get; }
        public double DiscountPercent { set; get; }
        public double Discount { set; get; }
        public int LanguageId { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
        public string FromDate { set; get; }
        public string ToDate { set; get; }
        public bool IsApply { set; get; }
    }
}
