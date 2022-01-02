using SnailApp.ViewModels.Accountants.PhieuKeToans;
using SnailApp.ViewModels.Catalog.ProductSKUs;
using SnailApp.ViewModels.System.Users;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnailApp.AdminApp.Models
{
    public class SupplierViewModel : BaseViewModel
    {
        public UserDto Supplier { set; get; }
        public List<PhieuKeToanDto> PhieuKeToans { set; get; }
        public List<ProductSKUDto> ProductSKus { set; get; }
        public List<SelectListItem> AppRoles { get; set; }
        public string FileNoImagePerson { set; get; }
    }
}
