using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Snail.ViewModels.Sales.Promotions;

namespace Snail.AdminApp.Models
{
    public class PromotionViewModel: BaseViewModel
    {
        public PromotionDto Promotion { set; get; }
        public string NoImageAvailable { set; get; }
    }
}
