using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.ViewModels.Sales.Carts
{
    public class CartRequest
    {
        public int? Id { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
    }
}
