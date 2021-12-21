using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class Country : BaseEntity
    {
        public ICollection<AppUser> AppUsers { set; get; }
    }
}
