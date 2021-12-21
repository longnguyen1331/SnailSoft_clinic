using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class AppUserStatusTranslation: BaseEntity
    {
        public int AppUserStatusId { set; get; }
        public AppUserStatus AppUserStatus { get; set; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
