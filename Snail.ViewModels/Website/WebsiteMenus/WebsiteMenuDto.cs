using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snail.ViewModels.Common;
using Snail.ViewModels.Enums;

namespace Snail.ViewModels.Website.WebsiteMenus
{
    public class WebsiteMenuDto: BaseDto
    {
        public int? ParentId { set; get; }
        public string Icon { set; get; }
        public string Link { set; get; }
        public int? WebsiteMenuType { set; get; }
    }
}
