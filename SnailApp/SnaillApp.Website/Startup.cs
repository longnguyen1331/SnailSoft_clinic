using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ChinoPet.ApiIntegration;

namespace ChinoPet.Website
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient();
            
            services.AddControllersWithViews()
                    .AddSessionStateTempDataProvider();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });

            services.AddDIApiClient();

            IMvcBuilder builder = services.AddRazorPages();
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

#if DEBUG
            if (environment == Environments.Development)
            {
                builder.AddRazorRuntimeCompilation();
            }
#endif
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "blog",
                    pattern: "blog/{page?}/{search?}", new
                    {
                        controller = "Blog",
                        action = "Index"
                    }
                );

                endpoints.MapControllerRoute(
                   name: "blogCategory",
                   pattern: "blog/{url}/{page?}/{search?}", new
                   {
                       controller = "Blog",
                       action = "Category"
                   }
                );

                endpoints.MapControllerRoute(
                    name: "hotel",
                    pattern: "hotel", new
                    {
                        controller = "Hotel",
                        action = "Index"
                    });

                endpoints.MapControllerRoute(
                   name: "vet",
                   pattern: "vet", new
                   {
                       controller = "Vet",
                       action = "Index"
                   });

                endpoints.MapControllerRoute(
                   name: "salon",
                   pattern: "salon", new
                   {
                       controller = "Salon",
                       action = "Index"
                   });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
