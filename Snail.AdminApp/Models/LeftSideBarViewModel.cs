using Snail.ViewModels.System.Menus;
using System.Collections.Generic;

namespace Snail.AdminApp.Models
{
    public class LeftSideBarViewModel
    {
        public List<MenuDto> Menus { set; get; }
        public string HtmlMenus { set; get; }
        public string Logo { set; get; }
    }
}
