using System;
using System.Collections.Generic;
using SnailApp.ViewModels.Catalog.ProductTypes;

namespace SnailApp.AdminApp.Models
{
    public class ProductTypeViewModel : BaseViewModel
    {
        public List<ProductTypeDto> ProductTypeDtos { set; get; }
    }
}
