using Snail.Data.Configurations;
using Snail.Data.Entities;
using Snail.Data.Extensions;
using Snail.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Snail.Data.EF
{
    public class EShopDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public EShopDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            modelBuilder.ApplyConfiguration(new AboutConfiguration());
            modelBuilder.ApplyConfiguration(new AboutTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppUser_AppUserTypeConfiguration());
            modelBuilder.ApplyConfiguration(new AppUser_BasicSalaryConfiguration());            
            modelBuilder.ApplyConfiguration(new AppUser_CommissionDiscountConfiguration());
            modelBuilder.ApplyConfiguration(new AppUser_PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserFeedbackConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserHelpConfiguration());            
            modelBuilder.ApplyConfiguration(new AppUserStatusConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserStatusTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserTypeConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserTypeTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new AttributeConfiguration());
            modelBuilder.ApplyConfiguration(new AttributeTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new AttributeValueConfiguration());
            modelBuilder.ApplyConfiguration(new AttributeValueTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new BasicSalaryConfiguration());
            modelBuilder.ApplyConfiguration(new BasicSalaryTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new BookingConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new CommissionDiscountConfiguration());
            modelBuilder.ApplyConfiguration(new CommissionDiscountTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new ContactInformationConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerTypeTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new DocTemplateConfiguration());
            modelBuilder.ApplyConfiguration(new DocTemplateTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DocTemplateTypeTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new FavoriteProductConfiguration());            
            modelBuilder.ApplyConfiguration(new GenderConfiguration());
            modelBuilder.ApplyConfiguration(new GenderTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new ManufacturerConfiguration());
            modelBuilder.ApplyConfiguration(new ManufacturerTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new MenuAppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new MenuConfiguration());
            modelBuilder.ApplyConfiguration(new MenuTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new NewsletterConfiguration());
            modelBuilder.ApplyConfiguration(new OrderStatusConfiguration());
            modelBuilder.ApplyConfiguration(new OrderStatusTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new PaperSizeConfiguration());
            modelBuilder.ApplyConfiguration(new PayrollConfiguration());
            modelBuilder.ApplyConfiguration(new PayrollDetailConfiguration());
            modelBuilder.ApplyConfiguration(new PayrollTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new PetServiceSelectionConfiguration());
            modelBuilder.ApplyConfiguration(new PetServiceSelectionTranslationConfiguration());            
            modelBuilder.ApplyConfiguration(new PhieuKeToanConfiguration());
            modelBuilder.ApplyConfiguration(new PhieuKeToanChiTietConfiguration());
            modelBuilder.ApplyConfiguration(new PhieuKeToanStatusConfiguration());
            modelBuilder.ApplyConfiguration(new PhieuKeToanStatusTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new PostImageConfiguration());
            modelBuilder.ApplyConfiguration(new PostStatusConfiguration());
            modelBuilder.ApplyConfiguration(new PostStatusTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new PostTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new PostTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PostTypeTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new PostTypeStatusConfiguration());
            modelBuilder.ApplyConfiguration(new PostTypeStatusTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInProductTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductSKUConfiguration());
            modelBuilder.ApplyConfiguration(new ProductSKU_AttributeValueConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTypeTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTypeStatusConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTypeStatusTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new Promotion_CommissionDiscountConfiguration());
            modelBuilder.ApplyConfiguration(new Promotion_ProductSKUConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new SlideConfiguration());
            modelBuilder.ApplyConfiguration(new SlideStatusConfiguration());
            modelBuilder.ApplyConfiguration(new SlideStatusTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new SlideTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new StoreConfiguration());
            modelBuilder.ApplyConfiguration(new StoreStatusConfiguration());
            modelBuilder.ApplyConfiguration(new StoreStatusTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new StoreTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new TestimonialConfiguration());            
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new UnitConfiguration());
            modelBuilder.ApplyConfiguration(new UnitTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new SoDuDauKySoQuyConfiguration());
            modelBuilder.ApplyConfiguration(new SoDuDauKyHangHoaConfiguration());
            modelBuilder.ApplyConfiguration(new PhieuKeToanChiTiet_AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new WebsiteMenuConfiguration());
            modelBuilder.ApplyConfiguration(new WebsiteMenuTranslationConfiguration());

            //Data seeding
            modelBuilder.Seed();
            //base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<About> Abouts{ get; set; }
        public DbSet<AboutTranslation> AboutTranslations { get; set; }
        public DbSet<AppConfig> AppConfigs { get; set; }
        public DbSet<AppRoleTranslation> AppRoleTranslations { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }        
        public DbSet<AppUser_AppUserType> AppUser_AppUserTypes { get; set; }
        public DbSet<AppUser_BasicSalary> AppUser_BasicSalarys { get; set; }
        public DbSet<AppUser_CommissionDiscount> AppUser_CommissionDiscounts { get; set; }
        public DbSet<AppUser_Promotion> AppUser_Promotions { get; set; }
        public DbSet<AppUserFeedback> AppUserFeedbacks { get; set; }
        public DbSet<AppUserHelp> AppUserHelps { get; set; }        
        public DbSet<AppUserStatus> AppUserStatuses { get; set; }
        public DbSet<AppUserStatusTranslation> AppUserStatusTranslations { get; set; }
        public DbSet<AppUserType> AppUserTypes { get; set; }
        public DbSet<AppUserTypeTranslation> AppUserTypeTranslations { get; set; }
        public DbSet<Data.Entities.Attribute> Attributes { get; set; }
        public DbSet<AttributeTranslation> AttributeTranslations { get; set; }
        public DbSet<Data.Entities.AttributeValue> AttributeValues { get; set; }
        public DbSet<AttributeValueTranslation> AttributeValueTranslations { get; set; }
        public DbSet<BasicSalary> BasicSalarys { get; set; }
        public DbSet<BasicSalaryTranslation> BasicSalaryTranslations { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CommissionDiscount> CommissionDiscounts { get; set; }
        public DbSet<CommissionDiscountTranslation> CommissionDiscountTranslations { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactInformation> ContactInformation { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<CustomerTypeTranslation> CustomerTypeTranslations { get; set; }
        public DbSet<DocTemplate> DocTemplates { get; set; }
        public DbSet<DocTemplateType> DocTemplateTypes { get; set; }
        public DbSet<DocTemplateTypeTranslation> DocTemplateTypeTranslations { get; set; }
        public DbSet<FavoriteProduct> FavoriteProducts { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<GenderTranslation> GenderTranslations { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<ManufacturerTranslation> ManufacturerTranslations { get; set; }
        public DbSet<MenuAppRole> MenuAppRoles { get; set; }
        public DbSet<MenuTranslation> MenuTranslations { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }        
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<OrderStatusTranslation> OrderStatusTranslations { get; set; }
        public DbSet<PaperSize> PaperSizes { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<PayrollDetail> PayrollDetails { get; set; }
        public DbSet<PayrollTranslation> PayrollTranslations { get; set; }
        public DbSet<PetServiceSelection> PetServiceSelections { get; set; }
        public DbSet<PetServiceSelectionTranslation> PetServiceSelectionTranslations { get; set; }        
        public DbSet<PhieuKeToanStatus> PhieuKeToanStatuses { get; set; }
        public DbSet<PhieuKeToanStatusTranslation> PhieuKeToanStatusTranslations { get; set; }        
        public DbSet<PhieuKeToan> PhieuKeToans { get; set; }
        public DbSet<PhieuKeToanChiTiet> PhieuKeToanChiTiets { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostImage> PostImages { get; set; }
        public DbSet<PostStatus> PostStatuses { get; set; }
        public DbSet<PostStatusTranslation> PostStatusTranslations { get; set; }
        public DbSet<PostTranslation> PostTranslations { get; set; }
        public DbSet<PostType> PostTypes { get; set; }
        public DbSet<PostTypeTranslation> PostTypeTranslations { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductInProductType> ProductInProductTypes { get; set; }
        public DbSet<ProductSKU> ProductSKUs { get; set; }
        public DbSet<ProductSKU_AttributeValue> ProductSKU_AttributeValues { get; set; }
        public DbSet<ProductTranslation> ProductTranslations { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductTypeTranslation> ProductTypeTranslations { get; set; }
        public DbSet<ProductTypeStatus> ProductTypeStatuses { get; set; }
        public DbSet<ProductTypeStatusTranslation> ProductTypeStatusTranslations { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Promotion_CommissionDiscount> Promotion_CommissionDiscounts { get; set; }
        public DbSet<PromotionTranslation> PromotionTranslations { get; set; }
        public DbSet<Promotion_ProductSKU> Promotion_ProductSKUs { get; set; }        
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SlideStatus> SlideStatuses { get; set; }
        public DbSet<SlideStatusTranslation> SlideStatusTranslations { get; set; }
        public DbSet<SlideTranslation> SlideTranslations { get; set; }
        public DbSet<PostTypeStatus> PostTypeStatuses { get; set; }
        public DbSet<PostTypeStatusTranslation> PostTypeStatusTranslations { get; set; }        
        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreTranslation> StoreTranslations { get; set; }
        public DbSet<StoreStatus> StoreStatuses { get; set; }
        public DbSet<StoreStatusTranslation> StoreStatusTranslations { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UnitTranslation> UnitTranslations { get; set; }
        public DbSet<SoDuDauKySoQuy> SoDuDauKySoQuys { get; set; }
        public DbSet<SoDuDauKyHangHoa> SoDuDauKyHangHoas { get; set; }
        public DbSet<PhieuKeToanChiTiet_AppUser> PhieuKeToanChiTiet_AppUsers { get; set; }
        public DbSet<WebsiteMenu> WebsiteMenus { get; set; }
        public DbSet<WebsiteMenuTranslation> WebsiteMenuTranslations { get; set; }


    }
}
