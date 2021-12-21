using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.ViewModels.Catalog.Manufacturers
{
    public class ManufacturerRequest
    {
        public int? Id { get; set; }
        public string Name { set; get; }
        public int LanguageId { set; get; }
        public virtual string Description { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
        
    }
}
