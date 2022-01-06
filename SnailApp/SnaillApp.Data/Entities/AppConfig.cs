using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Entities
{
    public class AppConfig: BaseEntity
    {
        public string Logo { set; get; }
        public string Favicon { set; get; }
        public string Title { set; get; }
        public string Keyword { set; get; }
        public string GoogleScript { set; get; }
        public string FacebookPixel { set; get; }
        public string FacebookChat { set; get; }
        public string Firebase_apiKey { set; get; }
        public string Firebase_authDomain { set; get; }
        public string Firebase_projectId { set; get; }
        public string Firebase_storageBucket { set; get; }
        public string Firebase_messagingSenderId { set; get; }
    }
}
