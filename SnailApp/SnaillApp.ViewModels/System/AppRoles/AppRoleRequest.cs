using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.ViewModels.System.AppRoles
{
    public class AppRoleRequest
    {
        public string Id { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public int Type { set; get; }
        public string Description { set; get; }
        public int LanguageId { set; get; }
        public Guid CreatedUserId { set; get; }
        public Guid ModifiedUserId { set; get; }

    }
}
