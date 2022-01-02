using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class PaperSize: BaseEntity
    {
        public double Value { set; get; }
        public ICollection<DocTemplate> DocTemplates { set; get; }
    }
}
