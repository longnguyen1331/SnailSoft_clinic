using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class PostTranslation: BaseEntity
    {
        public int PostId { set; get; }
        public Post Post { get; set; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
        public string Abstract { set; get; }
        public string Content { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }
    }
}
