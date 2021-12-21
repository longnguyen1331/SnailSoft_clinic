using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.ViewModels.Common
{
    public class PagingRequestBase
    {
        public int? PageIndex { get; set; }
        public int PageSize { get; set; }
        public string SearchBy { get; set; }
        public string TextSearch { get; set; }
        public int LanguageId { get; set; }
        public string OrderCol { get; set; }
        public string OrderDir { get; set; }
    }
}