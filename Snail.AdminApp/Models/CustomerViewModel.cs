using Snail.ViewModels.Accountants.PhieuKeToans;
using Snail.ViewModels.Catalog.ProductSKUs;
using Snail.ViewModels.System.Users;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Snail.AdminApp.Models
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
