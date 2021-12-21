using Snail.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Entities
{
    public class About : BaseEntity
    {
       
        public List<AboutTranslation> AboutTranslations { get; set; }

    }
}