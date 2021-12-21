using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Snail.ViewModels.Enums;

namespace Snail.ViewModels.News.Posts
{
    public class PostRequest
    {
        public int? Id { set; get; }
        public int LanguageId { set; get; }
        public string Name { set; get; }
        public string Author { set; get; }        
        public string Abstract { set; get; }
        public string Content { set; get; }
        public int? PostTypeId { set; get; }
        public IFormFile ThumbnailImage { set; get; }
        public int? PostStatusId { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
    }
}
