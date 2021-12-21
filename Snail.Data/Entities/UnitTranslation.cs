using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Entities
{
    public class UnitTranslation : BaseEntity
    {
        public int UnitId { set; get; }
        public Unit Unit { get; set; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
