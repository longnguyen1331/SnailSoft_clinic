using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class AppRoleTranslation : BaseEntity
    {
        public Guid AppRoleId { set; get; }
        public AppRole AppRole { set; get; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
