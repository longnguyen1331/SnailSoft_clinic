using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.System.DocTemplates
{
    public class ManageDocTemplatePagingRequest: PagingRequestBase
    {
        public int? StoreId { set; get; }
        public int? DocTemplateTypeId { set; get; }
        public string DocTemplateCode { set; get; }
    }
    
}
