using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ViewModels.News.Posts;
using SnailApp.ViewModels.Catalog.PostTypes;

namespace SnailApp.AdminApp.Models
{
    public class PostViewModel : BaseViewModel
    {
        public PostDto Post { set; get; }
        public List<PostTypeDto> PostTypes { set; get; }
    }
}
