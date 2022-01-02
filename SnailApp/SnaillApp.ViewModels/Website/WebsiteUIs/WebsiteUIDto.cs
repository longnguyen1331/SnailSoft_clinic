using System;
using System.Collections.Generic;
using SnailApp.ViewModels.Website.WebsiteMenus;
using SnailApp.ViewModels.System.ContactInformation;

namespace SnailApp.ViewModels.Website.WebsiteUIs
{
    public class WebsiteUIDto
    {
        public string Logo { set; get; }
        public List<WebsiteMenuDto> Menus { set; get; }
        public ContactInformationDto ContactInformation { set; get; }
    }
}
