using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Snail.ViewModels.HR.Payrolls;

namespace Snail.AdminApp.Models
{
    public class PayrollViewModel: BaseViewModel
    {
        public PayrollDto Payroll { set; get; }
    }
}
