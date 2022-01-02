using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class OrderStatusTranslation : BaseEntity
    { 
        public int OrderStatusId { set; get; }
        public OrderStatus OrderStatus { get; set; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
