using Snail.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Entities
{
    public class Post: BaseEntity
    {
        public string Author { set; get; }
        public int ViewCount { set; get; }
        public int? PostTypeId { set; get; }
        public PostType PostType { set; get; }
        public int? PostStatusId { set; get; }
        public PostStatus PostStatus { set; get; }
        public List<PostTranslation> PostTranslations { get; set; }
        public List<PostImage> PostImages { get; set; }
    }
}
