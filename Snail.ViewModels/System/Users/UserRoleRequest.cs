using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.ViewModels.System.Users
{
    public class UserRoleRequest
    {
        public int? LanguageId { set; get; }
        public string UserId { set; get; }
        public string ControllerName { set; get; }
        public string ActionName { set; get; }
    }
}
