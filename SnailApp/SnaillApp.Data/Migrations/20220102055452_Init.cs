using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Snail.Data.Migrations
{
    public partial class Init : Migration
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
                name: "AppUserStatuses",
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
                    table.PrimaryKey("PK_AppUserStatuses", x => x.Id);
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
                name: "AppUserTypes",
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
                    table.PrimaryKey("PK_AppUserTypes", x => x.Id);
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
                name: "PhieuKeToanStatuses",
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
                    table.PrimaryKey("PK_PhieuKeToanStatuses", x => x.Id);
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
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserStatusId = table.Column<int>(type: "int", nullable: true),
                    ActivateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastimePurchase = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalMoney = table.Column<double>(type: "float", nullable: false),
                    TotalDebt = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsStillInUse = table.Column<bool>(type: "bit", nullable: false),
                    TaxCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    CustomerTypeId = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressStreet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressWard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEmailVerified = table.Column<bool>(type: "bit", nullable: false),
                    IsPhoneVerified = table.Column<bool>(type: "bit", nullable: false),
                    Pin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RewardPoints = table.Column<double>(type: "float", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongTienTraHang = table.Column<double>(type: "float", nullable: false),
                    SoDonHang = table.Column<int>(type: "int", nullable: false),
                    NoNhaCungCap = table.Column<double>(type: "float", nullable: false),
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
                        name: "FK_AppUsers_AppUserStatuses_AppUserStatusId",
                        column: x => x.AppUserStatusId,
                        principalTable: "AppUserStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppUsers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppUsers_CustomerTypes_CustomerTypeId",
                        column: x => x.CustomerTypeId,
                        principalTable: "CustomerTypes",
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
                name: "AppUserStatusTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserStatusId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_AppUserStatusTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUserStatusTranslations_AppUserStatuses_AppUserStatusId",
                        column: x => x.AppUserStatusId,
                        principalTable: "AppUserStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserStatusTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTypeTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserTypeId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_AppUserTypeTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUserTypeTranslations_AppUserTypes_AppUserTypeId",
                        column: x => x.AppUserTypeId,
                        principalTable: "AppUserTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserTypeTranslations_Languages_LanguageId",
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
                name: "PhieuKeToanStatusTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhieuKeToanStatusId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_PhieuKeToanStatusTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhieuKeToanStatusTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuKeToanStatusTranslations_PhieuKeToanStatuses_PhieuKeToanStatusId",
                        column: x => x.PhieuKeToanStatusId,
                        principalTable: "PhieuKeToanStatuses",
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
                name: "AppUser_AppUserTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserTypeId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_AppUser_AppUserTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUser_AppUserTypes_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUser_AppUserTypes_AppUserTypes_AppUserTypeId",
                        column: x => x.AppUserTypeId,
                        principalTable: "AppUserTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUser_BasicSalarys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BasicSalaryId = table.Column<int>(type: "int", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    table.PrimaryKey("PK_AppUser_BasicSalarys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUser_BasicSalarys_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUser_BasicSalarys_BasicSalarys_BasicSalaryId",
                        column: x => x.BasicSalaryId,
                        principalTable: "BasicSalarys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUser_CommissionDiscounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommissionDiscountId = table.Column<int>(type: "int", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    table.PrimaryKey("PK_AppUser_CommissionDiscounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUser_CommissionDiscounts_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUser_CommissionDiscounts_CommissionDiscounts_CommissionDiscountId",
                        column: x => x.CommissionDiscountId,
                        principalTable: "CommissionDiscounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUser_Promotions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PromotionId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_AppUser_Promotions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUser_Promotions_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUser_Promotions_Promotions_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "Promotions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserFeedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
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
                    table.PrimaryKey("PK_AppUserFeedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUserFeedbacks_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserHelps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_AppUserHelps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUserHelps_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
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
                        name: "FK_Carts_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "PhieuKeToans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiPhieuKeToan = table.Column<int>(type: "int", nullable: false),
                    SaleStaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhieuKeToanStatusId = table.Column<int>(type: "int", nullable: true),
                    MoneyBeforeTax = table.Column<double>(type: "float", nullable: false),
                    MoneyAffterTax = table.Column<double>(type: "float", nullable: false),
                    TotalMoney = table.Column<double>(type: "float", nullable: false),
                    TotalPaid = table.Column<double>(type: "float", nullable: false),
                    TotalDiscount = table.Column<double>(type: "float", nullable: false),
                    TotalCommission = table.Column<double>(type: "float", nullable: false),
                    TotalDebt = table.Column<double>(type: "float", nullable: false),
                    TotalBuyingPrice = table.Column<double>(type: "float", nullable: false),
                    PercentDiscount = table.Column<double>(type: "float", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_PhieuKeToans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhieuKeToans_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhieuKeToans_AppUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhieuKeToans_AppUsers_SaleStaffId",
                        column: x => x.SaleStaffId,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhieuKeToans_PhieuKeToanStatuses_PhieuKeToanStatusId",
                        column: x => x.PhieuKeToanStatusId,
                        principalTable: "PhieuKeToanStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhieuKeToans_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
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
                name: "PhieuKeToanChiTiets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhieuKeToanId = table.Column<int>(type: "int", nullable: false),
                    ProductSKUId = table.Column<int>(type: "int", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImportPrice = table.Column<double>(type: "float", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    BuyingPrice = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
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
                    table.PrimaryKey("PK_PhieuKeToanChiTiets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhieuKeToanChiTiets_PhieuKeToans_PhieuKeToanId",
                        column: x => x.PhieuKeToanId,
                        principalTable: "PhieuKeToans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuKeToanChiTiets_ProductSKUs_ProductSKUId",
                        column: x => x.ProductSKUId,
                        principalTable: "ProductSKUs",
                        principalColumn: "Id");
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

            migrationBuilder.CreateTable(
                name: "PhieuKeToanChiTiet_AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhieuKeToanChiTietId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_PhieuKeToanChiTiet_AppUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhieuKeToanChiTiet_AppUsers_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhieuKeToanChiTiet_AppUsers_PhieuKeToanChiTiets_PhieuKeToanChiTietId",
                        column: x => x.PhieuKeToanChiTietId,
                        principalTable: "PhieuKeToanChiTiets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), "aea3f2ce-09ed-4ffd-b51c-fa333e7fbe2d", "Quản trị hệ thống", "admin", "admin" },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "15fcc4c0-457a-40ea-b8e8-146b5bded10f", "Quản lý cửa hàng", "StoreManager", "StoreManager" },
                    { new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"), "3d746737-5fa2-40f8-8827-c0b765141472", "Quản lý", "Manager", "manager" },
                    { new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"), "452e3aac-ccf2-43c1-92f6-720ad71b0e06", "Nhân viên kho", "WarehouseStaff", "WarehouseStaff" },
                    { new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"), "fa6687cc-c1d5-4491-8d57-8b43a316a9b2", "Nhân viên thu ngân", "Cashier", "Cashier" },
                    { new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"), "4f9f2e76-f33e-45bd-aa45-0c14d6fa9c03", "Nhân viên bán hàng", "ShopAssistant", "ShopAssistant" },
                    { new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"), "d1da8550-1029-43d4-8724-724863d9b4c9", "Quản lý chi nhánh", "BranchManager", "BranchManager" }
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
                table: "AppUserStatuses",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "InActive", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(824), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(824), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "Active", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(825), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(826), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "AppUserTypes",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "C", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6661), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6661), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "Su", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6662), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6662), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 3, "St", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6663), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6664), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Attributes",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "KG", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6358), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6359), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "Size", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6361), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6361), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "BasicSalarys",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "FromDate", "IsApply", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder", "ToDate", "Value" },
                values: new object[,]
                {
                    { 1, "001", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6869), new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6870), true, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6869), new Guid("00000000-0000-0000-0000-000000000000"), null, 0, null, 1000000.0 },
                    { 2, "002", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6871), new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6872), true, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6871), new Guid("00000000-0000-0000-0000-000000000000"), null, 0, null, 2000000.0 },
                    { 3, "003", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6873), new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6874), true, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6873), new Guid("00000000-0000-0000-0000-000000000000"), null, 0, null, 3000000.0 }
                });

            migrationBuilder.InsertData(
                table: "CommissionDiscounts",
                columns: new[] { "Id", "Code", "Commission", "CommissionPercent", "CreatedDate", "CreatedUserId", "Description", "Discount", "DiscountPercent", "FromDate", "IsApply", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder", "ToDate" },
                values: new object[,]
                {
                    { 1, null, 0.0, 2.0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7041), new Guid("00000000-0000-0000-0000-000000000000"), null, 0.0, 10.0, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7042), new Guid("00000000-0000-0000-0000-000000000000"), null, 0, null },
                    { 2, null, 0.0, 5.0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7044), new Guid("00000000-0000-0000-0000-000000000000"), null, 0.0, 15.0, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7045), new Guid("00000000-0000-0000-0000-000000000000"), null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "ContactInformation",
                columns: new[] { "Id", "Address", "Code", "CreatedDate", "CreatedUserId", "Description", "Email", "FacebookLink", "InstagramLink", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "PhoneNumber", "SortOrder", "YoutubeLink" },
                values: new object[] { 1, "29 Trần Trọng Cung, Q.7, TP. HCM", null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6829), new Guid("00000000-0000-0000-0000-000000000000"), null, "hello@chinopet.com", "/Chinopetvn", "https://www.instagram.com/", true, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6829), new Guid("00000000-0000-0000-0000-000000000000"), null, "037 6505247", 0, "https://www.youtube.com/" });

            migrationBuilder.InsertData(
                table: "DocTemplateTypes",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "PT", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6554), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6555), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "PC", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6555), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6556), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 3, "HDBHPOS", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6557), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6557), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 4, "PN", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6558), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6558), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 5, "PX", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6559), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6559), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "M", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5522), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5523), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "F", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5524), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5524), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "vi", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(120), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(128), new Guid("00000000-0000-0000-0000-000000000000"), "Tiếng Việt", 0 },
                    { 2, "en", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(131), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(131), new Guid("00000000-0000-0000-0000-000000000000"), "English", 0 }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "NSX1", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6295), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6295), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "NSX2", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6296), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6297), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 3, "NSX3", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6297), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6298), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 4, "NSX4", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6299), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6299), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "ActionName", "Code", "ControllerName", "CreatedDate", "CreatedUserId", "Description", "Icon", "IsDefault", "IsDeleted", "IsVisibled", "Link", "MenuType", "ModifiedDate", "ModifiedUserId", "Name", "ParentId", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, "WebApp_TQ", null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5577), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><path d='M3,16 L5,16 C5.55228475,16 6,15.5522847 6,15 C6,14.4477153 5.55228475,14 5,14 L3,14 L3,12 L5,12 C5.55228475,12 6,11.5522847 6,11 C6,10.4477153 5.55228475,10 5,10 L3,10 L3,8 L5,8 C5.55228475,8 6,7.55228475 6,7 C6,6.44771525 5.55228475,6 5,6 L3,6 L3,4 C3,3.44771525 3.44771525,3 4,3 L10,3 C10.5522847,3 11,3.44771525 11,4 L11,19 C11,19.5522847 10.5522847,20 10,20 L4,20 C3.44771525,20 3,19.5522847 3,19 L3,16 Z' fill='#000000' opacity='0.3'></path>		<path d='M16,3 L19,3 C20.1045695,3 21,3.8954305 21,5 L21,15.2485298 C21,15.7329761 20.8241635,16.200956 20.5051534,16.565539 L17.8762883,19.5699562 C17.6944473,19.7777745 17.378566,19.7988332 17.1707477,19.6169922 C17.1540423,19.602375 17.1383289,19.5866616 17.1237117,19.5699562 L14.4948466,16.565539 C14.1758365,16.200956 14,15.7329761 14,15.2485298 L14,5 C14,3.8954305 14.8954305,3 16,3 Z' fill='#000000'></path>	</svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5577), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 1 },
                    { 2, "Index", "WebApp_TQ_TQ", "Summary", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5579), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Home/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5579), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, 1 },
                    { 3, "Index", "WebApp_TQ_O", "Order", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5581), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Order/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5581), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, 2 },
                    { 4, null, "WebApp_HHDV", null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5596), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' width='24' height='24' viewBox='0 0 24 24' fill='none'>	<path opacity='0.25' fill-rule='evenodd' clip-rule='evenodd' d='M11 4.25769C11 3.07501 9.9663 2.13515 8.84397 2.50814C4.86766 3.82961 2 7.57987 2 11.9999C2 13.6101 2.38057 15.1314 3.05667 16.4788C3.58731 17.5363 4.98303 17.6028 5.81966 16.7662L5.91302 16.6728C6.60358 15.9823 6.65613 14.9011 6.3341 13.9791C6.11766 13.3594 6 12.6934 6 11.9999C6 9.62064 7.38488 7.56483 9.39252 6.59458C10.2721 6.16952 11 5.36732 11 4.39046V4.25769ZM16.4787 20.9434C17.5362 20.4127 17.6027 19.017 16.7661 18.1804L16.6727 18.087C15.9822 17.3964 14.901 17.3439 13.979 17.6659C13.3594 17.8823 12.6934 17.9999 12 17.9999C11.3066 17.9999 10.6406 17.8823 10.021 17.6659C9.09899 17.3439 8.01784 17.3964 7.3273 18.087L7.23392 18.1804C6.39728 19.017 6.4638 20.4127 7.52133 20.9434C8.86866 21.6194 10.3899 21.9999 12 21.9999C13.6101 21.9999 15.1313 21.6194 16.4787 20.9434Z' fill='#12131A'></path>	<path fill-rule='evenodd' clip-rule='evenodd' d='M13 4.39046C13 5.36732 13.7279 6.16952 14.6075 6.59458C16.6151 7.56483 18 9.62064 18 11.9999C18 12.6934 17.8823 13.3594 17.6659 13.9791C17.3439 14.9011 17.3964 15.9823 18.087 16.6728L18.1803 16.7662C19.017 17.6028 20.4127 17.5363 20.9433 16.4788C21.6194 15.1314 22 13.6101 22 11.9999C22 7.57987 19.1323 3.82961 15.156 2.50814C14.0337 2.13515 13 3.07501 13 4.25769V4.39046Z' fill='#12131A'></path></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5596), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 2 },
                    { 5, "Index", "WebApp_HHDV_HHDV", "Product", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5597), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Product/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5597), new Guid("00000000-0000-0000-0000-000000000000"), null, 4, 1 },
                    { 6, "Index", "WebApp_HHDV_NH", "StockIn", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5599), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/StockIn/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5599), new Guid("00000000-0000-0000-0000-000000000000"), null, 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "ActionName", "Code", "ControllerName", "CreatedDate", "CreatedUserId", "Description", "Icon", "IsDefault", "IsDeleted", "IsVisibled", "Link", "MenuType", "ModifiedDate", "ModifiedUserId", "Name", "ParentId", "SortOrder" },
                values: new object[,]
                {
                    { 7, "Index", "WebApp_HHDV_W", "Warehouse", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5600), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Warehouse/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5601), new Guid("00000000-0000-0000-0000-000000000000"), null, 4, 3 },
                    { 8, null, "WebApp_KH", null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5602), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns = 'http://www.w3.org/2000/svg' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><path d = 'M18,14 C16.3431458,14 15,12.6568542 15,11 C15,9.34314575 16.3431458,8 18,8 C19.6568542,8 21,9.34314575 21,11 C21,12.6568542 19.6568542,14 18,14 Z M9,11 C6.790861,11 5,9.209139 5,7 C5,4.790861 6.790861,3 9,3 C11.209139,3 13,4.790861 13,7 C13,9.209139 11.209139,11 9,11 Z' fill='#000000' fill-rule='nonzero' opacity='0.3'></path><path d = 'M17.6011961,15.0006174 C21.0077043,15.0378534 23.7891749,16.7601418 23.9984937,20.4 C24.0069246,20.5466056 23.9984937,21 23.4559499,21 L19.6,21 C19.6,18.7490654 18.8562935,16.6718327 17.6011961,15.0006174 Z M0.00065168429,20.1992055 C0.388258525,15.4265159 4.26191235,13 8.98334134,13 C13.7712164,13 17.7048837,15.2931929 17.9979143,20.2 C18.0095879,20.3954741 17.9979143,21 17.2466999,21 C13.541124,21 8.03472472,21 0.727502227,21 C0.476712155,21 -0.0204617505,20.45918 0.00065168429,20.1992055 Z' fill='#000000' fill-rule='nonzero'></path></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5602), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 3 },
                    { 9, "Index", "WebApp_KH_KH", "Customer", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5603), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Customer/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5604), new Guid("00000000-0000-0000-0000-000000000000"), null, 8, 1 },
                    { 10, "Index", "WebApp_KH_NCC", "Supplier", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5605), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Supplier/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5605), new Guid("00000000-0000-0000-0000-000000000000"), null, 8, 2 },
                    { 11, "Index", "WebApp_KH_NKH", "CustomerType", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5607), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/CustomerType/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5607), new Guid("00000000-0000-0000-0000-000000000000"), null, 8, 3 },
                    { 12, null, "WebApp_TB", null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5609), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><g stroke='none' stroke-width='1' fill='none' fill-rule='evenodd'>	<rect x='0' y='0' width='24' height='24'></rect>	<rect fill='#000000' opacity='0.3' x='2' y='5' width='20' height='14' rx='2'></rect>	<rect fill='#000000' x='2' y='8' width='20' height='3'></rect>	<rect fill='#000000' opacity='0.3' x='16' y='14' width='4' height='2' rx='1'></rect></g></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5609), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 4 },
                    { 13, "Index", "WebApp_TB_TQ", "SummaryOfReceiptPayment", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5611), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/SummaryOfReceiptPayment/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5611), new Guid("00000000-0000-0000-0000-000000000000"), null, 12, 1 },
                    { 14, "Index", "WebApp_TB_PT", "Receipt", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5612), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Receipt/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5613), new Guid("00000000-0000-0000-0000-000000000000"), null, 12, 2 },
                    { 15, "Index", "WebApp_TB_PC", "Payment", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5614), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Payment/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5614), new Guid("00000000-0000-0000-0000-000000000000"), null, 12, 3 },
                    { 16, "Index", "WebApp_TB_SQ", "CashBook", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5615), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/CashBook/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5616), new Guid("00000000-0000-0000-0000-000000000000"), null, 12, 4 },
                    { 17, null, "WebApp_BC", null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5617), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><g stroke='none' stroke-width='1' fill='none' fill-rule='evenodd'>	<polygon points='0 0 24 0 24 24 0 24'></polygon>	<path d='M5.85714286,2 L13.7364114,2 C14.0910962,2 14.4343066,2.12568431 14.7051108,2.35473959 L19.4686994,6.3839416 C19.8056532,6.66894833 20,7.08787823 20,7.52920201 L20,20.0833333 C20,21.8738751 19.9795521,22 18.1428571,22 L5.85714286,22 C4.02044787,22 4,21.8738751 4,20.0833333 L4,3.91666667 C4,2.12612489 4.02044787,2 5.85714286,2 Z' fill='#000000' fill-rule='nonzero' opacity='0.3'></path>	<rect fill='#000000' x='6' y='11' width='9' height='2' rx='1'></rect>	<rect fill='#000000' x='6' y='15' width='5' height='2' rx='1'></rect></g></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5617), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 5 },
                    { 18, null, "WebApp_BC_DS", null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5618), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/SaleReport/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5619), new Guid("00000000-0000-0000-0000-000000000000"), null, 17, 1 },
                    { 19, "Index", "WebApp_BC_HHDV", "ProductReport", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5620), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/ProductReport/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5620), new Guid("00000000-0000-0000-0000-000000000000"), null, 17, 2 },
                    { 20, "Index", "WebApp_BC_TK", "StockReport", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5621), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/StockReport/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5622), new Guid("00000000-0000-0000-0000-000000000000"), null, 17, 3 },
                    { 21, "Index", "WebApp_BC_LN", "ProfitReport", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5623), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/ProfitReport/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5624), new Guid("00000000-0000-0000-0000-000000000000"), null, 17, 4 },
                    { 22, "Index", "WebApp_BC_LL", "ProfitAndLossReport", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5625), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/ProfitAndLossReport/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5625), new Guid("00000000-0000-0000-0000-000000000000"), null, 17, 5 },
                    { 23, "Index", "WebApp_BC_BCT", "MonthlyReport", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5628), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/MonthlyReport/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5628), new Guid("00000000-0000-0000-0000-000000000000"), null, 17, 6 },
                    { 24, null, "WebApp_DM", null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5630), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><g stroke='none' stroke-width='1' fill='none' fill-rule='evenodd'><rect x='0' y='0' width='24' height='24'></rect><rect fill='#000000' x='4' y='4' width='7' height='7' rx='1.5'></rect><path d='M5.5,13 L9.5,13 C10.3284271,13 11,13.6715729 11,14.5 L11,18.5 C11,19.3284271 10.3284271,20 9.5,20 L5.5,20 C4.67157288,20 4,19.3284271 4,18.5 L4,14.5 C4,13.6715729 4.67157288,13 5.5,13 Z M14.5,4 L18.5,4 C19.3284271,4 20,4.67157288 20,5.5 L20,9.5 C20,10.3284271 19.3284271,11 18.5,11 L14.5,11 C13.6715729,11 13,10.3284271 13,9.5 L13,5.5 C13,4.67157288 13.6715729,4 14.5,4 Z M14.5,13 L18.5,13 C19.3284271,13 20,13.6715729 20,14.5 L20,18.5 C20,19.3284271 19.3284271,20 18.5,20 L14.5,20 C13.6715729,20 13,19.3284271 13,18.5 L13,14.5 C13,13.6715729 13.6715729,13 14.5,13 Z' fill='#000000' opacity='0.3'></path></g></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5630), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 6 },
                    { 25, "Index", "WebApp_DM_NHH", "ProductType", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5631), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/ProductType/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5631), new Guid("00000000-0000-0000-0000-000000000000"), null, 24, 1 },
                    { 26, "Index", "WebApp_DM_DVT", "Unit", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5633), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Unit/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5633), new Guid("00000000-0000-0000-0000-000000000000"), null, 24, 2 },
                    { 27, null, "WebApp_BHO", null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5634), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-link'><span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><path d='M16,15.6315789 L16,12 C16,10.3431458 14.6568542,9 13,9 L6.16183229,9 L6.16183229,5.52631579 C6.16183229,4.13107011 7.29290239,3 8.68814808,3 L20.4776218,3 C21.8728674,3 23.0039375,4.13107011 23.0039375,5.52631579 L23.0039375,13.1052632 L23.0206157,17.786793 C23.0215995,18.0629336 22.7985408,18.2875874 22.5224001,18.2885711 C22.3891754,18.2890457 22.2612702,18.2363324 22.1670655,18.1421277 L19.6565168,15.6315789 L16,15.6315789 Z' fill='#000000'></path><path d='M1.98505595,18 L1.98505595,13 C1.98505595,11.8954305 2.88048645,11 3.98505595,11 L11.9850559,11 C13.0896254,11 13.9850559,11.8954305 13.9850559,13 L13.9850559,18 C13.9850559,19.1045695 13.0896254,20 11.9850559,20 L4.10078614,20 L2.85693427,21.1905292 C2.65744295,21.3814685 2.34093638,21.3745358 2.14999706,21.1750444 C2.06092565,21.0819836 2.01120804,20.958136 2.01120804,20.8293182 L2.01120804,18.32426 C1.99400175,18.2187196 1.98505595,18.1104045 1.98505595,18 Z M6.5,14 C6.22385763,14 6,14.2238576 6,14.5 C6,14.7761424 6.22385763,15 6.5,15 L11.5,15 C11.7761424,15 12,14.7761424 12,14.5 C12,14.2238576 11.7761424,14 11.5,14 L6.5,14 Z M9.5,16 C9.22385763,16 9,16.2238576 9,16.5 C9,16.7761424 9.22385763,17 9.5,17 L11.5,17 C11.7761424,17 12,16.7761424 12,16.5 C12,16.2238576 11.7761424,16 11.5,16 L9.5,16 Z' fill='#000000' opacity='0.3'></path></svg></span></span><span class='menu-title'>Chat</span><span class='menu-arrow'></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5635), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 7 },
                    { 28, null, "WebApp_NV", null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5636), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns = 'http://www.w3.org/2000/svg' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><path d = 'M18,14 C16.3431458,14 15,12.6568542 15,11 C15,9.34314575 16.3431458,8 18,8 C19.6568542,8 21,9.34314575 21,11 C21,12.6568542 19.6568542,14 18,14 Z M9,11 C6.790861,11 5,9.209139 5,7 C5,4.790861 6.790861,3 9,3 C11.209139,3 13,4.790861 13,7 C13,9.209139 11.209139,11 9,11 Z' fill='#000000' fill-rule='nonzero' opacity='0.3'></path><path d = 'M17.6011961,15.0006174 C21.0077043,15.0378534 23.7891749,16.7601418 23.9984937,20.4 C24.0069246,20.5466056 23.9984937,21 23.4559499,21 L19.6,21 C19.6,18.7490654 18.8562935,16.6718327 17.6011961,15.0006174 Z M0.00065168429,20.1992055 C0.388258525,15.4265159 4.26191235,13 8.98334134,13 C13.7712164,13 17.7048837,15.2931929 17.9979143,20.2 C18.0095879,20.3954741 17.9979143,21 17.2466999,21 C13.541124,21 8.03472472,21 0.727502227,21 C0.476712155,21 -0.0204617505,20.45918 0.00065168429,20.1992055 Z' fill='#000000' fill-rule='nonzero'></path></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5637), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 8 },
                    { 29, "Index", "WebApp_NV_BL", "Payroll", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5638), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Payroll/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5638), new Guid("00000000-0000-0000-0000-000000000000"), null, 28, 1 },
                    { 30, null, "WebApp_CD", null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5639), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' width='24' height='24' viewBox='0 0 24 24' fill='none'><path opacity='0.25' d='M2 6.5C2 4.01472 4.01472 2 6.5 2H17.5C19.9853 2 22 4.01472 22 6.5V6.5C22 8.98528 19.9853 11 17.5 11H6.5C4.01472 11 2 8.98528 2 6.5V6.5Z' fill='#12131A'></path><path d='M20 6.5C20 7.88071 18.8807 9 17.5 9C16.1193 9 15 7.88071 15 6.5C15 5.11929 16.1193 4 17.5 4C18.8807 4 20 5.11929 20 6.5Z' fill='#12131A'></path><path opacity='0.25' d='M2 17.5C2 15.0147 4.01472 13 6.5 13H17.5C19.9853 13 22 15.0147 22 17.5V17.5C22 19.9853 19.9853 22 17.5 22H6.5C4.01472 22 2 19.9853 2 17.5V17.5Z' fill='#12131A'></path><path d='M9 17.5C9 18.8807 7.88071 20 6.5 20C5.11929 20 4 18.8807 4 17.5C4 16.1193 5.11929 15 6.5 15C7.88071 15 9 16.1193 9 17.5Z' fill='#12131A'></path></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5639), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 10 },
                    { 31, "Index", "WebApp_CD_NV", "Staff", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5641), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Staff/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5641), new Guid("00000000-0000-0000-0000-000000000000"), null, 30, 1 },
                    { 32, "Index", "WebApp_CD_PQ", "AppRole", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5642), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/AppRole/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5642), new Guid("00000000-0000-0000-0000-000000000000"), null, 30, 2 },
                    { 33, "Index", "WebApp_CD_CH", "Store", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5644), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Store/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5644), new Guid("00000000-0000-0000-0000-000000000000"), null, 30, 3 },
                    { 34, "Index", "WebApp_CD_MI", "DocTemplate", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5645), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/DocTemplate/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5645), new Guid("00000000-0000-0000-0000-000000000000"), null, 30, 4 },
                    { 35, null, "WebApp_CD_DMHT", null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5647), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5647), new Guid("00000000-0000-0000-0000-000000000000"), null, 30, 5 },
                    { 36, "Index", "WebApp_CD_DMHT_M", "Menu", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5648), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Menu/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5648), new Guid("00000000-0000-0000-0000-000000000000"), null, 35, 1 },
                    { 37, "Index", "WebApp_CD_DMHT_LMI", "DocTemplateType", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5649), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/DocTemplateType/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5650), new Guid("00000000-0000-0000-0000-000000000000"), null, 35, 2 },
                    { 38, null, "WebApp_QTW", null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5651), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='svg-icon svg-icon-primary svg-icon-2x'><!--begin::Svg Icon | path:/var/www/preview.keenthemes.com/metronic/releases/2021-05-14-112058/theme/html/demo2/dist/../src/media/svg/icons/Devices/iMac.svg--><svg xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'>    <g stroke='none' stroke-width='1' fill='none' fill-rule='evenodd'>        <rect x='0' y='0' width='24' height='24'/>        <path d='M5,5 L5,16 L19,16 L19,5 L5,5 Z M5,3 L19,3 C20.4201608,3 21,3.7163444 21,4.6 L21,17.4 C21,18.2836556 20.4201608,19 19,19 L5,19 C3.57983921,19 3,18.2836556 3,17.4 L3,4.6 C3,3.7163444 3.57983921,3 5,3 Z M12,18 C12.2761424,18 12.5,17.7761424 12.5,17.5 C12.5,17.2238576 12.2761424,17 12,17 C11.7238576,17 11.5,17.2238576 11.5,17.5 C11.5,17.7761424 11.7238576,18 12,18 Z' fill='#12131A' fill-rule='nonzero'/>        <polygon fill='#12131A' opacity='0.3' points='5 5 5 16 19 16 19 5'/>        <rect fill='#12131A' opacity='0.3' x='10' y='20' width='4' height='1' rx='0.5'/>    </g></svg><!--end::Svg Icon--></span>", false, false, true, "", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5651), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 11 },
                    { 39, "Index", "WebApp_QTW_P", "Post", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5652), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Post/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5653), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 1 },
                    { 40, "Index", "WebApp_QTW_PT", "PostType", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5654), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/PostType/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5654), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 2 },
                    { 41, "Index", "WebApp_QTW_S", "Slider", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5655), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Slider/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5656), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 3 },
                    { 42, "Index", "WebApp_KH_NSX", "Manufacturer", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5658), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Manufacturer/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5659), new Guid("00000000-0000-0000-0000-000000000000"), null, 8, 3 },
                    { 43, "Index", "WebApp_DM_TT", "Attribute", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5660), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Attribute/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5660), new Guid("00000000-0000-0000-0000-000000000000"), null, 24, 1 },
                    { 44, null, "WebApp_CD_DMHT_STATUS", null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5661), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5662), new Guid("00000000-0000-0000-0000-000000000000"), null, 35, 4 },
                    { 45, "Index", "WebApp_CD_DMHT_STATUS_AUS", "AppUserStatus", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5663), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/AppUserStatus/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5663), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 1 },
                    { 46, "Index", "WebApp_CD_DMHT_STATUS_OS", "AppUsOrderStatuserStatus", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5664), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/OrderStatus/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5665), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 2 },
                    { 47, "Index", "WebApp_CD_DMHT_STATUS_PS", "PhieuKeToanStatus", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5666), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/PhieuKeToanStatus/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5666), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 2 },
                    { 48, "Index", "WebApp_CD_DMHT_STATUS_POSTS", "PostStatus", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5667), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/PostStatus/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5668), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 3 }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "ActionName", "Code", "ControllerName", "CreatedDate", "CreatedUserId", "Description", "Icon", "IsDefault", "IsDeleted", "IsVisibled", "Link", "MenuType", "ModifiedDate", "ModifiedUserId", "Name", "ParentId", "SortOrder" },
                values: new object[,]
                {
                    { 49, "Index", "WebApp_CD_DMHT_STATUS_POSTTYPES", "PostTypeStatus", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5669), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/PostTypeStatus/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5669), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 4 },
                    { 50, "Index", "WebApp_CD_DMHT_STATUS_PRODUCTTYPES", "ProductTypeStatus", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5670), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/ProductTypeStatus/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5671), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 5 },
                    { 51, "Index", "WebApp_CD_DMHT_STATUS_STS", "StoreStatus", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5672), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/StoreStatus/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5672), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 6 },
                    { 52, "Index", "WebApp_DM_GTTT", "AttributeValue", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5676), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/AttributeValue/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5678), new Guid("00000000-0000-0000-0000-000000000000"), null, 24, 1 },
                    { 53, "Index", "WebApp_CD_DMHT_P", "PaperSize", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5679), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/PaperSize/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5679), new Guid("00000000-0000-0000-0000-000000000000"), null, 35, 3 },
                    { 54, "Index", "WebApp_CD_DMHT_AUT", "AppUserType", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5680), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/AppUserType/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5681), new Guid("00000000-0000-0000-0000-000000000000"), null, 35, 5 },
                    { 55, null, "WebApp_BH", null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5682), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' width='24' height='24' viewBox='0 0 24 24' fill='none'><path opacity='0.25' d='M2 6.5C2 4.01472 4.01472 2 6.5 2H17.5C19.9853 2 22 4.01472 22 6.5V6.5C22 8.98528 19.9853 11 17.5 11H6.5C4.01472 11 2 8.98528 2 6.5V6.5Z' fill='#12131A'></path><path d='M20 6.5C20 7.88071 18.8807 9 17.5 9C16.1193 9 15 7.88071 15 6.5C15 5.11929 16.1193 4 17.5 4C18.8807 4 20 5.11929 20 6.5Z' fill='#12131A'></path><path opacity='0.25' d='M2 17.5C2 15.0147 4.01472 13 6.5 13H17.5C19.9853 13 22 15.0147 22 17.5V17.5C22 19.9853 19.9853 22 17.5 22H6.5C4.01472 22 2 19.9853 2 17.5V17.5Z' fill='#12131A'></path><path d='M9 17.5C9 18.8807 7.88071 20 6.5 20C5.11929 20 4 18.8807 4 17.5C4 16.1193 5.11929 15 6.5 15C7.88071 15 9 16.1193 9 17.5Z' fill='#12131A'></path></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5682), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 9 },
                    { 56, "Index", "WebApp_BH_P", "Promotion", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5683), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Promotion/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5683), new Guid("00000000-0000-0000-0000-000000000000"), null, 55, 1 },
                    { 57, "Index", "WebApp_BH_CD", "CommissionDiscount", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5685), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/CommissionDiscount/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5686), new Guid("00000000-0000-0000-0000-000000000000"), null, 55, 2 },
                    { 58, "Index", "WebApp_NV_BS", "BasicSalary", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5687), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/BasicSalary/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5687), new Guid("00000000-0000-0000-0000-000000000000"), null, 28, 2 },
                    { 59, "Index", "WebApp_QTW_M", "WebsiteMenu", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5688), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/WebsiteMenu/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5689), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 4 },
                    { 60, "Index", "WebApp_QTW_B", "Booking", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5690), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Booking/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5690), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 5 },
                    { 61, "Index", "WebApp_QTW_C", "Contact", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5691), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Contact/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5692), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 6 },
                    { 62, "Index", "WebApp_QTW_CI", "ContactInformation", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5693), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/ContactInformation/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5694), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 7 },
                    { 63, "Index", "WebApp_QTW_N", "Newsletter", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5695), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Newsletter/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5696), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 8 },
                    { 64, "Index", "WebApp_QTW_T", "Testimonial", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5697), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Testimonial/Index", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5697), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 9 },
                    { 65, "Print", "WebApp_HHDV_QRC", "Product", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5698), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Product/Print", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5699), new Guid("00000000-0000-0000-0000-000000000000"), null, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "InProgress", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(447), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(448), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "Confirmed", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(450), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(450), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 3, "Shipping", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(451), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(451), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 4, "Success", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(452), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(453), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 5, "Canceled", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(454), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(454), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "PaperSizes",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder", "Value" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6525), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6526), new Guid("00000000-0000-0000-0000-000000000000"), "58 mm", 0, 5.7999999999999998 },
                    { 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6527), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6527), new Guid("00000000-0000-0000-0000-000000000000"), "80 mm", 0, 8.0 },
                    { 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6530), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6530), new Guid("00000000-0000-0000-0000-000000000000"), "A5", 0, 21.0 },
                    { 4, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6531), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6531), new Guid("00000000-0000-0000-0000-000000000000"), "A4", 0, 21.0 }
                });

            migrationBuilder.InsertData(
                table: "PhieuKeToanStatuses",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "InActive", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(664), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(664), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "Active", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(665), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(666), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "PostStatuses",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "InActive", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(506), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(506), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "Active", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(507), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(508), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "PostTypes",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "ParentId", "PostTypeStatusId", "SortOrder" },
                values: new object[,]
                {
                    { 1, "CNTT", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(542), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(543), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, 0 },
                    { 2, "CNSH", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(544), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(544), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductTypeStatuses",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "InActive", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(582), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(583), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "Active", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(584), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(584), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "FromDate", "IsApply", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder", "ToDate" },
                values: new object[,]
                {
                    { 1, "001", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7115), new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7116), true, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7116), new Guid("00000000-0000-0000-0000-000000000000"), null, 0, null },
                    { 2, "002", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7118), new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7119), true, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7118), new Guid("00000000-0000-0000-0000-000000000000"), null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "SlideStatuses",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "InActive", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(857), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(858), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "Active", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(858), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(859), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "Image", "IsDefault", "IsDeleted", "IsVisibled", "Link", "ModifiedDate", "ModifiedUserId", "Name", "SlideStatusId", "SortOrder" },
                values: new object[] { 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5333), new Guid("00000000-0000-0000-0000-000000000000"), null, "smart_farming.jpg", false, false, true, "#", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5334), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 1 });

            migrationBuilder.InsertData(
                table: "StoreStatuses",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "Active", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(619), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(619), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "Repair", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(620), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(620), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 3, "TemporarilyClosed", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(621), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(622), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "StoreStatuses",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[] { 4, "Closed", new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(623), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(623), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "Image", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[] { 1, "Le Quang Teo", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6846), new Guid("00000000-0000-0000-0000-000000000000"), "", null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6847), new Guid("00000000-0000-0000-0000-000000000000"), "It's Amazing", 0 });

            migrationBuilder.InsertData(
                table: "WebsiteMenus",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "Icon", "IsDefault", "IsDeleted", "IsVisibled", "Link", "ModifiedDate", "ModifiedUserId", "Name", "ParentId", "SortOrder", "WebsiteMenuType" },
                values: new object[,]
                {
                    { 1, "AboutUs", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6739), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/about-us", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6739), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 1, 1 },
                    { 2, "Pets", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6742), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Pets/Index", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6742), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 2, 1 },
                    { 3, "Shop", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6744), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Shop/Index", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6744), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 3, 1 },
                    { 4, "Services", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6745), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Services/Index", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6745), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 4, 1 },
                    { 5, "Blogs", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6746), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Blog/Index", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6747), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 5, 1 },
                    { 6, "Contact", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6748), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Contact/Index", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6748), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 6, 1 },
                    { 7, "PetMart", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6749), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Shop/Index", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6749), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 1, 2 },
                    { 8, "Chinovet", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6750), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Vet/Index", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6751), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 2, 2 },
                    { 9, "ChinoSalon", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6752), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Salon/Index", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6752), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 3, 2 },
                    { 10, "ChinoHotel", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6753), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Hotel/Index", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6753), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 4, 2 },
                    { 11, "Training", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6755), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Training/Index", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6756), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 5, 2 }
                });

            migrationBuilder.InsertData(
                table: "AppRoleTranslations",
                columns: new[] { "Id", "AppRoleId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1032), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý cửa hàng", false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1033), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý cửa hàng", 0 },
                    { 2, new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1035), new Guid("00000000-0000-0000-0000-000000000000"), "Store owner", false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1035), new Guid("00000000-0000-0000-0000-000000000000"), "Store manager", 0 },
                    { 3, new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1036), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý", false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1036), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý", 0 },
                    { 4, new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1037), new Guid("00000000-0000-0000-0000-000000000000"), "General manager", false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1038), new Guid("00000000-0000-0000-0000-000000000000"), "General manager", 0 },
                    { 5, new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1039), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên kho", false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1039), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên kho", 0 },
                    { 6, new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1040), new Guid("00000000-0000-0000-0000-000000000000"), "Warehouse staff", false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1041), new Guid("00000000-0000-0000-0000-000000000000"), "Warehouse staff", 0 },
                    { 7, new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1042), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên thu ngân", false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1042), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên thu ngân", 0 },
                    { 8, new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1043), new Guid("00000000-0000-0000-0000-000000000000"), "Cashier", false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1043), new Guid("00000000-0000-0000-0000-000000000000"), "Cashier", 0 },
                    { 9, new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1044), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên bán hàng", false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1045), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên bán hàng", 0 },
                    { 10, new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1046), new Guid("00000000-0000-0000-0000-000000000000"), "Shop assistant", false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1046), new Guid("00000000-0000-0000-0000-000000000000"), "Shop assistant", 0 },
                    { 11, new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1047), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý chi nhánh", false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1047), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý chi nhánh", 0 },
                    { 12, new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1048), new Guid("00000000-0000-0000-0000-000000000000"), "Branch manager", false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1049), new Guid("00000000-0000-0000-0000-000000000000"), "Branch manager", 0 },
                    { 13, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1050), new Guid("00000000-0000-0000-0000-000000000000"), "Quản trị hệ thống", false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1050), new Guid("00000000-0000-0000-0000-000000000000"), "Quản trị hệ thống", 0 },
                    { 14, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1052), new Guid("00000000-0000-0000-0000-000000000000"), "Branch Manager", false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(1052), new Guid("00000000-0000-0000-0000-000000000000"), "Branch Manager", 0 }
                });

            migrationBuilder.InsertData(
                table: "AppUserStatusTranslations",
                columns: new[] { "Id", "AppUserStatusId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(838), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(838), new Guid("00000000-0000-0000-0000-000000000000"), "Chưa kích hoạt", 0 },
                    { 2, 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(839), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(840), new Guid("00000000-0000-0000-0000-000000000000"), "InActive", 0 },
                    { 3, 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(841), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(841), new Guid("00000000-0000-0000-0000-000000000000"), "Đang hoạt động", 0 },
                    { 4, 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(842), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(843), new Guid("00000000-0000-0000-0000-000000000000"), "Active", 0 }
                });

            migrationBuilder.InsertData(
                table: "AppUserTypeTranslations",
                columns: new[] { "Id", "AppUserTypeId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6683), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6683), new Guid("00000000-0000-0000-0000-000000000000"), "Khách hàng", 0 },
                    { 2, 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6685), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6685), new Guid("00000000-0000-0000-0000-000000000000"), "Customer", 0 },
                    { 3, 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6687), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6687), new Guid("00000000-0000-0000-0000-000000000000"), "Nhà cung cấp", 0 },
                    { 4, 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6688), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6688), new Guid("00000000-0000-0000-0000-000000000000"), "Supplier", 0 },
                    { 5, 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6689), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6690), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên", 0 },
                    { 6, 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6690), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6691), new Guid("00000000-0000-0000-0000-000000000000"), "Staff", 0 }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivateDate", "Address", "AddressCity", "AddressDistrict", "AddressStreet", "AddressWard", "AppUserStatusId", "Avatar", "Code", "CompanyName", "ConcurrencyStamp", "ContactPerson", "CountryId", "CreatedDate", "CreatedUserId", "CustomerTypeId", "Description", "Dob", "Email", "EmailConfirmed", "FirstName", "GenderId", "GhiChu", "IsActive", "IsDelete", "IsEmailVerified", "IsPhoneVerified", "IsStillInUse", "LastName", "LastimePurchase", "LeaveDate", "LockoutEnabled", "LockoutEnd", "ModifiedDate", "ModifiedUserId", "NoNhaCungCap", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Pin", "RegisterDate", "RewardPoints", "SecurityStamp", "SoDonHang", "StartingDate", "TaxCode", "TongTienTraHang", "TotalDebt", "TotalMoney", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0227bc9a-ed2f-4617-e96b-08d9704a3422"), 0, null, "09 Lê Hồng Phong", null, null, null, null, 1, null, "003", null, "eb29b3b8-1129-4dff-a28c-f9cbd61a0dc1", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "tin@gmail.com", true, "Tin", null, null, true, false, false, false, true, "Ngo Trung", null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, "tin@gmail.com", "tin", "AQAAAAEAACcQAAAAEDJyKTjynH32cRJBb0hkzh7/n5PBvC+WhqVHmgS7EAIUlBmijaJRTljbTwI21BosNw==", "0922780224", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "", 0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5096), null, 0.0, 0.0, 0.0, false, "tin" },
                    { new Guid("0227bc9a-ed2f-4617-e96b-08d9704a3494"), 0, null, "09 Lê Hồng Phong", null, null, null, null, 1, null, "002", null, "3955228c-ea47-4475-b45c-42c388984183", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "long@gmail.com", true, "Long", null, null, true, false, false, false, true, "Nguyen Ho Phi", null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, "long@gmail.com", "long", "AQAAAAEAACcQAAAAELb/j70wdWz9CRAANRV57ipOfNAqyaI2JmDMLRn/mmFzHYlFP5ZL7EtRZFxjGgD/9w==", "0915780224", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "", 0, new DateTime(2022, 1, 2, 12, 54, 50, 157, DateTimeKind.Local).AddTicks(6097), null, 0.0, 0.0, 0.0, false, "long" },
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, null, "09 Lê Hồng Phong", null, null, null, null, 1, null, "001", null, "41484e11-0cc6-42ef-b36e-5d44003cee97", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenkhachuy2709@gmail.com", true, "Huy", null, null, true, false, false, false, true, "Nguyen Khac", null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), 0.0, "nguyenkhachuy2709@gmail.com", "admin", "AQAAAAEAACcQAAAAEN+HcKuz3fF7A0hRJLx13K4flOTYxAjjbVOM/mbM51TZ7375lgpTK09+IvTdR9tUJg==", "0915780794", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, "", 0, new DateTime(2022, 1, 2, 12, 54, 50, 151, DateTimeKind.Local).AddTicks(7903), null, 0.0, 0.0, 0.0, false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AttributeTranslations",
                columns: new[] { "Id", "AttributeId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SeoAlias", "SeoDescription", "SeoTitle", "SortOrder" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6378), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6378), new Guid("00000000-0000-0000-0000-000000000000"), "Số kí", null, null, null, 0 },
                    { 2, 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6380), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6380), new Guid("00000000-0000-0000-0000-000000000000"), "Kg", null, null, null, 0 },
                    { 3, 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6381), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6382), new Guid("00000000-0000-0000-0000-000000000000"), "Kích thước", null, null, null, 0 },
                    { 4, 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6382), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6383), new Guid("00000000-0000-0000-0000-000000000000"), "Size", null, null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "AttributeValues",
                columns: new[] { "Id", "AttributeId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6432), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6433), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6434), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6434), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "BasicSalaryTranslations",
                columns: new[] { "Id", "BasicSalaryId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6979), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6980), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý", 0 },
                    { 2, 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6984), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6985), new Guid("00000000-0000-0000-0000-000000000000"), "N/A", 0 },
                    { 3, 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6986), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6987), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên", 0 },
                    { 4, 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6987), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6988), new Guid("00000000-0000-0000-0000-000000000000"), "N/A", 0 },
                    { 5, 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6989), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6989), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý kho", 0 },
                    { 6, 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6990), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6990), new Guid("00000000-0000-0000-0000-000000000000"), "N/A", 0 }
                });

            migrationBuilder.InsertData(
                table: "CommissionDiscountTranslations",
                columns: new[] { "Id", "Code", "CommissionDiscountId", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7063), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7063), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên thử việc", 0 },
                    { 2, null, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7065), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7065), new Guid("00000000-0000-0000-0000-000000000000"), "N/A", 0 },
                    { 3, null, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7066), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7067), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên chính thức", 0 }
                });

            migrationBuilder.InsertData(
                table: "CommissionDiscountTranslations",
                columns: new[] { "Id", "Code", "CommissionDiscountId", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[] { 4, null, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7068), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7069), new Guid("00000000-0000-0000-0000-000000000000"), "N/A", 0 });

            migrationBuilder.InsertData(
                table: "DocTemplateTypeTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "DocTemplateTypeId", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6575), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6576), new Guid("00000000-0000-0000-0000-000000000000"), "Phiếu thu", 0 },
                    { 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6577), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6577), new Guid("00000000-0000-0000-0000-000000000000"), "Receipt", 0 },
                    { 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6578), new Guid("00000000-0000-0000-0000-000000000000"), null, 2, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6579), new Guid("00000000-0000-0000-0000-000000000000"), "Phiếu chi", 0 },
                    { 4, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6580), new Guid("00000000-0000-0000-0000-000000000000"), null, 2, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6581), new Guid("00000000-0000-0000-0000-000000000000"), "Payment", 0 },
                    { 5, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6582), new Guid("00000000-0000-0000-0000-000000000000"), null, 3, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6582), new Guid("00000000-0000-0000-0000-000000000000"), "Hóa đơn bán hàng POS", 0 },
                    { 6, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6583), new Guid("00000000-0000-0000-0000-000000000000"), null, 3, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6583), new Guid("00000000-0000-0000-0000-000000000000"), "Invoice POS", 0 },
                    { 7, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6584), new Guid("00000000-0000-0000-0000-000000000000"), null, 4, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6585), new Guid("00000000-0000-0000-0000-000000000000"), "Phiếu nhập kho", 0 },
                    { 8, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6586), new Guid("00000000-0000-0000-0000-000000000000"), null, 4, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6586), new Guid("00000000-0000-0000-0000-000000000000"), "Warehouse receipt", 0 },
                    { 9, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6587), new Guid("00000000-0000-0000-0000-000000000000"), null, 5, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6587), new Guid("00000000-0000-0000-0000-000000000000"), "Phiếu xuất kho", 0 },
                    { 10, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6588), new Guid("00000000-0000-0000-0000-000000000000"), null, 5, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6589), new Guid("00000000-0000-0000-0000-000000000000"), "Warehouse export", 0 }
                });

            migrationBuilder.InsertData(
                table: "DocTemplates",
                columns: new[] { "Id", "Code", "Content", "CreatedDate", "CreatedUserId", "Description", "DocTemplateTypeId", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "PaperSizeId", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6611), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, true, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6612), new Guid("00000000-0000-0000-0000-000000000000"), "Phiếu thu mẫu 1", null, 0 },
                    { 2, null, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6613), new Guid("00000000-0000-0000-0000-000000000000"), null, 2, true, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6614), new Guid("00000000-0000-0000-0000-000000000000"), "Phiếu chi mẫu 1", null, 0 },
                    { 3, null, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6615), new Guid("00000000-0000-0000-0000-000000000000"), null, 3, true, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6615), new Guid("00000000-0000-0000-0000-000000000000"), "Hóa đơn bán hàng mẫu 1", null, 0 },
                    { 4, null, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6616), new Guid("00000000-0000-0000-0000-000000000000"), null, 4, true, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6616), new Guid("00000000-0000-0000-0000-000000000000"), "Phiếu nhập kho mẫu 1", null, 0 },
                    { 5, null, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6617), new Guid("00000000-0000-0000-0000-000000000000"), null, 5, true, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6618), new Guid("00000000-0000-0000-0000-000000000000"), "Phiếu xuất kho mẫu 1", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "GenderTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "GenderId", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5551), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5551), new Guid("00000000-0000-0000-0000-000000000000"), "Nam", 0 },
                    { 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5553), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5553), new Guid("00000000-0000-0000-0000-000000000000"), "Male", 0 },
                    { 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5554), new Guid("00000000-0000-0000-0000-000000000000"), null, 2, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5555), new Guid("00000000-0000-0000-0000-000000000000"), "Nữ", 0 },
                    { 4, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5556), new Guid("00000000-0000-0000-0000-000000000000"), null, 2, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5556), new Guid("00000000-0000-0000-0000-000000000000"), "Female", 0 }
                });

            migrationBuilder.InsertData(
                table: "ManufacturerTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ManufacturerId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6324), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6324), new Guid("00000000-0000-0000-0000-000000000000"), "Nhà sản xuất 1", 0 },
                    { 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6325), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6326), new Guid("00000000-0000-0000-0000-000000000000"), "Manufacturer 1", 0 },
                    { 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6327), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6328), new Guid("00000000-0000-0000-0000-000000000000"), "Nhà sản xuất 2", 0 },
                    { 4, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6328), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6329), new Guid("00000000-0000-0000-0000-000000000000"), "Manufacturer 2", 0 },
                    { 5, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6330), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 3, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6330), new Guid("00000000-0000-0000-0000-000000000000"), "Nhà sản xuất 3", 0 },
                    { 6, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6331), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 3, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6331), new Guid("00000000-0000-0000-0000-000000000000"), "Manufacturer 3", 0 },
                    { 7, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6332), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 4, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6332), new Guid("00000000-0000-0000-0000-000000000000"), "Nhà sản xuất 4", 0 },
                    { 8, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6333), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 4, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6334), new Guid("00000000-0000-0000-0000-000000000000"), "Manufacturer 4", 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuAppRoles",
                columns: new[] { "Id", "AppRoleId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsAllow", "IsDefault", "IsDeleted", "IsVisibled", "MenuAppRoleType", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5981), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5981), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5983), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5983), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 3, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5984), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5985), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 4, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5985), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5986), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 5, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5987), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5987), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 6, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5988), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5988), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 7, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5989), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 3, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5989), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 8, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5990), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 3, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5990), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 9, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5991), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 3, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5991), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 10, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5992), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 4, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5993), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 11, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5993), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 4, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5994), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 12, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5994), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 4, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5995), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 13, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5996), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 5, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5996), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 14, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5997), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 5, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5997), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuAppRoles",
                columns: new[] { "Id", "AppRoleId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsAllow", "IsDefault", "IsDeleted", "IsVisibled", "MenuAppRoleType", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 15, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5998), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 5, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5998), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 16, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5999), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 6, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5999), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 17, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6000), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 6, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6000), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 18, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6001), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 6, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6001), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 19, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6002), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 7, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6003), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 20, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6003), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 7, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6004), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 21, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6004), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 7, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6005), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 22, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6006), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 8, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6007), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 23, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6007), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 8, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6008), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 24, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6008), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 8, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6009), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 25, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6010), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 9, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6010), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 26, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6011), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 9, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6011), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 27, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6012), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 9, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6012), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 28, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6013), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 10, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6013), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 29, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6014), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 10, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6015), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 30, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6015), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 10, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6016), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 31, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6022), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 11, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6022), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 32, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6023), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 11, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6023), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 33, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6024), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 11, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6024), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 34, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6025), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 12, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6026), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 35, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6026), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 12, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6027), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 36, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6027), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 12, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6028), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 37, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6029), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 13, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6029), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 38, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6030), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 13, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6030), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 39, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6031), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 13, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6031), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 40, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6032), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 14, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6032), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 41, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6033), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 14, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6033), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 42, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6034), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 14, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6035), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 43, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6036), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 15, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6037), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 44, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6037), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 15, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6038), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 45, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6038), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 15, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6039), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 46, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6040), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 16, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6040), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 47, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6041), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 16, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6041), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 48, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6042), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 16, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6042), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 49, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6043), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 17, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6043), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 50, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6044), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 17, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6045), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 51, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6045), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 17, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6046), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 52, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6046), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 18, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6047), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 53, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6048), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 18, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6048), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 54, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6049), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 18, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6049), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 55, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6050), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 19, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6050), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 56, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6051), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 19, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6051), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuAppRoles",
                columns: new[] { "Id", "AppRoleId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsAllow", "IsDefault", "IsDeleted", "IsVisibled", "MenuAppRoleType", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 57, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6052), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 19, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6053), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 58, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6053), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 20, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6054), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 59, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6054), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 20, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6055), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 60, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6056), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 20, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6056), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 61, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6057), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 21, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6057), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 62, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6058), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 21, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6058), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 63, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6059), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 21, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6059), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 64, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6061), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 22, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6061), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 65, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6062), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 22, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6062), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 66, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6063), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 22, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6063), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 67, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6064), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 23, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6065), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 68, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6065), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 23, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6066), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 69, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6066), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 23, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6067), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 70, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6067), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 24, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6068), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 71, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6069), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 24, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6069), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 72, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6070), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 24, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6070), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 73, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6071), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 25, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6071), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 74, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6072), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 25, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6072), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 75, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6073), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 25, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6073), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 76, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6074), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 26, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6075), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 77, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6075), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 26, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6076), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 78, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6076), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 26, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6077), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 79, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6078), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 27, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6078), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 80, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6079), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 27, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6079), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 81, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6080), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 27, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6080), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 82, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6081), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 28, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6081), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 83, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6082), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 28, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6082), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 84, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6084), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 28, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6084), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 85, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6085), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 29, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6085), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 86, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6086), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 29, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6087), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 87, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6087), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 29, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6088), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 88, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6093), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 30, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6094), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 89, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6096), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 30, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6096), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 90, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6097), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 30, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6097), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 91, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6098), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 31, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6099), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 92, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6099), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 31, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6100), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 93, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6100), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 31, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6101), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 94, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6101), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 32, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6102), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 95, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6103), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 32, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6103), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 96, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6104), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 32, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6104), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 97, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6105), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 33, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6105), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 98, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6106), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 33, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6107), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuAppRoles",
                columns: new[] { "Id", "AppRoleId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsAllow", "IsDefault", "IsDeleted", "IsVisibled", "MenuAppRoleType", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 99, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6107), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 33, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6108), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 100, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6108), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 34, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6109), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 101, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6110), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 34, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6110), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 102, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6111), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 34, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6111), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 103, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6112), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 35, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6112), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 104, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6114), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 35, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6114), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 105, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6115), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 35, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6115), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 106, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6116), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 36, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6117), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 107, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6117), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 36, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6118), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 108, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6118), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 36, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6119), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 109, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6120), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 37, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6120), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 110, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6121), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 37, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6121), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 111, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6122), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 37, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6122), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 112, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6123), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 38, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6123), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 113, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6125), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 38, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6125), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 114, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6126), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 38, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6127), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 115, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6127), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 39, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6128), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 116, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6128), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 39, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6129), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 117, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6130), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 39, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6130), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 118, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6131), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 40, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6131), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 119, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6133), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 40, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6134), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 120, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6135), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 40, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6135), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 121, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6136), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 41, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6136), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 122, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6137), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 41, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6137), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 123, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6138), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 41, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6138), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 124, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6139), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 42, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6140), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 125, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6140), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 42, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6141), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 126, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6142), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 42, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6143), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 127, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6145), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 43, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6145), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 128, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6146), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 43, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6146), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 129, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6147), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 43, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6148), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 130, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6148), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 44, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6149), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 131, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6149), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 44, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6150), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 132, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6151), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 44, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6151), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 133, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6152), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 45, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6152), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 134, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6153), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 45, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6153), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 135, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6154), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 45, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6154), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 136, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6155), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 46, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6155), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 137, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6156), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 46, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6157), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 138, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6158), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 46, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6159), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 139, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6160), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 47, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6160), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 140, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6161), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 47, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6161), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuAppRoles",
                columns: new[] { "Id", "AppRoleId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsAllow", "IsDefault", "IsDeleted", "IsVisibled", "MenuAppRoleType", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 141, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6162), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 47, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6162), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 142, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6163), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 48, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6163), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 143, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6164), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 48, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6165), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 144, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6168), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 48, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6169), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 145, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6170), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 49, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6170), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 146, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6172), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 49, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6172), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 147, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6174), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 49, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6174), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 148, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6175), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 50, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6175), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 149, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6176), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 50, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6177), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 150, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6177), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 50, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6178), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 151, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6178), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 51, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6179), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 152, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6179), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 51, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6180), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 153, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6181), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 51, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6181), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 154, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6182), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 52, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6182), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 155, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6183), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 52, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6183), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 156, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6184), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 52, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6184), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 157, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6185), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 53, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6185), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 158, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6186), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 53, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6187), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 159, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6187), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 53, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6188), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 160, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6188), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 54, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6189), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 161, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6190), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 54, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6190), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 162, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6191), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 54, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6191), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 163, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6192), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 55, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6192), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 164, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6193), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 55, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6193), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 165, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6194), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 55, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6194), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 166, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6195), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 56, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6196), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 167, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6196), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 56, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6197), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 168, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6198), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 56, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6199), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 169, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6199), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 57, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6200), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 170, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6200), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 57, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6201), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 171, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6205), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 57, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6205), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 172, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6207), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 58, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6207), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 173, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6208), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 58, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6208), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 174, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6210), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 58, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6210), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 175, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6211), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 59, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6211), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 176, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6212), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 59, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6212), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 177, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6213), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 59, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6214), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 178, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6214), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 60, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6215), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 179, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6215), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 60, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6216), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 180, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6217), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 60, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6217), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 181, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6218), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 61, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6218), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 182, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6219), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 61, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6219), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuAppRoles",
                columns: new[] { "Id", "AppRoleId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsAllow", "IsDefault", "IsDeleted", "IsVisibled", "MenuAppRoleType", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 183, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6220), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 61, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6220), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 184, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6221), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 62, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6221), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 185, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6222), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 62, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6223), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 186, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6223), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 62, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6224), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 187, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6224), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 63, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6225), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 188, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6226), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 63, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6227), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 189, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6227), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 63, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6228), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 190, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6229), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 64, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6229), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 191, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6230), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 64, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6230), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 192, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6231), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 64, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6232), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 193, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6232), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 65, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6233), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 194, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6233), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 65, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6234), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 195, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6235), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 65, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6235), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5740), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5740), new Guid("00000000-0000-0000-0000-000000000000"), "Tổng quan", 0 },
                    { 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5742), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5742), new Guid("00000000-0000-0000-0000-000000000000"), "Dashboard", 0 },
                    { 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5743), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5743), new Guid("00000000-0000-0000-0000-000000000000"), "Tổng quan", 0 },
                    { 4, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5744), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5745), new Guid("00000000-0000-0000-0000-000000000000"), "Summary", 0 },
                    { 5, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5746), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 3, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5746), new Guid("00000000-0000-0000-0000-000000000000"), "Đơn hàng", 0 },
                    { 6, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5747), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 3, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5747), new Guid("00000000-0000-0000-0000-000000000000"), "Orders", 0 },
                    { 7, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5748), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 4, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5749), new Guid("00000000-0000-0000-0000-000000000000"), "Hàng hóa & Dịch vụ", 0 },
                    { 8, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5749), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 4, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5750), new Guid("00000000-0000-0000-0000-000000000000"), "Products & Services", 0 },
                    { 9, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5752), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 5, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5752), new Guid("00000000-0000-0000-0000-000000000000"), "Hàng hóa/Dịch vụ", 0 },
                    { 10, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5753), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 5, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5753), new Guid("00000000-0000-0000-0000-000000000000"), "Products/Services", 0 },
                    { 11, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5754), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 6, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5755), new Guid("00000000-0000-0000-0000-000000000000"), "Nhập hàng", 0 },
                    { 12, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5755), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 6, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5756), new Guid("00000000-0000-0000-0000-000000000000"), "Stock in", 0 },
                    { 13, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5757), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 7, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5757), new Guid("00000000-0000-0000-0000-000000000000"), "Kho hàng", 0 },
                    { 14, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5758), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 7, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5758), new Guid("00000000-0000-0000-0000-000000000000"), "Warehouses", 0 },
                    { 15, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5760), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 8, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5761), new Guid("00000000-0000-0000-0000-000000000000"), "Khách hàng", 0 },
                    { 16, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5762), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 8, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5762), new Guid("00000000-0000-0000-0000-000000000000"), "Customers", 0 },
                    { 17, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5763), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 9, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5763), new Guid("00000000-0000-0000-0000-000000000000"), "Khách hàng", 0 },
                    { 18, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5764), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 9, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5765), new Guid("00000000-0000-0000-0000-000000000000"), "Customers", 0 },
                    { 19, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5765), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 10, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5766), new Guid("00000000-0000-0000-0000-000000000000"), "Nhà cung cấp", 0 },
                    { 20, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5770), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 10, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5771), new Guid("00000000-0000-0000-0000-000000000000"), "Suppliers", 0 },
                    { 21, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5772), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 11, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5773), new Guid("00000000-0000-0000-0000-000000000000"), "Nhóm khách hàng", 0 },
                    { 22, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5773), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 11, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5774), new Guid("00000000-0000-0000-0000-000000000000"), "Customer types", 0 },
                    { 23, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5775), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 12, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5775), new Guid("00000000-0000-0000-0000-000000000000"), "Tiền bạc", 0 },
                    { 24, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5776), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 12, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5776), new Guid("00000000-0000-0000-0000-000000000000"), "Receipts & payments", 0 },
                    { 25, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5777), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 13, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5778), new Guid("00000000-0000-0000-0000-000000000000"), "Tổng quan", 0 },
                    { 26, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5779), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 13, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5779), new Guid("00000000-0000-0000-0000-000000000000"), "Summary", 0 },
                    { 27, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5780), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 14, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5780), new Guid("00000000-0000-0000-0000-000000000000"), "Thu", 0 },
                    { 28, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5782), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 14, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5782), new Guid("00000000-0000-0000-0000-000000000000"), "Receipts", 0 },
                    { 29, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5783), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 15, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5783), new Guid("00000000-0000-0000-0000-000000000000"), "Chi", 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 30, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5784), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 15, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5785), new Guid("00000000-0000-0000-0000-000000000000"), "Payments", 0 },
                    { 31, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5786), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 16, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5786), new Guid("00000000-0000-0000-0000-000000000000"), "Sổ quỹ", 0 },
                    { 32, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5787), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 16, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5788), new Guid("00000000-0000-0000-0000-000000000000"), "Cash book", 0 },
                    { 33, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5788), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 17, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5789), new Guid("00000000-0000-0000-0000-000000000000"), "Báo cáo", 0 },
                    { 34, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5791), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 17, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5791), new Guid("00000000-0000-0000-0000-000000000000"), "Reports", 0 },
                    { 35, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5792), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 18, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5792), new Guid("00000000-0000-0000-0000-000000000000"), "Doanh số", 0 },
                    { 36, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5793), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 18, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5794), new Guid("00000000-0000-0000-0000-000000000000"), "Sales", 0 },
                    { 37, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5795), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 19, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5795), new Guid("00000000-0000-0000-0000-000000000000"), "Hàng hóa & Dịch vụ", 0 },
                    { 38, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5796), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 19, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5796), new Guid("00000000-0000-0000-0000-000000000000"), "Products & Services", 0 },
                    { 39, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5797), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 20, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5798), new Guid("00000000-0000-0000-0000-000000000000"), "Tồn kho", 0 },
                    { 40, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5798), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 20, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5799), new Guid("00000000-0000-0000-0000-000000000000"), "Stock", 0 },
                    { 41, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5800), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 21, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5800), new Guid("00000000-0000-0000-0000-000000000000"), "Lợi nhuận", 0 },
                    { 42, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5801), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 21, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5801), new Guid("00000000-0000-0000-0000-000000000000"), "Profit", 0 },
                    { 43, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5802), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 22, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5803), new Guid("00000000-0000-0000-0000-000000000000"), "Lãi lỗ", 0 },
                    { 44, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5804), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 22, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5805), new Guid("00000000-0000-0000-0000-000000000000"), "Profit & Loss", 0 },
                    { 45, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5806), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 23, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5806), new Guid("00000000-0000-0000-0000-000000000000"), "Báo cáo tháng", 0 },
                    { 46, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5807), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 23, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5807), new Guid("00000000-0000-0000-0000-000000000000"), "Monthly report", 0 },
                    { 47, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5808), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 24, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5809), new Guid("00000000-0000-0000-0000-000000000000"), "Danh mục", 0 },
                    { 48, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5810), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 24, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5810), new Guid("00000000-0000-0000-0000-000000000000"), "Directories", 0 },
                    { 49, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5811), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 25, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5812), new Guid("00000000-0000-0000-0000-000000000000"), "Nhóm hàng hóa", 0 },
                    { 50, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5813), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 25, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5814), new Guid("00000000-0000-0000-0000-000000000000"), "Product types", 0 },
                    { 51, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5815), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 26, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5815), new Guid("00000000-0000-0000-0000-000000000000"), "Đơn vị tính", 0 },
                    { 52, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5816), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 26, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5816), new Guid("00000000-0000-0000-0000-000000000000"), "Units", 0 },
                    { 53, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5817), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 27, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5818), new Guid("00000000-0000-0000-0000-000000000000"), "Bán hàng Online", 0 },
                    { 54, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5819), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 27, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5819), new Guid("00000000-0000-0000-0000-000000000000"), "Sale Online", 0 },
                    { 55, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5820), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 28, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5821), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên", 0 },
                    { 56, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5821), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 28, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5822), new Guid("00000000-0000-0000-0000-000000000000"), "Staff", 0 },
                    { 57, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5823), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 29, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5823), new Guid("00000000-0000-0000-0000-000000000000"), "Bảng lương", 0 },
                    { 58, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5825), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 29, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5825), new Guid("00000000-0000-0000-0000-000000000000"), "Payroll", 0 },
                    { 59, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5826), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 30, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5826), new Guid("00000000-0000-0000-0000-000000000000"), "Cài đặt", 0 },
                    { 60, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5827), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 30, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5828), new Guid("00000000-0000-0000-0000-000000000000"), "Setting", 0 },
                    { 61, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5828), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 31, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5829), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên", 0 },
                    { 62, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5830), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 31, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5831), new Guid("00000000-0000-0000-0000-000000000000"), "Staffs", 0 },
                    { 63, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5832), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 32, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5832), new Guid("00000000-0000-0000-0000-000000000000"), "Phân quyền", 0 },
                    { 64, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5833), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 32, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5834), new Guid("00000000-0000-0000-0000-000000000000"), "Roles", 0 },
                    { 65, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5834), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 33, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5836), new Guid("00000000-0000-0000-0000-000000000000"), "Cửa hàng", 0 },
                    { 66, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5837), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 33, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5837), new Guid("00000000-0000-0000-0000-000000000000"), "Stores", 0 },
                    { 67, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5838), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 34, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5838), new Guid("00000000-0000-0000-0000-000000000000"), "Mẫu in", 0 },
                    { 68, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5839), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 34, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5840), new Guid("00000000-0000-0000-0000-000000000000"), "Document templates", 0 },
                    { 69, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5841), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 35, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5842), new Guid("00000000-0000-0000-0000-000000000000"), "Danh mục hệ thống", 0 },
                    { 70, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5842), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 35, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5843), new Guid("00000000-0000-0000-0000-000000000000"), "System directories", 0 },
                    { 71, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5844), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 36, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5844), new Guid("00000000-0000-0000-0000-000000000000"), "Menu", 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 72, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5845), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 36, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5845), new Guid("00000000-0000-0000-0000-000000000000"), "Menu", 0 },
                    { 73, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5846), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 37, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5846), new Guid("00000000-0000-0000-0000-000000000000"), "Loại mẫu in", 0 },
                    { 74, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5847), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 37, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5848), new Guid("00000000-0000-0000-0000-000000000000"), "Document printing template type", 0 },
                    { 75, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5848), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 38, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5849), new Guid("00000000-0000-0000-0000-000000000000"), "Website", 0 },
                    { 76, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5850), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 38, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5851), new Guid("00000000-0000-0000-0000-000000000000"), "Website", 0 },
                    { 77, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5852), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 39, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5852), new Guid("00000000-0000-0000-0000-000000000000"), "Bài viết", 0 },
                    { 78, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5853), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 39, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5854), new Guid("00000000-0000-0000-0000-000000000000"), "Post", 0 },
                    { 79, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5855), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 40, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5855), new Guid("00000000-0000-0000-0000-000000000000"), "Chuyên mục", 0 },
                    { 80, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5856), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 40, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5857), new Guid("00000000-0000-0000-0000-000000000000"), "Categories", 0 },
                    { 81, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5858), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 41, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5858), new Guid("00000000-0000-0000-0000-000000000000"), "Slider", 0 },
                    { 82, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5859), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 41, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5860), new Guid("00000000-0000-0000-0000-000000000000"), "Slider", 0 },
                    { 83, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5861), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 42, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5862), new Guid("00000000-0000-0000-0000-000000000000"), "Nhà sản xuất", 0 },
                    { 84, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5866), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 42, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5867), new Guid("00000000-0000-0000-0000-000000000000"), "Manufacturer", 0 },
                    { 85, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5868), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 43, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5868), new Guid("00000000-0000-0000-0000-000000000000"), "Thuộc tính sản phẩm", 0 },
                    { 86, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5869), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 43, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5869), new Guid("00000000-0000-0000-0000-000000000000"), "Attribute", 0 },
                    { 87, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5870), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 44, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5871), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái", 0 },
                    { 88, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5872), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 44, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5872), new Guid("00000000-0000-0000-0000-000000000000"), "Status", 0 },
                    { 89, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5873), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 45, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5873), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái người sử dụng", 0 },
                    { 90, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5874), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 45, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5874), new Guid("00000000-0000-0000-0000-000000000000"), "User status", 0 },
                    { 91, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5875), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 46, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5875), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái đơn hàng", 0 },
                    { 92, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5876), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 46, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5877), new Guid("00000000-0000-0000-0000-000000000000"), "Order status", 0 },
                    { 93, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5878), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 47, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5878), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái phiếu kế toán", 0 },
                    { 94, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5879), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 47, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5879), new Guid("00000000-0000-0000-0000-000000000000"), "Phiếu kế toán status", 0 },
                    { 95, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5880), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 48, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5881), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái bài viết", 0 },
                    { 96, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5881), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 48, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5882), new Guid("00000000-0000-0000-0000-000000000000"), "Post status", 0 },
                    { 97, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5883), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 49, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5883), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái loại bài viết", 0 },
                    { 98, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5884), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 49, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5884), new Guid("00000000-0000-0000-0000-000000000000"), "Post type status", 0 },
                    { 99, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5885), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 50, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5886), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái slide", 0 },
                    { 100, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5886), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 50, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5887), new Guid("00000000-0000-0000-0000-000000000000"), "Slide status", 0 },
                    { 101, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5888), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 51, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5888), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái cửa hàng", 0 },
                    { 102, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5889), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 51, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5889), new Guid("00000000-0000-0000-0000-000000000000"), "Store status", 0 },
                    { 103, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5890), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 52, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5890), new Guid("00000000-0000-0000-0000-000000000000"), "Giá trị thuộc tính", 0 },
                    { 104, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5892), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 52, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5892), new Guid("00000000-0000-0000-0000-000000000000"), "Attribute value", 0 },
                    { 105, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5893), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 53, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5893), new Guid("00000000-0000-0000-0000-000000000000"), "Khổ giấy", 0 },
                    { 106, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5894), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 53, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5894), new Guid("00000000-0000-0000-0000-000000000000"), "Paper size", 0 },
                    { 107, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5895), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 54, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5896), new Guid("00000000-0000-0000-0000-000000000000"), "Loại người sử dụng", 0 },
                    { 108, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5897), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 54, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5897), new Guid("00000000-0000-0000-0000-000000000000"), "App user type", 0 },
                    { 109, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5898), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 55, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5898), new Guid("00000000-0000-0000-0000-000000000000"), "Bán hàng", 0 },
                    { 110, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5899), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 55, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5899), new Guid("00000000-0000-0000-0000-000000000000"), "Sales", 0 },
                    { 111, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5900), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 56, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5901), new Guid("00000000-0000-0000-0000-000000000000"), "Chương trình khuyến mãi", 0 },
                    { 112, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5901), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 56, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5902), new Guid("00000000-0000-0000-0000-000000000000"), "Sales Promotion", 0 },
                    { 113, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5903), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 57, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5903), new Guid("00000000-0000-0000-0000-000000000000"), "Hoa hồng - Giảm giá", 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 114, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5904), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 57, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5904), new Guid("00000000-0000-0000-0000-000000000000"), "Commission - Discount", 0 },
                    { 115, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5905), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 58, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5905), new Guid("00000000-0000-0000-0000-000000000000"), "Lương căn bản", 0 },
                    { 116, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5907), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 58, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5907), new Guid("00000000-0000-0000-0000-000000000000"), "Basic salary", 0 },
                    { 117, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5908), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 59, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5909), new Guid("00000000-0000-0000-0000-000000000000"), "Menu", 0 },
                    { 118, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5909), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 59, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5910), new Guid("00000000-0000-0000-0000-000000000000"), "Menu", 0 },
                    { 119, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5911), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 60, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5912), new Guid("00000000-0000-0000-0000-000000000000"), "Đặt lịch", 0 },
                    { 120, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5913), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 60, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5913), new Guid("00000000-0000-0000-0000-000000000000"), "Booking", 0 },
                    { 121, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5914), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 61, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5915), new Guid("00000000-0000-0000-0000-000000000000"), "Liên hệ", 0 },
                    { 122, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5916), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 61, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5916), new Guid("00000000-0000-0000-0000-000000000000"), "Contact", 0 },
                    { 123, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5917), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 62, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5917), new Guid("00000000-0000-0000-0000-000000000000"), "Thông tin liên hệ", 0 },
                    { 124, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5918), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 62, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5918), new Guid("00000000-0000-0000-0000-000000000000"), "Contact information", 0 },
                    { 125, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5919), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 63, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5920), new Guid("00000000-0000-0000-0000-000000000000"), "Newsletter", 0 },
                    { 126, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5920), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 63, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5921), new Guid("00000000-0000-0000-0000-000000000000"), "Newsletter", 0 },
                    { 127, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5922), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 64, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5923), new Guid("00000000-0000-0000-0000-000000000000"), "Testimonial", 0 },
                    { 128, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5923), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 64, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5924), new Guid("00000000-0000-0000-0000-000000000000"), "Testimonial", 0 },
                    { 129, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5925), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 65, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5925), new Guid("00000000-0000-0000-0000-000000000000"), "In mã QR", 0 },
                    { 130, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5926), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 65, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5926), new Guid("00000000-0000-0000-0000-000000000000"), "Print QR code", 0 }
                });

            migrationBuilder.InsertData(
                table: "OrderStatusTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "OrderStatusId", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(474), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(474), new Guid("00000000-0000-0000-0000-000000000000"), "InProgress", 1, 0 },
                    { 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(475), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(476), new Guid("00000000-0000-0000-0000-000000000000"), "InProgress", 1, 0 },
                    { 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(477), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(477), new Guid("00000000-0000-0000-0000-000000000000"), "Confirmed", 2, 0 },
                    { 4, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(478), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(478), new Guid("00000000-0000-0000-0000-000000000000"), "Confirmed", 2, 0 },
                    { 5, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(479), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(480), new Guid("00000000-0000-0000-0000-000000000000"), "Shipping", 3, 0 },
                    { 6, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(481), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(481), new Guid("00000000-0000-0000-0000-000000000000"), "Shipping", 3, 0 },
                    { 7, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(482), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(482), new Guid("00000000-0000-0000-0000-000000000000"), "Success", 4, 0 },
                    { 8, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(483), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(483), new Guid("00000000-0000-0000-0000-000000000000"), "Success", 4, 0 },
                    { 9, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(485), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(485), new Guid("00000000-0000-0000-0000-000000000000"), "Canceled", 5, 0 },
                    { 10, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(486), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(487), new Guid("00000000-0000-0000-0000-000000000000"), "Canceled", 5, 0 }
                });

            migrationBuilder.InsertData(
                table: "PhieuKeToanStatusTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "PhieuKeToanStatusId", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(802), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(803), new Guid("00000000-0000-0000-0000-000000000000"), "Chưa kích hoạt", 1, 0 },
                    { 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(804), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(805), new Guid("00000000-0000-0000-0000-000000000000"), "InActive", 1, 0 },
                    { 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(806), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(806), new Guid("00000000-0000-0000-0000-000000000000"), "Đang hoạt động", 2, 0 },
                    { 4, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(807), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(808), new Guid("00000000-0000-0000-0000-000000000000"), "Active", 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "PostStatusTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "PostStatusId", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(523), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(523), new Guid("00000000-0000-0000-0000-000000000000"), "Chưa kích hoạt", 1, 0 },
                    { 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(524), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(525), new Guid("00000000-0000-0000-0000-000000000000"), "InActive", 1, 0 },
                    { 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(526), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(526), new Guid("00000000-0000-0000-0000-000000000000"), "Đang hoạt động", 2, 0 },
                    { 4, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(527), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(528), new Guid("00000000-0000-0000-0000-000000000000"), "Active", 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "PostTypeTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "PostTypeId", "SeoAlias", "SeoDescription", "SeoTitle", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(562), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(562), new Guid("00000000-0000-0000-0000-000000000000"), "Công nghệ thông tin", 1, "cong-nghe-thong-tin", null, null, 0 },
                    { 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(564), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(564), new Guid("00000000-0000-0000-0000-000000000000"), "It", 1, "it", null, null, 0 },
                    { 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(565), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(566), new Guid("00000000-0000-0000-0000-000000000000"), "Công nghệ sinh học", 2, "cong-nghe-sinh-hoc", null, null, 0 },
                    { 4, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(566), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(567), new Guid("00000000-0000-0000-0000-000000000000"), "Biotechnology", 2, "biotechnology", null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductTypeStatusTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "ProductTypeStatusId", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(599), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(599), new Guid("00000000-0000-0000-0000-000000000000"), "Chưa kích hoạt", 1, 0 },
                    { 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(600), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(601), new Guid("00000000-0000-0000-0000-000000000000"), "InActive", 1, 0 },
                    { 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(602), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(602), new Guid("00000000-0000-0000-0000-000000000000"), "Đang hoạt động", 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductTypeStatusTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "ProductTypeStatusId", "SortOrder" },
                values: new object[] { 4, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(603), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(603), new Guid("00000000-0000-0000-0000-000000000000"), "Active", 2, 0 });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsShowOnHome", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "ParentId", "ProductTypeStatusId", "SortOrder", "StoreId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(895), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(895), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 2, 1, null },
                    { 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(896), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, true, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(897), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 2, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AllowSellWhenNotEnough", "Code", "CreatedDate", "CreatedUserId", "Description", "Image", "InventoryWarning", "IsDefault", "IsDeleted", "IsFeatured", "IsHasSKU", "IsPOS", "IsVisibled", "IsWeb", "ManufactuerId", "ModifiedDate", "ModifiedUserId", "Name", "OriginalPrice", "Price", "ProductTitle", "ShortDescription", "SortOrder", "Url" },
                values: new object[,]
                {
                    { 1, true, "SP0000001", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7185), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 0, false, false, null, true, true, true, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7182), new Guid("00000000-0000-0000-0000-000000000000"), null, 100000m, 200000m, "Hàng hóa 1", null, 0, "hang-hoa-1" },
                    { 2, true, "SP0000002", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7197), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 0, false, false, null, true, true, true, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7196), new Guid("00000000-0000-0000-0000-000000000000"), null, 3000000m, 6500000m, "Dịch vụ 2", null, 0, "dich-vu-2" }
                });

            migrationBuilder.InsertData(
                table: "PromotionTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "PromotionId", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7136), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7136), new Guid("00000000-0000-0000-0000-000000000000"), "Ưu đãi nhân viên", 1, 0 },
                    { 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7137), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7138), new Guid("00000000-0000-0000-0000-000000000000"), "N/A", 1, 0 },
                    { 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7138), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7139), new Guid("00000000-0000-0000-0000-000000000000"), "Chương trình trung thu", 2, 0 },
                    { 4, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7140), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7140), new Guid("00000000-0000-0000-0000-000000000000"), "N/A", 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "Promotion_CommissionDiscounts",
                columns: new[] { "Id", "Code", "CommissionDiscountId", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "PromotionId", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7159), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7159), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, 0 },
                    { 2, null, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7160), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7161), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "SlideStatusTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SlideStatusId", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(872), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(873), new Guid("00000000-0000-0000-0000-000000000000"), "Chưa kích hoạt", 1, 0 },
                    { 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(877), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(878), new Guid("00000000-0000-0000-0000-000000000000"), "InActive", 1, 0 },
                    { 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(879), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(880), new Guid("00000000-0000-0000-0000-000000000000"), "Đang hoạt động", 2, 0 },
                    { 4, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(881), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(881), new Guid("00000000-0000-0000-0000-000000000000"), "Active", 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "SlideTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SlideId", "SortOrder" },
                values: new object[,]
                {
                    { 1, "Nông nghiệp thông minh", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5390), new Guid("00000000-0000-0000-0000-000000000000"), "<p>Nền nông nghiệp ứng dụng công nghệ cao(cơ giới hóa, tự động hóa…)</p><p>Công nghệ sản xuất, bảo quản sản phẩm an toàn (hữu cơ, theo GAP…)</p><p>Công nghệ quản lý, nhận diện sản phẩm theo chuỗi giá trị… gắn với hệ thống trí tuệ nhân tạo (công nghệ thông tin).</p>", false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5390), new Guid("00000000-0000-0000-0000-000000000000"), "Smart farming", 1, 0 },
                    { 2, "Smart farm", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5394), new Guid("00000000-0000-0000-0000-000000000000"), "<p>Nền nông nghiệp ứng dụng công nghệ cao(cơ giới hóa, tự động hóa…)</p><p>Công nghệ sản xuất, bảo quản sản phẩm an toàn (hữu cơ, theo GAP…)</p><p>Công nghệ quản lý, nhận diện sản phẩm theo chuỗi giá trị… gắn với hệ thống trí tuệ nhân tạo (công nghệ thông tin).</p>", false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5394), new Guid("00000000-0000-0000-0000-000000000000"), "Smart farming", 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "Image", "IsDefault", "IsDeleted", "IsVisibled", "Link", "ModifiedDate", "ModifiedUserId", "Name", "SlideStatusId", "SortOrder" },
                values: new object[,]
                {
                    { 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5337), new Guid("00000000-0000-0000-0000-000000000000"), null, "biotechnology.jpg", false, false, true, "#", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5338), new Guid("00000000-0000-0000-0000-000000000000"), null, 2, 2 },
                    { 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5339), new Guid("00000000-0000-0000-0000-000000000000"), null, "information_technology.png", false, false, true, "#", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5339), new Guid("00000000-0000-0000-0000-000000000000"), null, 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "StoreStatusTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder", "StoreStatusId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(635), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(636), new Guid("00000000-0000-0000-0000-000000000000"), "Đang hoạt động", 0, 1 },
                    { 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(637), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(637), new Guid("00000000-0000-0000-0000-000000000000"), "Active", 0, 1 },
                    { 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(639), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(639), new Guid("00000000-0000-0000-0000-000000000000"), "Đang sữa chửa", 0, 2 },
                    { 4, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(640), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(640), new Guid("00000000-0000-0000-0000-000000000000"), "Repair", 0, 2 },
                    { 5, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(641), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(642), new Guid("00000000-0000-0000-0000-000000000000"), "Tạm thời đóng cửa", 0, 3 },
                    { 6, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(643), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(643), new Guid("00000000-0000-0000-0000-000000000000"), "TemporarilyClosed", 0, 3 },
                    { 7, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(644), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(644), new Guid("00000000-0000-0000-0000-000000000000"), "Đã đóng cửa", 0, 4 },
                    { 8, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(645), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(646), new Guid("00000000-0000-0000-0000-000000000000"), "Closed", 0, 4 }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "Address", "Code", "CreatedDate", "CreatedUserId", "Description", "Email", "IsDefault", "IsDeleted", "IsVisibled", "Logo", "ModifiedDate", "ModifiedUserId", "Name", "Phone", "SortOrder", "StoreStatusId", "Taxcode", "Website" },
                values: new object[,]
                {
                    { 1, null, "CH001", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5438), new Guid("00000000-0000-0000-0000-000000000000"), null, "abc@gmail.com", false, false, true, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5439), new Guid("00000000-0000-0000-0000-000000000000"), null, "0123456789", 0, 1, null, null },
                    { 2, null, "CH002", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5441), new Guid("00000000-0000-0000-0000-000000000000"), null, "abc@gmail.com", false, false, true, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5441), new Guid("00000000-0000-0000-0000-000000000000"), null, "0123456789", 0, 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "WebsiteMenuTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder", "WebsiteMenuId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6775), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6776), new Guid("00000000-0000-0000-0000-000000000000"), "About us", 0, 1 },
                    { 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6777), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6777), new Guid("00000000-0000-0000-0000-000000000000"), "About us", 0, 1 },
                    { 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6778), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6779), new Guid("00000000-0000-0000-0000-000000000000"), "Pets", 0, 2 },
                    { 4, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6780), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6781), new Guid("00000000-0000-0000-0000-000000000000"), "Pets", 0, 2 },
                    { 5, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6781), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6782), new Guid("00000000-0000-0000-0000-000000000000"), "Shop", 0, 3 },
                    { 6, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6783), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6783), new Guid("00000000-0000-0000-0000-000000000000"), "Shop", 0, 3 },
                    { 7, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6784), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6784), new Guid("00000000-0000-0000-0000-000000000000"), "Services", 0, 4 },
                    { 8, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6785), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6786), new Guid("00000000-0000-0000-0000-000000000000"), "Services", 0, 4 },
                    { 9, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6786), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6787), new Guid("00000000-0000-0000-0000-000000000000"), "Blogs", 0, 5 },
                    { 10, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6788), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6788), new Guid("00000000-0000-0000-0000-000000000000"), "Blogs", 0, 5 },
                    { 11, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6789), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6789), new Guid("00000000-0000-0000-0000-000000000000"), "Contact", 0, 6 },
                    { 12, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6790), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6790), new Guid("00000000-0000-0000-0000-000000000000"), "Contact", 0, 6 },
                    { 13, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6791), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6792), new Guid("00000000-0000-0000-0000-000000000000"), "Pet Mart", 0, 7 }
                });

            migrationBuilder.InsertData(
                table: "WebsiteMenuTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder", "WebsiteMenuId" },
                values: new object[,]
                {
                    { 14, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6792), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6793), new Guid("00000000-0000-0000-0000-000000000000"), "Pet Mart", 0, 7 },
                    { 15, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6794), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6794), new Guid("00000000-0000-0000-0000-000000000000"), "Chino Vet", 0, 8 },
                    { 16, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6795), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6795), new Guid("00000000-0000-0000-0000-000000000000"), "Chino Vet", 0, 8 },
                    { 17, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6796), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6797), new Guid("00000000-0000-0000-0000-000000000000"), "Chino Salon", 0, 9 },
                    { 18, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6798), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6798), new Guid("00000000-0000-0000-0000-000000000000"), "Chino Salon", 0, 9 },
                    { 19, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6799), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6799), new Guid("00000000-0000-0000-0000-000000000000"), "Chino Hotel", 0, 10 },
                    { 20, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6800), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6800), new Guid("00000000-0000-0000-0000-000000000000"), "Chino Hotel", 0, 10 },
                    { 21, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6801), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6802), new Guid("00000000-0000-0000-0000-000000000000"), "Training", 0, 11 },
                    { 22, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6802), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6803), new Guid("00000000-0000-0000-0000-000000000000"), "Training", 0, 11 }
                });

            migrationBuilder.InsertData(
                table: "AppUser_AppUserTypes",
                columns: new[] { "Id", "AppUserId", "AppUserTypeId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6711), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6711), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, new Guid("0227bc9a-ed2f-4617-e96b-08d9704a3494"), 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6712), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6713), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 3, new Guid("0227bc9a-ed2f-4617-e96b-08d9704a3422"), 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6717), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6718), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "AppUser_BasicSalarys",
                columns: new[] { "Id", "AppUserId", "BasicSalaryId", "Code", "CreatedDate", "CreatedUserId", "Description", "FromDate", "IsApply", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder", "ToDate" },
                values: new object[] { 2, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7019), new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7019), new Guid("00000000-0000-0000-0000-000000000000"), null, 0, null });

            migrationBuilder.InsertData(
                table: "AppUser_CommissionDiscounts",
                columns: new[] { "Id", "AppUserId", "Code", "CommissionDiscountId", "CreatedDate", "CreatedUserId", "Description", "FromDate", "IsApply", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder", "ToDate" },
                values: new object[] { 2, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), null, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7092), new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7092), new Guid("00000000-0000-0000-0000-000000000000"), null, 0, null });

            migrationBuilder.InsertData(
                table: "AttributeValueTranslations",
                columns: new[] { "Id", "AttributeValueId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SeoAlias", "SeoDescription", "SeoTitle", "SortOrder" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6488), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6489), new Guid("00000000-0000-0000-0000-000000000000"), "1kg", null, null, null, 0 },
                    { 2, 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6493), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6494), new Guid("00000000-0000-0000-0000-000000000000"), "N/A", null, null, null, 0 },
                    { 3, 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6495), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6496), new Guid("00000000-0000-0000-0000-000000000000"), "2kg", null, null, null, 0 },
                    { 4, 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6497), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6498), new Guid("00000000-0000-0000-0000-000000000000"), "N/A", null, null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "PhieuKeToans",
                columns: new[] { "Id", "AppUserId", "Code", "CreatedDate", "CreatedUserId", "CustomerId", "Date", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LoaiPhieuKeToan", "ModifiedDate", "ModifiedUserId", "MoneyAffterTax", "MoneyBeforeTax", "Name", "Note", "PaymentMethod", "PercentDiscount", "PhieuKeToanStatusId", "SaleStaffId", "SortOrder", "StoreId", "TotalBuyingPrice", "TotalCommission", "TotalDebt", "TotalDiscount", "TotalMoney", "TotalPaid" },
                values: new object[,]
                {
                    { 1, null, "PX2021/1", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7305), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("0227bc9a-ed2f-4617-e96b-08d9704a3494"), new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7322), null, false, false, true, 3, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7305), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0.0, 0.0, null, null, 0, 0.0, null, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, 1, 0.0, 0.0, 0.0, 0.0, 1050000.0, 1050000.0 },
                    { 2, null, "PX2021/2", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7325), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("0227bc9a-ed2f-4617-e96b-08d9704a3494"), new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7328), null, false, false, true, 3, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7326), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0.0, 0.0, null, null, 0, 0.0, null, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, 1, 0.0, 0.0, 0.0, 0.0, 6500000.0, 6500000.0 }
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
                    { 1, 1050000.0, "SP0000001", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7253), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7254), new Guid("00000000-0000-0000-0000-000000000000"), "Hàng hóa 1", 650000.0, 1, 10, 0 },
                    { 2, 1050000.0, "SP0000002", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7255), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7256), new Guid("00000000-0000-0000-0000-000000000000"), "Dịch vụ_1kg", 650000.0, 2, 10, 0 },
                    { 3, 1050000.0, "SP0000003", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7260), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7261), new Guid("00000000-0000-0000-0000-000000000000"), "Dịch vụ_2kg", 650000.0, 2, 10, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "Details", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "ProductId", "SeoAlias", "SeoDescription", "SeoTitle", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7215), new Guid("00000000-0000-0000-0000-000000000000"), "Hàng hóa 1", "Hàng hóa 1", false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7215), new Guid("00000000-0000-0000-0000-000000000000"), "Hàng hóa 1", 1, "hang-hoa-1", "Hàng hóa 1", "Hàng hóa 1", 0 },
                    { 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7217), new Guid("00000000-0000-0000-0000-000000000000"), "Product 1", "Product 1", false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7217), new Guid("00000000-0000-0000-0000-000000000000"), "Product 1", 1, "product-1", "Product 1", "Product 1", 0 },
                    { 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7219), new Guid("00000000-0000-0000-0000-000000000000"), "Dịch vụ 2", "Dịch vụ 2", false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7219), new Guid("00000000-0000-0000-0000-000000000000"), "Dịch vụ 2", 2, "dich-vu-2", "Dịch vụ 2", "Dịch vụ 2", 0 },
                    { 4, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7221), new Guid("00000000-0000-0000-0000-000000000000"), "Service 2", "Service 2", false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7221), new Guid("00000000-0000-0000-0000-000000000000"), "Service 2", 2, "service-2", "Service 2", "Service 2", 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductTypeTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "ProductTypeId", "SeoAlias", "SeoDescription", "SeoTitle", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(909), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(909), new Guid("00000000-0000-0000-0000-000000000000"), "Hàng hóa", 1, "hang-hoa", "Hàng hóa bán được", "Hàng hóa bán được", 0 },
                    { 2, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(911), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(911), new Guid("00000000-0000-0000-0000-000000000000"), "Product", 1, "product", "product", "product", 0 },
                    { 3, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(913), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(913), new Guid("00000000-0000-0000-0000-000000000000"), "Dịch vụ", 2, "dich-vu", "Dịch vụ", "Dịch vụ", 0 },
                    { 4, null, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(914), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 146, DateTimeKind.Local).AddTicks(914), new Guid("00000000-0000-0000-0000-000000000000"), "Service", 2, "service", "service", "service", 0 }
                });

            migrationBuilder.InsertData(
                table: "SlideTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SlideId", "SortOrder" },
                values: new object[,]
                {
                    { 3, "Công nghệ sinh học", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5396), new Guid("00000000-0000-0000-0000-000000000000"), "<p>Ứng dụng công nghệ sinh học trong sản xuất thuốc, thức ăn</p><p> Điều chế và sản xuất hóa chất công nghiệp; phát triển giống cây trồng, vật nuôi</p><p> Ứng dụng công nghệ di truyền, xét nghiệm trong y khoa </p><p> giải quyết các vấn đề môi trường…</p>", false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5396), new Guid("00000000-0000-0000-0000-000000000000"), "Biotechnology", 2, 0 },
                    { 4, "Công nghệ sinh học", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5398), new Guid("00000000-0000-0000-0000-000000000000"), "<p>Ứng dụng công nghệ sinh học trong sản xuất thuốc, thức ăn</p><p> Điều chế và sản xuất hóa chất công nghiệp; phát triển giống cây trồng, vật nuôi</p><p> Ứng dụng công nghệ di truyền, xét nghiệm trong y khoa </p><p> giải quyết các vấn đề môi trường…</p>", false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5398), new Guid("00000000-0000-0000-0000-000000000000"), "Biotechnology", 2, 0 },
                    { 5, "Công nghệ thông tin và truyền thông", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5400), new Guid("00000000-0000-0000-0000-000000000000"), "<p>ICT là sự kết hợp của công nghệ thông tin và công nghệ truyền thông</p><p> để tạo nên sự kết nối và chia sẻ thông tin với nhiều hình thức khác nhau </p><p> nhằm hỗ trợ và thúc đẩy năng lực sản xuất, kinh doanh Doanh nghiệp </p> ", false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5400), new Guid("00000000-0000-0000-0000-000000000000"), "IT", 3, 0 },
                    { 6, "Công nghệ thông tin và truyền thông", new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5401), new Guid("00000000-0000-0000-0000-000000000000"), "<p>ICT là sự kết hợp của công nghệ thông tin và công nghệ truyền thông</p><p> để tạo nên sự kết nối và chia sẻ thông tin với nhiều hình thức khác nhau </p><p> nhằm hỗ trợ và thúc đẩy năng lực sản xuất, kinh doanh Doanh nghiệp </p> ", false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5402), new Guid("00000000-0000-0000-0000-000000000000"), "IT", 3, 0 }
                });

            migrationBuilder.InsertData(
                table: "SoDuDauKySoQuys",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder", "StoreId", "Total", "Year" },
                values: new object[] { 1, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6637), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(6638), new Guid("00000000-0000-0000-0000-000000000000"), null, 0, 1, 2000000f, 0 });

            migrationBuilder.InsertData(
                table: "StoreTranslations",
                columns: new[] { "Id", "Address", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder", "StoreId" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5477), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5478), new Guid("00000000-0000-0000-0000-000000000000"), "Cửa hàng mặc định", 0, 1 },
                    { 2, null, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5479), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5479), new Guid("00000000-0000-0000-0000-000000000000"), "Default Store", 0, 1 },
                    { 3, null, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5480), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5481), new Guid("00000000-0000-0000-0000-000000000000"), "Cửa hàng 2", 0, 2 },
                    { 4, null, null, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5486), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(5496), new Guid("00000000-0000-0000-0000-000000000000"), "Store 2", 0, 2 }
                });

            migrationBuilder.InsertData(
                table: "PhieuKeToanChiTiets",
                columns: new[] { "Id", "BuyingPrice", "Code", "Commission", "CreatedDate", "CreatedUserId", "Description", "Discount", "ImportPrice", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "PhieuKeToanId", "Price", "ProductSKUId", "Qty", "SortOrder", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 1050000.0, null, 0.0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7346), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), null, 0.0, 0.0, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7346), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), null, 1, 1050000.0, 1, -1, 0, 1050000.0 },
                    { 2, 6500000.0, null, 0.0, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7350), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), null, 0.0, 0.0, false, false, true, new DateTime(2022, 1, 2, 12, 54, 50, 163, DateTimeKind.Local).AddTicks(7350), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), null, 2, 6500000.0, 2, -1, 0, 6500000.0 }
                });

            migrationBuilder.InsertData(
                table: "ProductSKU_AttributeValues",
                columns: new[] { "Id", "AttributeValueId", "ProductSKUId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 2, 3 }
                });

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
                name: "IX_AppUser_AppUserTypes_AppUserId",
                table: "AppUser_AppUserTypes",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_AppUserTypes_AppUserTypeId",
                table: "AppUser_AppUserTypes",
                column: "AppUserTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_BasicSalarys_AppUserId",
                table: "AppUser_BasicSalarys",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_BasicSalarys_BasicSalaryId",
                table: "AppUser_BasicSalarys",
                column: "BasicSalaryId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_CommissionDiscounts_AppUserId",
                table: "AppUser_CommissionDiscounts",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_CommissionDiscounts_CommissionDiscountId",
                table: "AppUser_CommissionDiscounts",
                column: "CommissionDiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_Promotions_AppUserId",
                table: "AppUser_Promotions",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_Promotions_PromotionId",
                table: "AppUser_Promotions",
                column: "PromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserFeedbacks_AppUserId",
                table: "AppUserFeedbacks",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserHelps_AppUserId",
                table: "AppUserHelps",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_AppUserStatusId",
                table: "AppUsers",
                column: "AppUserStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_CountryId",
                table: "AppUsers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_CustomerTypeId",
                table: "AppUsers",
                column: "CustomerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_GenderId",
                table: "AppUsers",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserStatusTranslations_AppUserStatusId",
                table: "AppUserStatusTranslations",
                column: "AppUserStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserStatusTranslations_LanguageId",
                table: "AppUserStatusTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserTypeTranslations_AppUserTypeId",
                table: "AppUserTypeTranslations",
                column: "AppUserTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserTypeTranslations_LanguageId",
                table: "AppUserTypeTranslations",
                column: "LanguageId");

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
                name: "IX_Carts_ProductId",
                table: "Carts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

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
                name: "IX_PhieuKeToanChiTiet_AppUsers_AppUserId",
                table: "PhieuKeToanChiTiet_AppUsers",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuKeToanChiTiet_AppUsers_PhieuKeToanChiTietId",
                table: "PhieuKeToanChiTiet_AppUsers",
                column: "PhieuKeToanChiTietId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuKeToanChiTiets_PhieuKeToanId",
                table: "PhieuKeToanChiTiets",
                column: "PhieuKeToanId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuKeToanChiTiets_ProductSKUId",
                table: "PhieuKeToanChiTiets",
                column: "ProductSKUId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuKeToans_AppUserId",
                table: "PhieuKeToans",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuKeToans_CustomerId",
                table: "PhieuKeToans",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuKeToans_PhieuKeToanStatusId",
                table: "PhieuKeToans",
                column: "PhieuKeToanStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuKeToans_SaleStaffId",
                table: "PhieuKeToans",
                column: "SaleStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuKeToans_StoreId",
                table: "PhieuKeToans",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuKeToanStatusTranslations_LanguageId",
                table: "PhieuKeToanStatusTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuKeToanStatusTranslations_PhieuKeToanStatusId",
                table: "PhieuKeToanStatusTranslations",
                column: "PhieuKeToanStatusId");

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
                name: "AppUser_AppUserTypes");

            migrationBuilder.DropTable(
                name: "AppUser_BasicSalarys");

            migrationBuilder.DropTable(
                name: "AppUser_CommissionDiscounts");

            migrationBuilder.DropTable(
                name: "AppUser_Promotions");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserFeedbacks");

            migrationBuilder.DropTable(
                name: "AppUserHelps");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserStatusTranslations");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "AppUserTypeTranslations");

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
                name: "PhieuKeToanChiTiet_AppUsers");

            migrationBuilder.DropTable(
                name: "PhieuKeToanStatusTranslations");

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
                name: "AppUserTypes");

            migrationBuilder.DropTable(
                name: "BasicSalarys");

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
                name: "PhieuKeToanChiTiets");

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
                name: "Units");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "WebsiteMenus");

            migrationBuilder.DropTable(
                name: "PhieuKeToans");

            migrationBuilder.DropTable(
                name: "ProductSKUs");

            migrationBuilder.DropTable(
                name: "PostStatuses");

            migrationBuilder.DropTable(
                name: "PostTypes");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropTable(
                name: "ProductTypeStatuses");

            migrationBuilder.DropTable(
                name: "SlideStatuses");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "PhieuKeToanStatuses");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "PostTypeStatuses");

            migrationBuilder.DropTable(
                name: "AppUserStatuses");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "CustomerTypes");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "StoreStatuses");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
