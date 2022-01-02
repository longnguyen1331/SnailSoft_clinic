using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Catalog.ProductImages
{
    public class ProductImageDto: BaseDto
    {
        public int ProductId { get; set; }

        public string ImagePath { get; set; }

        public string Caption { get; set; }

        public long FileSize { get; set; }
    }
}