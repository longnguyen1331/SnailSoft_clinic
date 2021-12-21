using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Entities
{
    public class Language: BaseEntity
    {
        public ICollection<CustomerTypeTranslation> CustomerTypeTranslations { get; set; }  
        public List<MenuTranslation> MenuTranslations { get; set; }
        public List<ProductTypeTranslation> ProductTypeTranslations { get; set; }
        public List<PostTypeTranslation> PostTypeTranslations { get; set; }
        public List<AttributeTranslation> AttributeTranslations { get; set; }
        public List<PostTranslation> PostTranslations { get; set; }
        public List<ProductTranslation> ProductTranslations { get; set; }
        public List<ManufacturerTranslation> ManufactuerTranslations { get; set; }
        public List<StoreTranslation> StoreTranslations { get; set; }
        public List<UnitTranslation> UnitTranslations { get; set; }
        public List<AppRoleTranslation> AppRoleTranslations { get; set; }
        public ICollection<PostTypeStatusTranslation> StatusTranslations { get; set; }
        public ICollection<ProductTypeStatusTranslation> ProductTypeStatusTranslations { get; set; }
        public ICollection<OrderStatusTranslation> OrderStatusTranslations { get; set; }
        public ICollection<PostStatusTranslation> PostStatusTranslations { get; set; }
        public ICollection<PostTypeStatusTranslation> PostTypeStatusTranslations { get; set; }
        public ICollection<StoreStatusTranslation> StoreStatusTranslations { get; set; }
        public ICollection<PhieuKeToanStatusTranslation> PhieuKeToanStatusTranslations { get; set; }
        public ICollection<AppUserStatusTranslation> AppUserStatusTranslations { get; set; }
        public ICollection<SlideStatusTranslation> SlideStatusTranslations { get; set; }
        public ICollection<SlideTranslation> SlideTranslations { get; set; }
        public ICollection<GenderTranslation> GenderTranslations { get; set; }
        public ICollection<DocTemplateTypeTranslation> DocTemplateTypeTranslations { get; set; }        
        public ICollection<AttributeValueTranslation> AttributeValueTranslations { get; set; }
        public ICollection<AppUserTypeTranslation> AppUserTypeTranslations { get; set; }
        public ICollection<PromotionTranslation> PromotionTranslations { set; get; }
        public ICollection<CommissionDiscountTranslation> CommissionDiscountTranslations { set; get; }
        public ICollection<BasicSalaryTranslation> BasicSalaryTranslations { set; get; }
        public List<PayrollTranslation> PayrollTranslations { get; set; }
        public List<AboutTranslation> AboutTranslations { get; set; }
        public ICollection<WebsiteMenuTranslation> WebsiteMenuTranslations { set; get; }
        public ICollection<PetServiceSelectionTranslation> PetServiceSelectionTranslations { set; get; }
    }
}
