using SnailApp.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Entities
{
    public class About : BaseEntity
    {
       
        public List<AboutTranslation> AboutTranslations { get; set; }

    }
}