using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;

namespace SnailApp.ViewModels.Website.WebsiteMenus
{
    public class WebsiteMenuDto: BaseDto
    {
        public int? ParentId { set; get; }
        public string Icon { set; get; }
        public string Link { set; get; }
        public int? WebsiteMenuType { set; get; }
    }
}
