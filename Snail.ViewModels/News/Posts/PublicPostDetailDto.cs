using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.ViewModels.News.Posts
{
    public class PublicPostDetailDto
    {
        public PostDto Post { set; get; }
        public List<PostDto> RecentPosts { set; get; }
    }
}
