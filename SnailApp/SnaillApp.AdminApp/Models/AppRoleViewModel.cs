using System;
using System.Collections.Generic;
using SnailApp.ViewModels.System.Menus;

namespace SnailApp.AdminApp.Models
{
    public class AppRoleViewModel: BaseViewModel
    {
        public List<MenuDto> Menus { set; get; }
    }
}
