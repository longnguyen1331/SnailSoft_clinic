using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class PostTypeStatusTranslation : BaseEntity
    {
        public int PostTypeStatusId { set; get; }
        public PostTypeStatus PostTypeStatus { set; get; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
