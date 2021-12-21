using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snail.AdminApp.Models
{
    public class SummaryOfReceiptPaymentModel : BaseViewModel
    {
        public double TotalCollectMoney { set;get; }
        public double TotalPaymentMoney { set; get; }
        public double OpeningBalance { set; get; }
    }
}
