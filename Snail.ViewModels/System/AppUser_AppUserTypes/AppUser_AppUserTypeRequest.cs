using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.ViewModels.System.AppUser_AppUserTypes
{
    public class AppUser_AppUserTypeRequest
    {
        public string AppUserId { set; get; }
        public int AppUserTypeId { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
    }
}
