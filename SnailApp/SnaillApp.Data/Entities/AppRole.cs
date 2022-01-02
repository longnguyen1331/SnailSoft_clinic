using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
        public ICollection<MenuAppRole> MenuRoles { set; get; }
        public List<AppRoleTranslation> AppRoleTranslations { get; set; }
    }
}
