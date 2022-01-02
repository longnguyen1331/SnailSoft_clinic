using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class SlideStatus: BaseEntity
    {
        public ICollection<SlideStatusTranslation> SlideStatusTranslations { set; get; }
        public ICollection<Slide> Slides { get; set; }
    }
}
