
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Snail.Data.Entities
{
    public class ProductSKU : BaseEntity
    {
        public double Price { set; get; }
        public double BuyingPrice { set; get; }
        public int QtyInStock { set; get; }
        public int ProductId { set; get; }
        public Product Product { set; get; }
        public ICollection<ProductSKU_AttributeValue> ProductSKU_AttributeValues { get; set; }
        public ICollection<Promotion_ProductSKU> Promotion_ProductSKUs { set; get; }
    }
}
