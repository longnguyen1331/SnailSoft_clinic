using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class OrderStatus: BaseEntity
    {
        public ICollection<OrderStatusTranslation> OrderStatusTranslations { set; get; }
    }
}
