using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class AppUser_BasicSalary: BaseEntity
    {
        public Guid AppUserId { set; get; }
        public AppUser AppUser { set; get; }
        public int BasicSalaryId { set; get; }
        public BasicSalary BasicSalary { set; get; }
        public DateTime? FromDate { set; get; }
        public DateTime? ToDate { set; get; }
        public bool IsApply { set; get; }
    }
}
