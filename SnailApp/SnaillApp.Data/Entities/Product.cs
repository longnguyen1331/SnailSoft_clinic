using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SnailApp.Data.Entities
{
    public class Product: BaseEntity
    {
        public decimal Price { set; get; } // buying
        public decimal OriginalPrice { set; get; } // import
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public bool? IsFeatured { get; set; }
        public bool? IsPOS { get; set; }
        public bool? IsWeb { get; set; }
        public bool? AllowSellWhenNotEnough { get; set; }
        public int? InventoryWarning { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public string ProductTitle { get; set; }
        public string ShortDescription { get; set; }
        public int? ManufactuerId { get; set; }
        public bool IsHasSKU { get; set; }
        public Manufacturer Manufactuer { set; get; }
        public ICollection<ProductInProductType> ProductInProductTypes { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<ProductTranslation> ProductTranslations { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<ProductSKU> ProductSKUs { get; set; }
        public ICollection<FavoriteProduct> FavoriteProducts { set; get; }
    }
}