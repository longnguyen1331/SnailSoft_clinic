using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class PetServiceSelection: BaseEntity
    {
        public ICollection<Booking> Bookings { set; get; }
        public ICollection<PetServiceSelectionTranslation> PetServiceSelectionTranslations { set; get; }
    }
}
