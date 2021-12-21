using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChinoPet.ViewModels.Website.WebsiteMenus;
using ChinoPet.ViewModels.System.ContactInformation;

namespace ChinoPet.Website.Models
{
    public class TopHeaderViewModel
    {
        public int CurrentLanguageId { set; get; }
        public string Logo { set; get; }
        public List<WebsiteMenuDto> Menus { set; get; }
        public ContactInformationDto ContactInformation { set; get; }
    }
}
