using SnailApp.ViewModels.System.Menus;
using System.Collections.Generic;

namespace SnailApp.AdminApp.Models
{
    public class LeftSideBarViewModel
    {
        public List<MenuDto> Menus { set; get; }
        public string HtmlMenus { set; get; }
        public string Logo { set; get; }
    }
}
