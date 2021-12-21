using Snail.ViewModels.Catalog.ProductTypes;
using System;
using System.Collections.Generic;
using System.Text;
using Snail.ViewModels.Common;

namespace Snail.ViewModels.Catalog.ProductSKUs
{
    public class ProductSKUDto : BaseDto
    {
        public double Price { set; get; }
        public double BuyingPrice { set; get; }
        public int QtyInStock { set; get; }
    }
}