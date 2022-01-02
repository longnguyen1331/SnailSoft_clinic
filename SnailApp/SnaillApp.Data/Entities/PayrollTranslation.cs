using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class PayrollTranslation: BaseEntity
    {
        public int PayrollId { set; get; }
        public Payroll Payroll { get; set; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
