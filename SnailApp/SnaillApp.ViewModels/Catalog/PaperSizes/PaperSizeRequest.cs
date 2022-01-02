using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.ViewModels.Catalog.PaperSizes
{
    public class PaperSizeRequest
    {
        public int? Id { set; get; }
        public string Name { set; get; }
        public double Value { set; get; }
        public Guid CreatedUserId { set; get; }
        public Guid ModifiedUserId { set; get; }
        public int LanguageId { set; get; }
    }
}
