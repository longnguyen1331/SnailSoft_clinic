using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class WebsiteMenuTranslation: BaseEntity
    {

        public int WebsiteMenuId { set; get; }
        public WebsiteMenu WebsiteMenu { get; set; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
