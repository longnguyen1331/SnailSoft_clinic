using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class Country : BaseEntity
    {
        public ICollection<AppUser> AppUsers { set; get; }
    }
}
