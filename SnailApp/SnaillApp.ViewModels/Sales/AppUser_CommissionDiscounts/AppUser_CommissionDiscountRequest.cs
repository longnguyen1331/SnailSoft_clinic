using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.ViewModels.Sales.AppUser_CommissionDiscounts
{
    public class AppUser_CommissionDiscountRequest
    {
        public int? Id { set; get; }
        public int CommissionDiscountId { set; get; }
        public string AppUserId { set; get; }
        public string FromDate { set; get; }
        public string ToDate { set; get; }
        public bool IsApply { set; get; }
        public int LanguageId { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
    }
}
