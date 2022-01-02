using System;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Sales.CommissionDiscounts;

namespace SnailApp.ViewModels.Sales.AppUser_CommissionDiscounts
{
    public class AppUser_CommissionDiscountDto: BaseDto
    {
        public CommissionDiscountDto CommissionDiscount { set; get; }
        public int CommissionDiscountId { set; get; }
        public string CommissionDiscountCode { set; get; }
        public string CommissionDiscountName { set; get; }
        public double CommissionDiscountDiscount { set; get; }
        public double CommissionDiscountDiscountPercent { set; get; }
        public double CommissionDiscountCommission { set; get; }
        public double CommissionDiscountCommissionPercent { set; get; }
        public double Commission { set; get; }
        public double Discount { set; get; }
        public DateTime? FromDate { set; get; }
        public DateTime? ToDate { set; get; }
        public string StrFromDate { set; get; }
        public string StrToDate { set; get; }
        public bool IsApply { set; get; }
    }
}
