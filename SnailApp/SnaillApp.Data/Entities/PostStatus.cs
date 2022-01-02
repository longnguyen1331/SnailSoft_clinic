using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class PostStatus : BaseEntity 
    {
        public ICollection<PostStatusTranslation> PostStatusTranslations { set; get; }
        public ICollection<Post> Posts { get; set; }
    }
}
