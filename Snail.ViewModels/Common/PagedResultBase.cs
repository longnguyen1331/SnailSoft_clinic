using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.ViewModels.Common
{
    public class PagedResultBase
    {
        public int? PageIndex { get; set; }

        public int PageSize { get; set; }

        public int TotalRecords { get; set; }
        public string Message { set; get; }

        public int PageCount
        {
            get
            {
                var pageCount = (PageIndex != null ? (double)TotalRecords / PageSize : 1);
                return (int)Math.Ceiling(pageCount);
            }
        }
    }
}