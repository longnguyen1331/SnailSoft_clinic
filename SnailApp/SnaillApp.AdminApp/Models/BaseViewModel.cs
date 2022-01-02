using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SnailApp.ViewModels.System.Users;

namespace SnailApp.AdminApp.Models
{
    public class BaseViewModel
    {
        public UserDto CurrentUserRole { set; get; }
        public string PageTitle { set; get; }
        public List<string> Breadcrumbs { set; get; }
    }
}