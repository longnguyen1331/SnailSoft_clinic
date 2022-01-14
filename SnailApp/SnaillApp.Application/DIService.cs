using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using SnailApp.Application.Common;
using SnailApp.Data.Entities;
using SnailApp.Application.SystemApplication.AppConfigs;
using SnailApp.Application.SystemApplication.Languages;
using SnailApp.Application.SystemApplication.Menus;
using SnailApp.Application.SystemApplication.MenuAppRoles;
using SnailApp.Application.SystemApplication.AppRoles;
using SnailApp.Application.SystemApplication.Users;
using SnailApp.Application.Catalog.Genders;
using SnailApp.Application.Catalog.Clinics;
using SnailApp.Application.Utilities.UI;
using SnailApp.Application.Catalog.Regions;
using SnailApp.Application.Catalog.Services;
using SnailApp.Application.Catalog.Doctor_Services;
using SnailApp.Application.Catalog.Appointments;
using SnailApp.Application.Catalog.AppointmentPayments;

namespace SnailApp.Application
{
    public static class DIService
    {
        public static IServiceCollection AddDIService(this IServiceCollection services)
        {
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
            services.AddTransient<IAdminAppUIService, AdminAppUIService>();
            services.AddTransient<IClinicService, ClinicService>();
            services.AddTransient<IGenderService, GenderService>();
            services.AddTransient<IFileStorageService, FileStorageService>();
            services.AddTransient<IUser_ClinicService, User_ClinicService>();
            services.AddTransient<IBloodService, BloodService>();
            services.AddTransient<IRegionService, RegionService>();
            services.AddTransient<IServiceTypeService, ServiceTypeService>();
            services.AddTransient<IServiceService, ServiceService>();
            services.AddTransient<IDoctor_ServiceService, Doctor_ServiceService>();
            services.AddTransient<IAppointmentService, AppointmentService>();
            services.AddTransient<IAppointmentPaymentService, AppointmentPaymentService>();
            return services;
        }
    }
}
