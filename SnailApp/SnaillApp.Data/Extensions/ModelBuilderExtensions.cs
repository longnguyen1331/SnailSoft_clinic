using SnailApp.Data.Entities;
using SnailApp.ViewModels.Enums;
using SnailApp.Data.EF;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace SnailApp.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Languages
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = 1, Code = "vi", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = 2, Code = "en", Name = "English", IsDefault = false}
            );

            //OrderStatus
            modelBuilder.Entity<OrderStatus>().HasData(
                new OrderStatus() { Id = 1, Code = "InProgress" },
                new OrderStatus() { Id = 2, Code = "Confirmed" },
                new OrderStatus() { Id = 3, Code = "Shipping" },
                new OrderStatus() { Id = 4, Code = "Success"},
                new OrderStatus() { Id = 5, Code = "Canceled" }
            );
            modelBuilder.Entity<OrderStatusTranslation>().HasData(
                new OrderStatusTranslation() { Id = 1, OrderStatusId = 1, Name = "InProgress", LanguageId = 1 },
                new OrderStatusTranslation() { Id = 2, OrderStatusId = 1, Name = "InProgress", LanguageId = 2 },
                new OrderStatusTranslation() { Id = 3, OrderStatusId = 2, Name = "Confirmed", LanguageId = 1 },
                new OrderStatusTranslation() { Id = 4, OrderStatusId = 2, Name = "Confirmed", LanguageId = 2 },
                new OrderStatusTranslation() { Id = 5, OrderStatusId = 3, Name = "Shipping", LanguageId = 1 },
                new OrderStatusTranslation() { Id = 6, OrderStatusId = 3, Name = "Shipping", LanguageId = 2 },
                new OrderStatusTranslation() { Id = 7, OrderStatusId = 4, Name = "Success", LanguageId = 1 },
                new OrderStatusTranslation() { Id = 8, OrderStatusId = 4, Name = "Success", LanguageId = 2 },
                new OrderStatusTranslation() { Id = 9, OrderStatusId = 5, Name = "Canceled", LanguageId = 1 },
                new OrderStatusTranslation() { Id = 10, OrderStatusId = 5, Name = "Canceled", LanguageId = 2 }
            );

            //PostStatus
            modelBuilder.Entity<PostStatus>().HasData(
                new PostStatus() { Id = 1, Code = "InActive" },
                new PostStatus() { Id = 2, Code = "Active" }
            );
            modelBuilder.Entity<PostStatusTranslation>().HasData(
                new PostStatusTranslation() { Id = 1, PostStatusId = 1, Name = "Chưa kích hoạt", LanguageId = 1 },
                new PostStatusTranslation() { Id = 2, PostStatusId = 1, Name = "InActive", LanguageId = 2 },
                new PostStatusTranslation() { Id = 3, PostStatusId = 2, Name = "Đang hoạt động", LanguageId = 1 },
                new PostStatusTranslation() { Id = 4, PostStatusId = 2, Name = "Active", LanguageId = 2 }
            );

            //PostType
            modelBuilder.Entity<PostType>().HasData(
                new PostType() { Id = 1, Code = "CNTT" },
                new PostType() { Id = 2, Code = "CNSH" }
            );
            modelBuilder.Entity<PostTypeTranslation>().HasData(
                new PostTypeTranslation() { Id = 1, PostTypeId = 1, Name = "Công nghệ thông tin", LanguageId = 1, SeoAlias ="cong-nghe-thong-tin" },
                new PostTypeTranslation() { Id = 2, PostTypeId = 1, Name = "It", LanguageId = 2, SeoAlias = "it" },
                new PostTypeTranslation() { Id = 3, PostTypeId = 2, Name = "Công nghệ sinh học", LanguageId = 1, SeoAlias = "cong-nghe-sinh-hoc" },
                new PostTypeTranslation() { Id = 4, PostTypeId = 2, Name = "Biotechnology", LanguageId = 2, SeoAlias = "biotechnology" }
            );

            //ProductTypeStatus
            modelBuilder.Entity<ProductTypeStatus>().HasData(
               new ProductTypeStatus() { Id = 1, Code = "InActive" },
               new ProductTypeStatus() { Id = 2, Code = "Active" }
            );
            modelBuilder.Entity<ProductTypeStatusTranslation>().HasData(
                new ProductTypeStatusTranslation() { Id = 1, ProductTypeStatusId = 1, Name = "Chưa kích hoạt", LanguageId = 1 },
                new ProductTypeStatusTranslation() { Id = 2, ProductTypeStatusId = 1, Name = "InActive", LanguageId = 2 },
                new ProductTypeStatusTranslation() { Id = 3, ProductTypeStatusId = 2, Name = "Đang hoạt động", LanguageId = 1 },
                new ProductTypeStatusTranslation() { Id = 4, ProductTypeStatusId = 2, Name = "Active", LanguageId = 2 }
            );

            //StoreStatus
            modelBuilder.Entity<StoreStatus>().HasData(
               new StoreStatus() { Id = 1, Code = "Active" },
               new StoreStatus() { Id = 2, Code = "Repair" },
               new StoreStatus() { Id = 3, Code = "TemporarilyClosed" },
               new StoreStatus() { Id = 4, Code = "Closed" }
            );
            modelBuilder.Entity<StoreStatusTranslation>().HasData(
                new StoreStatusTranslation() { Id = 1, StoreStatusId = 1, Name = "Đang hoạt động", LanguageId = 1 },
                new StoreStatusTranslation() { Id = 2, StoreStatusId = 1, Name = "Active", LanguageId = 2 },
                new StoreStatusTranslation() { Id = 3, StoreStatusId = 2, Name = "Đang sữa chửa", LanguageId = 1 },
                new StoreStatusTranslation() { Id = 4, StoreStatusId = 2, Name = "Repair", LanguageId = 2 },
                new StoreStatusTranslation() { Id = 5, StoreStatusId = 3, Name = "Tạm thời đóng cửa", LanguageId = 1 },
                new StoreStatusTranslation() { Id = 6, StoreStatusId = 3, Name = "TemporarilyClosed", LanguageId = 2 },
                new StoreStatusTranslation() { Id = 7, StoreStatusId = 4, Name = "Đã đóng cửa", LanguageId = 1 },
                new StoreStatusTranslation() { Id = 8, StoreStatusId = 4, Name = "Closed", LanguageId = 2 }
            );

     
            //SlideStatus
            modelBuilder.Entity<SlideStatus>().HasData(
               new SlideStatus() { Id = 1, Code = "InActive" },
               new SlideStatus() { Id = 2, Code = "Active" }
            );
            modelBuilder.Entity<SlideStatusTranslation>().HasData(
                new SlideStatusTranslation() { Id = 1, SlideStatusId = 1, Name = "Chưa kích hoạt", LanguageId = 1 },
                new SlideStatusTranslation() { Id = 2, SlideStatusId = 1, Name = "InActive", LanguageId = 2 },
                new SlideStatusTranslation() { Id = 3, SlideStatusId = 2, Name = "Đang hoạt động", LanguageId = 1 },
                new SlideStatusTranslation() { Id = 4, SlideStatusId = 2, Name = "Active", LanguageId = 2 }
            );

            //ProductType
            modelBuilder.Entity<ProductType>().HasData(
                new ProductType(){ Id = 1, IsShowOnHome = true, ParentId = null, SortOrder = 1, ProductTypeStatusId = 2},
                new ProductType(){ Id = 2, IsShowOnHome = true, ParentId = null, SortOrder = 2, ProductTypeStatusId = 2}
            );

            modelBuilder.Entity<ProductTypeTranslation>().HasData(
                new ProductTypeTranslation() { Id = 1, ProductTypeId = 1, Name = "Hàng hóa", LanguageId = 1, SeoAlias = "hang-hoa", SeoDescription = "Hàng hóa bán được", SeoTitle = "Hàng hóa bán được" },
                new ProductTypeTranslation() { Id = 2, ProductTypeId = 1, Name = "Product", LanguageId = 2, SeoAlias = "product", SeoDescription = "product", SeoTitle = "product" },
                new ProductTypeTranslation() { Id = 3, ProductTypeId = 2, Name = "Dịch vụ", LanguageId = 1, SeoAlias = "dich-vu", SeoDescription = "Dịch vụ", SeoTitle = "Dịch vụ" },
                new ProductTypeTranslation() { Id = 4, ProductTypeId = 2, Name = "Service", LanguageId = 2, SeoAlias = "service", SeoDescription = "service", SeoTitle = "service" }
            );

            //AppRoles
            var storeManagerRoleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var generalManagerRoleId = new Guid("8D04DCE2-969A-435D-BBA5-DF3F325983DC");
            var warehouseStaffRoleId = new Guid("8D04DCE2-969A-435D-BBA6-DF3F325983DC");
            var cashierRoleId = new Guid("8D04DCE2-969A-435D-BBA7-DF3F325983DC");
            var shopAssistantRoleId = new Guid("8D04DCE2-969A-435D-BBA8-DF3F325983DC");
            var branchManagerRoleId = new Guid("8D04DCE2-969A-435D-BBA9-DF3F325983DC");
            var administratorRoleId = new Guid("8D04DCE2-969A-435D-BBA3-DF3F325983DC");
            
            modelBuilder.Entity<AppRole>().HasData(
                new AppRole{ Id = storeManagerRoleId, Name = "StoreManager", NormalizedName = "StoreManager", Description = "Quản lý cửa hàng"}, 
                new AppRole{ Id = generalManagerRoleId, Name = "Manager", NormalizedName = "manager",Description = "Quản lý"},
                new AppRole{ Id = warehouseStaffRoleId, Name = "WarehouseStaff", NormalizedName = "WarehouseStaff",Description = "Nhân viên kho"},
                new AppRole{ Id = cashierRoleId, Name = "Cashier", NormalizedName = "Cashier", Description = "Nhân viên thu ngân"},
                new AppRole{ Id = shopAssistantRoleId, Name = "ShopAssistant", NormalizedName = "ShopAssistant",Description = "Nhân viên bán hàng"},
                new AppRole{ Id = branchManagerRoleId, Name = "BranchManager", NormalizedName = "BranchManager", Description = "Quản lý chi nhánh"},
                new AppRole{ Id = administratorRoleId, Name = "admin", NormalizedName = "admin",Description = "Quản trị hệ thống"}
            );

            modelBuilder.Entity<AppRoleTranslation>().HasData(
                new AppRoleTranslation{ Id = 1, AppRoleId = storeManagerRoleId, Name = "Quản lý cửa hàng", LanguageId = 1,Description = "Quản lý cửa hàng"},
                new AppRoleTranslation{ Id = 2, AppRoleId = storeManagerRoleId, Name = "Store manager", LanguageId = 2,Description = "Store owner"}, 
                new AppRoleTranslation{ Id = 3, AppRoleId = generalManagerRoleId, Name = "Quản lý", LanguageId = 1, Description = "Quản lý"},
                new AppRoleTranslation{ Id = 4, AppRoleId = generalManagerRoleId, Name = "General manager", LanguageId = 2, Description = "General manager"},
                new AppRoleTranslation{ Id = 5, AppRoleId = warehouseStaffRoleId, Name = "Nhân viên kho", LanguageId = 1, Description = "Nhân viên kho"},
                new AppRoleTranslation{ Id = 6, AppRoleId = warehouseStaffRoleId, Name = "Warehouse staff", LanguageId = 2, Description = "Warehouse staff"},
                new AppRoleTranslation{ Id = 7, AppRoleId = cashierRoleId, Name = "Nhân viên thu ngân", LanguageId = 1, Description = "Nhân viên thu ngân"},
                new AppRoleTranslation{ Id = 8, AppRoleId = cashierRoleId, Name = "Cashier", LanguageId = 2, Description = "Cashier"},
                new AppRoleTranslation{ Id = 9, AppRoleId = shopAssistantRoleId, Name = "Nhân viên bán hàng", LanguageId = 1, Description = "Nhân viên bán hàng"},
                new AppRoleTranslation{ Id = 10, AppRoleId = shopAssistantRoleId, Name = "Shop assistant", LanguageId = 2, Description = "Shop assistant"},
                new AppRoleTranslation{ Id = 11, AppRoleId = branchManagerRoleId, Name = "Quản lý chi nhánh", LanguageId = 1,Description = "Quản lý chi nhánh"},
                new AppRoleTranslation{ Id = 12, AppRoleId = branchManagerRoleId, Name = "Branch manager", LanguageId = 2,Description = "Branch manager"},
                new AppRoleTranslation{ Id = 13, AppRoleId = administratorRoleId, Name = "Quản trị hệ thống", LanguageId = 1,Description = "Quản trị hệ thống"},
                new AppRoleTranslation{ Id = 14, AppRoleId = administratorRoleId, Name = "Branch Manager", LanguageId = 2, Description = "Branch Manager"}
            );

            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            //AppUsers
            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                Code = "001",
                UserName = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123"),
                SecurityStamp = string.Empty,
                FirstName = "Nguyễn",
                LastName = "Hồ Phi Long",
                Dob = new DateTime(2020, 01, 31),
                PhoneNumber = "0915780794",
                Address = "09 Lê Hồng Phong",
                IsActive = true,
            }
            );



            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>{ RoleId = administratorRoleId, UserId = adminId},
                new IdentityUserRole<Guid>{ RoleId = warehouseStaffRoleId, UserId = adminId}, 
                new IdentityUserRole<Guid>{ RoleId = shopAssistantRoleId, UserId = adminId}
            );

            //Slide
            modelBuilder.Entity<Slide>().HasData(
              new Slide() { Id = 1, SortOrder = 1, Link = "#", Image = "smart_farming.jpg" },
              new Slide() { Id = 2, SortOrder = 2, Link = "#", Image = "biotechnology.jpg", SlideStatusId = 2 },
              new Slide() { Id = 3, SortOrder = 3, Link = "#", Image = "information_technology.png", SlideStatusId = 2 }
            );

            modelBuilder.Entity<SlideTranslation>().HasData(
               new SlideTranslation() { Id = 1, SlideId = 1, Code = "Nông nghiệp thông minh", Name = "Smart farming", Description = "<p>Nền nông nghiệp ứng dụng công nghệ cao(cơ giới hóa, tự động hóa…)</p><p>Công nghệ sản xuất, bảo quản sản phẩm an toàn (hữu cơ, theo GAP…)</p><p>Công nghệ quản lý, nhận diện sản phẩm theo chuỗi giá trị… gắn với hệ thống trí tuệ nhân tạo (công nghệ thông tin).</p>", LanguageId = 1 },
               new SlideTranslation() { Id = 2, SlideId = 1, Code = "Smart farm", Name = "Smart farming", Description = "<p>Nền nông nghiệp ứng dụng công nghệ cao(cơ giới hóa, tự động hóa…)</p><p>Công nghệ sản xuất, bảo quản sản phẩm an toàn (hữu cơ, theo GAP…)</p><p>Công nghệ quản lý, nhận diện sản phẩm theo chuỗi giá trị… gắn với hệ thống trí tuệ nhân tạo (công nghệ thông tin).</p>", LanguageId = 2 },
               new SlideTranslation() { Id = 3, SlideId = 2, Code = "Công nghệ sinh học", Name = "Biotechnology", Description = "<p>Ứng dụng công nghệ sinh học trong sản xuất thuốc, thức ăn</p><p> Điều chế và sản xuất hóa chất công nghiệp; phát triển giống cây trồng, vật nuôi</p><p> Ứng dụng công nghệ di truyền, xét nghiệm trong y khoa </p><p> giải quyết các vấn đề môi trường…</p>", LanguageId = 1 },
               new SlideTranslation() { Id = 4, SlideId = 2, Code = "Công nghệ sinh học", Name = "Biotechnology", Description = "<p>Ứng dụng công nghệ sinh học trong sản xuất thuốc, thức ăn</p><p> Điều chế và sản xuất hóa chất công nghiệp; phát triển giống cây trồng, vật nuôi</p><p> Ứng dụng công nghệ di truyền, xét nghiệm trong y khoa </p><p> giải quyết các vấn đề môi trường…</p>", LanguageId = 2 },
               new SlideTranslation() { Id = 5, SlideId = 3, Code = "Công nghệ thông tin và truyền thông", Name = "IT", Description = "<p>ICT là sự kết hợp của công nghệ thông tin và công nghệ truyền thông</p><p> để tạo nên sự kết nối và chia sẻ thông tin với nhiều hình thức khác nhau </p><p> nhằm hỗ trợ và thúc đẩy năng lực sản xuất, kinh doanh Doanh nghiệp </p> ", LanguageId = 1 },
               new SlideTranslation() { Id = 6, SlideId = 3, Code = "Công nghệ thông tin và truyền thông", Name = "IT", Description = "<p>ICT là sự kết hợp của công nghệ thông tin và công nghệ truyền thông</p><p> để tạo nên sự kết nối và chia sẻ thông tin với nhiều hình thức khác nhau </p><p> nhằm hỗ trợ và thúc đẩy năng lực sản xuất, kinh doanh Doanh nghiệp </p> ", LanguageId = 2 }
            );

            //Stores
            modelBuilder.Entity<Store>().HasData(
              new Store() { Id = 1, Code = "CH001", StoreStatusId = 1, Phone = "0123456789", Email ="abc@gmail.com" },
              new Store() { Id = 2, Code = "CH002", StoreStatusId = 1, Phone = "0123456789", Email ="abc@gmail.com" }
            );

            modelBuilder.Entity<StoreTranslation>().HasData(
               new StoreTranslation() { Id = 1, StoreId = 1, Name = "Cửa hàng mặc định", LanguageId = 1 },
               new StoreTranslation() { Id = 2, StoreId = 1, Name = "Default Store", LanguageId = 2 },
               new StoreTranslation() { Id = 3, StoreId = 2, Name = "Cửa hàng 2", LanguageId = 1 },
               new StoreTranslation() { Id = 4, StoreId = 2, Name = "Store 2", LanguageId = 2 }
            );

            //Gender
            modelBuilder.Entity<Gender>().HasData(
              new Gender() { Id = 1, Code = "M"},
              new Gender() { Id = 2, Code = "F" }
            );

            modelBuilder.Entity<GenderTranslation>().HasData(
               new GenderTranslation() { Id = 1, GenderId = 1, Name = "Nam", LanguageId = 1 },
               new GenderTranslation() { Id = 2, GenderId = 1, Name = "Male", LanguageId = 2 },
               new GenderTranslation() { Id = 3, GenderId = 2, Name = "Nữ", LanguageId = 1 },
               new GenderTranslation() { Id = 4, GenderId = 2, Name = "Female", LanguageId = 2 }
            );

            //Menus
            modelBuilder.Entity<Menu>().HasData(
                new Menu() { Id = 1, SortOrder = 1, Code = "WebApp_TQ", ParentId = new Nullable<int>(), Link = string.Empty, Icon = "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><path d='M3,16 L5,16 C5.55228475,16 6,15.5522847 6,15 C6,14.4477153 5.55228475,14 5,14 L3,14 L3,12 L5,12 C5.55228475,12 6,11.5522847 6,11 C6,10.4477153 5.55228475,10 5,10 L3,10 L3,8 L5,8 C5.55228475,8 6,7.55228475 6,7 C6,6.44771525 5.55228475,6 5,6 L3,6 L3,4 C3,3.44771525 3.44771525,3 4,3 L10,3 C10.5522847,3 11,3.44771525 11,4 L11,19 C11,19.5522847 10.5522847,20 10,20 L4,20 C3.44771525,20 3,19.5522847 3,19 L3,16 Z' fill='#000000' opacity='0.3'></path>		<path d='M16,3 L19,3 C20.1045695,3 21,3.8954305 21,5 L21,15.2485298 C21,15.7329761 20.8241635,16.200956 20.5051534,16.565539 L17.8762883,19.5699562 C17.6944473,19.7777745 17.378566,19.7988332 17.1707477,19.6169922 C17.1540423,19.602375 17.1383289,19.5866616 17.1237117,19.5699562 L14.4948466,16.565539 C14.1758365,16.200956 14,15.7329761 14,15.2485298 L14,5 C14,3.8954305 14.8954305,3 16,3 Z' fill='#000000'></path>	</svg></span></span>" },
                new Menu() { Id = 2, SortOrder = 1, Code = "WebApp_TQ_TQ", ParentId = 1, Link = "/Home/Index", ControllerName = "Summary", ActionName = "Index" },
                new Menu() { Id = 3, SortOrder = 2, Code = "WebApp_TQ_O", ParentId = 1, Link = "/Order/Index", ControllerName = "Order", ActionName = "Index" },
                new Menu() { Id = 4, SortOrder = 2, Code = "WebApp_HHDV", ParentId = new Nullable<int>(), Link = string.Empty, Icon = "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' width='24' height='24' viewBox='0 0 24 24' fill='none'>	<path opacity='0.25' fill-rule='evenodd' clip-rule='evenodd' d='M11 4.25769C11 3.07501 9.9663 2.13515 8.84397 2.50814C4.86766 3.82961 2 7.57987 2 11.9999C2 13.6101 2.38057 15.1314 3.05667 16.4788C3.58731 17.5363 4.98303 17.6028 5.81966 16.7662L5.91302 16.6728C6.60358 15.9823 6.65613 14.9011 6.3341 13.9791C6.11766 13.3594 6 12.6934 6 11.9999C6 9.62064 7.38488 7.56483 9.39252 6.59458C10.2721 6.16952 11 5.36732 11 4.39046V4.25769ZM16.4787 20.9434C17.5362 20.4127 17.6027 19.017 16.7661 18.1804L16.6727 18.087C15.9822 17.3964 14.901 17.3439 13.979 17.6659C13.3594 17.8823 12.6934 17.9999 12 17.9999C11.3066 17.9999 10.6406 17.8823 10.021 17.6659C9.09899 17.3439 8.01784 17.3964 7.3273 18.087L7.23392 18.1804C6.39728 19.017 6.4638 20.4127 7.52133 20.9434C8.86866 21.6194 10.3899 21.9999 12 21.9999C13.6101 21.9999 15.1313 21.6194 16.4787 20.9434Z' fill='#12131A'></path>	<path fill-rule='evenodd' clip-rule='evenodd' d='M13 4.39046C13 5.36732 13.7279 6.16952 14.6075 6.59458C16.6151 7.56483 18 9.62064 18 11.9999C18 12.6934 17.8823 13.3594 17.6659 13.9791C17.3439 14.9011 17.3964 15.9823 18.087 16.6728L18.1803 16.7662C19.017 17.6028 20.4127 17.5363 20.9433 16.4788C21.6194 15.1314 22 13.6101 22 11.9999C22 7.57987 19.1323 3.82961 15.156 2.50814C14.0337 2.13515 13 3.07501 13 4.25769V4.39046Z' fill='#12131A'></path></svg></span></span>" },
                new Menu() { Id = 5, SortOrder = 1, Code = "WebApp_HHDV_HHDV", ParentId = 4, Link = "/Product/Index", ControllerName = "Product", ActionName = "Index" },
                new Menu() { Id = 6, SortOrder = 2, Code = "WebApp_HHDV_NH", ParentId = 4, Link = "/StockIn/Index", ControllerName = "StockIn", ActionName = "Index" },
                new Menu() { Id = 7, SortOrder = 3, Code = "WebApp_HHDV_W", ParentId = 4, Link = "/Warehouse/Index", ControllerName = "Warehouse", ActionName = "Index" },
                new Menu() { Id = 8, SortOrder = 3, Code = "WebApp_KH", ParentId = new Nullable<int>(), Link = string.Empty, Icon = "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns = 'http://www.w3.org/2000/svg' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><path d = 'M18,14 C16.3431458,14 15,12.6568542 15,11 C15,9.34314575 16.3431458,8 18,8 C19.6568542,8 21,9.34314575 21,11 C21,12.6568542 19.6568542,14 18,14 Z M9,11 C6.790861,11 5,9.209139 5,7 C5,4.790861 6.790861,3 9,3 C11.209139,3 13,4.790861 13,7 C13,9.209139 11.209139,11 9,11 Z' fill='#000000' fill-rule='nonzero' opacity='0.3'></path><path d = 'M17.6011961,15.0006174 C21.0077043,15.0378534 23.7891749,16.7601418 23.9984937,20.4 C24.0069246,20.5466056 23.9984937,21 23.4559499,21 L19.6,21 C19.6,18.7490654 18.8562935,16.6718327 17.6011961,15.0006174 Z M0.00065168429,20.1992055 C0.388258525,15.4265159 4.26191235,13 8.98334134,13 C13.7712164,13 17.7048837,15.2931929 17.9979143,20.2 C18.0095879,20.3954741 17.9979143,21 17.2466999,21 C13.541124,21 8.03472472,21 0.727502227,21 C0.476712155,21 -0.0204617505,20.45918 0.00065168429,20.1992055 Z' fill='#000000' fill-rule='nonzero'></path></svg></span></span>" },
                new Menu() { Id = 9, SortOrder = 1, Code = "WebApp_KH_KH", ParentId = 8, Link = "/Customer/Index", ControllerName = "Customer", ActionName = "Index" },
                new Menu() { Id = 10, SortOrder = 2, Code = "WebApp_KH_NCC", ParentId = 8, Link = "/Supplier/Index", ControllerName = "Supplier", ActionName = "Index" },
                new Menu() { Id = 11, SortOrder = 3, Code = "WebApp_KH_NKH", ParentId = 8, Link = "/CustomerType/Index", ControllerName = "CustomerType", ActionName = "Index" },
                new Menu() { Id = 12, SortOrder = 4, Code = "WebApp_TB", ParentId = new Nullable<int>(), Link = string.Empty, Icon = "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><g stroke='none' stroke-width='1' fill='none' fill-rule='evenodd'>	<rect x='0' y='0' width='24' height='24'></rect>	<rect fill='#000000' opacity='0.3' x='2' y='5' width='20' height='14' rx='2'></rect>	<rect fill='#000000' x='2' y='8' width='20' height='3'></rect>	<rect fill='#000000' opacity='0.3' x='16' y='14' width='4' height='2' rx='1'></rect></g></svg></span></span>" },
                new Menu() { Id = 13, SortOrder = 1, Code = "WebApp_TB_TQ", ParentId = 12, Link = "/SummaryOfReceiptPayment/Index", ControllerName = "SummaryOfReceiptPayment", ActionName = "Index" },
                new Menu() { Id = 14, SortOrder = 2, Code = "WebApp_TB_PT", ParentId = 12, Link = "/Receipt/Index", ControllerName = "Receipt", ActionName = "Index" },
                new Menu() { Id = 15, SortOrder = 3, Code = "WebApp_TB_PC", ParentId = 12, Link = "/Payment/Index", ControllerName = "Payment", ActionName = "Index" },
                new Menu() { Id = 16, SortOrder = 4, Code = "WebApp_TB_SQ", ParentId = 12, Link = "/CashBook/Index", ControllerName = "CashBook", ActionName = "Index" },
                new Menu() { Id = 17, SortOrder = 5, Code = "WebApp_BC", ParentId = new Nullable<int>(), Link = string.Empty, Icon = "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><g stroke='none' stroke-width='1' fill='none' fill-rule='evenodd'>	<polygon points='0 0 24 0 24 24 0 24'></polygon>	<path d='M5.85714286,2 L13.7364114,2 C14.0910962,2 14.4343066,2.12568431 14.7051108,2.35473959 L19.4686994,6.3839416 C19.8056532,6.66894833 20,7.08787823 20,7.52920201 L20,20.0833333 C20,21.8738751 19.9795521,22 18.1428571,22 L5.85714286,22 C4.02044787,22 4,21.8738751 4,20.0833333 L4,3.91666667 C4,2.12612489 4.02044787,2 5.85714286,2 Z' fill='#000000' fill-rule='nonzero' opacity='0.3'></path>	<rect fill='#000000' x='6' y='11' width='9' height='2' rx='1'></rect>	<rect fill='#000000' x='6' y='15' width='5' height='2' rx='1'></rect></g></svg></span></span>" },
                new Menu() { Id = 18, SortOrder = 1, Code = "WebApp_BC_DS", ParentId = 17, Link = "/SaleReport/Index" },
                new Menu() { Id = 19, SortOrder = 2, Code = "WebApp_BC_HHDV", ParentId = 17, Link = "/ProductReport/Index", ControllerName = "ProductReport", ActionName = "Index" },
                new Menu() { Id = 20, SortOrder = 3, Code = "WebApp_BC_TK", ParentId = 17, Link = "/StockReport/Index", ControllerName = "StockReport", ActionName = "Index" },
                new Menu() { Id = 21, SortOrder = 4, Code = "WebApp_BC_LN", ParentId = 17, Link = "/ProfitReport/Index", ControllerName = "ProfitReport", ActionName = "Index" },
                new Menu() { Id = 22, SortOrder = 5, Code = "WebApp_BC_LL", ParentId = 17, Link = "/ProfitAndLossReport/Index", ControllerName = "ProfitAndLossReport", ActionName = "Index" },
                new Menu() { Id = 23, SortOrder = 6, Code = "WebApp_BC_BCT", ParentId = 17, Link = "/MonthlyReport/Index", ControllerName = "MonthlyReport", ActionName = "Index" },
                new Menu() { Id = 24, SortOrder = 6, Code = "WebApp_DM", ParentId = new Nullable<int>(), Link = string.Empty, Icon = "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><g stroke='none' stroke-width='1' fill='none' fill-rule='evenodd'><rect x='0' y='0' width='24' height='24'></rect><rect fill='#000000' x='4' y='4' width='7' height='7' rx='1.5'></rect><path d='M5.5,13 L9.5,13 C10.3284271,13 11,13.6715729 11,14.5 L11,18.5 C11,19.3284271 10.3284271,20 9.5,20 L5.5,20 C4.67157288,20 4,19.3284271 4,18.5 L4,14.5 C4,13.6715729 4.67157288,13 5.5,13 Z M14.5,4 L18.5,4 C19.3284271,4 20,4.67157288 20,5.5 L20,9.5 C20,10.3284271 19.3284271,11 18.5,11 L14.5,11 C13.6715729,11 13,10.3284271 13,9.5 L13,5.5 C13,4.67157288 13.6715729,4 14.5,4 Z M14.5,13 L18.5,13 C19.3284271,13 20,13.6715729 20,14.5 L20,18.5 C20,19.3284271 19.3284271,20 18.5,20 L14.5,20 C13.6715729,20 13,19.3284271 13,18.5 L13,14.5 C13,13.6715729 13.6715729,13 14.5,13 Z' fill='#000000' opacity='0.3'></path></g></svg></span></span>" },
                new Menu() { Id = 25, SortOrder = 1, Code = "WebApp_DM_NHH", ParentId = 24, Link = "/ProductType/Index", ControllerName = "ProductType", ActionName = "Index" },
                new Menu() { Id = 26, SortOrder = 2, Code = "WebApp_DM_DVT", ParentId = 24, Link = "/Unit/Index", ControllerName = "Unit", ActionName = "Index" },
                new Menu() { Id = 27, SortOrder = 7, Code = "WebApp_BHO", ParentId = new Nullable<int>(), Link = string.Empty, Icon = "<span class='menu-link'><span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><path d='M16,15.6315789 L16,12 C16,10.3431458 14.6568542,9 13,9 L6.16183229,9 L6.16183229,5.52631579 C6.16183229,4.13107011 7.29290239,3 8.68814808,3 L20.4776218,3 C21.8728674,3 23.0039375,4.13107011 23.0039375,5.52631579 L23.0039375,13.1052632 L23.0206157,17.786793 C23.0215995,18.0629336 22.7985408,18.2875874 22.5224001,18.2885711 C22.3891754,18.2890457 22.2612702,18.2363324 22.1670655,18.1421277 L19.6565168,15.6315789 L16,15.6315789 Z' fill='#000000'></path><path d='M1.98505595,18 L1.98505595,13 C1.98505595,11.8954305 2.88048645,11 3.98505595,11 L11.9850559,11 C13.0896254,11 13.9850559,11.8954305 13.9850559,13 L13.9850559,18 C13.9850559,19.1045695 13.0896254,20 11.9850559,20 L4.10078614,20 L2.85693427,21.1905292 C2.65744295,21.3814685 2.34093638,21.3745358 2.14999706,21.1750444 C2.06092565,21.0819836 2.01120804,20.958136 2.01120804,20.8293182 L2.01120804,18.32426 C1.99400175,18.2187196 1.98505595,18.1104045 1.98505595,18 Z M6.5,14 C6.22385763,14 6,14.2238576 6,14.5 C6,14.7761424 6.22385763,15 6.5,15 L11.5,15 C11.7761424,15 12,14.7761424 12,14.5 C12,14.2238576 11.7761424,14 11.5,14 L6.5,14 Z M9.5,16 C9.22385763,16 9,16.2238576 9,16.5 C9,16.7761424 9.22385763,17 9.5,17 L11.5,17 C11.7761424,17 12,16.7761424 12,16.5 C12,16.2238576 11.7761424,16 11.5,16 L9.5,16 Z' fill='#000000' opacity='0.3'></path></svg></span></span><span class='menu-title'>Chat</span><span class='menu-arrow'></span></span>" },
                new Menu() { Id = 28, SortOrder = 8, Code = "WebApp_NV", ParentId = new Nullable<int>(), Link = string.Empty, Icon = "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns = 'http://www.w3.org/2000/svg' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><path d = 'M18,14 C16.3431458,14 15,12.6568542 15,11 C15,9.34314575 16.3431458,8 18,8 C19.6568542,8 21,9.34314575 21,11 C21,12.6568542 19.6568542,14 18,14 Z M9,11 C6.790861,11 5,9.209139 5,7 C5,4.790861 6.790861,3 9,3 C11.209139,3 13,4.790861 13,7 C13,9.209139 11.209139,11 9,11 Z' fill='#000000' fill-rule='nonzero' opacity='0.3'></path><path d = 'M17.6011961,15.0006174 C21.0077043,15.0378534 23.7891749,16.7601418 23.9984937,20.4 C24.0069246,20.5466056 23.9984937,21 23.4559499,21 L19.6,21 C19.6,18.7490654 18.8562935,16.6718327 17.6011961,15.0006174 Z M0.00065168429,20.1992055 C0.388258525,15.4265159 4.26191235,13 8.98334134,13 C13.7712164,13 17.7048837,15.2931929 17.9979143,20.2 C18.0095879,20.3954741 17.9979143,21 17.2466999,21 C13.541124,21 8.03472472,21 0.727502227,21 C0.476712155,21 -0.0204617505,20.45918 0.00065168429,20.1992055 Z' fill='#000000' fill-rule='nonzero'></path></svg></span></span>" },
                new Menu() { Id = 29, SortOrder = 1, Code = "WebApp_NV_BL", ParentId = 28, Link = "/Payroll/Index", ControllerName = "Payroll", ActionName = "Index" },
                new Menu() { Id = 30, SortOrder = 10, Code = "WebApp_CD", ParentId = new Nullable<int>(), Link = string.Empty, Icon = "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' width='24' height='24' viewBox='0 0 24 24' fill='none'><path opacity='0.25' d='M2 6.5C2 4.01472 4.01472 2 6.5 2H17.5C19.9853 2 22 4.01472 22 6.5V6.5C22 8.98528 19.9853 11 17.5 11H6.5C4.01472 11 2 8.98528 2 6.5V6.5Z' fill='#12131A'></path><path d='M20 6.5C20 7.88071 18.8807 9 17.5 9C16.1193 9 15 7.88071 15 6.5C15 5.11929 16.1193 4 17.5 4C18.8807 4 20 5.11929 20 6.5Z' fill='#12131A'></path><path opacity='0.25' d='M2 17.5C2 15.0147 4.01472 13 6.5 13H17.5C19.9853 13 22 15.0147 22 17.5V17.5C22 19.9853 19.9853 22 17.5 22H6.5C4.01472 22 2 19.9853 2 17.5V17.5Z' fill='#12131A'></path><path d='M9 17.5C9 18.8807 7.88071 20 6.5 20C5.11929 20 4 18.8807 4 17.5C4 16.1193 5.11929 15 6.5 15C7.88071 15 9 16.1193 9 17.5Z' fill='#12131A'></path></svg></span></span>" },
                new Menu() { Id = 31, SortOrder = 1, Code = "WebApp_CD_NV", ParentId = 30, Link = "/Staff/Index", ControllerName = "Staff", ActionName = "Index" },
                new Menu() { Id = 32, SortOrder = 2, Code = "WebApp_CD_PQ", ParentId = 30, Link = "/AppRole/Index", ControllerName = "AppRole", ActionName = "Index" },
                new Menu() { Id = 33, SortOrder = 3, Code = "WebApp_CD_CH", ParentId = 30, Link = "/Store/Index", ControllerName = "Store", ActionName = "Index" },
                new Menu() { Id = 34, SortOrder = 4, Code = "WebApp_CD_MI", ParentId = 30, Link = "/DocTemplate/Index", ControllerName = "DocTemplate", ActionName = "Index" },
                new Menu() { Id = 35, SortOrder = 5, Code = "WebApp_CD_DMHT", ParentId = 30, Link = string.Empty },
                new Menu() { Id = 36, SortOrder = 1, Code = "WebApp_CD_DMHT_M", ParentId = 35, Link = "/Menu/Index", ControllerName = "Menu", ActionName = "Index" },
                new Menu() { Id = 37, SortOrder = 2, Code = "WebApp_CD_DMHT_LMI", ParentId = 35, Link = "/DocTemplateType/Index", ControllerName = "DocTemplateType", ActionName = "Index" },
                new Menu() { Id = 38, SortOrder = 11, Code = "WebApp_QTW", ParentId = new Nullable<int>(), Link = string.Empty, Icon = "<span class='svg-icon svg-icon-primary svg-icon-2x'><!--begin::Svg Icon | path:/var/www/preview.keenthemes.com/metronic/releases/2021-05-14-112058/theme/html/demo2/dist/../src/media/svg/icons/Devices/iMac.svg--><svg xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'>    <g stroke='none' stroke-width='1' fill='none' fill-rule='evenodd'>        <rect x='0' y='0' width='24' height='24'/>        <path d='M5,5 L5,16 L19,16 L19,5 L5,5 Z M5,3 L19,3 C20.4201608,3 21,3.7163444 21,4.6 L21,17.4 C21,18.2836556 20.4201608,19 19,19 L5,19 C3.57983921,19 3,18.2836556 3,17.4 L3,4.6 C3,3.7163444 3.57983921,3 5,3 Z M12,18 C12.2761424,18 12.5,17.7761424 12.5,17.5 C12.5,17.2238576 12.2761424,17 12,17 C11.7238576,17 11.5,17.2238576 11.5,17.5 C11.5,17.7761424 11.7238576,18 12,18 Z' fill='#12131A' fill-rule='nonzero'/>        <polygon fill='#12131A' opacity='0.3' points='5 5 5 16 19 16 19 5'/>        <rect fill='#12131A' opacity='0.3' x='10' y='20' width='4' height='1' rx='0.5'/>    </g></svg><!--end::Svg Icon--></span>" },
                new Menu() { Id = 39, SortOrder = 1, Code = "WebApp_QTW_P", ParentId = 38, Link = "/Post/Index", ControllerName = "Post", ActionName = "Index" },
                new Menu() { Id = 40, SortOrder = 2, Code = "WebApp_QTW_PT", ParentId = 38, Link = "/PostType/Index", ControllerName = "PostType", ActionName = "Index" },
                new Menu() { Id = 41, SortOrder = 3, Code = "WebApp_QTW_S", ParentId = 38, Link = "/Slider/Index", ControllerName = "Slider", ActionName = "Index" },
                new Menu() { Id = 42, SortOrder = 3, Code = "WebApp_KH_NSX", ParentId = 8, Link = "/Manufacturer/Index", ControllerName = "Manufacturer", ActionName = "Index" },
                new Menu() { Id = 43, SortOrder = 1, Code = "WebApp_DM_TT", ParentId = 24, Link = "/Attribute/Index", ControllerName = "Attribute", ActionName = "Index" },
                new Menu() { Id = 44, SortOrder = 4, Code = "WebApp_CD_DMHT_STATUS", ParentId = 35, Link = string.Empty },
                new Menu() { Id = 45, SortOrder = 1, Code = "WebApp_CD_DMHT_STATUS_AUS", ParentId = 44, Link = "/AppUserStatus/Index", ControllerName = "AppUserStatus", ActionName = "Index" },
                new Menu() { Id = 46, SortOrder = 2, Code = "WebApp_CD_DMHT_STATUS_OS", ParentId = 44, Link = "/OrderStatus/Index", ControllerName = "AppUsOrderStatuserStatus", ActionName = "Index" },
                new Menu() { Id = 47, SortOrder = 2, Code = "WebApp_CD_DMHT_STATUS_PS", ParentId = 44, Link = "/PhieuKeToanStatus/Index", ControllerName = "PhieuKeToanStatus", ActionName = "Index" },
                new Menu() { Id = 48, SortOrder = 3, Code = "WebApp_CD_DMHT_STATUS_POSTS", ParentId = 44, Link = "/PostStatus/Index", ControllerName = "PostStatus", ActionName = "Index" },
                new Menu() { Id = 49, SortOrder = 4, Code = "WebApp_CD_DMHT_STATUS_POSTTYPES", ParentId = 44, Link = "/PostTypeStatus/Index", ControllerName = "PostTypeStatus", ActionName = "Index" },
                new Menu() { Id = 50, SortOrder = 5, Code = "WebApp_CD_DMHT_STATUS_PRODUCTTYPES", ParentId = 44, Link = "/ProductTypeStatus/Index", ControllerName = "ProductTypeStatus", ActionName = "Index" },
                new Menu() { Id = 51, SortOrder = 6, Code = "WebApp_CD_DMHT_STATUS_STS", ParentId = 44, Link = "/StoreStatus/Index", ControllerName = "StoreStatus", ActionName = "Index" },
                new Menu() { Id = 52, SortOrder = 1, Code = "WebApp_DM_GTTT", ParentId = 24, Link = "/AttributeValue/Index", ControllerName = "AttributeValue", ActionName = "Index" },
                new Menu() { Id = 53, SortOrder = 3, Code = "WebApp_CD_DMHT_P", ParentId = 35, Link = "/PaperSize/Index", ControllerName = "PaperSize", ActionName = "Index" },
                new Menu() { Id = 54, SortOrder = 5, Code = "WebApp_CD_DMHT_AUT", ParentId = 35, Link = "/AppUserType/Index", ControllerName = "AppUserType", ActionName = "Index" },
                new Menu() { Id = 55, SortOrder = 9, Code = "WebApp_BH", ParentId = new Nullable<int>(), Link = string.Empty, Icon = "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' width='24' height='24' viewBox='0 0 24 24' fill='none'><path opacity='0.25' d='M2 6.5C2 4.01472 4.01472 2 6.5 2H17.5C19.9853 2 22 4.01472 22 6.5V6.5C22 8.98528 19.9853 11 17.5 11H6.5C4.01472 11 2 8.98528 2 6.5V6.5Z' fill='#12131A'></path><path d='M20 6.5C20 7.88071 18.8807 9 17.5 9C16.1193 9 15 7.88071 15 6.5C15 5.11929 16.1193 4 17.5 4C18.8807 4 20 5.11929 20 6.5Z' fill='#12131A'></path><path opacity='0.25' d='M2 17.5C2 15.0147 4.01472 13 6.5 13H17.5C19.9853 13 22 15.0147 22 17.5V17.5C22 19.9853 19.9853 22 17.5 22H6.5C4.01472 22 2 19.9853 2 17.5V17.5Z' fill='#12131A'></path><path d='M9 17.5C9 18.8807 7.88071 20 6.5 20C5.11929 20 4 18.8807 4 17.5C4 16.1193 5.11929 15 6.5 15C7.88071 15 9 16.1193 9 17.5Z' fill='#12131A'></path></svg></span></span>" },
                new Menu() { Id = 56, SortOrder = 1, Code = "WebApp_BH_P", ParentId = 55, Link = "/Promotion/Index", ControllerName = "Promotion", ActionName = "Index" },
                new Menu() { Id = 57, SortOrder = 2, Code = "WebApp_BH_CD", ParentId = 55, Link = "/CommissionDiscount/Index", ControllerName = "CommissionDiscount", ActionName = "Index" },
                new Menu() { Id = 58, SortOrder = 2, Code = "WebApp_NV_BS", ParentId = 28, Link = "/BasicSalary/Index", ControllerName = "BasicSalary", ActionName = "Index" },
                new Menu() { Id = 59, SortOrder = 4, Code = "WebApp_QTW_M", ParentId = 38, Link = "/WebsiteMenu/Index", ControllerName = "WebsiteMenu", ActionName = "Index" },
                new Menu() { Id = 60, SortOrder = 5, Code = "WebApp_QTW_B", ParentId = 38, Link = "/Booking/Index", ControllerName = "Booking", ActionName = "Index" },
                new Menu() { Id = 61, SortOrder = 6, Code = "WebApp_QTW_C", ParentId = 38, Link = "/Contact/Index", ControllerName = "Contact", ActionName = "Index" },
                new Menu() { Id = 62, SortOrder = 7, Code = "WebApp_QTW_CI", ParentId = 38, Link = "/ContactInformation/Index", ControllerName = "ContactInformation", ActionName = "Index" },
                new Menu() { Id = 63, SortOrder = 8, Code = "WebApp_QTW_N", ParentId = 38, Link = "/Newsletter/Index", ControllerName = "Newsletter", ActionName = "Index" },
                new Menu() { Id = 64, SortOrder = 9, Code = "WebApp_QTW_T", ParentId = 38, Link = "/Testimonial/Index", ControllerName = "Testimonial", ActionName = "Index" },
                new Menu() { Id = 65, SortOrder = 4, Code = "WebApp_HHDV_QRC", ParentId = 4, Link = "/Product/Print", ControllerName = "Product", ActionName = "Print" }
            );

            modelBuilder.Entity<MenuTranslation>().HasData(
                new MenuTranslation() { Id = 1, MenuId = 1, Name = "Tổng quan", LanguageId = 1 },
                new MenuTranslation() { Id = 2, MenuId = 1, Name = "Dashboard", LanguageId = 2 },
                new MenuTranslation() { Id = 3, MenuId = 2, Name = "Tổng quan", LanguageId = 1 },
                new MenuTranslation() { Id = 4, MenuId = 2, Name = "Summary", LanguageId = 2 },
                new MenuTranslation() { Id = 5, MenuId = 3, Name = "Đơn hàng", LanguageId = 1 },
                new MenuTranslation() { Id = 6, MenuId = 3, Name = "Orders", LanguageId = 2 },
                new MenuTranslation() { Id = 7, MenuId = 4, Name = "Hàng hóa & Dịch vụ", LanguageId = 1 },
                new MenuTranslation() { Id = 8, MenuId = 4, Name = "Products & Services", LanguageId = 2 },
                new MenuTranslation() { Id = 9, MenuId = 5, Name = "Hàng hóa/Dịch vụ", LanguageId = 1 },
                new MenuTranslation() { Id = 10, MenuId = 5, Name = "Products/Services", LanguageId = 2 },
                new MenuTranslation() { Id = 11, MenuId = 6, Name = "Nhập hàng", LanguageId = 1 },
                new MenuTranslation() { Id = 12, MenuId = 6, Name = "Stock in", LanguageId = 2 },
                new MenuTranslation() { Id = 13, MenuId = 7, Name = "Kho hàng", LanguageId = 1 },
                new MenuTranslation() { Id = 14, MenuId = 7, Name = "Warehouses", LanguageId = 2 },
                new MenuTranslation() { Id = 15, MenuId = 8, Name = "Khách hàng", LanguageId = 1 },
                new MenuTranslation() { Id = 16, MenuId = 8, Name = "Customers", LanguageId = 2 },
                new MenuTranslation() { Id = 17, MenuId = 9, Name = "Khách hàng", LanguageId = 1 },
                new MenuTranslation() { Id = 18, MenuId = 9, Name = "Customers", LanguageId = 2 },
                new MenuTranslation() { Id = 19, MenuId = 10, Name = "Nhà cung cấp", LanguageId = 1 },
                new MenuTranslation() { Id = 20, MenuId = 10, Name = "Suppliers", LanguageId = 2 },
                new MenuTranslation() { Id = 21, MenuId = 11, Name = "Nhóm khách hàng", LanguageId = 1 },
                new MenuTranslation() { Id = 22, MenuId = 11, Name = "Customer types", LanguageId = 2 },
                new MenuTranslation() { Id = 23, MenuId = 12, Name = "Tiền bạc", LanguageId = 1 },
                new MenuTranslation() { Id = 24, MenuId = 12, Name = "Receipts & payments", LanguageId = 2 },
                new MenuTranslation() { Id = 25, MenuId = 13, Name = "Tổng quan", LanguageId = 1 },
                new MenuTranslation() { Id = 26, MenuId = 13, Name = "Summary", LanguageId = 2 },
                new MenuTranslation() { Id = 27, MenuId = 14, Name = "Thu", LanguageId = 1 },
                new MenuTranslation() { Id = 28, MenuId = 14, Name = "Receipts", LanguageId = 2 },
                new MenuTranslation() { Id = 29, MenuId = 15, Name = "Chi", LanguageId = 1 },
                new MenuTranslation() { Id = 30, MenuId = 15, Name = "Payments", LanguageId = 2 },
                new MenuTranslation() { Id = 31, MenuId = 16, Name = "Sổ quỹ", LanguageId = 1 },
                new MenuTranslation() { Id = 32, MenuId = 16, Name = "Cash book", LanguageId = 2 },
                new MenuTranslation() { Id = 33, MenuId = 17, Name = "Báo cáo", LanguageId = 1 },
                new MenuTranslation() { Id = 34, MenuId = 17, Name = "Reports", LanguageId = 2 },
                new MenuTranslation() { Id = 35, MenuId = 18, Name = "Doanh số", LanguageId = 1 },
                new MenuTranslation() { Id = 36, MenuId = 18, Name = "Sales", LanguageId = 2 },
                new MenuTranslation() { Id = 37, MenuId = 19, Name = "Hàng hóa & Dịch vụ", LanguageId = 1 },
                new MenuTranslation() { Id = 38, MenuId = 19, Name = "Products & Services", LanguageId = 2 },
                new MenuTranslation() { Id = 39, MenuId = 20, Name = "Tồn kho", LanguageId = 1 },
                new MenuTranslation() { Id = 40, MenuId = 20, Name = "Stock", LanguageId = 2 },
                new MenuTranslation() { Id = 41, MenuId = 21, Name = "Lợi nhuận", LanguageId = 1 },
                new MenuTranslation() { Id = 42, MenuId = 21, Name = "Profit", LanguageId = 2 },
                new MenuTranslation() { Id = 43, MenuId = 22, Name = "Lãi lỗ", LanguageId = 1 },
                new MenuTranslation() { Id = 44, MenuId = 22, Name = "Profit & Loss", LanguageId = 2 },
                new MenuTranslation() { Id = 45, MenuId = 23, Name = "Báo cáo tháng", LanguageId = 1 },
                new MenuTranslation() { Id = 46, MenuId = 23, Name = "Monthly report", LanguageId = 2 },
                new MenuTranslation() { Id = 47, MenuId = 24, Name = "Danh mục", LanguageId = 1 },
                new MenuTranslation() { Id = 48, MenuId = 24, Name = "Directories", LanguageId = 2 },
                new MenuTranslation() { Id = 49, MenuId = 25, Name = "Nhóm hàng hóa", LanguageId = 1 },
                new MenuTranslation() { Id = 50, MenuId = 25, Name = "Product types", LanguageId = 2 },
                new MenuTranslation() { Id = 51, MenuId = 26, Name = "Đơn vị tính", LanguageId = 1 },
                new MenuTranslation() { Id = 52, MenuId = 26, Name = "Units", LanguageId = 2 },
                new MenuTranslation() { Id = 53, MenuId = 27, Name = "Bán hàng Online", LanguageId = 1 },
                new MenuTranslation() { Id = 54, MenuId = 27, Name = "Sale Online", LanguageId = 2 },
                new MenuTranslation() { Id = 55, MenuId = 28, Name = "Nhân viên", LanguageId = 1 },
                new MenuTranslation() { Id = 56, MenuId = 28, Name = "Staff", LanguageId = 2 },
                new MenuTranslation() { Id = 57, MenuId = 29, Name = "Bảng lương", LanguageId = 1 },
                new MenuTranslation() { Id = 58, MenuId = 29, Name = "Payroll", LanguageId = 2 },
                new MenuTranslation() { Id = 59, MenuId = 30, Name = "Cài đặt", LanguageId = 1 },
                new MenuTranslation() { Id = 60, MenuId = 30, Name = "Setting", LanguageId = 2 },
                new MenuTranslation() { Id = 61, MenuId = 31, Name = "Nhân viên", LanguageId = 1 },
                new MenuTranslation() { Id = 62, MenuId = 31, Name = "Staffs", LanguageId = 2 },
                new MenuTranslation() { Id = 63, MenuId = 32, Name = "Phân quyền", LanguageId = 1 },
                new MenuTranslation() { Id = 64, MenuId = 32, Name = "Roles", LanguageId = 2 },
                new MenuTranslation() { Id = 65, MenuId = 33, Name = "Cửa hàng", LanguageId = 1 },
                new MenuTranslation() { Id = 66, MenuId = 33, Name = "Stores", LanguageId = 2 },
                new MenuTranslation() { Id = 67, MenuId = 34, Name = "Mẫu in", LanguageId = 1 },
                new MenuTranslation() { Id = 68, MenuId = 34, Name = "Document templates", LanguageId = 2 },
                new MenuTranslation() { Id = 69, MenuId = 35, Name = "Danh mục hệ thống", LanguageId = 1 },
                new MenuTranslation() { Id = 70, MenuId = 35, Name = "System directories", LanguageId = 2 },
                new MenuTranslation() { Id = 71, MenuId = 36, Name = "Menu", LanguageId = 1 },
                new MenuTranslation() { Id = 72, MenuId = 36, Name = "Menu", LanguageId = 2 },
                new MenuTranslation() { Id = 73, MenuId = 37, Name = "Loại mẫu in", LanguageId = 1 },
                new MenuTranslation() { Id = 74, MenuId = 37, Name = "Document printing template type", LanguageId = 2 },
                new MenuTranslation() { Id = 75, MenuId = 38, Name = "Website", LanguageId = 1 },
                new MenuTranslation() { Id = 76, MenuId = 38, Name = "Website", LanguageId = 2 },
                new MenuTranslation() { Id = 77, MenuId = 39, Name = "Bài viết", LanguageId = 1 },
                new MenuTranslation() { Id = 78, MenuId = 39, Name = "Post", LanguageId = 2 },
                new MenuTranslation() { Id = 79, MenuId = 40, Name = "Chuyên mục", LanguageId = 1 },
                new MenuTranslation() { Id = 80, MenuId = 40, Name = "Categories", LanguageId = 2 },
                new MenuTranslation() { Id = 81, MenuId = 41, Name = "Slider", LanguageId = 1},
                new MenuTranslation() { Id = 82, MenuId = 41, Name = "Slider", LanguageId = 2 },
                new MenuTranslation() { Id = 83, MenuId = 42, Name = "Nhà sản xuất", LanguageId = 1 },
                new MenuTranslation() { Id = 84, MenuId = 42, Name = "Manufacturer", LanguageId = 2 },
                new MenuTranslation() { Id = 85, MenuId = 43, Name = "Thuộc tính sản phẩm", LanguageId = 1 },
                new MenuTranslation() { Id = 86, MenuId = 43, Name = "Attribute", LanguageId = 2 },
                new MenuTranslation() { Id = 87, MenuId = 44, Name = "Trạng thái", LanguageId = 1 },
                new MenuTranslation() { Id = 88, MenuId = 44, Name = "Status", LanguageId = 2 },
                new MenuTranslation() { Id = 89, MenuId = 45, Name = "Trạng thái người sử dụng", LanguageId = 1 },
                new MenuTranslation() { Id = 90, MenuId = 45, Name = "User status", LanguageId = 2 },
                new MenuTranslation() { Id = 91, MenuId = 46, Name = "Trạng thái đơn hàng", LanguageId = 1 },
                new MenuTranslation() { Id = 92, MenuId = 46, Name = "Order status", LanguageId = 2 },
                new MenuTranslation() { Id = 93, MenuId = 47, Name = "Trạng thái phiếu kế toán", LanguageId = 1 },
                new MenuTranslation() { Id = 94, MenuId = 47, Name = "Phiếu kế toán status", LanguageId = 2 },
                new MenuTranslation() { Id = 95, MenuId = 48, Name = "Trạng thái bài viết", LanguageId = 1 },
                new MenuTranslation() { Id = 96, MenuId = 48, Name = "Post status", LanguageId = 2 },
                new MenuTranslation() { Id = 97, MenuId = 49, Name = "Trạng thái loại bài viết", LanguageId = 1 },
                new MenuTranslation() { Id = 98, MenuId = 49, Name = "Post type status", LanguageId = 2 },
                new MenuTranslation() { Id = 99, MenuId = 50, Name = "Trạng thái slide", LanguageId = 1 },
                new MenuTranslation() { Id = 100, MenuId = 50, Name = "Slide status", LanguageId = 2 },
                new MenuTranslation() { Id = 101, MenuId = 51, Name = "Trạng thái cửa hàng", LanguageId = 1 },
                new MenuTranslation() { Id = 102, MenuId = 51, Name = "Store status", LanguageId = 2 },
                new MenuTranslation() { Id = 103, MenuId = 52, Name = "Giá trị thuộc tính", LanguageId = 1 },
                new MenuTranslation() { Id = 104, MenuId = 52, Name = "Attribute value", LanguageId = 2 }, 
                new MenuTranslation() { Id = 105, MenuId = 53, Name = "Khổ giấy", LanguageId = 1 },
                new MenuTranslation() { Id = 106, MenuId = 53, Name = "Paper size", LanguageId = 2 },
                new MenuTranslation() { Id = 107, MenuId = 54, Name = "Loại người sử dụng", LanguageId = 1 },
                new MenuTranslation() { Id = 108, MenuId = 54, Name = "App user type", LanguageId = 2 },
                new MenuTranslation() { Id = 109, MenuId = 55, Name = "Bán hàng", LanguageId = 1 },
                new MenuTranslation() { Id = 110, MenuId = 55, Name = "Sales", LanguageId = 2 },
                new MenuTranslation() { Id = 111, MenuId = 56, Name = "Chương trình khuyến mãi", LanguageId = 1 },
                new MenuTranslation() { Id = 112, MenuId = 56, Name = "Sales Promotion", LanguageId = 2 },
                new MenuTranslation() { Id = 113, MenuId = 57, Name = "Hoa hồng - Giảm giá", LanguageId = 1 },
                new MenuTranslation() { Id = 114, MenuId = 57, Name = "Commission - Discount", LanguageId = 2 },
                new MenuTranslation() { Id = 115, MenuId = 58, Name = "Lương căn bản", LanguageId = 1 },
                new MenuTranslation() { Id = 116, MenuId = 58, Name = "Basic salary", LanguageId = 2 },
                new MenuTranslation() { Id = 117, MenuId = 59, Name = "Menu", LanguageId = 1 },
                new MenuTranslation() { Id = 118, MenuId = 59, Name = "Menu", LanguageId = 2 },
                new MenuTranslation() { Id = 119, MenuId = 60, Name = "Đặt lịch", LanguageId = 1 },
                new MenuTranslation() { Id = 120, MenuId = 60, Name = "Booking", LanguageId = 2 },
                new MenuTranslation() { Id = 121, MenuId = 61, Name = "Liên hệ", LanguageId = 1 },
                new MenuTranslation() { Id = 122, MenuId = 61, Name = "Contact", LanguageId = 2 },
                new MenuTranslation() { Id = 123, MenuId = 62, Name = "Thông tin liên hệ", LanguageId = 1 },
                new MenuTranslation() { Id = 124, MenuId = 62, Name = "Contact information", LanguageId = 2 },
                new MenuTranslation() { Id = 125, MenuId = 63, Name = "Newsletter", LanguageId = 1 },
                new MenuTranslation() { Id = 126, MenuId = 63, Name = "Newsletter", LanguageId = 2 },
                new MenuTranslation() { Id = 127, MenuId = 64, Name = "Testimonial", LanguageId = 1 },
                new MenuTranslation() { Id = 128, MenuId = 64, Name = "Testimonial", LanguageId = 2 },
                new MenuTranslation() { Id = 129, MenuId = 65, Name = "In mã QR", LanguageId = 1 },
                new MenuTranslation() { Id = 130, MenuId = 65, Name = "Print QR code", LanguageId = 2 }
            );

            //MenuAppRoles
            modelBuilder.Entity<MenuAppRole>().HasData(
                new MenuAppRole() { Id = 1, MenuId = 1, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 2, MenuId = 1, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 3, MenuId = 1, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 4, MenuId = 2, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 5, MenuId = 2, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 6, MenuId = 2, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 7, MenuId = 3, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 8, MenuId = 3, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 9, MenuId = 3, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 10, MenuId = 4, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 11, MenuId = 4, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 12, MenuId = 4, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 13, MenuId = 5, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 14, MenuId = 5, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 15, MenuId = 5, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 16, MenuId = 6, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 17, MenuId = 6, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 18, MenuId = 6, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 19, MenuId = 7, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 20, MenuId = 7, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 21, MenuId = 7, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 22, MenuId = 8, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 23, MenuId = 8, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 24, MenuId = 8, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 25, MenuId = 9, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 26, MenuId = 9, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 27, MenuId = 9, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 28, MenuId = 10, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 29, MenuId = 10, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 30, MenuId = 10, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 31, MenuId = 11, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 32, MenuId = 11, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 33, MenuId = 11, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 34, MenuId = 12, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 35, MenuId = 12, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 36, MenuId = 12, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 37, MenuId = 13, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 38, MenuId = 13, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 39, MenuId = 13, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 40, MenuId = 14, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 41, MenuId = 14, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 42, MenuId = 14, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 43, MenuId = 15, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 44, MenuId = 15, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 45, MenuId = 15, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 46, MenuId = 16, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 47, MenuId = 16, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 48, MenuId = 16, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 49, MenuId = 17, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 50, MenuId = 17, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 51, MenuId = 17, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 52, MenuId = 18, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 53, MenuId = 18, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 54, MenuId = 18, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 55, MenuId = 19, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 56, MenuId = 19, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 57, MenuId = 19, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 58, MenuId = 20, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 59, MenuId = 20, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 60, MenuId = 20, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 61, MenuId = 21, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 62, MenuId = 21, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 63, MenuId = 21, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 64, MenuId = 22, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 65, MenuId = 22, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 66, MenuId = 22, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 67, MenuId = 23, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 68, MenuId = 23, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 69, MenuId = 23, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 70, MenuId = 24, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 71, MenuId = 24, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 72, MenuId = 24, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 73, MenuId = 25, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 74, MenuId = 25, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 75, MenuId = 25, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 76, MenuId = 26, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 77, MenuId = 26, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 78, MenuId = 26, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 79, MenuId = 27, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 80, MenuId = 27, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 81, MenuId = 27, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 82, MenuId = 28, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 83, MenuId = 28, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 84, MenuId = 28, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 85, MenuId = 29, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 86, MenuId = 29, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 87, MenuId = 29, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 88, MenuId = 30, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 89, MenuId = 30, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 90, MenuId = 30, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 91, MenuId = 31, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 92, MenuId = 31, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 93, MenuId = 31, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 94, MenuId = 32, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 95, MenuId = 32, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 96, MenuId = 32, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 97, MenuId = 33, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 98, MenuId = 33, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 99, MenuId = 33, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 100, MenuId = 34, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 101, MenuId = 34, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 102, MenuId = 34, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 103, MenuId = 35, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 104, MenuId = 35, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 105, MenuId = 35, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 106, MenuId = 36, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 107, MenuId = 36, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 108, MenuId = 36, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 109, MenuId = 37, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 110, MenuId = 37, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 111, MenuId = 37, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 112, MenuId = 38, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 113, MenuId = 38, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 114, MenuId = 38, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 115, MenuId = 39, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 116, MenuId = 39, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 117, MenuId = 39, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 118, MenuId = 40, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 119, MenuId = 40, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 120, MenuId = 40, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 121, MenuId = 41, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 122, MenuId = 41, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 123, MenuId = 41, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 124, MenuId = 42, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 125, MenuId = 42, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 126, MenuId = 42, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 127, MenuId = 43, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 128, MenuId = 43, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 129, MenuId = 43, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 130, MenuId = 44, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 131, MenuId = 44, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 132, MenuId = 44, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 133, MenuId = 45, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 134, MenuId = 45, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 135, MenuId = 45, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 136, MenuId = 46, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 137, MenuId = 46, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 138, MenuId = 46, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 139, MenuId = 47, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 140, MenuId = 47, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 141, MenuId = 47, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 142, MenuId = 48, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 143, MenuId = 48, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 144, MenuId = 48, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 145, MenuId = 49, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 146, MenuId = 49, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 147, MenuId = 49, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 148, MenuId = 50, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 149, MenuId = 50, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 150, MenuId = 50, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 151, MenuId = 51, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 152, MenuId = 51, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 153, MenuId = 51, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 154, MenuId = 52, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 155, MenuId = 52, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 156, MenuId = 52, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 157, MenuId = 53, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 158, MenuId = 53, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 159, MenuId = 53, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 160, MenuId = 54, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 161, MenuId = 54, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 162, MenuId = 54, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 163, MenuId = 55, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 164, MenuId = 55, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 165, MenuId = 55, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 166, MenuId = 56, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 167, MenuId = 56, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 168, MenuId = 56, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 169, MenuId = 57, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 170, MenuId = 57, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 171, MenuId = 57, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 172, MenuId = 58, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 173, MenuId = 58, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 174, MenuId = 58, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 175, MenuId = 59, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 176, MenuId = 59, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 177, MenuId = 59, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 178, MenuId = 60, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 179, MenuId = 60, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 180, MenuId = 60, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 181, MenuId = 61, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 182, MenuId = 61, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 183, MenuId = 61, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 184, MenuId = 62, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 185, MenuId = 62, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 186, MenuId = 62, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 187, MenuId = 63, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 188, MenuId = 63, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 189, MenuId = 63, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 190, MenuId = 64, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 191, MenuId = 64, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 192, MenuId = 64, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true },
                new MenuAppRole() { Id = 193, MenuId = 65, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataView, IsAllow = true },
                new MenuAppRole() { Id = 194, MenuId = 65, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataEdit, IsAllow = true },
                new MenuAppRole() { Id = 195, MenuId = 65, AppRoleId = administratorRoleId, MenuAppRoleType = MenuAppRoleType.GlobalDataDelete, IsAllow = true }
            );

            //Manufacturer
            modelBuilder.Entity<Manufacturer>().HasData(
               new Manufacturer() { Id = 1, Code = "NSX1" },
               new Manufacturer() { Id = 2, Code = "NSX2" },
               new Manufacturer() { Id = 3, Code = "NSX3" },
               new Manufacturer() { Id = 4, Code = "NSX4" }

            );
            modelBuilder.Entity<ManufacturerTranslation>().HasData(
                new ManufacturerTranslation() { Id = 1, ManufacturerId = 1, Name = "Nhà sản xuất 1", LanguageId = 1 },
                new ManufacturerTranslation() { Id = 2, ManufacturerId = 1, Name = "Manufacturer 1", LanguageId = 2 },
                new ManufacturerTranslation() { Id = 3, ManufacturerId = 2, Name = "Nhà sản xuất 2", LanguageId = 1 },
                new ManufacturerTranslation() { Id = 4, ManufacturerId = 2, Name = "Manufacturer 2", LanguageId = 2 },
                new ManufacturerTranslation() { Id = 5, ManufacturerId = 3, Name = "Nhà sản xuất 3", LanguageId = 1 },
                new ManufacturerTranslation() { Id = 6, ManufacturerId = 3, Name = "Manufacturer 3", LanguageId = 2 },
                new ManufacturerTranslation() { Id = 7, ManufacturerId = 4, Name = "Nhà sản xuất 4", LanguageId = 1 },
                new ManufacturerTranslation() { Id = 8, ManufacturerId = 4, Name = "Manufacturer 4", LanguageId = 2 }
            );

            //Attribute
            modelBuilder.Entity<Entities.Attribute>().HasData(
               new Entities.Attribute() { Id = 1, Code = "KG" },
               new Entities.Attribute() { Id = 2, Code = "Size" }
            );
            modelBuilder.Entity<AttributeTranslation>().HasData(
                new AttributeTranslation() { Id = 1, AttributeId = 1, Name = "Số kí", LanguageId = 1 },
                new AttributeTranslation() { Id = 2, AttributeId = 1, Name = "Kg", LanguageId = 2 },
                new AttributeTranslation() { Id = 3, AttributeId = 2, Name = "Kích thước", LanguageId = 1 },
                new AttributeTranslation() { Id = 4, AttributeId = 2, Name = "Size", LanguageId = 2 }
            );


            //AttributeValue
            modelBuilder.Entity<Entities.AttributeValue>().HasData(
               new Entities.AttributeValue() { Id = 1, AttributeId = 1},
               new Entities.AttributeValue() { Id = 2, AttributeId = 1 }
            );
            modelBuilder.Entity<AttributeValueTranslation>().HasData(
                new AttributeValueTranslation() { Id = 1, AttributeValueId = 1, Name = "1kg", LanguageId = 1 },
                new AttributeValueTranslation() { Id = 2, AttributeValueId = 1, Name = "N/A", LanguageId = 2 },
                new AttributeValueTranslation() { Id = 3, AttributeValueId = 2, Name = "2kg", LanguageId = 1 },
                new AttributeValueTranslation() { Id = 4, AttributeValueId = 2, Name = "N/A", LanguageId = 2 }
            );

            //PaperSize
            modelBuilder.Entity<PaperSize>().HasData(
               new PaperSize() { Id = 1, Name = "58 mm", Value = 5.8},
               new PaperSize() { Id = 2, Name = "80 mm", Value = 8 },
               new PaperSize() { Id = 3, Name = "A5", Value = 21 },
               new PaperSize() { Id = 4, Name = "A4", Value = 21 }
            );

            //DocTemplates
            modelBuilder.Entity<DocTemplateType>().HasData(
               new DocTemplateType() { Id = 1, Code = "PT" },
               new DocTemplateType() { Id = 2, Code = "PC" },
               new DocTemplateType() { Id = 3, Code = "HDBHPOS" },
               new DocTemplateType() { Id = 4, Code = "PN" },
               new DocTemplateType() { Id = 5, Code = "PX" }
            );

            modelBuilder.Entity<DocTemplateTypeTranslation>().HasData(
                new DocTemplateTypeTranslation() { Id = 1, DocTemplateTypeId = 1, Name = "Phiếu thu", LanguageId = 1 },
                new DocTemplateTypeTranslation() { Id = 2, DocTemplateTypeId = 1, Name = "Receipt", LanguageId = 2 },
                new DocTemplateTypeTranslation() { Id = 3, DocTemplateTypeId = 2, Name = "Phiếu chi", LanguageId = 1 },
                new DocTemplateTypeTranslation() { Id = 4, DocTemplateTypeId = 2, Name = "Payment", LanguageId = 2 },
                new DocTemplateTypeTranslation() { Id = 5, DocTemplateTypeId = 3, Name = "Hóa đơn bán hàng POS", LanguageId = 1 },
                new DocTemplateTypeTranslation() { Id = 6, DocTemplateTypeId = 3, Name = "Invoice POS", LanguageId = 2 },
                new DocTemplateTypeTranslation() { Id = 7, DocTemplateTypeId = 4, Name = "Phiếu nhập kho", LanguageId = 1 },
                new DocTemplateTypeTranslation() { Id = 8, DocTemplateTypeId = 4, Name = "Warehouse receipt", LanguageId = 2 },
                new DocTemplateTypeTranslation() { Id = 9, DocTemplateTypeId = 5, Name = "Phiếu xuất kho", LanguageId = 1 },
                new DocTemplateTypeTranslation() { Id = 10, DocTemplateTypeId = 5, Name = "Warehouse export", LanguageId = 2 }
            );


            modelBuilder.Entity<DocTemplate>().HasData(
               new DocTemplate() { Id = 1, Name = "Phiếu thu mẫu 1", DocTemplateTypeId = 1, IsDefault = true },
               new DocTemplate() { Id = 2, Name = "Phiếu chi mẫu 1", DocTemplateTypeId = 2, IsDefault = true },
               new DocTemplate() { Id = 3, Name = "Hóa đơn bán hàng mẫu 1", DocTemplateTypeId = 3, IsDefault = true },
               new DocTemplate() { Id = 4, Name = "Phiếu nhập kho mẫu 1", DocTemplateTypeId = 4, IsDefault = true },
               new DocTemplate() { Id = 5, Name = "Phiếu xuất kho mẫu 1", DocTemplateTypeId = 5, IsDefault = true }
            );

            modelBuilder.Entity<SoDuDauKySoQuy>().HasData(
              new SoDuDauKySoQuy() { Id = 1, StoreId = 1 , Total = 2000000}
            );

         
            //WebsiteMenus
            modelBuilder.Entity<WebsiteMenu>().HasData(
                new WebsiteMenu() { Id = 1, SortOrder = 1, Code = "AboutUs", ParentId = new Nullable<int>(), Link = "/about-us", WebsiteMenuType = 1 },
                new WebsiteMenu() { Id = 2, SortOrder = 2, Code = "Pets", ParentId = new Nullable<int>(), Link = "/Pets/Index", WebsiteMenuType = 1 },
                new WebsiteMenu() { Id = 3, SortOrder = 3, Code = "Shop", ParentId = new Nullable<int>(), Link = "/Shop/Index", WebsiteMenuType = 1 },
                new WebsiteMenu() { Id = 4, SortOrder = 4, Code = "Services", ParentId = new Nullable<int>(), Link = "/Services/Index", WebsiteMenuType = 1 },
                new WebsiteMenu() { Id = 5, SortOrder = 5, Code = "Blogs", ParentId = new Nullable<int>(), Link = "/Blog/Index", WebsiteMenuType = 1 },
                new WebsiteMenu() { Id = 6, SortOrder = 6, Code = "Contact", ParentId = new Nullable<int>(), Link = "/Contact/Index", WebsiteMenuType = 1 },
                new WebsiteMenu() { Id = 7, SortOrder = 1, Code = "PetMart", ParentId = new Nullable<int>(), Link = "/Shop/Index", WebsiteMenuType = 2 },
                new WebsiteMenu() { Id = 8, SortOrder = 2, Code = "Chinovet", ParentId = new Nullable<int>(), Link = "/Vet/Index", WebsiteMenuType = 2 },
                new WebsiteMenu() { Id = 9, SortOrder = 3, Code = "ChinoSalon", ParentId = new Nullable<int>(), Link = "/Salon/Index", WebsiteMenuType = 2 },
                new WebsiteMenu() { Id = 10, SortOrder = 4, Code = "ChinoHotel", ParentId = new Nullable<int>(), Link = "/Hotel/Index", WebsiteMenuType = 2 },
                new WebsiteMenu() { Id = 11, SortOrder = 5, Code = "Training", ParentId = new Nullable<int>(), Link = "/Training/Index", WebsiteMenuType = 2 }
            );

            modelBuilder.Entity<WebsiteMenuTranslation>().HasData(
                new WebsiteMenuTranslation() { Id = 1, WebsiteMenuId = 1, Name = "About us", LanguageId = 1 },
                new WebsiteMenuTranslation() { Id = 2, WebsiteMenuId = 1, Name = "About us", LanguageId = 2 },
                new WebsiteMenuTranslation() { Id = 3, WebsiteMenuId = 2, Name = "Pets", LanguageId = 1 },
                new WebsiteMenuTranslation() { Id = 4, WebsiteMenuId = 2, Name = "Pets", LanguageId = 2 },
                new WebsiteMenuTranslation() { Id = 5, WebsiteMenuId = 3, Name = "Shop", LanguageId = 1 },
                new WebsiteMenuTranslation() { Id = 6, WebsiteMenuId = 3, Name = "Shop", LanguageId = 2 },
                new WebsiteMenuTranslation() { Id = 7, WebsiteMenuId = 4, Name = "Services", LanguageId = 1 },
                new WebsiteMenuTranslation() { Id = 8, WebsiteMenuId = 4, Name = "Services", LanguageId = 2 },
                new WebsiteMenuTranslation() { Id = 9, WebsiteMenuId = 5, Name = "Blogs", LanguageId = 1 },
                new WebsiteMenuTranslation() { Id = 10, WebsiteMenuId = 5, Name = "Blogs", LanguageId = 2 },
                new WebsiteMenuTranslation() { Id = 11, WebsiteMenuId = 6, Name = "Contact", LanguageId = 1 },
                new WebsiteMenuTranslation() { Id = 12, WebsiteMenuId = 6, Name = "Contact", LanguageId = 2 },
                new WebsiteMenuTranslation() { Id = 13, WebsiteMenuId = 7, Name = "Pet Mart", LanguageId = 1 },
                new WebsiteMenuTranslation() { Id = 14, WebsiteMenuId = 7, Name = "Pet Mart", LanguageId = 2 },
                new WebsiteMenuTranslation() { Id = 15, WebsiteMenuId = 8, Name = "Chino Vet", LanguageId = 1 },
                new WebsiteMenuTranslation() { Id = 16, WebsiteMenuId = 8, Name = "Chino Vet", LanguageId = 2 },
                new WebsiteMenuTranslation() { Id = 17, WebsiteMenuId = 9, Name = "Chino Salon", LanguageId = 1 },
                new WebsiteMenuTranslation() { Id = 18, WebsiteMenuId = 9, Name = "Chino Salon", LanguageId = 2 },
                new WebsiteMenuTranslation() { Id = 19, WebsiteMenuId = 10, Name = "Chino Hotel", LanguageId = 1 },
                new WebsiteMenuTranslation() { Id = 20, WebsiteMenuId = 10, Name = "Chino Hotel", LanguageId = 2 },
                new WebsiteMenuTranslation() { Id = 21, WebsiteMenuId = 11, Name = "Training", LanguageId = 1 },
                new WebsiteMenuTranslation() { Id = 22, WebsiteMenuId = 11, Name = "Training", LanguageId = 2 }
            );

            //ContactInformation
            modelBuilder.Entity<ContactInformation>().HasData(
               new ContactInformation() { 
                   Id = 1, 
                   Address = "29 Trần Trọng Cung, Q.7, TP. HCM", 
                   PhoneNumber = "037 6505247", 
                   Email = "hello@chinopet.com",
                   IsDefault = true,
                   FacebookLink = "/Chinopetvn",
                   InstagramLink = "https://www.instagram.com/",
                   YoutubeLink = "https://www.youtube.com/"
               }
            );

            //Testimonial
            modelBuilder.Entity<Testimonial>().HasData(
               new Testimonial()
               {
                   Id = 1,
                   Code = "Le Quang Teo",
                   Name = "It's Amazing",
                   Description = string.Empty
               }
            );

            //demo data
            modelBuilder.Entity<BasicSalary> ().HasData(
               new BasicSalary() { Id = 1, Code = "001", Value = 1000000, FromDate = DateTime.Now, IsApply = true },
               new BasicSalary() { Id = 2, Code = "002", Value = 2000000, FromDate = DateTime.Now, IsApply = true },
               new BasicSalary() { Id = 3, Code = "003", Value = 3000000, FromDate = DateTime.Now, IsApply = true }
            );
            modelBuilder.Entity<BasicSalaryTranslation>().HasData(
                new BasicSalaryTranslation() { Id = 1, BasicSalaryId = 1, Name = "Quản lý", LanguageId = 1},
                new BasicSalaryTranslation() { Id = 2, BasicSalaryId = 1, Name = "N/A", LanguageId = 2 },
                new BasicSalaryTranslation() { Id = 3, BasicSalaryId = 2, Name = "Nhân viên", LanguageId = 1 },
                new BasicSalaryTranslation() { Id = 4, BasicSalaryId = 2, Name = "N/A", LanguageId = 2 },
                new BasicSalaryTranslation() { Id = 5, BasicSalaryId = 3, Name = "Quản lý kho", LanguageId = 1 },
                new BasicSalaryTranslation() { Id = 6, BasicSalaryId = 3, Name = "N/A", LanguageId = 2 }
             );

       

            modelBuilder.Entity<CommissionDiscount>().HasData(
               new CommissionDiscount() { Id = 1, Commission = 0, CommissionPercent = 2, Discount = 0, DiscountPercent = 10, FromDate = new DateTime(2021, 9, 1), IsApply = true },
               new CommissionDiscount() { Id = 2, Commission = 0, CommissionPercent = 5, Discount = 0, DiscountPercent = 15, FromDate = new DateTime(2021, 9, 1), IsApply = true }
            );
            modelBuilder.Entity<CommissionDiscountTranslation>().HasData(
                new CommissionDiscountTranslation() { Id = 1, CommissionDiscountId = 1, Name = "Nhân viên thử việc", LanguageId = 1 },
                new CommissionDiscountTranslation() { Id = 2, CommissionDiscountId = 1, Name = "N/A", LanguageId = 2 },
                new CommissionDiscountTranslation() { Id = 3, CommissionDiscountId = 2, Name = "Nhân viên chính thức", LanguageId = 1 },
                new CommissionDiscountTranslation() { Id = 4, CommissionDiscountId = 2, Name = "N/A", LanguageId = 2 }
            );

          

            modelBuilder.Entity<Promotion>().HasData(
                new Promotion() { Id = 1, Code = "001", FromDate = DateTime.Now, IsApply = true },
                new Promotion() { Id = 2, Code = "002", FromDate = DateTime.Now, IsApply = true }
            );
            modelBuilder.Entity<PromotionTranslation>().HasData(
                new PromotionTranslation() { Id = 1, PromotionId = 1, Name = "Ưu đãi nhân viên", LanguageId = 1 },
                new PromotionTranslation() { Id = 2, PromotionId = 1, Name = "N/A", LanguageId = 2 },
                new PromotionTranslation() { Id = 3, PromotionId = 2, Name = "Chương trình trung thu", LanguageId = 1 },
                new PromotionTranslation() { Id = 4, PromotionId = 2, Name = "N/A", LanguageId = 2 }
            );

            modelBuilder.Entity<Promotion_CommissionDiscount>().HasData(
                new Promotion_CommissionDiscount() { Id = 1, PromotionId = 1, CommissionDiscountId = 1 },
                new Promotion_CommissionDiscount() { Id = 2, PromotionId = 1, CommissionDiscountId = 2 }
            );






            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0,
                    CreatedDate = DateTime.Now,
                    IsPOS = true,
                    IsWeb = true,
                    AllowSellWhenNotEnough = true,
                    InventoryWarning = 0,
                    Url = "hang-hoa-1",
                    ProductTitle = "Hàng hóa 1",
                    ManufactuerId = 1,
                    IsHasSKU = true,
                    Code = "SP0000001",
                    IsVisibled = true
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 2,
                    OriginalPrice = 3000000,
                    Price = 6500000,
                    Stock = 0,
                    ViewCount = 0,
                    CreatedDate = DateTime.Now,
                    IsPOS = true,
                    IsWeb = true,
                    AllowSellWhenNotEnough = true,
                    InventoryWarning = 0,
                    Url = "dich-vu-2",
                    ProductTitle = "Dịch vụ 2",
                    ManufactuerId = 1,
                    IsHasSKU = true,
                    Code = "SP0000002",
                    IsVisibled = true
                }
            );

            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation() { Id = 1, ProductId = 1, Name = "Hàng hóa 1", LanguageId = 1, SeoAlias = "hang-hoa-1", SeoDescription = "Hàng hóa 1", SeoTitle = "Hàng hóa 1", Details = "Hàng hóa 1", Description = "Hàng hóa 1" },
                new ProductTranslation() { Id = 2, ProductId = 1, Name = "Product 1", LanguageId = 2, SeoAlias = "product-1", SeoDescription = "Product 1", SeoTitle = "Product 1", Details = "Product 1", Description = "Product 1" },
                 new ProductTranslation() { Id = 3, ProductId = 2, Name = "Dịch vụ 2", LanguageId = 1, SeoAlias = "dich-vu-2", SeoDescription = "Dịch vụ 2", SeoTitle = "Dịch vụ 2", Details = "Dịch vụ 2", Description = "Dịch vụ 2" },
                new ProductTranslation() { Id = 4, ProductId =2 , Name = "Service 2", LanguageId = 2, SeoAlias = "service-2", SeoDescription = "Service 2", SeoTitle = "Service 2", Details = "Service 2", Description = "Service 2" }
            );


            modelBuilder.Entity<ProductInProductType>().HasData(
                new ProductInProductType() { ProductId = 1, ProductTypeId = 1 },
                new ProductInProductType() { ProductId = 2, ProductTypeId = 2 }
            );


            modelBuilder.Entity<ProductSKU>().HasData(
                new ProductSKU() { Id = 1, ProductId = 1, Code = "SP0000001", Name = "Hàng hóa 1", Price = 650000, BuyingPrice = 1050000, QtyInStock = 10 },
                new ProductSKU() { Id = 2, ProductId = 2, Code = "SP0000002", Name = "Dịch vụ_1kg", Price = 650000, BuyingPrice = 1050000, QtyInStock = 10 },
                new ProductSKU() { Id = 3, ProductId = 2, Code = "SP0000003", Name = "Dịch vụ_2kg", Price = 650000, BuyingPrice = 1050000, QtyInStock = 10 }
            );


            modelBuilder.Entity<ProductSKU_AttributeValue>().HasData(
               new ProductSKU_AttributeValue() { Id = 1, ProductSKUId = 2, AttributeValueId =1 },
               new ProductSKU_AttributeValue() { Id = 2, ProductSKUId = 3, AttributeValueId = 2 }
           );
            
        }
    }
}