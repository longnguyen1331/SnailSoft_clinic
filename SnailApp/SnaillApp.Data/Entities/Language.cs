using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Entities
{
    public class Language: BaseEntity
    {
        public List<MenuTranslation> MenuTranslations { get; set; }
        public List<AppRoleTranslation> AppRoleTranslations { get; set; }
        public ICollection<GenderTranslation> GenderTranslations { get; set; }
    }
}
