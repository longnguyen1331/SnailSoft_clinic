using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Entities
{
    public class ProductTypeTranslation: BaseEntity
    {
        public int ProductTypeId { set; get; }
        public ProductType ProductType { get; set; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
        public string SeoAlias { set; get; }
    }
}
