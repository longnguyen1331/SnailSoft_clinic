using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.ViewModels.Common
{
    public class DeleteRequest
    {
        public List<int> Ids { set; get; }
        public List<Guid> GuidIds { set; get; }
    }
}
