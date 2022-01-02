using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Entities
{
    public class ProductImage: BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string Image { get; set; }
        public string Caption { get; set; }
        public long FileSize { get; set; }
    }
}
