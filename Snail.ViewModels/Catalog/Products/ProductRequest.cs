using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Snail.ViewModels.Catalog.ProductSKUs;
using Snail.ViewModels.Catalog.ProductImages;

namespace Snail.ViewModels.Catalog.Products
{
    public class ProductRequest 
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm")]
        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }
        public bool IsProduct { get; set; }
        public int LanguageId { set; get; }
        public bool? IsFeatured { get; set; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
        public int ViewCount { set; get; }
        public bool? IsPOS { get; set; }
        public bool? IsWeb { get; set; }
        public bool? AllowSellWhenNotEnough { get; set; }
        public bool IsHasSKU { get; set; }
        public int? InventoryWarning { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public string ProductTitle { get; set; }
        public string ShortDescription { get; set; }
        public int? ManufactuerId { get; set; }
        public int? AttributeId { get; set; }
        public List<int> ProductInType { get; set; }
        public string Logo { get; set; }
        public string StoreName { get; set; }
        public List<ProductImageDto> ProductImages { get; set; }
        public List<ProductSKU_AttributeValueDto> ProductSKU_AttributeValues { get; set; }
        public List<ProductSkuPrintDto> ProductSkuPrints { get; set; }
    }
}