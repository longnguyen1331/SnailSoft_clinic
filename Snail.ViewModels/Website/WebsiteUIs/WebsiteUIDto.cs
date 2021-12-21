using System;
using System.Collections.Generic;
using Snail.ViewModels.Website.WebsiteMenus;
using Snail.ViewModels.System.ContactInformation;

namespace Snail.ViewModels.Website.WebsiteUIs
{
    public class WebsiteUIDto
    {
        public string Logo { set; get; }
        public List<WebsiteMenuDto> Menus { set; get; }
        public ContactInformationDto ContactInformation { set; get; }
    }
}
