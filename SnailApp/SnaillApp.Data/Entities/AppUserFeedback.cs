using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class AppUserFeedback: BaseEntity
    {
        public Guid AppUserId { set; get; }
        public AppUser AppUser { set; get; }
        public double Rate { set; get; }
    }
}
