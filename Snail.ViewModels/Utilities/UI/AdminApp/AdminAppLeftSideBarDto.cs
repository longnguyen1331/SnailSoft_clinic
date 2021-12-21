using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snail.ViewModels.System.Menus;

namespace Snail.ViewModels.Utilities.UI.AdminApp
{
    public class AdminAppLeftSideBarDto
    {
        public string Logo { set; get; }
        public List<MenuDto> Menus { set; get; }
    }
}
