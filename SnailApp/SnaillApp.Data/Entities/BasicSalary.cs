using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class BasicSalary: BaseEntity
    {
        public double Value { set; get; }
        public DateTime FromDate { set; get; }
        public DateTime? ToDate { set; get; }
        public bool IsApply { set; get; }
        public ICollection<BasicSalaryTranslation> BasicSalaryTranslations { set; get; }
    }
}
