using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class StoreStatusTranslation : BaseEntity 
    {
        public int StoreStatusId { set; get; }
        public StoreStatus StoreStatus { get; set; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
