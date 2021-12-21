using System;
using System.Collections.Generic;
using Snail.ViewModels.Website.WebsiteMenus;

namespace Snail.ViewModels.Website.Blogs
{
    public class WebsiteBlogDto
    {
        public string Logo { set; get; }
        public List<WebsiteMenuDto> Menus { set; get; }
    }
}
