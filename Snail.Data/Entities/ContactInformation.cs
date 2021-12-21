using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.Data.Entities
{
    public class ContactInformation : BaseEntity
    {
        public string Address { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string FacebookLink {set;get;}
        public string InstagramLink { set; get; }
        public string YoutubeLink { set; get; }
    }
}
