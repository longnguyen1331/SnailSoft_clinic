using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snail.AdminApp.Models
{
    public class LoginViewModel
    {
        public string Logo { set; get; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool RememberMe { get; set; }
        public string Message { set; get; }
    }
}
