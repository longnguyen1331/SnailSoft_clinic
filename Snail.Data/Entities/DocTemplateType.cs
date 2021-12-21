using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class DocTemplateType: BaseEntity
    {
        public ICollection<DocTemplate> DocTemplates { set; get; }
        public ICollection<DocTemplateTypeTranslation> DocTemplateTypeTranslations { set; get; }
    }
}
