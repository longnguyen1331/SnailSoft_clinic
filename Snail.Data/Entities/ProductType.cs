using Snail.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Entities
{
    public class ProductType: BaseEntity
    {
        public bool IsShowOnHome { set; get; }
        public int? ParentId { set; get; }
        public int? ProductTypeStatusId { set; get; }
        public ProductTypeStatus ProductTypeStatus { set; get; }
        public Store Store { set; get; }
        public List<ProductInProductType> ProductInProductTypes { get; set; }
        public List<ProductTypeTranslation> ProductTypeTranslations { get; set; }


    }
}
