using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class AppUserStatus: BaseEntity
    {
        public ICollection<AppUserStatusTranslation> AppUserStatusTranslations { set; get; }
        public ICollection<AppUser> AppUsers { get; set; }
    }
}
