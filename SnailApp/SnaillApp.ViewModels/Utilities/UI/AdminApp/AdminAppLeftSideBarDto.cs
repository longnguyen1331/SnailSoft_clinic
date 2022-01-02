using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnailApp.ViewModels.System.Menus;

namespace SnailApp.ViewModels.Utilities.UI.AdminApp
{
    public class AdminAppLeftSideBarDto
    {
        public string Logo { set; get; }
        public List<MenuDto> Menus { set; get; }
    }
}
