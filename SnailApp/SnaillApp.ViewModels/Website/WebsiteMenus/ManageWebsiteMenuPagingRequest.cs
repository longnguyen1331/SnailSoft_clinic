using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;

namespace SnailApp.ViewModels.Website.WebsiteMenus
{
    public class ManageWebsiteMenuPagingRequest : PagingRequestBase
    {
        public int? WebsiteMenuType { set; get; }
    }
}
