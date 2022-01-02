using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class PayrollDetail: BaseEntity
    {
        public int PayrollId { set; get; }
        public Payroll Payroll { get; set; }
        public Guid AppUserId { set; get; }
        public AppUser AppUser { set; get; }
        public double BasicSalary { set; get; }
        public double Commission { set; get; }
        public double Discount { set; get; }
        public double Total { set; get; }
    }
}
