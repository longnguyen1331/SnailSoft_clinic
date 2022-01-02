using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChinoPet.ViewModels.System.ContactInformation;
using ChinoPet.ViewModels.News.Testimonials;
using ChinoPet.ViewModels.Catalog.PetServiceSelections;

namespace ChinoPet.Website.Models
{
    public class HomeViewModel
    {
        public ContactInformationDto ContactInformation { set; get; }
        public List<TestimonialDto> Testimonials { set; get; }
        public List<PetServiceSelectionDto> PetServiceSelections { set; get; }
    }
}
