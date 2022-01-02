using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class Unit: BaseEntity
    {
        public ICollection<UnitTranslation> UnitTranslations { set; get; }

    }
}
