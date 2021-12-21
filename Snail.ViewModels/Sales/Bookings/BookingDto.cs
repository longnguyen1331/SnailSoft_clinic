using Snail.ViewModels.Common;
using Snail.ViewModels.Catalog.PetServiceSelections;

namespace Snail.ViewModels.Sales.Bookings
{
    public class BookingDto: BaseDto
    {
        public PetServiceSelectionDto PetServiceSelection { set; get; }
        public string Email { set; get; }
        public string PetName { set; get; }
        public double PetWeight { set; get; }
        public string StrDateContact { set; get; }
        public string SpecialNote { set; get; }
        public string PhoneNumber { set; get; }
        public int? PetServiceSelectionId { set; get; }
    }
}
