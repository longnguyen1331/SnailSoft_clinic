using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class GenderTranslation: BaseEntity
    {
        public int GenderId { set; get; }
        public Gender Gender { get; set; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
