using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class WebsiteMenu: BaseEntity
    {
        public int? ParentId { set; get; }
        public string Icon { set; get; }
        public string Link { set; get; }
        public int WebsiteMenuType { set; get; } //1: Menu, 2: Service
        public ICollection<WebsiteMenuTranslation> WebsiteMenuTranslations { set; get; }
    }
}
