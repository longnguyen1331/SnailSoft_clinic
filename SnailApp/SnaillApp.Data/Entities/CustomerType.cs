using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Entities
{
    public class CustomerType : BaseEntity
    {
        public ICollection<CustomerTypeTranslation> CustomerTypeTranslations { get; set; }
    }
}
