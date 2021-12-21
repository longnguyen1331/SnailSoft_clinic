﻿using System;
using System.Collections.Generic;
using System.Text;
using Snail.ViewModels.Common;

namespace Snail.ViewModels.System.MenuAppRoles
{
    public class MenuAppRoleDto
    {
        public int Id { set; get; }
        public string AppRoleId { set; get; }
        public int MenuId { set; get; }
        public string MenuName { set; get; }
        public int MenuAppRoleType { set; get; }
        public bool IsAllow { set; get; }
        public string ControllerName { set; get; }
        public string ActionName { set; get; }
    }
}
