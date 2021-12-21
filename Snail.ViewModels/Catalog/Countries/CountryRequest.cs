using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.ViewModels.Catalog.Countries
{
    public class CountryRequest
    {
        public int? Id { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedDate { set; get; }
    }
}
