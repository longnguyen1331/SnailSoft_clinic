using Snail.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Entities
{
    public class Attribute : BaseEntity
    {
        public ICollection<AttributeTranslation> AttributeTranslations { get; set; }
        public ICollection<AttributeValue> AttributeValues { get; set; }
    }
}
