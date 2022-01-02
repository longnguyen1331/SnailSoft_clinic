using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class PhieuKeToanStatus : BaseEntity 
    {
        public ICollection<PhieuKeToanStatusTranslation> PhieuKeToanStatusTranslations { set; get; }
        public ICollection<PhieuKeToan> PhieuKeToans { get; set; }
    }
}
