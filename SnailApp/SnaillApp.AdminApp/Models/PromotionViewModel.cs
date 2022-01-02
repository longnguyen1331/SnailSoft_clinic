using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ViewModels.Sales.Promotions;

namespace SnailApp.AdminApp.Models
{
    public class PromotionViewModel: BaseViewModel
    {
        public PromotionDto Promotion { set; get; }
        public string NoImageAvailable { set; get; }
    }
}
