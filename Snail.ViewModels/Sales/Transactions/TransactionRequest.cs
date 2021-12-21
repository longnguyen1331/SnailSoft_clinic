using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.ViewModels.Sales.Transactions
{
    public class TransactionRequest
    {
        public int? Id { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
    }
}
