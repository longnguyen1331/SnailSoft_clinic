using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.ViewModels.News.PostImages
{
    public class PostImageDto
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public string Image { get; set; }

        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public DateTime CreatedDate { get; set; }

        public int SortOrder { get; set; }

        public long FileSize { get; set; }
    }
}
