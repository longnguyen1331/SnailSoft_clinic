using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SnailApp.ViewModels.News.Testimonials
{
    public class TestimonialRequest
    {
        public int? Id { set; get; }
        public int SortOrder { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
        public IFormFile Image { set; get; }
    }
}
