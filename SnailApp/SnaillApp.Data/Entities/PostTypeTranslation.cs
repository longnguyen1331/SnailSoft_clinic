using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class PostTypeTranslation: BaseEntity
    {
        public int PostTypeId { set; get; }
        public PostType PostType { set; get; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }
    }
}
