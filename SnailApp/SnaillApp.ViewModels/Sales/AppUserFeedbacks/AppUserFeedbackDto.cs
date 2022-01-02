using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Sales.AppUserFeedbacks
{
    public class AppUserFeedbackDto: BaseDto
    {
        public string UserId { set; get; }
        public double Rate { set; get; }
    }
}
