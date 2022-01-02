using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.ViewModels.News.PostImages
{
    public class PostImageRequest
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public int SortOrder { get; set; }
        public IFormFile ImageFile { get; set; }
        public int PostId { set; get; }
    }
}
