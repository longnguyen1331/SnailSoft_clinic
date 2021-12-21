using Snail.ViewModels.Accountants.PhieuKeToans;
using Snail.ViewModels.Catalog.ProductSKUs;
using Snail.ViewModels.System.Users;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snail.AdminApp.Models
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
