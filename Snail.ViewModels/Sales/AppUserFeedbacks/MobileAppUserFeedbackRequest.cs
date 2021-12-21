using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.ViewModels.Sales.AppUserFeedbacks
{
    public class MobileAppUserFeedbackRequest
    {
        public int? Id { set; get; }
        public string UserId { set; get; }
        public string Note { set; get; }
        public double Rate { set; get; }
    }
}
