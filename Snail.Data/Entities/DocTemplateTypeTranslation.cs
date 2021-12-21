using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class DocTemplateTypeTranslation: BaseEntity
    {
        public int? DocTemplateTypeId { set; get; }
        public DocTemplateType DocTemplateType { set; get; }
        public int? LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
