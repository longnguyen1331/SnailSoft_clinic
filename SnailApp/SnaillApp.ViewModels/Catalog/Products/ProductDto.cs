using SnailApp.ViewModels.Catalog.ProductTypes;
using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Catalog.Products
{
    public class ProductDto: BaseDto
    {
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public double LowerPrice { set; get; }
        public double HigherPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public bool IsHasSKU { get; set; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }
        public bool? IsFeatured { get; set; }
        public string ThumbnailImage { get; set; }
        public int? ManufactuerId { get; set; }
        public int? AttributeId { get; set; }
        public string AttributeName { get; set; }
        public string ManufactuerName { get; set; }
        
        public string ProductTypeName { get; set; }
        public bool AllowSellWhenNotEnough { get; set; }
        public int? ProductSKUId { get; set; }
        public int? ProductAttributeId { get; set; }
        public int? InventoryWarning { get; set; }
        public string ProductTypeIds { get; set; }
        public string ProductImages { get; set; }
        public string ProductImageSizes { get; set; }
        
        //public List<string> ProductTypes { get; set; } = new List<string>();
    }
}