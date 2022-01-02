using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.ViewModels.System.Users
{
    public class MobileUserRegisterRequest
    {
        public string FullName { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public string RegisterDate { set; get; }
        public string AppUserTypeCodes { set; get; }
    }
}
