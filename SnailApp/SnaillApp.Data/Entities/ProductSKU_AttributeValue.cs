
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SnailApp.Data.Entities
{
    public class ProductSKU_AttributeValue
    {
        [Key]
        public int Id { set; get; }
        public int AttributeValueId { set; get; }
        public AttributeValue AttributeValue { set; get; }
        public int ProductSKUId { set; get; }
        public ProductSKU ProductSKU { set; get; }
    }
}
