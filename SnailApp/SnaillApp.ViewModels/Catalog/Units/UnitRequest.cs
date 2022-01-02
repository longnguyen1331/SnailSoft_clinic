using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SnailApp.ViewModels.Common;
namespace SnailApp.ViewModels.Catalog.Units
{
    public class UnitRequest
    {
        public int? Id { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public int LanguageId { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
    }
}
