using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.ViewModels.HR.PayrollDetails
{
    public class PayrollDetailRequest
    {
        public int? Id { set; get; }
        public string FromDate { set; get; }
        public string ToDate { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
        public int PayrollId { set; get; }
    }
}
