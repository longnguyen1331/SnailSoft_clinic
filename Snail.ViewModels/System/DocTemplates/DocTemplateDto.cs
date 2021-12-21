using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snail.ViewModels.Common;
using Snail.ViewModels.Catalog.DocTemplateTypes;
using Snail.ViewModels.Catalog.PaperSizes;

namespace Snail.ViewModels.System.DocTemplates
{
    public class DocTemplateDto: BaseDto
    {
        public string StoreName { set; get; }
        public string StoreAddress { set; get; }
        public string StorePhone { set; get; }
        public string Content { set; get; }
        public DocTemplateTypeDto DocTemplateType { set; get; }
        public PaperSizeDto PaperSize { set; get; }
    }
}
