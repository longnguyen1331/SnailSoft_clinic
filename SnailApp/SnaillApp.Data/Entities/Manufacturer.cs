using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Entities
{
    public class Manufacturer : BaseEntity
    {
        public ICollection<ManufacturerTranslation> ManufacturerTranslations { get; set; }
    }
}
