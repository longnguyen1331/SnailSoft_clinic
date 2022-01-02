using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnailApp.ViewModels.Enums;

namespace SnailApp.Data.Entities
{
    public class PostTypeStatus: BaseEntity
    {
        public ICollection<PostTypeStatusTranslation> PostTypeStatusTranslations { get; set; }
        public ICollection<PostType> PostTypes { get; set; }        
    }
}
