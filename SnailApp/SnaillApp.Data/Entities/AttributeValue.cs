using SnailApp.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Entities
{
    public class AttributeValue : BaseEntity
    {
        public int? AttributeId { set; get; }
        public Attribute Attribute { get; set; }
        public ICollection<AttributeValueTranslation> AttributeValueTranslations { get; set; }
    }
}
