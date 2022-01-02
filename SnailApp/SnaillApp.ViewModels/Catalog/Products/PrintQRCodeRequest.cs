using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using SnailApp.ViewModels.Catalog.ProductSKUs;
using SnailApp.ViewModels.Catalog.ProductImages;

namespace SnailApp.ViewModels.Catalog.Products
{
    public class PrintQRCodeRequest
    {
        public int StoreId{ get; set; }
        public string Logo { get; set; }
        public string StoreName { get; set; }
        public string SizeName { get; set; }
        public string Code { get; set; }
        public List<ProductSkuPrintDto> ProductSkuPrints { get; set; }
    }
}