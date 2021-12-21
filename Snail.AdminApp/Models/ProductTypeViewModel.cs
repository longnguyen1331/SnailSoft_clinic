using System;
using System.Collections.Generic;
using Snail.ViewModels.Catalog.ProductTypes;

namespace Snail.AdminApp.Models
{
    public class ProductTypeViewModel : BaseViewModel
    {
        public List<ProductTypeDto> ProductTypeDtos { set; get; }
    }
}
