using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using SnailApp.ViewModels.Catalog.ProductSKUs;
using SnailApp.ViewModels.Catalog.ProductImages;

namespace SnailApp.ViewModels.Catalog.Products
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