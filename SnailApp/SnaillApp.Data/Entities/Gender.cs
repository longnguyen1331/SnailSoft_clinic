using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class Gender: BaseEntity
    {
        public ICollection<GenderTranslation> GenderTranslations { set; get; }
    }
}
