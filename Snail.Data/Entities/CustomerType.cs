using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Entities
{
    public class CustomerType : BaseEntity
    {
        public ICollection<CustomerTypeTranslation> CustomerTypeTranslations { get; set; }
    }
}
