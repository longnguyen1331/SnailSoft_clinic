using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snail.ViewModels.Common;
using Snail.ViewModels.HR.BasicSalaries;

namespace Snail.ViewModels.HR.AppUser_BasicSalaries
{
    public class AppUser_BasicSalaryDto : BaseDto
    {
        public DateTime? FromDate { set; get; }
        public DateTime? ToDate { set; get; }
        public string StrFromDate { set; get; }
        public string StrToDate { set; get; }
        public bool IsApply { set; get; }
        public int BasicSalaryId { set; get; }
        public string BasicSalaryCode { set; get; }
        public string BasicSalaryName { set; get; }
        public double BasicSalaryValue { set; get; }
        public BasicSalaryDto BasicSalary { set; get; }
    }
}
