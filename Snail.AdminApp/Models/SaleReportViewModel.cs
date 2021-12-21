using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snail.AdminApp.Models
{
    public class SaleReportViewModel : BaseViewModel
    {
        public double TotalDebt { set; get; }
        public double TotalMoney { set; get; }
        public int TotoalOrder{ set; get; }
        public int TotoalReturn { set; get; }
    }
}
