using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snail.ViewModels.Common;

namespace Snail.ViewModels.System.AppUser_AppUserTypes
{
    public class AppUser_AppUserTypeDto: BaseDto
    {
        public string AppUserId { set; get; }
        public int AppUserTypeId { set; get; }
        public string AppUserTypeName { set; get; }
    }
}
