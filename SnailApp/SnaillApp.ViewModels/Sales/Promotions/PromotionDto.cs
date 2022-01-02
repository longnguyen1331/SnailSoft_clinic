using System;
using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Sales.Promotions
{
    public class PromotionDto: BaseDto
    {
        public DateTime? FromDate { set; get; }
        public DateTime? ToDate { set; get; }
        public bool IsApply { set; get; }
    }
}
