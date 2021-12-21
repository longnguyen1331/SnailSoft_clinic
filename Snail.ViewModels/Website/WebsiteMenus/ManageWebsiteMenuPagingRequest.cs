using Snail.ViewModels.Common;
using Snail.ViewModels.Enums;

namespace Snail.ViewModels.Website.WebsiteMenus
{
    public class ManageWebsiteMenuPagingRequest : PagingRequestBase
    {
        public int? WebsiteMenuType { set; get; }
    }
}
