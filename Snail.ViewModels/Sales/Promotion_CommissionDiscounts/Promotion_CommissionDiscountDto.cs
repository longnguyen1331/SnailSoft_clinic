﻿using System;
using Snail.ViewModels.Common;
using Snail.ViewModels.Sales.CommissionDiscounts;

namespace Snail.ViewModels.Sales.Promotion_CommissionDiscounts
{
    public class Promotion_CommissionDiscountDto: BaseDto
    {
        public int PromotionId { set; get; }
        public CommissionDiscountDto CommissionDiscount { set; get; }
        public int CommissionDiscountId { set; get; }
        public string CommissionDiscountCode { set; get; }
        public string CommissionDiscountName { set; get; }
        public double CommissionDiscountDiscount { set; get; }
        public double CommissionDiscountDiscountPercent { set; get; }
        public double CommissionDiscountCommission { set; get; }
        public double CommissionDiscountCommissionPercent { set; get; }
    }
}
