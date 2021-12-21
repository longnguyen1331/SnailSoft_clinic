using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class SlideTranslation: BaseEntity
    {
        public int SlideId { set; get; }
        public Slide Slide { set; get; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
