using SnailApp.ViewModels.Accountants.PhieuKeToans;
using SnailApp.ViewModels.Catalog.ProductSKUs;
using SnailApp.ViewModels.System.Users;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace SnailApp.AdminApp.Models
{
    public class CustomerViewModel : BaseViewModel
    {
        public UserDto Customer { set; get; }
        public List<PhieuKeToanDto> PhieuKeToans { set; get; }
        public List<ProductSKUDto> ProductSKus { set; get; }

        public List<SelectListItem> AppRoles { get; set; }
        public string FileNoImagePerson { set; get; }
    }
}
