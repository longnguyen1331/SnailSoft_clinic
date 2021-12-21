using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Entities
{
    public class Cart: BaseEntity
    {
        public int Quantity { set; get; }
        public decimal Price { set; get; }
        public int ProductId { set; get; }
        public Product Product { get; set; }
        public Guid UserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
