using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Entities
{
    public class ProductTranslation: BaseEntity
    {
        public int ProductId { set; get; }
        public Product Product { get; set; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
