using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using SnailApp.ViewModels.System.Users;

namespace SnailApp.AdminApp.Models
{
    public class StaffViewModel: BaseViewModel
    {
        public UserDto Staff { set; get; }
        public List<SelectListItem> AppRoles { get; set; }
        public string FileNoImagePerson { set; get; }
    }
}
