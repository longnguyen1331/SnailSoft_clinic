using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.ViewModels.HR.BasicSalaries
{
    public class BasicSalaryRequest
    {
        public int? Id { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public double Value { set; get; }
        public string FromDate { set; get; }
        public string ToDate { set; get; }
        public bool IsApply { set; get; }
        public int LanguageId { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
    }
}
