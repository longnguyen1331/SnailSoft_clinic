using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Snail.ViewModels.System.DocTemplates;
using Snail.ViewModels.Catalog.PaperSizes;

namespace Snail.AdminApp.Models
{
    public class DocTemplateViewModel: BaseViewModel
    {
        public DocTemplateDto DocTemplate { set; get; }
        public List<PaperSizeDto> PaperSizes { set; get; }
    }
}
