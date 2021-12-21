using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class DocTemplate: BaseEntity
    {
        public int? DocTemplateTypeId { set; get; }
        public DocTemplateType DocTemplateType { set; get; }
        public string Content { set; get; }
        public int? PaperSizeId { set; get; }
        public PaperSize PaperSize { set; get; }
    }
}
