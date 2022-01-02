using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class Payroll: BaseEntity
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public List<PayrollDetail> PayrollDetails { get; set; }
        public List<PayrollTranslation> PayrollTranslations { get; set; }
    }
}
