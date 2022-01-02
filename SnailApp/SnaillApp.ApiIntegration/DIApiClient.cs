using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;

namespace SnailApp.ApiIntegration
{
    public static class DIApiClient
    {
        public static IServiceCollection AddDIApiClient(this IServiceCollection services)
        {
            services.AddTransient<IAdminAppUIApiClient, AdminAppUIApiClient>();
            services.AddTransient<IAppConfigApiClient, AppConfigApiClient>();
            services.AddTransient<IAppRoleApiClient, AppRoleApiClient>();
            services.AddTransient<IAppUserStatusApiClient, AppUserStatusApiClient>();
            services.AddTransient<IAppUserTypeApiClient, AppUserTypeApiClient>();
            services.AddTransient<IAppUser_AppUserTypeApiClient, AppUser_AppUserTypeApiClient>();
            services.AddTransient<IAppUser_CommissionDiscountApiClient, AppUser_CommissionDiscountApiClient>();
            services.AddTransient<IAppUser_BasicSalaryApiClient, AppUser_BasicSalaryApiClient>();
            services.AddTransient<IAttributeApiClient, AttributeApiClient>();
            services.AddTransient<IBasicSalaryApiClient, BasicSalaryApiClient>();
            services.AddTransient<IBookingApiClient, BookingApiClient>();
            services.AddTransient<ICartApiClient, CartApiClient>();
            services.AddTransient<ICommissionDiscountApiClient, CommissionDiscountApiClient>();
            services.AddTransient<IContactApiClient, ContactApiClient>();
            services.AddTransient<IContactInformationApiClient, ContactInformationApiClient>();
            services.AddTransient<ICustomerTypeApiClient, CustomerTypeApiClient>();
            services.AddTransient<IDocTemplateApiClient, DocTemplateApiClient>();
            services.AddTransient<IDocTemplateTypeApiClient, DocTemplateTypeApiClient>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<ILanguageApiClient, LanguageApiClient>();
            services.AddTransient<IManufacturerApiClient, ManufacturerApiClient>();
            services.AddTransient<IMenuApiClient, MenuApiClient>();
            services.AddTransient<IMenuAppRoleApiClient, MenuAppRoleApiClient>();
            services.AddTransient<INewsletterApiClient, NewsletterApiClient>();
            services.AddTransient<IOrderStatusApiClient, OrderStatusApiClient>();
            services.AddTransient<IPaperSizeApiClient, PaperSizeApiClient>();
            services.AddTransient<IPayrollApiClient, PayrollApiClient>();
            services.AddTransient<IPayrollDetailApiClient, PayrollDetailApiClient>();
            services.AddTransient<IPetServiceSelectionApiClient, PetServiceSelectionApiClient>();
            services.AddTransient<IPhieuKeToanApiClient, PhieuKeToanApiClient>();
            services.AddTransient<IPhieuKeToanStatusApiClient, PhieuKeToanStatusApiClient>();
            services.AddTransient<IPostApiClient, PostApiClient>();
            services.AddTransient<IPostStatusApiClient, PostStatusApiClient>();
            services.AddTransient<IPostTypeApiClient, PostTypeApiClient>();
            services.AddTransient<IPostTypeStatusApiClient, PostTypeStatusApiClient>();
            services.AddTransient<IProductApiClient, ProductApiClient>();
            services.AddTransient<IProductTypeApiClient, ProductTypeApiClient>();
            services.AddTransient<IProductTypeStatusApiClient, ProductTypeStatusApiClient>();
            services.AddTransient<IProductSKUApiClient, ProductSKUApiClient>();
            services.AddTransient<IPromotionApiClient, PromotionApiClient>();
            services.AddTransient<IPromotion_CommissionDiscountApiClient, Promotion_CommissionDiscountApiClient>();
            services.AddTransient<IPromotion_ProductSKUApiClient, Promotion_ProductSKUApiClient>();
            services.AddTransient<ISlideApiClient, SlideApiClient>();
            services.AddTransient<ISlideStatusApiClient, SlideStatusApiClient>();
            services.AddTransient<IStoreApiClient, StoreApiClient>();
            services.AddTransient<IStoreStatusApiClient, StoreStatusApiClient>();
            services.AddTransient<ITransactionApiClient, TransactionApiClient>();
            services.AddTransient<ITestimonialApiClient, TestimonialApiClient>();
            services.AddTransient<IUnitApiClient, UnitApiClient>();            
            services.AddTransient<IUserApiClient, UserApiClient>();            
            services.AddTransient<IAttributeValueApiClient, AttributeValueApiClient>();            
            services.AddTransient<IReportCashBookApiClient, ReportCashBookApiClient>();            
            services.AddTransient<IReportWarehouseApiClient, ReportWarehouseApiClient>();            
            services.AddTransient<IReportSummaryApiClient, ReportSummaryApiClient>();            
            services.AddTransient<IGenderApiClient, GenderApiClient>();            
            services.AddTransient<IReportMonthlyApiClient, ReportMonthlyApiClient>();            
            services.AddTransient<IReportProfitAndLossApiClient, ReportProfitAndLossApiClient>();            
            services.AddTransient<IReportProfitApiClient, ReportProfitApiClient>();            
            services.AddTransient<IReportProductApiClient, ReportProductApiClient>();
            services.AddTransient<IWebsiteMenuApiClient, WebsiteMenuApiClient>();
            services.AddTransient<IWebsiteUIApiClient, WebsiteUIApiClient>();

            return services;
        }
    }
}
