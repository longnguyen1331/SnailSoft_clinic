using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class Booking: BaseEntity
    {
        public string PetName { set; get; }
        public double PetWeight { set; get; }
        public DateTime DateContact { set; get; }
        public int? PetServiceSelectionId { set; get; }
        public PetServiceSelection PetServiceSelection { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string SpecialNote { set; get; }
    }
}
