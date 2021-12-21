using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Snail.ViewModels.News.Posts;
using Snail.ViewModels.Catalog.PostTypes;

namespace Snail.AdminApp.Models
{
    public class PostViewModel : BaseViewModel
    {
        public PostDto Post { set; get; }
        public List<PostTypeDto> PostTypes { set; get; }
    }
}
