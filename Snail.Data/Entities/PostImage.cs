using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class PostImage : BaseEntity
    {
        public int PostId { get; set; }
        public Post Post { get; set; }
        public string Image { get; set; }
        public long FileSize { get; set; }
    }
}
