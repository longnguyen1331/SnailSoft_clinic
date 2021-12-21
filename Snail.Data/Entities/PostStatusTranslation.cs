using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class PostStatusTranslation : BaseEntity 
    {
        public int PostStatusId { set; get; }
        public PostStatus PostStatus { get; set; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
