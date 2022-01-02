using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ViewModels.System.DocTemplates;
using SnailApp.ViewModels.Catalog.PaperSizes;

namespace SnailApp.AdminApp.Models
{
    public class DocTemplateViewModel: BaseViewModel
    {
        public DocTemplateDto DocTemplate { set; get; }
        public List<PaperSizeDto> PaperSizes { set; get; }
    }
}
