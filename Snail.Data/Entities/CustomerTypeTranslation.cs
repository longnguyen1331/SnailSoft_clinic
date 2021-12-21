using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class CustomerTypeTranslation : BaseEntity 
    {
        public int CustomerTypeId { set; get; }
        public CustomerType CustomerType { set; get; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
