using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.ViewModels.HR.AppUser_BasicSalaries
{
    public class AppUser_BasicSalaryRequest
    {
        public int? Id { set; get; }
        public string Code { set; get; }
        public string Name{ set; get; }
        public string FromDate { set; get; }
        public string ToDate { set; get; }
        public bool IsApply { set; get; }
        public string AppUserId { set; get; }
        public int BasicSalaryId { set; get; }
        public int LanguageId { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
    }
}
