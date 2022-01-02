using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Catalog.PetServiceSelections;

namespace SnailApp.ViewModels.Sales.Bookings
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
