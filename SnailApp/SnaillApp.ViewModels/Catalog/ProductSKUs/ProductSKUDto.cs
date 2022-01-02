using SnailApp.ViewModels.Catalog.ProductTypes;
using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Catalog.ProductSKUs
{
    public class ProductSKUDto : BaseDto
    {
        public double Price { set; get; }
        public double BuyingPrice { set; get; }
        public int QtyInStock { set; get; }
    }
}