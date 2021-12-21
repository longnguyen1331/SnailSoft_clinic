using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snail.ViewModels.Common;

namespace Snail.ViewModels.HR.Payrolls
{
    public class PayrollDto: BaseDto
    {
        public string StrFromDate { set; get; }
        public string StrToDate { set; get; }
        public DateTime FromDate { set; get; }
        public DateTime ToDate { set; get; }
        public double BasicSalary { set; get; }
        public double Commission { set; get; }
        public double Discount { set; get; }
        public double Total { set; get; }
    }
}
