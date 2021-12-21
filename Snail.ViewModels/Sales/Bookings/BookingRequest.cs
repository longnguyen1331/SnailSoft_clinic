using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.ViewModels.Sales.Bookings
{
    public class BookingRequest
    {
        public int? Id { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string PetName { set; get; }
        public double PetWeight { set; get; }
        public string DateContact { set; get; }
        public int? PetServiceSelectionId { set; get; }
        public string SpecialNote { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
    }
}
