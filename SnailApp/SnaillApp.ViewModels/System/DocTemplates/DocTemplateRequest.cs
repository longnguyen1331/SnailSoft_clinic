using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.ViewModels.System.DocTemplates
{
    public class DocTemplateRequest
    {
        public int? StoreId { set; get; }
        public int? Id { set; get; }
        public string Name { set; get; }
        public string Content { set; get; }
        public string DocTemplateCode { set; get; }
        public int? DocTemplateTypeId { set; get; }
        public int? LanguageId { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
        public bool IsDefault { set; get; }
        public int PaperSizeId { set; get; }
    }
}
