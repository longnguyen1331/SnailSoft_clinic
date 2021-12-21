using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snail.ViewModels.Common;

namespace Snail.ViewModels.HR.AppUser_BasicSalaries
{
    public class ManageAppUser_BasicSalaryPagingRequest: PagingRequestBase
    {
        public string AppUserId { set; get; }
    }
}
