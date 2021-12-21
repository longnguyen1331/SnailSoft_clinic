using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class BasicSalaryTranslation: BaseEntity
    {
        public int BasicSalaryId { set; get; }
        public BasicSalary BasicSalary { get; set; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
