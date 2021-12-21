using System;
using Snail.ViewModels.Common;

namespace Snail.ViewModels.Sales.Promotions
{
    public class PromotionDto: BaseDto
    {
        public DateTime? FromDate { set; get; }
        public DateTime? ToDate { set; get; }
        public bool IsApply { set; get; }
    }
}
