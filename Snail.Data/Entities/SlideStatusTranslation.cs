using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class SlideStatusTranslation: BaseEntity
    {
        public int SlideStatusId { set; get; }
        public SlideStatus SlideStatus { get; set; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
