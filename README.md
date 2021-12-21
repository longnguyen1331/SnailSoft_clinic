# ChinoPet project 
## Technologies
- ASP.NET Core MVC 5.0
- Entity Framework core 5.0
## Install Tools
- .NET Core SDK 3.1
- Git client
- Visual Studio 2019
- SQL Server 2019
## Youtube tutorial
- Video list: https://www.youtube.com/playlist?list=PLRhlTlpDUWsyN_FiVQrDWMtHix_E2A_UD
- TEDU Course: https://tedu.com.vn/khoa-hoc/lam-du-an-voi-aspnet-core-31-34.html
## How to configure and run
- Clone code
- Open solution ChinoPet.sln in Visual Studio 2019
- Set startup project is ChinoPet.Data
- Change connection string in Appsetting.json in ChinoPet.Data project
- Open Tools --> Nuget Package Manager -->  Package Manager Console in Visual Studio
- Run "ADD-migration db1"  and Enter.
- Run "Update-database" and Enter.
- After migrate database successful, set Startup Project is ChinoPet.WebApp
- Change database connection in appsettings.Development.json in ChinoPet.WebApp project.
- You need to change 3 projects to self-host profile.
- Set multiple run project: Right click to Solution and choose Properties and set Multiple Project, choose Start for 3 Projects: BackendApi, WebApp and AdminApp.
- Choose profile to run or press F5
## Admin template: metronic_v8, Https://preview.keenthemes.com/metronic8
## Portal template: sky theme
## I18N (Internalization)
- References: https://medium.com/swlh/step-by-step-tutorial-to-build-multi-cultural-asp-net-core-web-app-3fac9a960c43
- Source code: https://github.com/LazZiya/ExpressLocalizationSampleCore3
## Install packages for ChinoPet.Application
- Microsoft.EntityFrameworkCore
- Microsoft.AspNetCore.Http
- Microsoft.AspNetCore.Hosting
## Install packages for ChinoPet.BackendApi
- Microsoft.OpenApi
- Swashbuckle.AspNetCore
- Microsoft.IdentityModel.Tokens
- Microsoft.AspNetCore.Authentication.JwtBearer
- FluentValidation.AspNetCore
## Install packages for ChinoPet.AdminApp
- Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
- FluentValidation.AspNetCore
- Microsoft.IdentityModel.Logging
- Microsoft.IdentityModel.Tokens
- Microsoft.AspNetCore.Session
- Microsoft.AspNetCore.Http.Extensions
- System.IdentityModel.Tokens.Jwt
## Install packages for ChinoPet.Data
- microsoft.entityframeworkcore.sqlserver
- microsoft.entityframeworkcore.design
- microsoft.entityframeworkcore.tools
- Microsoft.Extensions.Configuration.FileExtensions
- Microsoft.Extensions.Configuration.Json
- Microsoft.AspNetCore.Identity
- Microsoft.AspNetCore.Identity.EntityFrameworkCore
## Install packages for ChinoPet.Utilities
- Newtonsoft.Json
- Microsoft.AspNetCore.Http
- Microsoft.AspNetCore.Http.Extensions
## Install packages for ChinoPet.ViewModel
- Microsoft.AspNetCore.Http
- FluentValidation.AspNetCore
## Install packages for ChinoPet.Website
- LazZiya.ExpressLocalization
- LazZiya.TagHelpers
## Install packages for ChinoPet.ApiIntegration
- Newtonsoft.Json