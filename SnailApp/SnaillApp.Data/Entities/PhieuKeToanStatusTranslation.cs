using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class PhieuKeToanStatusTranslation : BaseEntity 
    {
        public int PhieuKeToanStatusId { set; get; }
        public PhieuKeToanStatus PhieuKeToanStatus { get; set; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }
    }
}
