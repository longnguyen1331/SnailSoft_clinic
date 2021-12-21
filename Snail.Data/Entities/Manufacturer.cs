using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Entities
{
    public class Manufacturer : BaseEntity
    {
        public ICollection<ManufacturerTranslation> ManufacturerTranslations { get; set; }
    }
}
