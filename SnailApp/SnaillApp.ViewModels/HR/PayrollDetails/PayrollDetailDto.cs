using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.System.Users;

namespace SnailApp.ViewModels.HR.PayrollDetails
{
    public class PayrollDetailDto: BaseDto
    {
        public string AppUserFirstName { set; get; }
        public string AppUserLastName { set; get; }
        public double BasicSalary { set; get; }
        public double Commission { set; get; }
        public double Discount { set; get; }
        public double Total { set; get; }
    }
}
