using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class ProductTypeStatusTranslation: BaseEntity
    {
        public int ProductTypeStatusId { set; get; }
        public ProductTypeStatus ProductTypeStatus { get; set; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
