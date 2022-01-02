using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ViewModels.HR.Payrolls;

namespace SnailApp.AdminApp.Models
{
    public class PayrollViewModel: BaseViewModel
    {
        public PayrollDto Payroll { set; get; }
    }
}
