using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class PromotionTranslation: BaseEntity
    {
        public int PromotionId { set; get; }
        public Promotion Promotion { get; set; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
