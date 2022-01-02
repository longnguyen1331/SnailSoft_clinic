using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class StoreTranslation: BaseEntity
    {
        public int StoreId { set; get; }
        public Store Store { set; get; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
        public string Address { set; get; }
    }
}
