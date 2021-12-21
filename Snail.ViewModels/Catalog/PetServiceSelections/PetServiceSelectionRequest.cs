using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.ViewModels.Catalog.PetServiceSelections
{
    public class PetServiceSelectionRequest
    {
        public int? Id { set; get; }
        public string Name { set; get; }
        public int LanguageId { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
    }
}
