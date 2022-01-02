using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.ViewModels.Catalog.AttributeValues
{
    public class AttributeValueRequest
    {
        public int? Id { set; get; }
        public int SortOrder { set; get; }
        public virtual string Code { set; get; }
        public virtual string Name { set; get; }
        public virtual string Description { set; get; }
        public string CreatedDate { set; get; }
        public string ModifiedDate { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
        public int AttributeId { set; get; }
        public bool IsDeleted { set; get; }
        public bool IsDefault { set; get; }
        public bool IsVisibled { set; get; }
        public int LanguageId { set; get; }
    }
}