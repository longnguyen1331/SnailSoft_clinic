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
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<ILanguageApiClient, LanguageApiClient>();
            services.AddTransient<IMenuApiClient, MenuApiClient>();
            services.AddTransient<IMenuAppRoleApiClient, MenuAppRoleApiClient>();
            services.AddTransient<IUserApiClient, UserApiClient>();            
            services.AddTransient<IGenderApiClient, GenderApiClient>();            


            //new Clinic
            services.AddTransient<IClinicApiClient, ClinicApiClient>();
            services.AddTransient<IBloodApiClient, BloodApiClient>();
            services.AddTransient<IRegionApiClient, RegionApiClient>();
            services.AddTransient<IServiceTypeApiClient, ServiceTypeApiClient>();
            services.AddTransient<IServiceApiClient, ServiceApiClient>();


            return services;
        }
    }
}
