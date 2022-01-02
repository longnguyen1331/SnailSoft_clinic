using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class AppUserTypeTranslation: BaseEntity
    {
        public int AppUserTypeId { set; get; }
        public AppUserType AppUserType { get; set; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
