using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Snail.ViewModels.Catalog.ProductSKUs;
using Snail.ViewModels.Catalog.ProductImages;

namespace Snail.ViewModels.Catalog.Products
{
    public class ProductImportRequest
    {
        public IFormFile File { get; set; }
        public Guid CreatedUserId{ get; set; }
        public int StoreId { get; set; }
        public int LanguageId { get; set; }
    }
}