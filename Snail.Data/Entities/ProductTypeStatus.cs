using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class ProductTypeStatus: BaseEntity
    {
        public ICollection<ProductTypeStatusTranslation> ProductTypeStatusTranslations { set; get; }
        public ICollection<ProductType> ProductTypes { get; set; }
    }
}
