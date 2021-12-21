using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Snail.ViewModels.Catalog.ProductSKUs;
using Snail.ViewModels.Catalog.ProductImages;

namespace Snail.ViewModels.Catalog.Products
{
    public class ProductPrintRespone
    {
        public string ProductName { set; get; }
        public string ProductCode { set; get; }
        public double ProductPrice { set; get; }
        public int Qty{ set; get; }
        public byte[] Bitmap { set; get; }
    }
}