using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using SnailApp.ViewModels.Catalog.ProductSKUs;
using SnailApp.ViewModels.Catalog.ProductImages;

namespace SnailApp.ViewModels.Catalog.Products
{
    public class ProductImportRequest
    {
        public IFormFile File { get; set; }
        public Guid CreatedUserId{ get; set; }
        public int StoreId { get; set; }
        public int LanguageId { get; set; }
    }
}