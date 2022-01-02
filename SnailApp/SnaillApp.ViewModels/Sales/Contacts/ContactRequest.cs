using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.ViewModels.Sales.Contacts
{
    public class ContactRequest
    {
        public int? Id { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string Message { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
    }
}
