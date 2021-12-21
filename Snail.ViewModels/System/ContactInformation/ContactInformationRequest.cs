using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.ViewModels.System.ContactInformation
{
    public class ContactInformationRequest
    {
        public int? Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public string PhoneNumber { set; get; }
        public string FacebookLink { set; get; }
        public string InstagramLink { set; get; }
        public string YoutubeLink { set; get; }
        public bool IsDefault { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
    }
}
