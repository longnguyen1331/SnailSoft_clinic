using SnailApp.ViewModels.Catalog.ProductTypes;
using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;

namespace SnailApp.ViewModels.System.Menus
{
    public class MenuDto: BaseDto
    {
        public int? ParentId { set; get; }
        public string Icon { set; get; }
        public string ParentName { set; get; }
        public string ControllerName { set; get; }
        public string ActionName { set; get; }
        public MenuType MenuType { set; get; }
        public string Link { set; get; }
    }
}