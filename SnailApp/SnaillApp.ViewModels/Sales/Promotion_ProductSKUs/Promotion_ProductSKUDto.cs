using System;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Catalog.Products;
using SnailApp.ViewModels.Catalog.ProductSKUs;

namespace SnailApp.ViewModels.Sales.Promotion_ProductSKUs
{
    public class Promotion_ProductSKUDto: BaseDto
    {
        public ProductSKUDto ProductSKU { set; get; }
        public int ProductSKUId { set; get; }
        public string ProductSKUCode { set; get; }
        public string ProductSKUName { set; get; }
        public double Discount { set; get; }
        public double DiscountPercent { set; get; }
        public double Commission { set; get; }
        public double CommissionPercent { set; get; }
        public ProductDto Product { set; get; }
    }
}
