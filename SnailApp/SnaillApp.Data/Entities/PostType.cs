using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnailApp.ViewModels.Enums;

namespace SnailApp.Data.Entities
{
    public class PostType: BaseEntity
    {
        public int? ParentId { set; get; }
        public int? PostTypeStatusId { set; get; }
        public PostTypeStatus PostTypeStatus { set; get; }
        public ICollection<Post> Posts { set; get; }
        public ICollection<PostTypeTranslation> PostTypeTranslations { set; get; }
    }
}
