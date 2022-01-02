using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.System.ContactInformation
{
    public class ContactInformationDto: BaseDto
    {
        public string Email { set; get; }
        public string Address { set; get; }
        public string PhoneNumber { set; get; }
        public string FacebookLink { set; get; }
        public string InstagramLink { set; get; }
        public string YoutubeLink { set; get; }
    }
}
