using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Sales.Contacts
{
    public class ContactDto: BaseDto
    {
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string Message { set; get; }
    }
}
