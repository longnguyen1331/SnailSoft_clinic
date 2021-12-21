using Snail.ViewModels.Catalog.ProductTypes;
using System;
using System.Collections.Generic;
using System.Text;
using Snail.ViewModels.Common;
using Snail.ViewModels.Enums;

namespace Snail.ViewModels.System.Menus
{
    public class MenuDto: BaseDto
    {
        public int? ParentId { set; get; }
        public string Icon { set; get; }
        public MenuType MenuType { set; get; }
        public string Link { set; get; }
    }
}