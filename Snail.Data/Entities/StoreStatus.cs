using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class StoreStatus : BaseEntity 
    {
        public ICollection<StoreStatusTranslation> StoreStatusTranslations { set; get; }
        public ICollection<Store> Stores { get; set; }
    }
}
