﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using SnailApp.Application.Common;
using SnailApp.Data.Entities;
using SnailApp.Application.Accountants;
using SnailApp.Application.News.Posts;
using SnailApp.Application.News.Newsletters;
using SnailApp.Application.News.Testimonials;
using SnailApp.Application.Catalog.PostTypes;
using SnailApp.Application.Catalog.ProductTypes;
using SnailApp.Application.Catalog.Products;
using SnailApp.Application.Catalog.ProductSKUs;
using SnailApp.Application.Catalog.Stores;
using SnailApp.Application.Catalog.CustomerTypes;
using SnailApp.Application.Catalog.Manufacturers;
using SnailApp.Application.Catalog.Units;
using SnailApp.Application.Catalog.Attributes;
using SnailApp.Application.Catalog.AttributeValues;
using SnailApp.Application.Catalog.DocTemplateTypes;
using SnailApp.Application.Catalog.PaperSizes;
using SnailApp.Application.Catalog.PetServiceSelections;
using SnailApp.Application.HR.Payrolls;
using SnailApp.Application.HR.PayrollDetails;
using SnailApp.Application.HR.BasicSalaries;
using SnailApp.Application.Sales.Contacts;
using SnailApp.Application.Sales.Bookings;
using SnailApp.Application.Sales.Carts;
using SnailApp.Application.Sales.CommissionDiscounts;
using SnailApp.Application.Sales.Transactions;
using SnailApp.Application.Sales.Promotion_CommissionDiscounts;
using SnailApp.Application.Sales.Promotion_ProductSKUs;
using SnailApp.Application.SystemApplication.AppConfigs;
using SnailApp.Application.Sales.Promotions;
using SnailApp.Application.SystemApplication.Languages;
using SnailApp.Application.SystemApplication.DocTemplates;
using SnailApp.Application.SystemApplication.Menus;
using SnailApp.Application.SystemApplication.MenuAppRoles;
using SnailApp.Application.SystemApplication.AppRoles;
using SnailApp.Application.SystemApplication.Users;
using SnailApp.Application.SystemApplication.Statuses;
using SnailApp.Application.SystemApplication.ContactInformation;
using SnailApp.Application.Utilities.Slides;
using SnailApp.Application.Utilities.UI;
using SnailApp.Application.Catalog.Genders;
using SnailApp.Application.Website.WebsiteUIs;
using SnailApp.Application.Website.WebsiteMenus;
using SnailApp.Application.Catalog.Clinics;

namespace SnailApp.Application
{
    public static class DIService
    {
        public static IServiceCollection AddDIService(this IServiceCollection services)
        {
            services.AddTransient<IAdminAppUIService, AdminAppUIService>();
            services.AddTransient<IAttributeService, AttributeService>();            
           
            services.AddTransient<IBasicSalaryService, BasicSalaryService>();
            services.AddTransient<IBookingService, BookingService>();
            services.AddTransient<ICartService, CartService>();
            services.AddTransient<ICommissionDiscountService, CommissionDiscountService>();
            services.AddTransient<IContactService, ContactService>();
            services.AddTransient<IContactInformationService, ContactInformationService>();
            services.AddTransient<ICustomerTypeService, CustomerTypeService>();
            services.AddTransient<IDocTemplateService, DocTemplateService>();
            services.AddTransient<IDocTemplateTypeService, DocTemplateTypeService>();
            services.AddTransient<IFileStorageService, FileStorageService>();
            services.AddTransient<IManufacturerService, ManufacturerService>();
            services.AddTransient<INewsletterService, NewsletterService>();
            services.AddTransient<IPaperSizeService, PaperSizeService>();
            services.AddTransient<IPayrollService, PayrollService>();
            services.AddTransient<IPayrollDetailService, PayrollDetailService>();
            services.AddTransient<IPetServiceSelectionService, PetServiceSelectionService>();
            services.AddTransient<IPostService, PostService>();
            services.AddTransient<IPostStatusService, PostStatusService>();
            services.AddTransient<IPostTypeService, PostTypeService>();
            services.AddTransient<IPostTypeStatusService, PostTypeStatusService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IProductTypeService, ProductTypeService>();
            services.AddTransient<IProductTypeStatusService, ProductTypeStatusService>();
            services.AddTransient<IProductSKUService, ProductSKUService>();
            services.AddTransient<IPromotionService, PromotionService>();
            services.AddTransient<IPromotion_CommissionDiscountService, Promotion_CommissionDiscountService>();
            services.AddTransient<IPromotion_ProductSKUService, Promotion_ProductSKUService>();
            services.AddTransient<IOrderStatusService, OrderStatusService>();
            services.AddTransient<ISlideService, SlideService>();
            services.AddTransient<ISlideStatusService, SlideStatusService>();
            services.AddTransient<IStoreService, StoreService>();
            services.AddTransient<IStoreStatusService, StoreStatusService>();
            services.AddTransient<ITransactionService, TransactionService>();
            services.AddTransient<ITestimonialService, TestimonialService>();
            services.AddTransient<IUnitService, UnitService>();
            services.AddTransient<IAttributeService, AttributeService>();
            services.AddTransient<IAttributeValueService, AttributeValueService>();
            services.AddTransient<IReportCashBookService, ReportCashBookService>();
            services.AddTransient<IReportWarehouseService, ReportWarehouseService>();
            services.AddTransient<IReportSummaryService, ReportSummaryService>();
            services.AddTransient<IGenderService, GenderService>();
            services.AddTransient<IReportMonthlyService, ReportMonthlyService>();
            services.AddTransient<IReportProfitAndLossService, ReportProfitAndLossService>();
            services.AddTransient<IReportProfitService, ReportProfitService>();
            services.AddTransient<IReportProductService, ReportProductService>();
            services.AddTransient<IWebsiteMenuService, WebsiteMenuService>();
            services.AddTransient<IWebsiteUIService, WebsiteUIService>();




            //New Clinic
            services.AddTransient<RoleManager<AppRole>, RoleManager<AppRole>>();
            services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<UserManager<AppUser>, UserManager<AppUser>>();
            services.AddTransient<IAppConfigService, AppConfigService>();
            services.AddTransient<IAppRoleService, AppRoleService>();
            services.AddTransient<ILanguageService, LanguageService>();
            services.AddTransient<IMenuService, MenuService>();
            services.AddTransient<IMenuAppRoleService, MenuAppRoleService>();

            services.AddTransient<IClinicService, ClinicService>();

            return services;
        }
    }
}
