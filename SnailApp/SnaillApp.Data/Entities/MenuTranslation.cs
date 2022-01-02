using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class MenuTranslation: BaseEntity
    {
        public int MenuId { set; get; }
        public Menu Menu { get; set; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
