using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.HR.BasicSalaries
{
    public class BasicSalaryDto: BaseDto
    {
        public double Value { set; get; }
        public DateTime? FromDate { set; get; }
        public DateTime? ToDate { set; get; }
        public string StrFromDate { set; get; }
        public string StrToDate { set; get; }
        public bool IsApply { set; get; }
    }
}
