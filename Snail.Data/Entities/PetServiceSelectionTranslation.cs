using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class PetServiceSelectionTranslation: BaseEntity
    {
        public int PetServiceSelectionId { set; get; }
        public PetServiceSelection PetServiceSelection { get; set; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
