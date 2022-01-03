using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SnaillApp.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfigs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BasicSalarys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(type: "float", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsApply = table.Column<bool>(type: "bit", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicSalarys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClinicConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Favicon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondaryColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Introduction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoogleScript = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookPixel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookChat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firebase_apiKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firebase_authDomain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firebase_projectId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firebase_storageBucket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firebase_messagingSenderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firebase_appId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firebase_measurementId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClinicDomain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookAppname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookAppid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookAppsecret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookLogin = table.Column<bool>(type: "bit", nullable: false),
                    GoogleLogin = table.Column<bool>(type: "bit", nullable: false),
                    GoogleAppname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoogleApikey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoogleClientid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoogleClientsecret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicConfigs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommissionDiscounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommissionPercent = table.Column<double>(type: "float", nullable: false),
                    Commission = table.Column<double>(type: "float", nullable: false),
                    DiscountPercent = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsApply = table.Column<bool>(type: "bit", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommissionDiscounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YoutubeLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocTemplateTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocTemplateTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", unicode: false, maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuType = table.Column<int>(type: "int", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControllerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Newsletters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaperSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(type: "float", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaperSizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payrolls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payrolls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PetServiceSelections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetServiceSelections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostTypeStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTypeStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypeStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypeStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsApply = table.Column<bool>(type: "bit", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SlideStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlideStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoreStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WebsiteMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebsiteMenuType = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebsiteMenus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttributeValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeId = table.Column<int>(type: "int", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttributeValues_Attributes_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attributes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUsers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppUsers_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AboutTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", unicode: false, maxLength: 5, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Youtube = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoogleMap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutUs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutTranslations_Abouts_AboutId",
                        column: x => x.AboutId,
                        principalTable: "Abouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AboutTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppRoleTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppRoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageId = table.Column<int>(type: "int", unicode: false, maxLength: 5, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppRoleTranslations_AppRoles_AppRoleId",
                        column: x => x.AppRoleId,
                        principalTable: "AppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppRoleTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttributeTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<int>(type: "int", unicode: false, maxLength: 5, nullable: false),
                    SeoAlias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttributeTranslations_Attributes_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttributeTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BasicSalaryTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasicSalaryId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", unicode: false, maxLength: 5, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicSalaryTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasicSalaryTranslations_BasicSalarys_BasicSalaryId",
                        column: x => x.BasicSalaryId,
                        principalTable: "BasicSalarys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasicSalaryTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommissionDiscountTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommissionDiscountId = table.Column<int>(type: "int", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommissionDiscountTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommissionDiscountTranslations_CommissionDiscounts_CommissionDiscountId",
                        column: x => x.CommissionDiscountId,
                        principalTable: "CommissionDiscounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CommissionDiscountTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerTypeTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerTypeId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", unicode: false, maxLength: 5, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTypeTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerTypeTranslations_CustomerTypes_CustomerTypeId",
                        column: x => x.CustomerTypeId,
                        principalTable: "CustomerTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerTypeTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocTemplateTypeTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocTemplateTypeId = table.Column<int>(type: "int", nullable: true),
                    LanguageId = table.Column<int>(type: "int", unicode: false, maxLength: 5, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocTemplateTypeTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocTemplateTypeTranslations_DocTemplateTypes_DocTemplateTypeId",
                        column: x => x.DocTemplateTypeId,
                        principalTable: "DocTemplateTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DocTemplateTypeTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenderTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", unicode: false, maxLength: 5, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenderTranslations_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenderTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManufacturerTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufacturerTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManufacturerTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManufacturerTranslations_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ViewCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: true),
                    IsPOS = table.Column<bool>(type: "bit", nullable: true),
                    IsWeb = table.Column<bool>(type: "bit", nullable: true),
                    AllowSellWhenNotEnough = table.Column<bool>(type: "bit", nullable: true),
                    InventoryWarning = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufactuerId = table.Column<int>(type: "int", nullable: true),
                    IsHasSKU = table.Column<bool>(type: "bit", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Manufacturers_ManufactuerId",
                        column: x => x.ManufactuerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MenuAppRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppRoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    MenuAppRoleType = table.Column<byte>(type: "tinyint", nullable: false),
                    IsAllow = table.Column<bool>(type: "bit", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuAppRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuAppRoles_AppRoles_AppRoleId",
                        column: x => x.AppRoleId,
                        principalTable: "AppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuAppRoles_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", unicode: false, maxLength: 5, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuTranslations_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatusTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderStatusId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", unicode: false, maxLength: 5, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatusTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderStatusTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderStatusTranslations_OrderStatuses_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocTemplateTypeId = table.Column<int>(type: "int", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaperSizeId = table.Column<int>(type: "int", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocTemplates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocTemplates_DocTemplateTypes_DocTemplateTypeId",
                        column: x => x.DocTemplateTypeId,
                        principalTable: "DocTemplateTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DocTemplates_PaperSizes_PaperSizeId",
                        column: x => x.PaperSizeId,
                        principalTable: "PaperSizes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PayrollTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayrollId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayrollTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PayrollTranslations_Payrolls_PayrollId",
                        column: x => x.PayrollId,
                        principalTable: "Payrolls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PetWeight = table.Column<double>(type: "float", nullable: false),
                    DateContact = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PetServiceSelectionId = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_PetServiceSelections_PetServiceSelectionId",
                        column: x => x.PetServiceSelectionId,
                        principalTable: "PetServiceSelections",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PetServiceSelectionTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetServiceSelectionId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetServiceSelectionTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PetServiceSelectionTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PetServiceSelectionTranslations_PetServiceSelections_PetServiceSelectionId",
                        column: x => x.PetServiceSelectionId,
                        principalTable: "PetServiceSelections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostStatusTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostStatusId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", unicode: false, maxLength: 5, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostStatusTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostStatusTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostStatusTranslations_PostStatuses_PostStatusId",
                        column: x => x.PostStatusId,
                        principalTable: "PostStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    PostTypeStatusId = table.Column<int>(type: "int", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostTypes_PostTypeStatuses_PostTypeStatusId",
                        column: x => x.PostTypeStatusId,
                        principalTable: "PostTypeStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PostTypeStatusTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostTypeStatusId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", unicode: false, maxLength: 5, nullable: false),
                    LanguageId1 = table.Column<int>(type: "int", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTypeStatusTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostTypeStatusTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTypeStatusTranslations_Languages_LanguageId1",
                        column: x => x.LanguageId1,
                        principalTable: "Languages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PostTypeStatusTranslations_PostTypeStatuses_PostTypeStatusId",
                        column: x => x.PostTypeStatusId,
                        principalTable: "PostTypeStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypeStatusTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductTypeStatusId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", unicode: false, maxLength: 5, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypeStatusTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTypeStatusTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTypeStatusTranslations_ProductTypeStatuses_ProductTypeStatusId",
                        column: x => x.ProductTypeStatusId,
                        principalTable: "ProductTypeStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Promotion_CommissionDiscounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromotionId = table.Column<int>(type: "int", nullable: false),
                    CommissionDiscountId = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion_CommissionDiscounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Promotion_CommissionDiscounts_CommissionDiscounts_CommissionDiscountId",
                        column: x => x.CommissionDiscountId,
                        principalTable: "CommissionDiscounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Promotion_CommissionDiscounts_Promotions_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "Promotions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PromotionTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromotionId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PromotionTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PromotionTranslations_Promotions_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "Promotions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Slides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SlideStatusId = table.Column<int>(type: "int", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slides", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slides_SlideStatuses_SlideStatusId",
                        column: x => x.SlideStatusId,
                        principalTable: "SlideStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SlideStatusTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SlideStatusId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", unicode: false, maxLength: 5, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlideStatusTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SlideStatusTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SlideStatusTranslations_SlideStatuses_SlideStatusId",
                        column: x => x.SlideStatusId,
                        principalTable: "SlideStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Taxcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreStatusId = table.Column<int>(type: "int", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stores_StoreStatuses_StoreStatusId",
                        column: x => x.StoreStatusId,
                        principalTable: "StoreStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StoreStatusTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreStatusId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", unicode: false, maxLength: 5, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreStatusTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreStatusTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreStatusTranslations_StoreStatuses_StoreStatusId",
                        column: x => x.StoreStatusId,
                        principalTable: "StoreStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnitTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitTranslations_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WebsiteMenuTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WebsiteMenuId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebsiteMenuTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WebsiteMenuTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WebsiteMenuTranslations_WebsiteMenus_WebsiteMenuId",
                        column: x => x.WebsiteMenuId,
                        principalTable: "WebsiteMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttributeValueTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeValueId = table.Column<int>(type: "int", nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<int>(type: "int", unicode: false, maxLength: 5, nullable: false),
                    SeoAlias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeValueTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttributeValueTranslations_AttributeValues_AttributeValueId",
                        column: x => x.AttributeValueId,
                        principalTable: "AttributeValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttributeValueTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PayrollDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayrollId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BasicSalary = table.Column<double>(type: "float", nullable: false),
                    Commission = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayrollDetails_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PayrollDetails_Payrolls_PayrollId",
                        column: x => x.PayrollId,
                        principalTable: "Payrolls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExternalTransactionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Carts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteProducts_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSKUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    BuyingPrice = table.Column<double>(type: "float", nullable: false),
                    QtyInStock = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSKUs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSKUs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoAlias = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LanguageId = table.Column<int>(type: "int", unicode: false, maxLength: 5, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTranslations_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    PostTypeId = table.Column<int>(type: "int", nullable: true),
                    PostStatusId = table.Column<int>(type: "int", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_PostStatuses_PostStatusId",
                        column: x => x.PostStatusId,
                        principalTable: "PostStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Posts_PostTypes_PostTypeId",
                        column: x => x.PostTypeId,
                        principalTable: "PostTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PostTypeTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostTypeId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoAlias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTypeTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostTypeTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTypeTranslations_PostTypes_PostTypeId",
                        column: x => x.PostTypeId,
                        principalTable: "PostTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SlideTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SlideId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlideTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SlideTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SlideTranslations_Slides_SlideId",
                        column: x => x.SlideId,
                        principalTable: "Slides",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsShowOnHome = table.Column<bool>(type: "bit", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    ProductTypeStatusId = table.Column<int>(type: "int", nullable: true),
                    StoreId = table.Column<int>(type: "int", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTypes_ProductTypeStatuses_ProductTypeStatusId",
                        column: x => x.ProductTypeStatusId,
                        principalTable: "ProductTypeStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductTypes_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SoDuDauKySoQuys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<float>(type: "real", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoDuDauKySoQuys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoDuDauKySoQuys_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StoreTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreTranslations_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSKU_AttributeValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeValueId = table.Column<int>(type: "int", nullable: false),
                    ProductSKUId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSKU_AttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSKU_AttributeValues_AttributeValues_AttributeValueId",
                        column: x => x.AttributeValueId,
                        principalTable: "AttributeValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSKU_AttributeValues_ProductSKUs_ProductSKUId",
                        column: x => x.ProductSKUId,
                        principalTable: "ProductSKUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Promotion_ProductSKUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromotionId = table.Column<int>(type: "int", nullable: false),
                    ProductSKUId = table.Column<int>(type: "int", nullable: false),
                    DiscountPercent = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    CommissionPercent = table.Column<double>(type: "float", nullable: false),
                    Commission = table.Column<double>(type: "float", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion_ProductSKUs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Promotion_ProductSKUs_ProductSKUs_ProductSKUId",
                        column: x => x.ProductSKUId,
                        principalTable: "ProductSKUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Promotion_ProductSKUs_Promotions_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "Promotions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SoDuDauKyHangHoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    QtyInStock = table.Column<int>(type: "int", nullable: false),
                    ProductSKUId = table.Column<int>(type: "int", nullable: true),
                    StoreId = table.Column<int>(type: "int", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoDuDauKyHangHoas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoDuDauKyHangHoas_ProductSKUs_ProductSKUId",
                        column: x => x.ProductSKUId,
                        principalTable: "ProductSKUs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SoDuDauKyHangHoas_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PostImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostImages_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Abstract = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoAlias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTranslations_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInProductTypes",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInProductTypes", x => new { x.ProductTypeId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInProductTypes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInProductTypes_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypeTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SeoTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LanguageId = table.Column<int>(type: "int", unicode: false, maxLength: 5, nullable: false),
                    SeoAlias = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypeTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTypeTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTypeTranslations_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), "f4a5c330-d1f7-41e0-b6a8-d4fd8c5c0a77", "Quản trị hệ thống", "admin", "admin" },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "ac60bdb6-a8e0-4a16-9f34-fa3b767db933", "Quản lý cửa hàng", "StoreManager", "StoreManager" },
                    { new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"), "8fb47a33-aa6c-4ed2-93f6-5f535cdf985b", "Quản lý", "Manager", "manager" },
                    { new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"), "1f385bec-ceb9-48f6-9ef9-8ba1926fe00d", "Nhân viên kho", "WarehouseStaff", "WarehouseStaff" },
                    { new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"), "175561ca-39d5-4069-b39e-373d7cad6f16", "Nhân viên thu ngân", "Cashier", "Cashier" },
                    { new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"), "9b7a4f92-49b2-4933-90f1-de9a756539bd", "Nhân viên bán hàng", "ShopAssistant", "ShopAssistant" },
                    { new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"), "d3bc3842-d5d8-4419-8c18-16edaac7d961", "Quản lý chi nhánh", "BranchManager", "BranchManager" }
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "Code", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedUserId", "Dob", "Email", "EmailConfirmed", "FirstName", "GenderId", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedDate", "ModifiedUserId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "09 Lê Hồng Phong", null, "001", "56c226d4-df33-413a-b834-1ababbc69f49", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Nguyễn", null, true, "Hồ Phi Long", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "admin@gmail.com", "admin@gmail.com", "AQAAAAEAACcQAAAAEK388fSunpFm0JBLiRwuS8onuUD28oXP9rcQNccI/L51FaSAaWyNroKoWQrX7hOPuw==", "0915780794", false, "", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "KG", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3542), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3542), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "Size", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3543), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3543), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "BasicSalarys",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "FromDate", "IsApply", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder", "ToDate", "Value" },
                values: new object[,]
                {
                    { 1, "001", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3854), new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3855), true, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3854), new Guid("00000000-0000-0000-0000-000000000000"), null, 0, null, 1000000.0 },
                    { 2, "002", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3856), new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3857), true, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3857), new Guid("00000000-0000-0000-0000-000000000000"), null, 0, null, 2000000.0 },
                    { 3, "003", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3858), new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3859), true, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3858), new Guid("00000000-0000-0000-0000-000000000000"), null, 0, null, 3000000.0 }
                });

            migrationBuilder.InsertData(
                table: "CommissionDiscounts",
                columns: new[] { "Id", "Code", "Commission", "CommissionPercent", "CreatedDate", "CreatedUserId", "Description", "Discount", "DiscountPercent", "FromDate", "IsApply", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder", "ToDate" },
                values: new object[,]
                {
                    { 1, null, 0.0, 2.0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3902), new Guid("00000000-0000-0000-0000-000000000000"), null, 0.0, 10.0, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3903), new Guid("00000000-0000-0000-0000-000000000000"), null, 0, null },
                    { 2, null, 0.0, 5.0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3906), new Guid("00000000-0000-0000-0000-000000000000"), null, 0.0, 15.0, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3906), new Guid("00000000-0000-0000-0000-000000000000"), null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "ContactInformation",
                columns: new[] { "Id", "Address", "Code", "CreatedDate", "CreatedUserId", "Description", "Email", "FacebookLink", "InstagramLink", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "PhoneNumber", "SortOrder", "YoutubeLink" },
                values: new object[] { 1, "29 Trần Trọng Cung, Q.7, TP. HCM", null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3821), new Guid("00000000-0000-0000-0000-000000000000"), null, "hello@chinopet.com", "/Chinopetvn", "https://www.instagram.com/", true, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3822), new Guid("00000000-0000-0000-0000-000000000000"), null, "037 6505247", 0, "https://www.youtube.com/" });

            migrationBuilder.InsertData(
                table: "DocTemplateTypes",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "PT", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3648), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3649), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "PC", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3650), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3650), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 3, "HDBHPOS", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3651), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3651), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 4, "PN", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3652), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3652), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 5, "PX", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3653), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3654), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "M", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2818), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2818), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "F", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2819), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2820), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "vi", new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2804), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2812), new Guid("00000000-0000-0000-0000-000000000000"), "Tiếng Việt", 0 },
                    { 2, "en", new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2815), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2815), new Guid("00000000-0000-0000-0000-000000000000"), "English", 0 }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "NSX1", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3492), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3492), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "NSX2", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3493), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3494), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 3, "NSX3", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3494), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3495), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 4, "NSX4", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3496), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3496), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "ActionName", "Code", "ControllerName", "CreatedDate", "CreatedUserId", "Description", "Icon", "IsDefault", "IsDeleted", "IsVisibled", "Link", "MenuType", "ModifiedDate", "ModifiedUserId", "Name", "ParentId", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, "WebApp_TQ", null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2861), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><path d='M3,16 L5,16 C5.55228475,16 6,15.5522847 6,15 C6,14.4477153 5.55228475,14 5,14 L3,14 L3,12 L5,12 C5.55228475,12 6,11.5522847 6,11 C6,10.4477153 5.55228475,10 5,10 L3,10 L3,8 L5,8 C5.55228475,8 6,7.55228475 6,7 C6,6.44771525 5.55228475,6 5,6 L3,6 L3,4 C3,3.44771525 3.44771525,3 4,3 L10,3 C10.5522847,3 11,3.44771525 11,4 L11,19 C11,19.5522847 10.5522847,20 10,20 L4,20 C3.44771525,20 3,19.5522847 3,19 L3,16 Z' fill='#000000' opacity='0.3'></path>		<path d='M16,3 L19,3 C20.1045695,3 21,3.8954305 21,5 L21,15.2485298 C21,15.7329761 20.8241635,16.200956 20.5051534,16.565539 L17.8762883,19.5699562 C17.6944473,19.7777745 17.378566,19.7988332 17.1707477,19.6169922 C17.1540423,19.602375 17.1383289,19.5866616 17.1237117,19.5699562 L14.4948466,16.565539 C14.1758365,16.200956 14,15.7329761 14,15.2485298 L14,5 C14,3.8954305 14.8954305,3 16,3 Z' fill='#000000'></path>	</svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2862), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 1 },
                    { 2, "Index", "WebApp_TQ_TQ", "Summary", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2864), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Home/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2864), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, 1 },
                    { 3, "Index", "WebApp_TQ_O", "Order", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2865), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Order/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2866), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, 2 },
                    { 4, null, "WebApp_HHDV", null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2867), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' width='24' height='24' viewBox='0 0 24 24' fill='none'>	<path opacity='0.25' fill-rule='evenodd' clip-rule='evenodd' d='M11 4.25769C11 3.07501 9.9663 2.13515 8.84397 2.50814C4.86766 3.82961 2 7.57987 2 11.9999C2 13.6101 2.38057 15.1314 3.05667 16.4788C3.58731 17.5363 4.98303 17.6028 5.81966 16.7662L5.91302 16.6728C6.60358 15.9823 6.65613 14.9011 6.3341 13.9791C6.11766 13.3594 6 12.6934 6 11.9999C6 9.62064 7.38488 7.56483 9.39252 6.59458C10.2721 6.16952 11 5.36732 11 4.39046V4.25769ZM16.4787 20.9434C17.5362 20.4127 17.6027 19.017 16.7661 18.1804L16.6727 18.087C15.9822 17.3964 14.901 17.3439 13.979 17.6659C13.3594 17.8823 12.6934 17.9999 12 17.9999C11.3066 17.9999 10.6406 17.8823 10.021 17.6659C9.09899 17.3439 8.01784 17.3964 7.3273 18.087L7.23392 18.1804C6.39728 19.017 6.4638 20.4127 7.52133 20.9434C8.86866 21.6194 10.3899 21.9999 12 21.9999C13.6101 21.9999 15.1313 21.6194 16.4787 20.9434Z' fill='#12131A'></path>	<path fill-rule='evenodd' clip-rule='evenodd' d='M13 4.39046C13 5.36732 13.7279 6.16952 14.6075 6.59458C16.6151 7.56483 18 9.62064 18 11.9999C18 12.6934 17.8823 13.3594 17.6659 13.9791C17.3439 14.9011 17.3964 15.9823 18.087 16.6728L18.1803 16.7662C19.017 17.6028 20.4127 17.5363 20.9433 16.4788C21.6194 15.1314 22 13.6101 22 11.9999C22 7.57987 19.1323 3.82961 15.156 2.50814C14.0337 2.13515 13 3.07501 13 4.25769V4.39046Z' fill='#12131A'></path></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2867), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 2 },
                    { 5, "Index", "WebApp_HHDV_HHDV", "Product", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2869), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Product/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2870), new Guid("00000000-0000-0000-0000-000000000000"), null, 4, 1 },
                    { 6, "Index", "WebApp_HHDV_NH", "StockIn", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2872), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/StockIn/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2872), new Guid("00000000-0000-0000-0000-000000000000"), null, 4, 2 },
                    { 7, "Index", "WebApp_HHDV_W", "Warehouse", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2873), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Warehouse/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2873), new Guid("00000000-0000-0000-0000-000000000000"), null, 4, 3 },
                    { 8, null, "WebApp_KH", null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2874), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns = 'http://www.w3.org/2000/svg' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><path d = 'M18,14 C16.3431458,14 15,12.6568542 15,11 C15,9.34314575 16.3431458,8 18,8 C19.6568542,8 21,9.34314575 21,11 C21,12.6568542 19.6568542,14 18,14 Z M9,11 C6.790861,11 5,9.209139 5,7 C5,4.790861 6.790861,3 9,3 C11.209139,3 13,4.790861 13,7 C13,9.209139 11.209139,11 9,11 Z' fill='#000000' fill-rule='nonzero' opacity='0.3'></path><path d = 'M17.6011961,15.0006174 C21.0077043,15.0378534 23.7891749,16.7601418 23.9984937,20.4 C24.0069246,20.5466056 23.9984937,21 23.4559499,21 L19.6,21 C19.6,18.7490654 18.8562935,16.6718327 17.6011961,15.0006174 Z M0.00065168429,20.1992055 C0.388258525,15.4265159 4.26191235,13 8.98334134,13 C13.7712164,13 17.7048837,15.2931929 17.9979143,20.2 C18.0095879,20.3954741 17.9979143,21 17.2466999,21 C13.541124,21 8.03472472,21 0.727502227,21 C0.476712155,21 -0.0204617505,20.45918 0.00065168429,20.1992055 Z' fill='#000000' fill-rule='nonzero'></path></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2875), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 3 },
                    { 9, "Index", "WebApp_KH_KH", "Customer", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2876), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Customer/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2876), new Guid("00000000-0000-0000-0000-000000000000"), null, 8, 1 },
                    { 10, "Index", "WebApp_KH_NCC", "Supplier", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2877), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Supplier/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2878), new Guid("00000000-0000-0000-0000-000000000000"), null, 8, 2 }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "ActionName", "Code", "ControllerName", "CreatedDate", "CreatedUserId", "Description", "Icon", "IsDefault", "IsDeleted", "IsVisibled", "Link", "MenuType", "ModifiedDate", "ModifiedUserId", "Name", "ParentId", "SortOrder" },
                values: new object[,]
                {
                    { 11, "Index", "WebApp_KH_NKH", "CustomerType", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2879), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/CustomerType/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2879), new Guid("00000000-0000-0000-0000-000000000000"), null, 8, 3 },
                    { 12, null, "WebApp_TB", null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2880), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><g stroke='none' stroke-width='1' fill='none' fill-rule='evenodd'>	<rect x='0' y='0' width='24' height='24'></rect>	<rect fill='#000000' opacity='0.3' x='2' y='5' width='20' height='14' rx='2'></rect>	<rect fill='#000000' x='2' y='8' width='20' height='3'></rect>	<rect fill='#000000' opacity='0.3' x='16' y='14' width='4' height='2' rx='1'></rect></g></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2881), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 4 },
                    { 13, "Index", "WebApp_TB_TQ", "SummaryOfReceiptPayment", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2882), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/SummaryOfReceiptPayment/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2882), new Guid("00000000-0000-0000-0000-000000000000"), null, 12, 1 },
                    { 14, "Index", "WebApp_TB_PT", "Receipt", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2884), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Receipt/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2884), new Guid("00000000-0000-0000-0000-000000000000"), null, 12, 2 },
                    { 15, "Index", "WebApp_TB_PC", "Payment", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2885), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Payment/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2885), new Guid("00000000-0000-0000-0000-000000000000"), null, 12, 3 },
                    { 16, "Index", "WebApp_TB_SQ", "CashBook", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2886), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/CashBook/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2887), new Guid("00000000-0000-0000-0000-000000000000"), null, 12, 4 },
                    { 17, null, "WebApp_BC", null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2888), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><g stroke='none' stroke-width='1' fill='none' fill-rule='evenodd'>	<polygon points='0 0 24 0 24 24 0 24'></polygon>	<path d='M5.85714286,2 L13.7364114,2 C14.0910962,2 14.4343066,2.12568431 14.7051108,2.35473959 L19.4686994,6.3839416 C19.8056532,6.66894833 20,7.08787823 20,7.52920201 L20,20.0833333 C20,21.8738751 19.9795521,22 18.1428571,22 L5.85714286,22 C4.02044787,22 4,21.8738751 4,20.0833333 L4,3.91666667 C4,2.12612489 4.02044787,2 5.85714286,2 Z' fill='#000000' fill-rule='nonzero' opacity='0.3'></path>	<rect fill='#000000' x='6' y='11' width='9' height='2' rx='1'></rect>	<rect fill='#000000' x='6' y='15' width='5' height='2' rx='1'></rect></g></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2888), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 5 },
                    { 18, null, "WebApp_BC_DS", null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2889), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/SaleReport/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2890), new Guid("00000000-0000-0000-0000-000000000000"), null, 17, 1 },
                    { 19, "Index", "WebApp_BC_HHDV", "ProductReport", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2890), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/ProductReport/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2891), new Guid("00000000-0000-0000-0000-000000000000"), null, 17, 2 },
                    { 20, "Index", "WebApp_BC_TK", "StockReport", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2892), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/StockReport/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2892), new Guid("00000000-0000-0000-0000-000000000000"), null, 17, 3 },
                    { 21, "Index", "WebApp_BC_LN", "ProfitReport", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2894), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/ProfitReport/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2894), new Guid("00000000-0000-0000-0000-000000000000"), null, 17, 4 },
                    { 22, "Index", "WebApp_BC_LL", "ProfitAndLossReport", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2895), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/ProfitAndLossReport/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2896), new Guid("00000000-0000-0000-0000-000000000000"), null, 17, 5 },
                    { 23, "Index", "WebApp_BC_BCT", "MonthlyReport", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2897), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/MonthlyReport/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2897), new Guid("00000000-0000-0000-0000-000000000000"), null, 17, 6 },
                    { 24, null, "WebApp_DM", null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2898), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><g stroke='none' stroke-width='1' fill='none' fill-rule='evenodd'><rect x='0' y='0' width='24' height='24'></rect><rect fill='#000000' x='4' y='4' width='7' height='7' rx='1.5'></rect><path d='M5.5,13 L9.5,13 C10.3284271,13 11,13.6715729 11,14.5 L11,18.5 C11,19.3284271 10.3284271,20 9.5,20 L5.5,20 C4.67157288,20 4,19.3284271 4,18.5 L4,14.5 C4,13.6715729 4.67157288,13 5.5,13 Z M14.5,4 L18.5,4 C19.3284271,4 20,4.67157288 20,5.5 L20,9.5 C20,10.3284271 19.3284271,11 18.5,11 L14.5,11 C13.6715729,11 13,10.3284271 13,9.5 L13,5.5 C13,4.67157288 13.6715729,4 14.5,4 Z M14.5,13 L18.5,13 C19.3284271,13 20,13.6715729 20,14.5 L20,18.5 C20,19.3284271 19.3284271,20 18.5,20 L14.5,20 C13.6715729,20 13,19.3284271 13,18.5 L13,14.5 C13,13.6715729 13.6715729,13 14.5,13 Z' fill='#000000' opacity='0.3'></path></g></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2899), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 6 },
                    { 25, "Index", "WebApp_DM_NHH", "ProductType", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2900), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/ProductType/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2900), new Guid("00000000-0000-0000-0000-000000000000"), null, 24, 1 },
                    { 26, "Index", "WebApp_DM_DVT", "Unit", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2901), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Unit/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2901), new Guid("00000000-0000-0000-0000-000000000000"), null, 24, 2 },
                    { 27, null, "WebApp_BHO", null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2902), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-link'><span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><path d='M16,15.6315789 L16,12 C16,10.3431458 14.6568542,9 13,9 L6.16183229,9 L6.16183229,5.52631579 C6.16183229,4.13107011 7.29290239,3 8.68814808,3 L20.4776218,3 C21.8728674,3 23.0039375,4.13107011 23.0039375,5.52631579 L23.0039375,13.1052632 L23.0206157,17.786793 C23.0215995,18.0629336 22.7985408,18.2875874 22.5224001,18.2885711 C22.3891754,18.2890457 22.2612702,18.2363324 22.1670655,18.1421277 L19.6565168,15.6315789 L16,15.6315789 Z' fill='#000000'></path><path d='M1.98505595,18 L1.98505595,13 C1.98505595,11.8954305 2.88048645,11 3.98505595,11 L11.9850559,11 C13.0896254,11 13.9850559,11.8954305 13.9850559,13 L13.9850559,18 C13.9850559,19.1045695 13.0896254,20 11.9850559,20 L4.10078614,20 L2.85693427,21.1905292 C2.65744295,21.3814685 2.34093638,21.3745358 2.14999706,21.1750444 C2.06092565,21.0819836 2.01120804,20.958136 2.01120804,20.8293182 L2.01120804,18.32426 C1.99400175,18.2187196 1.98505595,18.1104045 1.98505595,18 Z M6.5,14 C6.22385763,14 6,14.2238576 6,14.5 C6,14.7761424 6.22385763,15 6.5,15 L11.5,15 C11.7761424,15 12,14.7761424 12,14.5 C12,14.2238576 11.7761424,14 11.5,14 L6.5,14 Z M9.5,16 C9.22385763,16 9,16.2238576 9,16.5 C9,16.7761424 9.22385763,17 9.5,17 L11.5,17 C11.7761424,17 12,16.7761424 12,16.5 C12,16.2238576 11.7761424,16 11.5,16 L9.5,16 Z' fill='#000000' opacity='0.3'></path></svg></span></span><span class='menu-title'>Chat</span><span class='menu-arrow'></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2903), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 7 },
                    { 28, null, "WebApp_NV", null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2904), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns = 'http://www.w3.org/2000/svg' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><path d = 'M18,14 C16.3431458,14 15,12.6568542 15,11 C15,9.34314575 16.3431458,8 18,8 C19.6568542,8 21,9.34314575 21,11 C21,12.6568542 19.6568542,14 18,14 Z M9,11 C6.790861,11 5,9.209139 5,7 C5,4.790861 6.790861,3 9,3 C11.209139,3 13,4.790861 13,7 C13,9.209139 11.209139,11 9,11 Z' fill='#000000' fill-rule='nonzero' opacity='0.3'></path><path d = 'M17.6011961,15.0006174 C21.0077043,15.0378534 23.7891749,16.7601418 23.9984937,20.4 C24.0069246,20.5466056 23.9984937,21 23.4559499,21 L19.6,21 C19.6,18.7490654 18.8562935,16.6718327 17.6011961,15.0006174 Z M0.00065168429,20.1992055 C0.388258525,15.4265159 4.26191235,13 8.98334134,13 C13.7712164,13 17.7048837,15.2931929 17.9979143,20.2 C18.0095879,20.3954741 17.9979143,21 17.2466999,21 C13.541124,21 8.03472472,21 0.727502227,21 C0.476712155,21 -0.0204617505,20.45918 0.00065168429,20.1992055 Z' fill='#000000' fill-rule='nonzero'></path></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2904), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 8 },
                    { 29, "Index", "WebApp_NV_BL", "Payroll", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2906), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Payroll/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2906), new Guid("00000000-0000-0000-0000-000000000000"), null, 28, 1 },
                    { 30, null, "WebApp_CD", null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2907), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' width='24' height='24' viewBox='0 0 24 24' fill='none'><path opacity='0.25' d='M2 6.5C2 4.01472 4.01472 2 6.5 2H17.5C19.9853 2 22 4.01472 22 6.5V6.5C22 8.98528 19.9853 11 17.5 11H6.5C4.01472 11 2 8.98528 2 6.5V6.5Z' fill='#12131A'></path><path d='M20 6.5C20 7.88071 18.8807 9 17.5 9C16.1193 9 15 7.88071 15 6.5C15 5.11929 16.1193 4 17.5 4C18.8807 4 20 5.11929 20 6.5Z' fill='#12131A'></path><path opacity='0.25' d='M2 17.5C2 15.0147 4.01472 13 6.5 13H17.5C19.9853 13 22 15.0147 22 17.5V17.5C22 19.9853 19.9853 22 17.5 22H6.5C4.01472 22 2 19.9853 2 17.5V17.5Z' fill='#12131A'></path><path d='M9 17.5C9 18.8807 7.88071 20 6.5 20C5.11929 20 4 18.8807 4 17.5C4 16.1193 5.11929 15 6.5 15C7.88071 15 9 16.1193 9 17.5Z' fill='#12131A'></path></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2907), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 10 },
                    { 31, "Index", "WebApp_CD_NV", "Staff", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2908), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Staff/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2909), new Guid("00000000-0000-0000-0000-000000000000"), null, 30, 1 },
                    { 32, "Index", "WebApp_CD_PQ", "AppRole", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2910), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/AppRole/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2910), new Guid("00000000-0000-0000-0000-000000000000"), null, 30, 2 },
                    { 33, "Index", "WebApp_CD_CH", "Store", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2911), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Store/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2911), new Guid("00000000-0000-0000-0000-000000000000"), null, 30, 3 },
                    { 34, "Index", "WebApp_CD_MI", "DocTemplate", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2912), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/DocTemplate/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2913), new Guid("00000000-0000-0000-0000-000000000000"), null, 30, 4 },
                    { 35, null, "WebApp_CD_DMHT", null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2917), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2918), new Guid("00000000-0000-0000-0000-000000000000"), null, 30, 5 },
                    { 36, "Index", "WebApp_CD_DMHT_M", "Menu", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2919), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Menu/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2920), new Guid("00000000-0000-0000-0000-000000000000"), null, 35, 1 },
                    { 37, "Index", "WebApp_CD_DMHT_LMI", "DocTemplateType", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2921), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/DocTemplateType/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2921), new Guid("00000000-0000-0000-0000-000000000000"), null, 35, 2 },
                    { 38, null, "WebApp_QTW", null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2922), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='svg-icon svg-icon-primary svg-icon-2x'><!--begin::Svg Icon | path:/var/www/preview.keenthemes.com/metronic/releases/2021-05-14-112058/theme/html/demo2/dist/../src/media/svg/icons/Devices/iMac.svg--><svg xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'>    <g stroke='none' stroke-width='1' fill='none' fill-rule='evenodd'>        <rect x='0' y='0' width='24' height='24'/>        <path d='M5,5 L5,16 L19,16 L19,5 L5,5 Z M5,3 L19,3 C20.4201608,3 21,3.7163444 21,4.6 L21,17.4 C21,18.2836556 20.4201608,19 19,19 L5,19 C3.57983921,19 3,18.2836556 3,17.4 L3,4.6 C3,3.7163444 3.57983921,3 5,3 Z M12,18 C12.2761424,18 12.5,17.7761424 12.5,17.5 C12.5,17.2238576 12.2761424,17 12,17 C11.7238576,17 11.5,17.2238576 11.5,17.5 C11.5,17.7761424 11.7238576,18 12,18 Z' fill='#12131A' fill-rule='nonzero'/>        <polygon fill='#12131A' opacity='0.3' points='5 5 5 16 19 16 19 5'/>        <rect fill='#12131A' opacity='0.3' x='10' y='20' width='4' height='1' rx='0.5'/>    </g></svg><!--end::Svg Icon--></span>", false, false, true, "", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2923), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 11 },
                    { 39, "Index", "WebApp_QTW_P", "Post", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2924), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Post/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2924), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 1 },
                    { 40, "Index", "WebApp_QTW_PT", "PostType", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2925), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/PostType/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2925), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 2 },
                    { 41, "Index", "WebApp_QTW_S", "Slider", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2926), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Slider/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2927), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 3 },
                    { 42, "Index", "WebApp_KH_NSX", "Manufacturer", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2928), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Manufacturer/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2928), new Guid("00000000-0000-0000-0000-000000000000"), null, 8, 3 },
                    { 43, "Index", "WebApp_DM_TT", "Attribute", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2930), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Attribute/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2930), new Guid("00000000-0000-0000-0000-000000000000"), null, 24, 1 },
                    { 44, null, "WebApp_CD_DMHT_STATUS", null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2931), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2931), new Guid("00000000-0000-0000-0000-000000000000"), null, 35, 4 },
                    { 45, "Index", "WebApp_CD_DMHT_STATUS_AUS", "AppUserStatus", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2932), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/AppUserStatus/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2933), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 1 },
                    { 46, "Index", "WebApp_CD_DMHT_STATUS_OS", "AppUsOrderStatuserStatus", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2934), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/OrderStatus/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2934), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 2 },
                    { 47, "Index", "WebApp_CD_DMHT_STATUS_PS", "PhieuKeToanStatus", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2935), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/PhieuKeToanStatus/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2936), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 2 },
                    { 48, "Index", "WebApp_CD_DMHT_STATUS_POSTS", "PostStatus", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2937), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/PostStatus/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2937), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 3 },
                    { 49, "Index", "WebApp_CD_DMHT_STATUS_POSTTYPES", "PostTypeStatus", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2938), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/PostTypeStatus/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2939), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 4 },
                    { 50, "Index", "WebApp_CD_DMHT_STATUS_PRODUCTTYPES", "ProductTypeStatus", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2940), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/ProductTypeStatus/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2940), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 5 },
                    { 51, "Index", "WebApp_CD_DMHT_STATUS_STS", "StoreStatus", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2942), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/StoreStatus/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2942), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 6 },
                    { 52, "Index", "WebApp_DM_GTTT", "AttributeValue", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2943), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/AttributeValue/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2944), new Guid("00000000-0000-0000-0000-000000000000"), null, 24, 1 }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "ActionName", "Code", "ControllerName", "CreatedDate", "CreatedUserId", "Description", "Icon", "IsDefault", "IsDeleted", "IsVisibled", "Link", "MenuType", "ModifiedDate", "ModifiedUserId", "Name", "ParentId", "SortOrder" },
                values: new object[,]
                {
                    { 53, "Index", "WebApp_CD_DMHT_P", "PaperSize", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2945), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/PaperSize/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2945), new Guid("00000000-0000-0000-0000-000000000000"), null, 35, 3 },
                    { 54, "Index", "WebApp_CD_DMHT_AUT", "AppUserType", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2946), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/AppUserType/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2946), new Guid("00000000-0000-0000-0000-000000000000"), null, 35, 5 },
                    { 55, null, "WebApp_BH", null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2947), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' width='24' height='24' viewBox='0 0 24 24' fill='none'><path opacity='0.25' d='M2 6.5C2 4.01472 4.01472 2 6.5 2H17.5C19.9853 2 22 4.01472 22 6.5V6.5C22 8.98528 19.9853 11 17.5 11H6.5C4.01472 11 2 8.98528 2 6.5V6.5Z' fill='#12131A'></path><path d='M20 6.5C20 7.88071 18.8807 9 17.5 9C16.1193 9 15 7.88071 15 6.5C15 5.11929 16.1193 4 17.5 4C18.8807 4 20 5.11929 20 6.5Z' fill='#12131A'></path><path opacity='0.25' d='M2 17.5C2 15.0147 4.01472 13 6.5 13H17.5C19.9853 13 22 15.0147 22 17.5V17.5C22 19.9853 19.9853 22 17.5 22H6.5C4.01472 22 2 19.9853 2 17.5V17.5Z' fill='#12131A'></path><path d='M9 17.5C9 18.8807 7.88071 20 6.5 20C5.11929 20 4 18.8807 4 17.5C4 16.1193 5.11929 15 6.5 15C7.88071 15 9 16.1193 9 17.5Z' fill='#12131A'></path></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2948), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 9 },
                    { 56, "Index", "WebApp_BH_P", "Promotion", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2949), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Promotion/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2949), new Guid("00000000-0000-0000-0000-000000000000"), null, 55, 1 },
                    { 57, "Index", "WebApp_BH_CD", "CommissionDiscount", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2950), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/CommissionDiscount/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2951), new Guid("00000000-0000-0000-0000-000000000000"), null, 55, 2 },
                    { 58, "Index", "WebApp_NV_BS", "BasicSalary", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2952), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/BasicSalary/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2952), new Guid("00000000-0000-0000-0000-000000000000"), null, 28, 2 },
                    { 59, "Index", "WebApp_QTW_M", "WebsiteMenu", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2953), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/WebsiteMenu/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2953), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 4 },
                    { 60, "Index", "WebApp_QTW_B", "Booking", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2954), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Booking/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2955), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 5 },
                    { 61, "Index", "WebApp_QTW_C", "Contact", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2956), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Contact/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2956), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 6 },
                    { 62, "Index", "WebApp_QTW_CI", "ContactInformation", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2957), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/ContactInformation/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2958), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 7 },
                    { 63, "Index", "WebApp_QTW_N", "Newsletter", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2959), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Newsletter/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2959), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 8 },
                    { 64, "Index", "WebApp_QTW_T", "Testimonial", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2960), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Testimonial/Index", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2961), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 9 },
                    { 65, "Print", "WebApp_HHDV_QRC", "Product", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2962), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Product/Print", 0, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2962), new Guid("00000000-0000-0000-0000-000000000000"), null, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "InProgress", new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2936), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2937), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "Confirmed", new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2938), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2938), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 3, "Shipping", new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2939), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2940), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 4, "Success", new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2941), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2941), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 5, "Canceled", new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2942), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2942), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "PaperSizes",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder", "Value" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3617), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3618), new Guid("00000000-0000-0000-0000-000000000000"), "58 mm", 0, 5.7999999999999998 },
                    { 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3619), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3619), new Guid("00000000-0000-0000-0000-000000000000"), "80 mm", 0, 8.0 },
                    { 3, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3620), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3621), new Guid("00000000-0000-0000-0000-000000000000"), "A5", 0, 21.0 },
                    { 4, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3622), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3622), new Guid("00000000-0000-0000-0000-000000000000"), "A4", 0, 21.0 }
                });

            migrationBuilder.InsertData(
                table: "PostStatuses",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "InActive", new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2989), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2990), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "Active", new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2991), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2991), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "PostTypes",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "ParentId", "PostTypeStatusId", "SortOrder" },
                values: new object[,]
                {
                    { 1, "CNTT", new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3031), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3031), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, 0 },
                    { 2, "CNSH", new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3032), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3033), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductTypeStatuses",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "InActive", new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3071), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3072), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "Active", new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3073), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3073), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "FromDate", "IsApply", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder", "ToDate" },
                values: new object[,]
                {
                    { 1, "001", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3949), new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3950), true, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3949), new Guid("00000000-0000-0000-0000-000000000000"), null, 0, null },
                    { 2, "002", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3951), new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3952), true, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3951), new Guid("00000000-0000-0000-0000-000000000000"), null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "SlideStatuses",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "InActive", new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3145), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3145), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "Active", new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3146), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3146), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "Image", "IsDefault", "IsDeleted", "IsVisibled", "Link", "ModifiedDate", "ModifiedUserId", "Name", "SlideStatusId", "SortOrder" },
                values: new object[] { 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2710), new Guid("00000000-0000-0000-0000-000000000000"), null, "smart_farming.jpg", false, false, true, "#", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2713), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 1 });

            migrationBuilder.InsertData(
                table: "StoreStatuses",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "Active", new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3103), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3104), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "Repair", new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3105), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3105), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 3, "TemporarilyClosed", new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3106), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3106), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 4, "Closed", new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3108), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3108), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "Image", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[] { 1, "Le Quang Teo", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3837), new Guid("00000000-0000-0000-0000-000000000000"), "", null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3837), new Guid("00000000-0000-0000-0000-000000000000"), "It's Amazing", 0 });

            migrationBuilder.InsertData(
                table: "WebsiteMenus",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "Icon", "IsDefault", "IsDeleted", "IsVisibled", "Link", "ModifiedDate", "ModifiedUserId", "Name", "ParentId", "SortOrder", "WebsiteMenuType" },
                values: new object[,]
                {
                    { 1, "AboutUs", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3742), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/about-us", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3743), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 1, 1 },
                    { 2, "Pets", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3745), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Pets/Index", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3745), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 2, 1 },
                    { 3, "Shop", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3747), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Shop/Index", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3747), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 3, 1 },
                    { 4, "Services", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3748), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Services/Index", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3748), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "WebsiteMenus",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "Icon", "IsDefault", "IsDeleted", "IsVisibled", "Link", "ModifiedDate", "ModifiedUserId", "Name", "ParentId", "SortOrder", "WebsiteMenuType" },
                values: new object[,]
                {
                    { 5, "Blogs", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3749), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Blog/Index", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3750), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 5, 1 },
                    { 6, "Contact", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3751), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Contact/Index", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3751), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 6, 1 },
                    { 7, "PetMart", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3752), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Shop/Index", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3752), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 1, 2 },
                    { 8, "Chinovet", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3753), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Vet/Index", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3754), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 2, 2 },
                    { 9, "ChinoSalon", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3755), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Salon/Index", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3755), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 3, 2 },
                    { 10, "ChinoHotel", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3756), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Hotel/Index", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3756), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 4, 2 },
                    { 11, "Training", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3757), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Training/Index", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3758), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 5, 2 }
                });

            migrationBuilder.InsertData(
                table: "AppRoleTranslations",
                columns: new[] { "Id", "AppRoleId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3303), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý cửa hàng", false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3303), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý cửa hàng", 0 },
                    { 2, new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3305), new Guid("00000000-0000-0000-0000-000000000000"), "Store owner", false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3305), new Guid("00000000-0000-0000-0000-000000000000"), "Store manager", 0 },
                    { 3, new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3306), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý", false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3307), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý", 0 },
                    { 4, new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3308), new Guid("00000000-0000-0000-0000-000000000000"), "General manager", false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3308), new Guid("00000000-0000-0000-0000-000000000000"), "General manager", 0 },
                    { 5, new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3309), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên kho", false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3310), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên kho", 0 },
                    { 6, new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3311), new Guid("00000000-0000-0000-0000-000000000000"), "Warehouse staff", false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3311), new Guid("00000000-0000-0000-0000-000000000000"), "Warehouse staff", 0 },
                    { 7, new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3312), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên thu ngân", false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3312), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên thu ngân", 0 },
                    { 8, new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3313), new Guid("00000000-0000-0000-0000-000000000000"), "Cashier", false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3314), new Guid("00000000-0000-0000-0000-000000000000"), "Cashier", 0 },
                    { 9, new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3315), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên bán hàng", false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3316), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên bán hàng", 0 },
                    { 10, new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3317), new Guid("00000000-0000-0000-0000-000000000000"), "Shop assistant", false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3317), new Guid("00000000-0000-0000-0000-000000000000"), "Shop assistant", 0 },
                    { 11, new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3318), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý chi nhánh", false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3318), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý chi nhánh", 0 },
                    { 12, new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3319), new Guid("00000000-0000-0000-0000-000000000000"), "Branch manager", false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3320), new Guid("00000000-0000-0000-0000-000000000000"), "Branch manager", 0 },
                    { 13, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3322), new Guid("00000000-0000-0000-0000-000000000000"), "Quản trị hệ thống", false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3322), new Guid("00000000-0000-0000-0000-000000000000"), "Quản trị hệ thống", 0 },
                    { 14, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3323), new Guid("00000000-0000-0000-0000-000000000000"), "Branch Manager", false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3323), new Guid("00000000-0000-0000-0000-000000000000"), "Branch Manager", 0 }
                });

            migrationBuilder.InsertData(
                table: "AttributeTranslations",
                columns: new[] { "Id", "AttributeId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SeoAlias", "SeoDescription", "SeoTitle", "SortOrder" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3559), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3560), new Guid("00000000-0000-0000-0000-000000000000"), "Số kí", null, null, null, 0 },
                    { 2, 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3561), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3561), new Guid("00000000-0000-0000-0000-000000000000"), "Kg", null, null, null, 0 },
                    { 3, 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3562), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3562), new Guid("00000000-0000-0000-0000-000000000000"), "Kích thước", null, null, null, 0 },
                    { 4, 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3563), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3564), new Guid("00000000-0000-0000-0000-000000000000"), "Size", null, null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "AttributeValues",
                columns: new[] { "Id", "AttributeId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3577), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3577), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3578), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3578), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "BasicSalaryTranslations",
                columns: new[] { "Id", "BasicSalaryId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3878), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3879), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý", 0 },
                    { 2, 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3880), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3880), new Guid("00000000-0000-0000-0000-000000000000"), "N/A", 0 },
                    { 3, 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3881), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3882), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên", 0 },
                    { 4, 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3883), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3883), new Guid("00000000-0000-0000-0000-000000000000"), "N/A", 0 },
                    { 5, 3, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3884), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3884), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý kho", 0 },
                    { 6, 3, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3885), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3885), new Guid("00000000-0000-0000-0000-000000000000"), "N/A", 0 }
                });

            migrationBuilder.InsertData(
                table: "CommissionDiscountTranslations",
                columns: new[] { "Id", "Code", "CommissionDiscountId", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3923), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3924), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên thử việc", 0 },
                    { 2, null, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3926), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3926), new Guid("00000000-0000-0000-0000-000000000000"), "N/A", 0 },
                    { 3, null, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3927), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3928), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên chính thức", 0 },
                    { 4, null, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3928), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3929), new Guid("00000000-0000-0000-0000-000000000000"), "N/A", 0 }
                });

            migrationBuilder.InsertData(
                table: "DocTemplateTypeTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "DocTemplateTypeId", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3667), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3668), new Guid("00000000-0000-0000-0000-000000000000"), "Phiếu thu", 0 },
                    { 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3669), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3670), new Guid("00000000-0000-0000-0000-000000000000"), "Receipt", 0 },
                    { 3, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3671), new Guid("00000000-0000-0000-0000-000000000000"), null, 2, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3671), new Guid("00000000-0000-0000-0000-000000000000"), "Phiếu chi", 0 },
                    { 4, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3672), new Guid("00000000-0000-0000-0000-000000000000"), null, 2, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3672), new Guid("00000000-0000-0000-0000-000000000000"), "Payment", 0 },
                    { 5, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3673), new Guid("00000000-0000-0000-0000-000000000000"), null, 3, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3674), new Guid("00000000-0000-0000-0000-000000000000"), "Hóa đơn bán hàng POS", 0 },
                    { 6, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3675), new Guid("00000000-0000-0000-0000-000000000000"), null, 3, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3675), new Guid("00000000-0000-0000-0000-000000000000"), "Invoice POS", 0 },
                    { 7, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3676), new Guid("00000000-0000-0000-0000-000000000000"), null, 4, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3677), new Guid("00000000-0000-0000-0000-000000000000"), "Phiếu nhập kho", 0 },
                    { 8, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3678), new Guid("00000000-0000-0000-0000-000000000000"), null, 4, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3678), new Guid("00000000-0000-0000-0000-000000000000"), "Warehouse receipt", 0 },
                    { 9, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3679), new Guid("00000000-0000-0000-0000-000000000000"), null, 5, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3679), new Guid("00000000-0000-0000-0000-000000000000"), "Phiếu xuất kho", 0 },
                    { 10, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3680), new Guid("00000000-0000-0000-0000-000000000000"), null, 5, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3681), new Guid("00000000-0000-0000-0000-000000000000"), "Warehouse export", 0 }
                });

            migrationBuilder.InsertData(
                table: "DocTemplates",
                columns: new[] { "Id", "Code", "Content", "CreatedDate", "CreatedUserId", "Description", "DocTemplateTypeId", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "PaperSizeId", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3700), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, true, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3700), new Guid("00000000-0000-0000-0000-000000000000"), "Phiếu thu mẫu 1", null, 0 },
                    { 2, null, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3702), new Guid("00000000-0000-0000-0000-000000000000"), null, 2, true, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3703), new Guid("00000000-0000-0000-0000-000000000000"), "Phiếu chi mẫu 1", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "DocTemplates",
                columns: new[] { "Id", "Code", "Content", "CreatedDate", "CreatedUserId", "Description", "DocTemplateTypeId", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "PaperSizeId", "SortOrder" },
                values: new object[,]
                {
                    { 3, null, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3704), new Guid("00000000-0000-0000-0000-000000000000"), null, 3, true, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3704), new Guid("00000000-0000-0000-0000-000000000000"), "Hóa đơn bán hàng mẫu 1", null, 0 },
                    { 4, null, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3705), new Guid("00000000-0000-0000-0000-000000000000"), null, 4, true, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3706), new Guid("00000000-0000-0000-0000-000000000000"), "Phiếu nhập kho mẫu 1", null, 0 },
                    { 5, null, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3710), new Guid("00000000-0000-0000-0000-000000000000"), null, 5, true, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3710), new Guid("00000000-0000-0000-0000-000000000000"), "Phiếu xuất kho mẫu 1", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "GenderTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "GenderId", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2834), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2835), new Guid("00000000-0000-0000-0000-000000000000"), "Nam", 0 },
                    { 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2836), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2836), new Guid("00000000-0000-0000-0000-000000000000"), "Male", 0 },
                    { 3, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2837), new Guid("00000000-0000-0000-0000-000000000000"), null, 2, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2838), new Guid("00000000-0000-0000-0000-000000000000"), "Nữ", 0 },
                    { 4, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2839), new Guid("00000000-0000-0000-0000-000000000000"), null, 2, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2839), new Guid("00000000-0000-0000-0000-000000000000"), "Female", 0 }
                });

            migrationBuilder.InsertData(
                table: "ManufacturerTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ManufacturerId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3510), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3511), new Guid("00000000-0000-0000-0000-000000000000"), "Nhà sản xuất 1", 0 },
                    { 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3512), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3512), new Guid("00000000-0000-0000-0000-000000000000"), "Manufacturer 1", 0 },
                    { 3, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3513), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3514), new Guid("00000000-0000-0000-0000-000000000000"), "Nhà sản xuất 2", 0 },
                    { 4, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3515), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3515), new Guid("00000000-0000-0000-0000-000000000000"), "Manufacturer 2", 0 },
                    { 5, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3516), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 3, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3516), new Guid("00000000-0000-0000-0000-000000000000"), "Nhà sản xuất 3", 0 },
                    { 6, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3520), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 3, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3521), new Guid("00000000-0000-0000-0000-000000000000"), "Manufacturer 3", 0 },
                    { 7, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3522), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 4, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3523), new Guid("00000000-0000-0000-0000-000000000000"), "Nhà sản xuất 4", 0 },
                    { 8, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3523), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 4, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3524), new Guid("00000000-0000-0000-0000-000000000000"), "Manufacturer 4", 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuAppRoles",
                columns: new[] { "Id", "AppRoleId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsAllow", "IsDefault", "IsDeleted", "IsVisibled", "MenuAppRoleType", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3200), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3201), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3202), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3203), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 3, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3204), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3204), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 4, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3205), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3205), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 5, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3206), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3207), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 6, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3207), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3208), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 7, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3208), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 3, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3209), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 8, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3210), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 3, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3210), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 9, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3211), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 3, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3211), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 10, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3215), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 4, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3216), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 11, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3217), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 4, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3218), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 12, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3218), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 4, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3219), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 13, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3219), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 5, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3220), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 14, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3221), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 5, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3222), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 15, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3223), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 5, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3223), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 16, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3224), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 6, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3224), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 17, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3225), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 6, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3225), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 18, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3226), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 6, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3226), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 19, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3227), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 7, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3227), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 20, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3228), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 7, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3229), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 21, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3229), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 7, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3230), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 22, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3230), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 8, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3231), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 23, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3232), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 8, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3232), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 24, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3233), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 8, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3233), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 25, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3234), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 9, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3234), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 26, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3235), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 9, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3236), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 27, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3236), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 9, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3237), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuAppRoles",
                columns: new[] { "Id", "AppRoleId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsAllow", "IsDefault", "IsDeleted", "IsVisibled", "MenuAppRoleType", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 28, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3237), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 10, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3238), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 29, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3239), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 10, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3239), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 30, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3240), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 10, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3240), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 31, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3241), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 11, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3241), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 32, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3243), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 11, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3243), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 33, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3244), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 11, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3244), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 34, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3245), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 12, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3246), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 35, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3246), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 12, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3247), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 36, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3247), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 12, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3248), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 37, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3249), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 13, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3249), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 38, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3250), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 13, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3250), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 39, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3251), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 13, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3251), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 40, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3252), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 14, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3252), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 41, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3253), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 14, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3254), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 42, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3254), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 14, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3255), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 43, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3255), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 15, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3256), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 44, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3257), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 15, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3257), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 45, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3258), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 15, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3258), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 46, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3259), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 16, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3259), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 47, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3260), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 16, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3260), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 48, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3261), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 16, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3261), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 49, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3262), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 17, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3263), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 50, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3263), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 17, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3264), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 51, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3264), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 17, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3265), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 52, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3266), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 18, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3266), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 53, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3267), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 18, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3267), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 54, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3268), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 18, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3268), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 55, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3269), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 19, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3269), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 56, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3271), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 19, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3271), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 57, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3272), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 19, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3272), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 58, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3273), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 20, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3273), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 59, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3274), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 20, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3275), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 60, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3275), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 20, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3276), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 61, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3276), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 21, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3277), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 62, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3278), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 21, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3278), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 63, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3279), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 21, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3279), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 64, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3280), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 22, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3280), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 65, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3281), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 22, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3281), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 66, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3282), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 22, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3282), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 67, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3286), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 23, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3287), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 68, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3288), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 23, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3288), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 69, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3289), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 23, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3289), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuAppRoles",
                columns: new[] { "Id", "AppRoleId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsAllow", "IsDefault", "IsDeleted", "IsVisibled", "MenuAppRoleType", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 70, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3290), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 24, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3290), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 71, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3291), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 24, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3292), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 72, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3292), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 24, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3293), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 73, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3293), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 25, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3294), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 74, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3295), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 25, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3295), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 75, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3296), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 25, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3296), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 76, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3297), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 26, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3297), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 77, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3299), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 26, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3299), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 78, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3300), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 26, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3300), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 79, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3301), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 27, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3302), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 80, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3302), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 27, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3303), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 81, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3303), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 27, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3304), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 82, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3304), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 28, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3305), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 83, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3306), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 28, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3306), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 84, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3307), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 28, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3307), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 85, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3308), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 29, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3308), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 86, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3309), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 29, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3309), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 87, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3310), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 29, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3310), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 88, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3311), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 30, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3312), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 89, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3312), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 30, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3313), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 90, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3313), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 30, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3314), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 91, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3315), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 31, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3315), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 92, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3316), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 31, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3316), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 93, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3317), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 31, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3317), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 94, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3318), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 32, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3318), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 95, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3320), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 32, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3320), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 96, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3321), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 32, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3321), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 97, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3322), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 33, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3323), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 98, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3323), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 33, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3324), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 99, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3324), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 33, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3325), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 100, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3325), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 34, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3326), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 101, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3327), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 34, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3327), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 102, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3328), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 34, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3328), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 103, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3329), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 35, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3329), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 104, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3330), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 35, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3330), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 105, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3331), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 35, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3332), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 106, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3332), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 36, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3333), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 107, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3333), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 36, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3334), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 108, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3335), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 36, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3335), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 109, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3336), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 37, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3337), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 110, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3337), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 37, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3338), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 111, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3338), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 37, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3339), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuAppRoles",
                columns: new[] { "Id", "AppRoleId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsAllow", "IsDefault", "IsDeleted", "IsVisibled", "MenuAppRoleType", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 112, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3340), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 38, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3340), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 113, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3341), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 38, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3341), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 114, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3342), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 38, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3342), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 115, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3343), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 39, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3343), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 116, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3344), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 39, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3344), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 117, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3345), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 39, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3346), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 118, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3347), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 40, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3347), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 119, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3348), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 40, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3349), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 120, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3349), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 40, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3350), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 121, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3350), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 41, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3351), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 122, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3352), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 41, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3352), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 123, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3353), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 41, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3353), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 124, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3357), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 42, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3358), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 125, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3359), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 42, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3359), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 126, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3360), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 42, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3360), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 127, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3361), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 43, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3361), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 128, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3362), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 43, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3362), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 129, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3363), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 43, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3363), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 130, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3364), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 44, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3365), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 131, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3365), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 44, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3366), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 132, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3366), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 44, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3367), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 133, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3368), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 45, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3368), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 134, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3369), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 45, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3369), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 135, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3370), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 45, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3370), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 136, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3371), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 46, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3371), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 137, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3372), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 46, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3373), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 138, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3373), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 46, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3374), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 139, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3375), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 47, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3376), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 140, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3376), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 47, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3377), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 141, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3378), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 47, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3378), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 142, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3379), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 48, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3379), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 143, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3380), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 48, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3380), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 144, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3381), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 48, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3381), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 145, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3382), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 49, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3383), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 146, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3383), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 49, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3384), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 147, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3384), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 49, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3385), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 148, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3386), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 50, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3386), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 149, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3387), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 50, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3387), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 150, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3388), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 50, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3388), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 151, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3389), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 51, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3389), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 152, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3390), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 51, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3390), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 153, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3391), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 51, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3392), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuAppRoles",
                columns: new[] { "Id", "AppRoleId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsAllow", "IsDefault", "IsDeleted", "IsVisibled", "MenuAppRoleType", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 154, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3392), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 52, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3393), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 155, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3393), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 52, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3394), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 156, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3394), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 52, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3395), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 157, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3396), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 53, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3396), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 158, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3398), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 53, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3398), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 159, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3399), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 53, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3399), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 160, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3400), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 54, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3400), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 161, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3401), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 54, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3401), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 162, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3402), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 54, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3403), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 163, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3403), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 55, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3404), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 164, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3404), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 55, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3405), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 165, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3406), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 55, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3406), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 166, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3407), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 56, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3407), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 167, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3408), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 56, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3408), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 168, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3409), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 56, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3409), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 169, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3410), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 57, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3410), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 170, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3411), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 57, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3412), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 171, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3412), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 57, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3413), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 172, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3413), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 58, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3414), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 173, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3415), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 58, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3415), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 174, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3416), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 58, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3416), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 175, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3417), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 59, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3417), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 176, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3418), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 59, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3418), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 177, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3419), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 59, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3419), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 178, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3420), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 60, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3421), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 179, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3421), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 60, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3422), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 180, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3426), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 60, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3427), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 181, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3428), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 61, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3428), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 182, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3429), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 61, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3430), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 183, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3430), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 61, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3431), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 184, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3431), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 62, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3432), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 185, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3433), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 62, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3433), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 186, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3434), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 62, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3434), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 187, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3435), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 63, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3435), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 188, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3436), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 63, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3436), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 189, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3437), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 63, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3437), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 190, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3438), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 64, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3439), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 191, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3439), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 64, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3440), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 192, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3441), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 64, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3441), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 193, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3442), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 65, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3442), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 194, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3443), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 65, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3443), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 195, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3444), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 65, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3444), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2991), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2992), new Guid("00000000-0000-0000-0000-000000000000"), "Tổng quan", 0 },
                    { 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2993), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2993), new Guid("00000000-0000-0000-0000-000000000000"), "Dashboard", 0 },
                    { 3, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2994), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2995), new Guid("00000000-0000-0000-0000-000000000000"), "Tổng quan", 0 },
                    { 4, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2996), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2996), new Guid("00000000-0000-0000-0000-000000000000"), "Summary", 0 },
                    { 5, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2997), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 3, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2997), new Guid("00000000-0000-0000-0000-000000000000"), "Đơn hàng", 0 },
                    { 6, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2998), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 3, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2999), new Guid("00000000-0000-0000-0000-000000000000"), "Orders", 0 },
                    { 7, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2999), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 4, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3000), new Guid("00000000-0000-0000-0000-000000000000"), "Hàng hóa & Dịch vụ", 0 },
                    { 8, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3001), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 4, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3001), new Guid("00000000-0000-0000-0000-000000000000"), "Products & Services", 0 },
                    { 9, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3002), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 5, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3002), new Guid("00000000-0000-0000-0000-000000000000"), "Hàng hóa/Dịch vụ", 0 },
                    { 10, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3003), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 5, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3004), new Guid("00000000-0000-0000-0000-000000000000"), "Products/Services", 0 },
                    { 11, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3004), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 6, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3005), new Guid("00000000-0000-0000-0000-000000000000"), "Nhập hàng", 0 },
                    { 12, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3006), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 6, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3006), new Guid("00000000-0000-0000-0000-000000000000"), "Stock in", 0 },
                    { 13, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3008), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 7, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3008), new Guid("00000000-0000-0000-0000-000000000000"), "Kho hàng", 0 },
                    { 14, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3009), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 7, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3009), new Guid("00000000-0000-0000-0000-000000000000"), "Warehouses", 0 },
                    { 15, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3010), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 8, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3011), new Guid("00000000-0000-0000-0000-000000000000"), "Khách hàng", 0 },
                    { 16, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3011), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 8, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3012), new Guid("00000000-0000-0000-0000-000000000000"), "Customers", 0 },
                    { 17, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3013), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 9, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3013), new Guid("00000000-0000-0000-0000-000000000000"), "Khách hàng", 0 },
                    { 18, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3014), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 9, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3014), new Guid("00000000-0000-0000-0000-000000000000"), "Customers", 0 },
                    { 19, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3015), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 10, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3015), new Guid("00000000-0000-0000-0000-000000000000"), "Nhà cung cấp", 0 },
                    { 20, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3016), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 10, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3017), new Guid("00000000-0000-0000-0000-000000000000"), "Suppliers", 0 },
                    { 21, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3017), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 11, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3018), new Guid("00000000-0000-0000-0000-000000000000"), "Nhóm khách hàng", 0 },
                    { 22, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3019), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 11, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3019), new Guid("00000000-0000-0000-0000-000000000000"), "Customer types", 0 },
                    { 23, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3020), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 12, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3020), new Guid("00000000-0000-0000-0000-000000000000"), "Tiền bạc", 0 },
                    { 24, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3021), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 12, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3022), new Guid("00000000-0000-0000-0000-000000000000"), "Receipts & payments", 0 },
                    { 25, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3023), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 13, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3024), new Guid("00000000-0000-0000-0000-000000000000"), "Tổng quan", 0 },
                    { 26, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3024), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 13, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3025), new Guid("00000000-0000-0000-0000-000000000000"), "Summary", 0 },
                    { 27, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3026), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 14, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3026), new Guid("00000000-0000-0000-0000-000000000000"), "Thu", 0 },
                    { 28, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3027), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 14, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3028), new Guid("00000000-0000-0000-0000-000000000000"), "Receipts", 0 },
                    { 29, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3028), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 15, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3029), new Guid("00000000-0000-0000-0000-000000000000"), "Chi", 0 },
                    { 30, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3030), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 15, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3030), new Guid("00000000-0000-0000-0000-000000000000"), "Payments", 0 },
                    { 31, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3031), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 16, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3031), new Guid("00000000-0000-0000-0000-000000000000"), "Sổ quỹ", 0 },
                    { 32, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3032), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 16, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3032), new Guid("00000000-0000-0000-0000-000000000000"), "Cash book", 0 },
                    { 33, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3033), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 17, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3034), new Guid("00000000-0000-0000-0000-000000000000"), "Báo cáo", 0 },
                    { 34, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3035), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 17, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3035), new Guid("00000000-0000-0000-0000-000000000000"), "Reports", 0 },
                    { 35, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3036), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 18, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3036), new Guid("00000000-0000-0000-0000-000000000000"), "Doanh số", 0 },
                    { 36, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3037), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 18, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3037), new Guid("00000000-0000-0000-0000-000000000000"), "Sales", 0 },
                    { 37, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3038), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 19, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3039), new Guid("00000000-0000-0000-0000-000000000000"), "Hàng hóa & Dịch vụ", 0 },
                    { 38, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3040), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 19, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3040), new Guid("00000000-0000-0000-0000-000000000000"), "Products & Services", 0 },
                    { 39, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3041), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 20, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3041), new Guid("00000000-0000-0000-0000-000000000000"), "Tồn kho", 0 },
                    { 40, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3042), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 20, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3042), new Guid("00000000-0000-0000-0000-000000000000"), "Stock", 0 },
                    { 41, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3043), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 21, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3044), new Guid("00000000-0000-0000-0000-000000000000"), "Lợi nhuận", 0 },
                    { 42, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3044), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 21, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3045), new Guid("00000000-0000-0000-0000-000000000000"), "Profit", 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 43, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3046), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 22, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3046), new Guid("00000000-0000-0000-0000-000000000000"), "Lãi lỗ", 0 },
                    { 44, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3047), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 22, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3047), new Guid("00000000-0000-0000-0000-000000000000"), "Profit & Loss", 0 },
                    { 45, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3048), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 23, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3048), new Guid("00000000-0000-0000-0000-000000000000"), "Báo cáo tháng", 0 },
                    { 46, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3049), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 23, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3050), new Guid("00000000-0000-0000-0000-000000000000"), "Monthly report", 0 },
                    { 47, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3051), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 24, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3051), new Guid("00000000-0000-0000-0000-000000000000"), "Danh mục", 0 },
                    { 48, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3052), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 24, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3052), new Guid("00000000-0000-0000-0000-000000000000"), "Directories", 0 },
                    { 49, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3054), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 25, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3054), new Guid("00000000-0000-0000-0000-000000000000"), "Nhóm hàng hóa", 0 },
                    { 50, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3055), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 25, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3055), new Guid("00000000-0000-0000-0000-000000000000"), "Product types", 0 },
                    { 51, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3056), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 26, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3057), new Guid("00000000-0000-0000-0000-000000000000"), "Đơn vị tính", 0 },
                    { 52, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3057), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 26, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3058), new Guid("00000000-0000-0000-0000-000000000000"), "Units", 0 },
                    { 53, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3059), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 27, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3059), new Guid("00000000-0000-0000-0000-000000000000"), "Bán hàng Online", 0 },
                    { 54, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3060), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 27, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3060), new Guid("00000000-0000-0000-0000-000000000000"), "Sale Online", 0 },
                    { 55, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3061), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 28, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3062), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên", 0 },
                    { 56, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3062), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 28, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3063), new Guid("00000000-0000-0000-0000-000000000000"), "Staff", 0 },
                    { 57, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3064), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 29, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3064), new Guid("00000000-0000-0000-0000-000000000000"), "Bảng lương", 0 },
                    { 58, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3065), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 29, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3065), new Guid("00000000-0000-0000-0000-000000000000"), "Payroll", 0 },
                    { 59, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3066), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 30, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3066), new Guid("00000000-0000-0000-0000-000000000000"), "Cài đặt", 0 },
                    { 60, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3067), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 30, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3068), new Guid("00000000-0000-0000-0000-000000000000"), "Setting", 0 },
                    { 61, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3072), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 31, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3073), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên", 0 },
                    { 62, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3074), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 31, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3074), new Guid("00000000-0000-0000-0000-000000000000"), "Staffs", 0 },
                    { 63, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3075), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 32, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3075), new Guid("00000000-0000-0000-0000-000000000000"), "Phân quyền", 0 },
                    { 64, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3076), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 32, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3076), new Guid("00000000-0000-0000-0000-000000000000"), "Roles", 0 },
                    { 65, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3077), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 33, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3078), new Guid("00000000-0000-0000-0000-000000000000"), "Cửa hàng", 0 },
                    { 66, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3079), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 33, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3079), new Guid("00000000-0000-0000-0000-000000000000"), "Stores", 0 },
                    { 67, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3080), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 34, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3080), new Guid("00000000-0000-0000-0000-000000000000"), "Mẫu in", 0 },
                    { 68, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3081), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 34, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3081), new Guid("00000000-0000-0000-0000-000000000000"), "Document templates", 0 },
                    { 69, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3082), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 35, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3083), new Guid("00000000-0000-0000-0000-000000000000"), "Danh mục hệ thống", 0 },
                    { 70, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3084), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 35, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3084), new Guid("00000000-0000-0000-0000-000000000000"), "System directories", 0 },
                    { 71, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3085), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 36, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3086), new Guid("00000000-0000-0000-0000-000000000000"), "Menu", 0 },
                    { 72, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3087), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 36, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3087), new Guid("00000000-0000-0000-0000-000000000000"), "Menu", 0 },
                    { 73, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3088), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 37, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3088), new Guid("00000000-0000-0000-0000-000000000000"), "Loại mẫu in", 0 },
                    { 74, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3089), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 37, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3090), new Guid("00000000-0000-0000-0000-000000000000"), "Document printing template type", 0 },
                    { 75, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3090), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 38, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3091), new Guid("00000000-0000-0000-0000-000000000000"), "Website", 0 },
                    { 76, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3092), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 38, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3092), new Guid("00000000-0000-0000-0000-000000000000"), "Website", 0 },
                    { 77, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3093), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 39, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3093), new Guid("00000000-0000-0000-0000-000000000000"), "Bài viết", 0 },
                    { 78, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3094), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 39, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3094), new Guid("00000000-0000-0000-0000-000000000000"), "Post", 0 },
                    { 79, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3095), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 40, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3096), new Guid("00000000-0000-0000-0000-000000000000"), "Chuyên mục", 0 },
                    { 80, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3097), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 40, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3097), new Guid("00000000-0000-0000-0000-000000000000"), "Categories", 0 },
                    { 81, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3098), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 41, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3098), new Guid("00000000-0000-0000-0000-000000000000"), "Slider", 0 },
                    { 82, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3099), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 41, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3099), new Guid("00000000-0000-0000-0000-000000000000"), "Slider", 0 },
                    { 83, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3100), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 42, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3101), new Guid("00000000-0000-0000-0000-000000000000"), "Nhà sản xuất", 0 },
                    { 84, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3101), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 42, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3102), new Guid("00000000-0000-0000-0000-000000000000"), "Manufacturer", 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 85, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3103), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 43, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3103), new Guid("00000000-0000-0000-0000-000000000000"), "Thuộc tính sản phẩm", 0 },
                    { 86, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3104), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 43, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3104), new Guid("00000000-0000-0000-0000-000000000000"), "Attribute", 0 },
                    { 87, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3105), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 44, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3105), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái", 0 },
                    { 88, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3106), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 44, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3107), new Guid("00000000-0000-0000-0000-000000000000"), "Status", 0 },
                    { 89, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3108), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 45, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3108), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái người sử dụng", 0 },
                    { 90, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3109), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 45, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3109), new Guid("00000000-0000-0000-0000-000000000000"), "User status", 0 },
                    { 91, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3110), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 46, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3111), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái đơn hàng", 0 },
                    { 92, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3111), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 46, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3112), new Guid("00000000-0000-0000-0000-000000000000"), "Order status", 0 },
                    { 93, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3113), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 47, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3113), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái phiếu kế toán", 0 },
                    { 94, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3114), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 47, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3114), new Guid("00000000-0000-0000-0000-000000000000"), "Phiếu kế toán status", 0 },
                    { 95, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3115), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 48, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3116), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái bài viết", 0 },
                    { 96, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3117), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 48, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3117), new Guid("00000000-0000-0000-0000-000000000000"), "Post status", 0 },
                    { 97, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3118), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 49, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3118), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái loại bài viết", 0 },
                    { 98, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3120), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 49, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3120), new Guid("00000000-0000-0000-0000-000000000000"), "Post type status", 0 },
                    { 99, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3121), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 50, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3122), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái slide", 0 },
                    { 100, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3122), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 50, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3123), new Guid("00000000-0000-0000-0000-000000000000"), "Slide status", 0 },
                    { 101, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3124), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 51, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3124), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái cửa hàng", 0 },
                    { 102, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3125), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 51, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3125), new Guid("00000000-0000-0000-0000-000000000000"), "Store status", 0 },
                    { 103, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3126), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 52, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3126), new Guid("00000000-0000-0000-0000-000000000000"), "Giá trị thuộc tính", 0 },
                    { 104, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3127), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 52, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3128), new Guid("00000000-0000-0000-0000-000000000000"), "Attribute value", 0 },
                    { 105, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3129), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 53, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3129), new Guid("00000000-0000-0000-0000-000000000000"), "Khổ giấy", 0 },
                    { 106, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3130), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 53, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3130), new Guid("00000000-0000-0000-0000-000000000000"), "Paper size", 0 },
                    { 107, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3131), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 54, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3131), new Guid("00000000-0000-0000-0000-000000000000"), "Loại người sử dụng", 0 },
                    { 108, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3132), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 54, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3133), new Guid("00000000-0000-0000-0000-000000000000"), "App user type", 0 },
                    { 109, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3133), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 55, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3134), new Guid("00000000-0000-0000-0000-000000000000"), "Bán hàng", 0 },
                    { 110, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3135), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 55, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3135), new Guid("00000000-0000-0000-0000-000000000000"), "Sales", 0 },
                    { 111, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3136), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 56, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3136), new Guid("00000000-0000-0000-0000-000000000000"), "Chương trình khuyến mãi", 0 },
                    { 112, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3137), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 56, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3138), new Guid("00000000-0000-0000-0000-000000000000"), "Sales Promotion", 0 },
                    { 113, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3138), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 57, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3139), new Guid("00000000-0000-0000-0000-000000000000"), "Hoa hồng - Giảm giá", 0 },
                    { 114, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3140), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 57, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3140), new Guid("00000000-0000-0000-0000-000000000000"), "Commission - Discount", 0 },
                    { 115, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3141), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 58, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3141), new Guid("00000000-0000-0000-0000-000000000000"), "Lương căn bản", 0 },
                    { 116, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3142), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 58, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3142), new Guid("00000000-0000-0000-0000-000000000000"), "Basic salary", 0 },
                    { 117, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3143), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 59, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3144), new Guid("00000000-0000-0000-0000-000000000000"), "Menu", 0 },
                    { 118, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3145), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 59, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3145), new Guid("00000000-0000-0000-0000-000000000000"), "Menu", 0 },
                    { 119, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3146), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 60, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3146), new Guid("00000000-0000-0000-0000-000000000000"), "Đặt lịch", 0 },
                    { 120, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3147), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 60, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3147), new Guid("00000000-0000-0000-0000-000000000000"), "Booking", 0 },
                    { 121, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3148), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 61, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3149), new Guid("00000000-0000-0000-0000-000000000000"), "Liên hệ", 0 },
                    { 122, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3150), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 61, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3150), new Guid("00000000-0000-0000-0000-000000000000"), "Contact", 0 },
                    { 123, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3151), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 62, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3152), new Guid("00000000-0000-0000-0000-000000000000"), "Thông tin liên hệ", 0 },
                    { 124, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3153), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 62, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3153), new Guid("00000000-0000-0000-0000-000000000000"), "Contact information", 0 },
                    { 125, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3157), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 63, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3158), new Guid("00000000-0000-0000-0000-000000000000"), "Newsletter", 0 },
                    { 126, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3159), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 63, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3159), new Guid("00000000-0000-0000-0000-000000000000"), "Newsletter", 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 127, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3160), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 64, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3160), new Guid("00000000-0000-0000-0000-000000000000"), "Testimonial", 0 },
                    { 128, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3161), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 64, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3162), new Guid("00000000-0000-0000-0000-000000000000"), "Testimonial", 0 },
                    { 129, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3162), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 65, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3163), new Guid("00000000-0000-0000-0000-000000000000"), "In mã QR", 0 },
                    { 130, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3164), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 65, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3164), new Guid("00000000-0000-0000-0000-000000000000"), "Print QR code", 0 }
                });

            migrationBuilder.InsertData(
                table: "OrderStatusTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "OrderStatusId", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2959), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2959), new Guid("00000000-0000-0000-0000-000000000000"), "InProgress", 1, 0 },
                    { 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2961), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2961), new Guid("00000000-0000-0000-0000-000000000000"), "InProgress", 1, 0 },
                    { 3, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2962), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2963), new Guid("00000000-0000-0000-0000-000000000000"), "Confirmed", 2, 0 },
                    { 4, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2963), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2964), new Guid("00000000-0000-0000-0000-000000000000"), "Confirmed", 2, 0 },
                    { 5, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2965), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2965), new Guid("00000000-0000-0000-0000-000000000000"), "Shipping", 3, 0 },
                    { 6, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2966), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2966), new Guid("00000000-0000-0000-0000-000000000000"), "Shipping", 3, 0 },
                    { 7, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2967), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2968), new Guid("00000000-0000-0000-0000-000000000000"), "Success", 4, 0 },
                    { 8, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2969), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2969), new Guid("00000000-0000-0000-0000-000000000000"), "Success", 4, 0 },
                    { 9, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2970), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2970), new Guid("00000000-0000-0000-0000-000000000000"), "Canceled", 5, 0 },
                    { 10, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2971), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2971), new Guid("00000000-0000-0000-0000-000000000000"), "Canceled", 5, 0 }
                });

            migrationBuilder.InsertData(
                table: "PostStatusTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "PostStatusId", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3010), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3010), new Guid("00000000-0000-0000-0000-000000000000"), "Chưa kích hoạt", 1, 0 },
                    { 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3012), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3012), new Guid("00000000-0000-0000-0000-000000000000"), "InActive", 1, 0 },
                    { 3, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3013), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3014), new Guid("00000000-0000-0000-0000-000000000000"), "Đang hoạt động", 2, 0 },
                    { 4, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3015), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3015), new Guid("00000000-0000-0000-0000-000000000000"), "Active", 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "PostTypeTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "PostTypeId", "SeoAlias", "SeoDescription", "SeoTitle", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3053), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3054), new Guid("00000000-0000-0000-0000-000000000000"), "Công nghệ thông tin", 1, "cong-nghe-thong-tin", null, null, 0 },
                    { 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3055), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3055), new Guid("00000000-0000-0000-0000-000000000000"), "It", 1, "it", null, null, 0 },
                    { 3, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3057), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3057), new Guid("00000000-0000-0000-0000-000000000000"), "Công nghệ sinh học", 2, "cong-nghe-sinh-hoc", null, null, 0 },
                    { 4, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3058), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3058), new Guid("00000000-0000-0000-0000-000000000000"), "Biotechnology", 2, "biotechnology", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductTypeStatusTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "ProductTypeStatusId", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3087), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3087), new Guid("00000000-0000-0000-0000-000000000000"), "Chưa kích hoạt", 1, 0 },
                    { 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3088), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3089), new Guid("00000000-0000-0000-0000-000000000000"), "InActive", 1, 0 },
                    { 3, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3090), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3090), new Guid("00000000-0000-0000-0000-000000000000"), "Đang hoạt động", 2, 0 },
                    { 4, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3091), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3091), new Guid("00000000-0000-0000-0000-000000000000"), "Active", 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsShowOnHome", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "ParentId", "ProductTypeStatusId", "SortOrder", "StoreId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3175), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3175), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 2, 1, null },
                    { 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3177), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, true, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3177), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 2, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AllowSellWhenNotEnough", "Code", "CreatedDate", "CreatedUserId", "Description", "Image", "InventoryWarning", "IsDefault", "IsDeleted", "IsFeatured", "IsHasSKU", "IsPOS", "IsVisibled", "IsWeb", "ManufactuerId", "ModifiedDate", "ModifiedUserId", "Name", "OriginalPrice", "Price", "ProductTitle", "ShortDescription", "SortOrder", "Url" },
                values: new object[,]
                {
                    { 1, true, "SP0000001", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4037), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 0, false, false, null, true, true, true, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4034), new Guid("00000000-0000-0000-0000-000000000000"), null, 100000m, 200000m, "Hàng hóa 1", null, 0, "hang-hoa-1" },
                    { 2, true, "SP0000002", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4048), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 0, false, false, null, true, true, true, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4047), new Guid("00000000-0000-0000-0000-000000000000"), null, 3000000m, 6500000m, "Dịch vụ 2", null, 0, "dich-vu-2" }
                });

            migrationBuilder.InsertData(
                table: "PromotionTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "PromotionId", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3995), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3995), new Guid("00000000-0000-0000-0000-000000000000"), "Ưu đãi nhân viên", 1, 0 },
                    { 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3997), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3997), new Guid("00000000-0000-0000-0000-000000000000"), "N/A", 1, 0 },
                    { 3, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3998), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3999), new Guid("00000000-0000-0000-0000-000000000000"), "Chương trình trung thu", 2, 0 },
                    { 4, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4000), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4000), new Guid("00000000-0000-0000-0000-000000000000"), "N/A", 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "Promotion_CommissionDiscounts",
                columns: new[] { "Id", "Code", "CommissionDiscountId", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "PromotionId", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4013), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4013), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, 0 },
                    { 2, null, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4014), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4015), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "SlideStatusTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SlideStatusId", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3157), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3158), new Guid("00000000-0000-0000-0000-000000000000"), "Chưa kích hoạt", 1, 0 },
                    { 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3159), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3159), new Guid("00000000-0000-0000-0000-000000000000"), "InActive", 1, 0 },
                    { 3, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3160), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3161), new Guid("00000000-0000-0000-0000-000000000000"), "Đang hoạt động", 2, 0 },
                    { 4, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3162), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3162), new Guid("00000000-0000-0000-0000-000000000000"), "Active", 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "SlideTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SlideId", "SortOrder" },
                values: new object[,]
                {
                    { 1, "Nông nghiệp thông minh", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2733), new Guid("00000000-0000-0000-0000-000000000000"), "<p>Nền nông nghiệp ứng dụng công nghệ cao(cơ giới hóa, tự động hóa…)</p><p>Công nghệ sản xuất, bảo quản sản phẩm an toàn (hữu cơ, theo GAP…)</p><p>Công nghệ quản lý, nhận diện sản phẩm theo chuỗi giá trị… gắn với hệ thống trí tuệ nhân tạo (công nghệ thông tin).</p>", false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2734), new Guid("00000000-0000-0000-0000-000000000000"), "Smart farming", 1, 0 },
                    { 2, "Smart farm", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2738), new Guid("00000000-0000-0000-0000-000000000000"), "<p>Nền nông nghiệp ứng dụng công nghệ cao(cơ giới hóa, tự động hóa…)</p><p>Công nghệ sản xuất, bảo quản sản phẩm an toàn (hữu cơ, theo GAP…)</p><p>Công nghệ quản lý, nhận diện sản phẩm theo chuỗi giá trị… gắn với hệ thống trí tuệ nhân tạo (công nghệ thông tin).</p>", false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2739), new Guid("00000000-0000-0000-0000-000000000000"), "Smart farming", 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "Image", "IsDefault", "IsDeleted", "IsVisibled", "Link", "ModifiedDate", "ModifiedUserId", "Name", "SlideStatusId", "SortOrder" },
                values: new object[,]
                {
                    { 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2716), new Guid("00000000-0000-0000-0000-000000000000"), null, "biotechnology.jpg", false, false, true, "#", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2716), new Guid("00000000-0000-0000-0000-000000000000"), null, 2, 2 },
                    { 3, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2718), new Guid("00000000-0000-0000-0000-000000000000"), null, "information_technology.png", false, false, true, "#", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2718), new Guid("00000000-0000-0000-0000-000000000000"), null, 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "StoreStatusTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder", "StoreStatusId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3121), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3121), new Guid("00000000-0000-0000-0000-000000000000"), "Đang hoạt động", 0, 1 },
                    { 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3122), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3123), new Guid("00000000-0000-0000-0000-000000000000"), "Active", 0, 1 },
                    { 3, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3124), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3124), new Guid("00000000-0000-0000-0000-000000000000"), "Đang sữa chửa", 0, 2 },
                    { 4, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3125), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3125), new Guid("00000000-0000-0000-0000-000000000000"), "Repair", 0, 2 },
                    { 5, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3127), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3127), new Guid("00000000-0000-0000-0000-000000000000"), "Tạm thời đóng cửa", 0, 3 },
                    { 6, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3128), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3129), new Guid("00000000-0000-0000-0000-000000000000"), "TemporarilyClosed", 0, 3 },
                    { 7, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3129), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3130), new Guid("00000000-0000-0000-0000-000000000000"), "Đã đóng cửa", 0, 4 },
                    { 8, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3131), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3131), new Guid("00000000-0000-0000-0000-000000000000"), "Closed", 0, 4 }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "Address", "Code", "CreatedDate", "CreatedUserId", "Description", "Email", "IsDefault", "IsDeleted", "IsVisibled", "Logo", "ModifiedDate", "ModifiedUserId", "Name", "Phone", "SortOrder", "StoreStatusId", "Taxcode", "Website" },
                values: new object[,]
                {
                    { 1, null, "CH001", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2765), new Guid("00000000-0000-0000-0000-000000000000"), null, "abc@gmail.com", false, false, true, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2766), new Guid("00000000-0000-0000-0000-000000000000"), null, "0123456789", 0, 1, null, null },
                    { 2, null, "CH002", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2767), new Guid("00000000-0000-0000-0000-000000000000"), null, "abc@gmail.com", false, false, true, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2768), new Guid("00000000-0000-0000-0000-000000000000"), null, "0123456789", 0, 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "WebsiteMenuTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder", "WebsiteMenuId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3772), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3772), new Guid("00000000-0000-0000-0000-000000000000"), "About us", 0, 1 },
                    { 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3773), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3774), new Guid("00000000-0000-0000-0000-000000000000"), "About us", 0, 1 },
                    { 3, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3775), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3775), new Guid("00000000-0000-0000-0000-000000000000"), "Pets", 0, 2 },
                    { 4, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3776), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3776), new Guid("00000000-0000-0000-0000-000000000000"), "Pets", 0, 2 },
                    { 5, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3777), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3777), new Guid("00000000-0000-0000-0000-000000000000"), "Shop", 0, 3 },
                    { 6, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3778), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3779), new Guid("00000000-0000-0000-0000-000000000000"), "Shop", 0, 3 },
                    { 7, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3780), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3781), new Guid("00000000-0000-0000-0000-000000000000"), "Services", 0, 4 },
                    { 8, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3782), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3782), new Guid("00000000-0000-0000-0000-000000000000"), "Services", 0, 4 },
                    { 9, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3783), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3783), new Guid("00000000-0000-0000-0000-000000000000"), "Blogs", 0, 5 },
                    { 10, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3784), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3784), new Guid("00000000-0000-0000-0000-000000000000"), "Blogs", 0, 5 },
                    { 11, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3785), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3786), new Guid("00000000-0000-0000-0000-000000000000"), "Contact", 0, 6 },
                    { 12, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3786), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3787), new Guid("00000000-0000-0000-0000-000000000000"), "Contact", 0, 6 },
                    { 13, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3788), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3788), new Guid("00000000-0000-0000-0000-000000000000"), "Pet Mart", 0, 7 },
                    { 14, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3789), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3790), new Guid("00000000-0000-0000-0000-000000000000"), "Pet Mart", 0, 7 },
                    { 15, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3790), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3791), new Guid("00000000-0000-0000-0000-000000000000"), "Chino Vet", 0, 8 },
                    { 16, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3792), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3792), new Guid("00000000-0000-0000-0000-000000000000"), "Chino Vet", 0, 8 },
                    { 17, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3793), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3793), new Guid("00000000-0000-0000-0000-000000000000"), "Chino Salon", 0, 9 },
                    { 18, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3794), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3795), new Guid("00000000-0000-0000-0000-000000000000"), "Chino Salon", 0, 9 },
                    { 19, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3796), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3796), new Guid("00000000-0000-0000-0000-000000000000"), "Chino Hotel", 0, 10 },
                    { 20, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3797), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3797), new Guid("00000000-0000-0000-0000-000000000000"), "Chino Hotel", 0, 10 },
                    { 21, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3798), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3799), new Guid("00000000-0000-0000-0000-000000000000"), "Training", 0, 11 },
                    { 22, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3799), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3800), new Guid("00000000-0000-0000-0000-000000000000"), "Training", 0, 11 }
                });

            migrationBuilder.InsertData(
                table: "AttributeValueTranslations",
                columns: new[] { "Id", "AttributeValueId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SeoAlias", "SeoDescription", "SeoTitle", "SortOrder" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3594), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3595), new Guid("00000000-0000-0000-0000-000000000000"), "1kg", null, null, null, 0 },
                    { 2, 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3596), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3596), new Guid("00000000-0000-0000-0000-000000000000"), "N/A", null, null, null, 0 },
                    { 3, 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3597), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3598), new Guid("00000000-0000-0000-0000-000000000000"), "2kg", null, null, null, 0 },
                    { 4, 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3598), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3599), new Guid("00000000-0000-0000-0000-000000000000"), "N/A", null, null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductInProductTypes",
                columns: new[] { "ProductId", "ProductTypeId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductSKUs",
                columns: new[] { "Id", "BuyingPrice", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "Price", "ProductId", "QtyInStock", "SortOrder" },
                values: new object[,]
                {
                    { 1, 1050000.0, "SP0000001", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4093), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4094), new Guid("00000000-0000-0000-0000-000000000000"), "Hàng hóa 1", 650000.0, 1, 10, 0 },
                    { 2, 1050000.0, "SP0000002", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4095), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4096), new Guid("00000000-0000-0000-0000-000000000000"), "Dịch vụ_1kg", 650000.0, 2, 10, 0 },
                    { 3, 1050000.0, "SP0000003", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4097), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4097), new Guid("00000000-0000-0000-0000-000000000000"), "Dịch vụ_2kg", 650000.0, 2, 10, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "Details", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "ProductId", "SeoAlias", "SeoDescription", "SeoTitle", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4062), new Guid("00000000-0000-0000-0000-000000000000"), "Hàng hóa 1", "Hàng hóa 1", false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4062), new Guid("00000000-0000-0000-0000-000000000000"), "Hàng hóa 1", 1, "hang-hoa-1", "Hàng hóa 1", "Hàng hóa 1", 0 },
                    { 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4064), new Guid("00000000-0000-0000-0000-000000000000"), "Product 1", "Product 1", false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4064), new Guid("00000000-0000-0000-0000-000000000000"), "Product 1", 1, "product-1", "Product 1", "Product 1", 0 },
                    { 3, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4066), new Guid("00000000-0000-0000-0000-000000000000"), "Dịch vụ 2", "Dịch vụ 2", false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4066), new Guid("00000000-0000-0000-0000-000000000000"), "Dịch vụ 2", 2, "dich-vu-2", "Dịch vụ 2", "Dịch vụ 2", 0 },
                    { 4, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4067), new Guid("00000000-0000-0000-0000-000000000000"), "Service 2", "Service 2", false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4068), new Guid("00000000-0000-0000-0000-000000000000"), "Service 2", 2, "service-2", "Service 2", "Service 2", 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductTypeTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "ProductTypeId", "SeoAlias", "SeoDescription", "SeoTitle", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3188), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3188), new Guid("00000000-0000-0000-0000-000000000000"), "Hàng hóa", 1, "hang-hoa", "Hàng hóa bán được", "Hàng hóa bán được", 0 },
                    { 2, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3190), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3190), new Guid("00000000-0000-0000-0000-000000000000"), "Product", 1, "product", "product", "product", 0 },
                    { 3, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3191), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3192), new Guid("00000000-0000-0000-0000-000000000000"), "Dịch vụ", 2, "dich-vu", "Dịch vụ", "Dịch vụ", 0 },
                    { 4, null, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3193), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3193), new Guid("00000000-0000-0000-0000-000000000000"), "Service", 2, "service", "service", "service", 0 }
                });

            migrationBuilder.InsertData(
                table: "SlideTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SlideId", "SortOrder" },
                values: new object[,]
                {
                    { 3, "Công nghệ sinh học", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2740), new Guid("00000000-0000-0000-0000-000000000000"), "<p>Ứng dụng công nghệ sinh học trong sản xuất thuốc, thức ăn</p><p> Điều chế và sản xuất hóa chất công nghiệp; phát triển giống cây trồng, vật nuôi</p><p> Ứng dụng công nghệ di truyền, xét nghiệm trong y khoa </p><p> giải quyết các vấn đề môi trường…</p>", false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2740), new Guid("00000000-0000-0000-0000-000000000000"), "Biotechnology", 2, 0 },
                    { 4, "Công nghệ sinh học", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2742), new Guid("00000000-0000-0000-0000-000000000000"), "<p>Ứng dụng công nghệ sinh học trong sản xuất thuốc, thức ăn</p><p> Điều chế và sản xuất hóa chất công nghiệp; phát triển giống cây trồng, vật nuôi</p><p> Ứng dụng công nghệ di truyền, xét nghiệm trong y khoa </p><p> giải quyết các vấn đề môi trường…</p>", false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2742), new Guid("00000000-0000-0000-0000-000000000000"), "Biotechnology", 2, 0 },
                    { 5, "Công nghệ thông tin và truyền thông", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2743), new Guid("00000000-0000-0000-0000-000000000000"), "<p>ICT là sự kết hợp của công nghệ thông tin và công nghệ truyền thông</p><p> để tạo nên sự kết nối và chia sẻ thông tin với nhiều hình thức khác nhau </p><p> nhằm hỗ trợ và thúc đẩy năng lực sản xuất, kinh doanh Doanh nghiệp </p> ", false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2744), new Guid("00000000-0000-0000-0000-000000000000"), "IT", 3, 0 },
                    { 6, "Công nghệ thông tin và truyền thông", new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2746), new Guid("00000000-0000-0000-0000-000000000000"), "<p>ICT là sự kết hợp của công nghệ thông tin và công nghệ truyền thông</p><p> để tạo nên sự kết nối và chia sẻ thông tin với nhiều hình thức khác nhau </p><p> nhằm hỗ trợ và thúc đẩy năng lực sản xuất, kinh doanh Doanh nghiệp </p> ", false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2747), new Guid("00000000-0000-0000-0000-000000000000"), "IT", 3, 0 }
                });

            migrationBuilder.InsertData(
                table: "SoDuDauKySoQuys",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder", "StoreId", "Total", "Year" },
                values: new object[] { 1, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3729), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3730), new Guid("00000000-0000-0000-0000-000000000000"), null, 0, 1, 2000000f, 0 });

            migrationBuilder.InsertData(
                table: "StoreTranslations",
                columns: new[] { "Id", "Address", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder", "StoreId" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2783), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2783), new Guid("00000000-0000-0000-0000-000000000000"), "Cửa hàng mặc định", 0, 1 },
                    { 2, null, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2793), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2793), new Guid("00000000-0000-0000-0000-000000000000"), "Default Store", 0, 1 },
                    { 3, null, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2794), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2795), new Guid("00000000-0000-0000-0000-000000000000"), "Cửa hàng 2", 0, 2 },
                    { 4, null, null, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2796), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2796), new Guid("00000000-0000-0000-0000-000000000000"), "Store 2", 0, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductSKU_AttributeValues",
                columns: new[] { "Id", "AttributeValueId", "ProductSKUId" },
                values: new object[] { 1, 1, 2 });

            migrationBuilder.InsertData(
                table: "ProductSKU_AttributeValues",
                columns: new[] { "Id", "AttributeValueId", "ProductSKUId" },
                values: new object[] { 2, 2, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_AboutTranslations_AboutId",
                table: "AboutTranslations",
                column: "AboutId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutTranslations_LanguageId",
                table: "AboutTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRoleTranslations_AppRoleId",
                table: "AppRoleTranslations",
                column: "AppRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRoleTranslations_LanguageId",
                table: "AppRoleTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_CountryId",
                table: "AppUsers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_GenderId",
                table: "AppUsers",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeTranslations_AttributeId",
                table: "AttributeTranslations",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeTranslations_LanguageId",
                table: "AttributeTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeValues_AttributeId",
                table: "AttributeValues",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeValueTranslations_AttributeValueId",
                table: "AttributeValueTranslations",
                column: "AttributeValueId");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeValueTranslations_LanguageId",
                table: "AttributeValueTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_BasicSalaryTranslations_BasicSalaryId",
                table: "BasicSalaryTranslations",
                column: "BasicSalaryId");

            migrationBuilder.CreateIndex(
                name: "IX_BasicSalaryTranslations_LanguageId",
                table: "BasicSalaryTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PetServiceSelectionId",
                table: "Bookings",
                column: "PetServiceSelectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_AppUserId",
                table: "Carts",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductId",
                table: "Carts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CommissionDiscountTranslations_CommissionDiscountId",
                table: "CommissionDiscountTranslations",
                column: "CommissionDiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_CommissionDiscountTranslations_LanguageId",
                table: "CommissionDiscountTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTypeTranslations_CustomerTypeId",
                table: "CustomerTypeTranslations",
                column: "CustomerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTypeTranslations_LanguageId",
                table: "CustomerTypeTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_DocTemplates_DocTemplateTypeId",
                table: "DocTemplates",
                column: "DocTemplateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DocTemplates_PaperSizeId",
                table: "DocTemplates",
                column: "PaperSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_DocTemplateTypeTranslations_DocTemplateTypeId",
                table: "DocTemplateTypeTranslations",
                column: "DocTemplateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DocTemplateTypeTranslations_LanguageId",
                table: "DocTemplateTypeTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteProducts_AppUserId",
                table: "FavoriteProducts",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteProducts_ProductId",
                table: "FavoriteProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_GenderTranslations_GenderId",
                table: "GenderTranslations",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_GenderTranslations_LanguageId",
                table: "GenderTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturerTranslations_LanguageId",
                table: "ManufacturerTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturerTranslations_ManufacturerId",
                table: "ManufacturerTranslations",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuAppRoles_AppRoleId",
                table: "MenuAppRoles",
                column: "AppRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuAppRoles_MenuId",
                table: "MenuAppRoles",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuTranslations_LanguageId",
                table: "MenuTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuTranslations_MenuId",
                table: "MenuTranslations",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatusTranslations_LanguageId",
                table: "OrderStatusTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatusTranslations_OrderStatusId",
                table: "OrderStatusTranslations",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PayrollDetails_AppUserId",
                table: "PayrollDetails",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PayrollDetails_PayrollId",
                table: "PayrollDetails",
                column: "PayrollId");

            migrationBuilder.CreateIndex(
                name: "IX_PayrollTranslations_LanguageId",
                table: "PayrollTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PayrollTranslations_PayrollId",
                table: "PayrollTranslations",
                column: "PayrollId");

            migrationBuilder.CreateIndex(
                name: "IX_PetServiceSelectionTranslations_LanguageId",
                table: "PetServiceSelectionTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PetServiceSelectionTranslations_PetServiceSelectionId",
                table: "PetServiceSelectionTranslations",
                column: "PetServiceSelectionId");

            migrationBuilder.CreateIndex(
                name: "IX_PostImages_PostId",
                table: "PostImages",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostStatusId",
                table: "Posts",
                column: "PostStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostTypeId",
                table: "Posts",
                column: "PostTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PostStatusTranslations_LanguageId",
                table: "PostStatusTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PostStatusTranslations_PostStatusId",
                table: "PostStatusTranslations",
                column: "PostStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTranslations_LanguageId",
                table: "PostTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTranslations_PostId",
                table: "PostTranslations",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTypes_PostTypeStatusId",
                table: "PostTypes",
                column: "PostTypeStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTypeStatusTranslations_LanguageId",
                table: "PostTypeStatusTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTypeStatusTranslations_LanguageId1",
                table: "PostTypeStatusTranslations",
                column: "LanguageId1");

            migrationBuilder.CreateIndex(
                name: "IX_PostTypeStatusTranslations_PostTypeStatusId",
                table: "PostTypeStatusTranslations",
                column: "PostTypeStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTypeTranslations_LanguageId",
                table: "PostTypeTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTypeTranslations_PostTypeId",
                table: "PostTypeTranslations",
                column: "PostTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInProductTypes_ProductId",
                table: "ProductInProductTypes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ManufactuerId",
                table: "Products",
                column: "ManufactuerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSKU_AttributeValues_AttributeValueId",
                table: "ProductSKU_AttributeValues",
                column: "AttributeValueId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSKU_AttributeValues_ProductSKUId",
                table: "ProductSKU_AttributeValues",
                column: "ProductSKUId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSKUs_ProductId",
                table: "ProductSKUs",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTranslations_LanguageId",
                table: "ProductTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTranslations_ProductId",
                table: "ProductTranslations",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_ProductTypeStatusId",
                table: "ProductTypes",
                column: "ProductTypeStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_StoreId",
                table: "ProductTypes",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypeStatusTranslations_LanguageId",
                table: "ProductTypeStatusTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypeStatusTranslations_ProductTypeStatusId",
                table: "ProductTypeStatusTranslations",
                column: "ProductTypeStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypeTranslations_LanguageId",
                table: "ProductTypeTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypeTranslations_ProductTypeId",
                table: "ProductTypeTranslations",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_CommissionDiscounts_CommissionDiscountId",
                table: "Promotion_CommissionDiscounts",
                column: "CommissionDiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_CommissionDiscounts_PromotionId",
                table: "Promotion_CommissionDiscounts",
                column: "PromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_ProductSKUs_ProductSKUId",
                table: "Promotion_ProductSKUs",
                column: "ProductSKUId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_ProductSKUs_PromotionId",
                table: "Promotion_ProductSKUs",
                column: "PromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionTranslations_LanguageId",
                table: "PromotionTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionTranslations_PromotionId",
                table: "PromotionTranslations",
                column: "PromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_Slides_SlideStatusId",
                table: "Slides",
                column: "SlideStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SlideStatusTranslations_LanguageId",
                table: "SlideStatusTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_SlideStatusTranslations_SlideStatusId",
                table: "SlideStatusTranslations",
                column: "SlideStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SlideTranslations_LanguageId",
                table: "SlideTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_SlideTranslations_SlideId",
                table: "SlideTranslations",
                column: "SlideId");

            migrationBuilder.CreateIndex(
                name: "IX_SoDuDauKyHangHoas_ProductSKUId",
                table: "SoDuDauKyHangHoas",
                column: "ProductSKUId");

            migrationBuilder.CreateIndex(
                name: "IX_SoDuDauKyHangHoas_StoreId",
                table: "SoDuDauKyHangHoas",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_SoDuDauKySoQuys_StoreId",
                table: "SoDuDauKySoQuys",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_StoreStatusId",
                table: "Stores",
                column: "StoreStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreStatusTranslations_LanguageId",
                table: "StoreStatusTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreStatusTranslations_StoreStatusId",
                table: "StoreStatusTranslations",
                column: "StoreStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreTranslations_LanguageId",
                table: "StoreTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreTranslations_StoreId",
                table: "StoreTranslations",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AppUserId",
                table: "Transactions",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitTranslations_LanguageId",
                table: "UnitTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitTranslations_UnitId",
                table: "UnitTranslations",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_WebsiteMenuTranslations_LanguageId",
                table: "WebsiteMenuTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_WebsiteMenuTranslations_WebsiteMenuId",
                table: "WebsiteMenuTranslations",
                column: "WebsiteMenuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutTranslations");

            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoleTranslations");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "AttributeTranslations");

            migrationBuilder.DropTable(
                name: "AttributeValueTranslations");

            migrationBuilder.DropTable(
                name: "BasicSalaryTranslations");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "ClinicConfigs");

            migrationBuilder.DropTable(
                name: "CommissionDiscountTranslations");

            migrationBuilder.DropTable(
                name: "ContactInformation");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "CustomerTypeTranslations");

            migrationBuilder.DropTable(
                name: "DocTemplates");

            migrationBuilder.DropTable(
                name: "DocTemplateTypeTranslations");

            migrationBuilder.DropTable(
                name: "FavoriteProducts");

            migrationBuilder.DropTable(
                name: "GenderTranslations");

            migrationBuilder.DropTable(
                name: "ManufacturerTranslations");

            migrationBuilder.DropTable(
                name: "MenuAppRoles");

            migrationBuilder.DropTable(
                name: "MenuTranslations");

            migrationBuilder.DropTable(
                name: "Newsletters");

            migrationBuilder.DropTable(
                name: "OrderStatusTranslations");

            migrationBuilder.DropTable(
                name: "PayrollDetails");

            migrationBuilder.DropTable(
                name: "PayrollTranslations");

            migrationBuilder.DropTable(
                name: "PetServiceSelectionTranslations");

            migrationBuilder.DropTable(
                name: "PostImages");

            migrationBuilder.DropTable(
                name: "PostStatusTranslations");

            migrationBuilder.DropTable(
                name: "PostTranslations");

            migrationBuilder.DropTable(
                name: "PostTypeStatusTranslations");

            migrationBuilder.DropTable(
                name: "PostTypeTranslations");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductInProductTypes");

            migrationBuilder.DropTable(
                name: "ProductSKU_AttributeValues");

            migrationBuilder.DropTable(
                name: "ProductTranslations");

            migrationBuilder.DropTable(
                name: "ProductTypeStatusTranslations");

            migrationBuilder.DropTable(
                name: "ProductTypeTranslations");

            migrationBuilder.DropTable(
                name: "Promotion_CommissionDiscounts");

            migrationBuilder.DropTable(
                name: "Promotion_ProductSKUs");

            migrationBuilder.DropTable(
                name: "PromotionTranslations");

            migrationBuilder.DropTable(
                name: "SlideStatusTranslations");

            migrationBuilder.DropTable(
                name: "SlideTranslations");

            migrationBuilder.DropTable(
                name: "SoDuDauKyHangHoas");

            migrationBuilder.DropTable(
                name: "SoDuDauKySoQuys");

            migrationBuilder.DropTable(
                name: "StoreStatusTranslations");

            migrationBuilder.DropTable(
                name: "StoreTranslations");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "UnitTranslations");

            migrationBuilder.DropTable(
                name: "WebsiteMenuTranslations");

            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "BasicSalarys");

            migrationBuilder.DropTable(
                name: "CustomerTypes");

            migrationBuilder.DropTable(
                name: "PaperSizes");

            migrationBuilder.DropTable(
                name: "DocTemplateTypes");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "OrderStatuses");

            migrationBuilder.DropTable(
                name: "Payrolls");

            migrationBuilder.DropTable(
                name: "PetServiceSelections");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "AttributeValues");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "CommissionDiscounts");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Slides");

            migrationBuilder.DropTable(
                name: "ProductSKUs");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "WebsiteMenus");

            migrationBuilder.DropTable(
                name: "PostStatuses");

            migrationBuilder.DropTable(
                name: "PostTypes");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropTable(
                name: "ProductTypeStatuses");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "SlideStatuses");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "PostTypeStatuses");

            migrationBuilder.DropTable(
                name: "StoreStatuses");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
