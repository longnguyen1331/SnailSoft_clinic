using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class AppUserType: BaseEntity
    {
        public ICollection<AppUserTypeTranslation> AppUserTypeTranslations { set; get; }
        public ICollection<AppUser_AppUserType> AppUser_AppUserTypes { set; get; }
    }
}
