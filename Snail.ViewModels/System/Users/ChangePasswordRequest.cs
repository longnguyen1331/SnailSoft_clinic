using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.ViewModels.System.Users
{
    public class ChangePasswordRequest
    {
        public Guid Id { set; get; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
