using Snail.ViewModels.Enums;

namespace Snail.ViewModels.System.MenuAppRoles
{
    public class MenuAppRoleRequest
    {
        public string AppRoleId { set; get; }
        public int MenuId { set; get; }
        public int MenuAppRoleType { set; get; }
        public bool IsAllow { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
    }
}