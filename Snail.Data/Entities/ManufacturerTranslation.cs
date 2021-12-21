using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class ManufacturerTranslation: BaseEntity
    {
        public int ManufacturerId { set; get; }
        public Manufacturer Manufacturer { set; get; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
