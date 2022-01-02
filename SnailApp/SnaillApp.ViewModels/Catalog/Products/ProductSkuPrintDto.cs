using SnailApp.ViewModels.Catalog.ProductTypes;
using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Catalog.Products
{
    public class ProductSkuPrintDto
    {
        public int ProductSKUId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public double ProductPrice { get; set; }
        public int Qty { get; set; }
        
    }
}