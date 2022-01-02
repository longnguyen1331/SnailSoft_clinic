using System;
using SnailApp.ViewModels.Catalog.Products;

namespace SnailApp.AdminApp.Models
{
    public class ProductViewModel : BaseViewModel
    {
        public bool IsProduct { set; get; } // true là hàng hóa, false là dịch vụ
        public ProductDto Product { set; get; }
    }
}
