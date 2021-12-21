using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snail.ViewModels.Enums;

namespace Snail.Data.Entities
{
    public class PostTypeStatus: BaseEntity
    {
        public ICollection<PostTypeStatusTranslation> PostTypeStatusTranslations { get; set; }
        public ICollection<PostType> PostTypes { get; set; }        
    }
}
