using System;
using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Sales.CommissionDiscounts
{
    public class CommissionDiscountDto: BaseDto
    {
        public double CommissionPercent { set; get; }
        public double Commission { set; get; }
        public double DiscountPercent { set; get; }
        public double Discount { set; get; }
        public DateTime? FromDate { set; get; }
        public DateTime? ToDate { set; get; }
        public string StrFromDate { set; get; }
        public string StrToDate { set; get; }
        public bool IsApply { set; get; }
    }
}
