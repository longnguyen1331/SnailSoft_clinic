using System;
using System.Collections.Generic;
using System.Text;
using Snail.ViewModels.Common;

namespace Snail.ViewModels.System.AppRoles
{
    public class AppRoleDto
    {
        public string Id { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public int LanguageId { set; get; }
    }
}