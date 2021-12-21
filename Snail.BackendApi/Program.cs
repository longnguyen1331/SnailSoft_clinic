using System.Collections.Generic;
using Snail.Data.EF;
using Snail.Data.Entities;
using Snail.Utilities.Constants;
using Snail.ViewModels.System.Users;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Snail.Application.Common;
using Snail.Application.Accountants;
using Snail.Application.News.Posts;
using Snail.Application.News.Newsletters;
using Snail.Application.News.Testimonials;
using Snail.Application.Catalog.PostTypes;
using Snail.Application.Catalog.AppUserTypes;
using Snail.Application.Catalog.ProductTypes;
using Snail.Application.Catalog.Products;
using Snail.Application.Catalog.ProductSKUs;
using Snail.Application.Catalog.Stores;
using Snail.Application.Catalog.CustomerTypes;
using Snail.Application.Catalog.Manufacturers;
using Snail.Application.Catalog.Units;
using Snail.Application.Catalog.Attributes;
using Snail.Application.Catalog.AttributeValues;
using Snail.Application.Catalog.DocTemplateTypes;
using Snail.Application.Catalog.PaperSizes;
using Snail.Application.Catalog.PetServiceSelections;
using Snail.Application.HR.Payrolls;
using Snail.Application.HR.PayrollDetails;
using Snail.Application.HR.AppUser_BasicSalaries;
using Snail.Application.HR.BasicSalaries;
using Snail.Application.Sales.Contacts;
using Snail.Application.Sales.Bookings;
using Snail.Application.Sales.Carts;
using Snail.Application.Sales.AppUser_CommissionDiscounts;
using Snail.Application.Sales.CommissionDiscounts;
using Snail.Application.Sales.Transactions;
using Snail.Application.Sales.Promotion_CommissionDiscounts;
using Snail.Application.Sales.Promotion_ProductSKUs;
using Snail.Application.SystemApplication.AppConfigs;
using Snail.Application.Sales.Promotions;
using Snail.Application.SystemApplication.Languages;
using Snail.Application.SystemApplication.DocTemplates;
using Snail.Application.SystemApplication.Menus;
using Snail.Application.SystemApplication.MenuAppRoles;
using Snail.Application.SystemApplication.AppRoles;
using Snail.Application.SystemApplication.AppUser_AppUserTypes;
using Snail.Application.SystemApplication.Users;
using Snail.Application.SystemApplication.Statuses;
using Snail.Application.SystemApplication.ContactInformation;
using Snail.Application.Utilities.Slides;
using Snail.Application.Utilities.UI;
using Snail.Application.Catalog.Genders;
using Snail.Application.Website.WebsiteUIs;
using Snail.Application.Website.WebsiteMenus;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<EShopDbContext>(options =>
              options.UseSqlServer(builder.Configuration.GetConnectionString(SystemConstants.ConnectionStringConstants.MainConnectionString)));

builder.Services.AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<EShopDbContext>()
    .AddDefaultTokenProviders();

// Truy cập IdentityOptions
builder.Services.Configure<IdentityOptions>(options =>
{
    // Thiết lập về Password
    options.Password.RequireDigit = false; // Không bắt phải có số
    options.Password.RequireLowercase = false; // Không bắt phải có chữ thường
    options.Password.RequireNonAlphanumeric = false; // Không bắt ký tự đặc biệt
    options.Password.RequireUppercase = false; // Không bắt buộc chữ in
    options.Password.RequiredLength = 3; // Số ký tự tối thiểu của password
    options.Password.RequiredUniqueChars = 1; // Số ký tự riêng biệt
});

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "_myAllowSpecificOrigins",
                      builder => builder
   .AllowAnyOrigin()
     .AllowAnyMethod()
     .AllowAnyHeader());
});

//Declare DI
//builder.Services.AddDIService();
builder.Services.AddTransient<IAdminAppUIService, AdminAppUIService>();
builder.Services.AddTransient<IAttributeService, AttributeService>();
builder.Services.AddTransient<IAppConfigService, AppConfigService>();
builder.Services.AddTransient<IAppRoleService, AppRoleService>();
builder.Services.AddTransient<IAppUserStatusService, AppUserStatusService>();
builder.Services.AddTransient<IAppUserTypeService, AppUserTypeService>();
builder.Services.AddTransient<IAppUser_AppUserTypeService, AppUser_AppUserTypeService>();
builder.Services.AddTransient<IAppUser_CommissionDiscountService, AppUser_CommissionDiscountService>();
builder.Services.AddTransient<IAppUser_BasicSalaryService, AppUser_BasicSalaryService>();
builder.Services.AddTransient<IBasicSalaryService, BasicSalaryService>();
builder.Services.AddTransient<IBookingService, BookingService>();
builder.Services.AddTransient<ICartService, CartService>();
builder.Services.AddTransient<ICommissionDiscountService, CommissionDiscountService>();
builder.Services.AddTransient<IContactService, ContactService>();
builder.Services.AddTransient<IContactInformationService, ContactInformationService>();
builder.Services.AddTransient<ICustomerTypeService, CustomerTypeService>();
builder.Services.AddTransient<IDocTemplateService, DocTemplateService>();
builder.Services.AddTransient<IDocTemplateTypeService, DocTemplateTypeService>();
builder.Services.AddTransient<IFileStorageService, FileStorageService>();
builder.Services.AddTransient<ILanguageService, LanguageService>();
builder.Services.AddTransient<IManufacturerService, ManufacturerService>();
builder.Services.AddTransient<IMenuService, MenuService>();
builder.Services.AddTransient<IMenuAppRoleService, MenuAppRoleService>();
builder.Services.AddTransient<INewsletterService, NewsletterService>();
builder.Services.AddTransient<IPaperSizeService, PaperSizeService>();
builder.Services.AddTransient<IPayrollService, PayrollService>();
builder.Services.AddTransient<IPayrollDetailService, PayrollDetailService>();
builder.Services.AddTransient<IPetServiceSelectionService, PetServiceSelectionService>();
builder.Services.AddTransient<IPhieuKeToanService, PhieuKeToanService>();
builder.Services.AddTransient<IPhieuKeToanStatusService, PhieuKeToanStatusService>();
builder.Services.AddTransient<IPostService, PostService>();
builder.Services.AddTransient<IPostStatusService, PostStatusService>();
builder.Services.AddTransient<IPostTypeService, PostTypeService>();
builder.Services.AddTransient<IPostTypeStatusService, PostTypeStatusService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IProductTypeService, ProductTypeService>();
builder.Services.AddTransient<IProductTypeStatusService, ProductTypeStatusService>();
builder.Services.AddTransient<IProductSKUService, ProductSKUService>();
builder.Services.AddTransient<IPromotionService, PromotionService>();
builder.Services.AddTransient<IPromotion_CommissionDiscountService, Promotion_CommissionDiscountService>();
builder.Services.AddTransient<IPromotion_ProductSKUService, Promotion_ProductSKUService>();
builder.Services.AddTransient<IOrderStatusService, OrderStatusService>();
builder.Services.AddTransient<ISlideService, SlideService>();
builder.Services.AddTransient<ISlideStatusService, SlideStatusService>();
builder.Services.AddTransient<IStoreService, StoreService>();
builder.Services.AddTransient<IStoreStatusService, StoreStatusService>();
builder.Services.AddTransient<ITransactionService, TransactionService>();
builder.Services.AddTransient<ITestimonialService, TestimonialService>();
builder.Services.AddTransient<IUnitService, UnitService>();
builder.Services.AddTransient<RoleManager<AppRole>, RoleManager<AppRole>>();
builder.Services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<UserManager<AppUser>, UserManager<AppUser>>();
builder.Services.AddTransient<IAttributeService, AttributeService>();
builder.Services.AddTransient<IAttributeValueService, AttributeValueService>();
builder.Services.AddTransient<IReportCashBookService, ReportCashBookService>();
builder.Services.AddTransient<IReportWarehouseService, ReportWarehouseService>();
builder.Services.AddTransient<IReportSummaryService, ReportSummaryService>();
builder.Services.AddTransient<IGenderService, GenderService>();
builder.Services.AddTransient<IReportMonthlyService, ReportMonthlyService>();
builder.Services.AddTransient<IReportProfitAndLossService, ReportProfitAndLossService>();
builder.Services.AddTransient<IReportProfitService, ReportProfitService>();
builder.Services.AddTransient<IReportProductService, ReportProductService>();
builder.Services.AddTransient<IWebsiteMenuService, WebsiteMenuService>();
builder.Services.AddTransient<IWebsiteUIService, WebsiteUIService>();

builder.Services.AddControllers()
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<LoginRequestValidator>());

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger eShop Solution", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                  {
                    {
                      new OpenApiSecurityScheme
                      {
                        Reference = new OpenApiReference
                          {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                          },
                          Scheme = "oauth2",
                          Name = "Bearer",
                          In = ParameterLocation.Header,
                        },
                        new List<string>()
                      }
                    });
});

string issuer = builder.Configuration.GetValue<string>("Tokens:Issuer");
string signingKey = builder.Configuration.GetValue<string>("Tokens:Key");
byte[] signingKeyBytes = System.Text.Encoding.UTF8.GetBytes(signingKey);

builder.Services.AddAuthentication(opt =>
{
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidIssuer = issuer,
        ValidateAudience = true,
        ValidAudience = issuer,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ClockSkew = System.TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(signingKeyBytes)
    };
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();
app.UseRouting();
app.UseCors("_myAllowSpecificOrigins");
app.UseAuthorization();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Snail V1");
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});
app.Run();