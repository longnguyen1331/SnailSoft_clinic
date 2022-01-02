using SnailApp.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Entities
{
    public class Attribute : BaseEntity
    {
        public ICollection<AttributeTranslation> AttributeTranslations { get; set; }
        public ICollection<AttributeValue> AttributeValues { get; set; }
    }
}
