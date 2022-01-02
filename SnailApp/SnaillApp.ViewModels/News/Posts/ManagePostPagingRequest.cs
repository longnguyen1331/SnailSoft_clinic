using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.News.Posts
{
    public class ManagePostPagingRequest : PagingRequestBase
    {
        public string PostTypeAlias { set; get; }
        public int? PostTypeId { get; set; }
        public int? PostStatusId { set; get; }
    }
}
