using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.System.AppRoles
{
    public class AppRoleDto
    {
        public string Id { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public int LanguageId { set; get; }
        public int Type { set; get; }
    }
}