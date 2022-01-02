using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Entities
{
    public class ProductInProductType
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
    }
}
