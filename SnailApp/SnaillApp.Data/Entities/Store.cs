using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Enums;

namespace SnailApp.Data.Entities
{
    public class Store : BaseEntity
    {
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public string Website { get; set; }
        public string Taxcode { get; set; }
        public string Logo { get; set; }
        public int? StoreStatusId { get; set; }
        public StoreStatus StoreStatus { get; set; }
        public ICollection<StoreTranslation> StoreTranslations { set; get; }
    }
}
