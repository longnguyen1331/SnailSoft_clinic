using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Entities
{
    public class AttributeTranslation : BaseEntity
    {
        public int AttributeId { set; get; }
        public Attribute Attribute { get; set; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
        public string SeoAlias { set; get; }

    }
}
