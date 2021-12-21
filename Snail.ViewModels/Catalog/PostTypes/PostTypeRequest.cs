using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snail.ViewModels.Enums;

namespace Snail.ViewModels.Catalog.PostTypes
{
    public class PostTypeRequest
    {
        public int? Id { get; set; }
        public string Name { set; get; }
        public int LanguageId { set; get; }
        public int PostTypeStatusId { set; get; }
        public Guid CreatedUserId { set; get; }
        public Guid ModifiedUserId { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }
    }
}
