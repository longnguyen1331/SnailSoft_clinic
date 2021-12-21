using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Snail.ViewModels.System.Users;

namespace Snail.AdminApp.Models
{
    public class BaseViewModel
    {
        public UserDto CurrentUserRole { set; get; }
        public string PageTitle { set; get; }
        public List<string> Breadcrumbs { set; get; }
    }
}