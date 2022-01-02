using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnailApp.ViewModels.Enums;

namespace SnailApp.Data.Entities
{
    public class Menu: BaseEntity
    {
        public int? ParentId { set; get; }
        public string Icon { set; get; }
        public MenuType MenuType { set; get; }
        public string Link { set; get; }
        public string ControllerName { set; get; }
        public string ActionName { set; get; }
        public ICollection<MenuAppRole> MenuRoles { set; get; }
        public ICollection<MenuTranslation> MenuTranslations { set; get; }
    }
}
