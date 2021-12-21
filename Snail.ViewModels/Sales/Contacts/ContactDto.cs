using Snail.ViewModels.Common;

namespace Snail.ViewModels.Sales.Contacts
{
    public class ContactDto: BaseDto
    {
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string Message { set; get; }
    }
}
