using System;
using System.Collections.Generic;
using SnailApp.ViewModels.Website.WebsiteMenus;

namespace SnailApp.ViewModels.Website.Blogs
{
    public class WebsiteBlogDto
    {
        public string Logo { set; get; }
        public List<WebsiteMenuDto> Menus { set; get; }
    }
}
