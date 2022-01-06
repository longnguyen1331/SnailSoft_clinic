using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SnaillApp.Data.Migrations
{
    public partial class updateDBRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Favicon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoogleScript = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookPixel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookChat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firebase_apiKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firebase_authDomain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firebase_projectId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firebase_storageBucket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firebase_messagingSenderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Clinics",
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
                    table.PrimaryKey("PK_Clinics", x => x.Id);
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
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ClinicID = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_AppUsers_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id");
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

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), "f7bf2e76-2103-4d36-8e45-f67068becc47", "Quản trị hệ thống", "admin", "admin" },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "f459237c-52ba-46c6-9a22-e9df42d66b2d", "Quản lý cửa hàng", "StoreManager", "StoreManager" },
                    { new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"), "72726dca-2684-4cf0-ab34-4a81b6f771d3", "Quản lý", "Manager", "manager" },
                    { new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"), "38e8620a-2fa3-401d-9e27-ae71fb01e347", "Nhân viên kho", "WarehouseStaff", "WarehouseStaff" },
                    { new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"), "cd1e7b23-9474-485a-a3cd-a48fabc99c9e", "Nhân viên thu ngân", "Cashier", "Cashier" },
                    { new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"), "427849ba-9233-439e-b54a-f0427a71165a", "Nhân viên bán hàng", "ShopAssistant", "ShopAssistant" },
                    { new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"), "d76fa393-1a81-438b-b0d7-997897c519a9", "Quản lý chi nhánh", "BranchManager", "BranchManager" }
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
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "Biography", "ClinicID", "Code", "ConcurrencyStamp", "CreatedDate", "CreatedUserId", "Dob", "Email", "EmailConfirmed", "FirstName", "GenderId", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedDate", "ModifiedUserId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Skills", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "09 Lê Hồng Phong", null, null, 0, "001", "b36d4a64-f83e-4680-9210-020b9b0519b7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Nguyễn", null, true, "Hồ Phi Long", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "admin@gmail.com", "admin@gmail.com", "AQAAAAEAACcQAAAAEF7+dhL9vHodlxX4oE6JHVhWOsHvX13RbLSQTpPTyiSID+WU9XybK0Tq2T3NSH1dWw==", null, "0915780794", false, "", null, false, false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "M", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1356), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1360), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, "F", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1362), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1363), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "vi", new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3668), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, true, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3677), new Guid("00000000-0000-0000-0000-000000000000"), "Tiếng Việt", 0 },
                    { 2, "en", new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3680), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3680), new Guid("00000000-0000-0000-0000-000000000000"), "English", 0 }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "ActionName", "Code", "ControllerName", "CreatedDate", "CreatedUserId", "Description", "Icon", "IsDefault", "IsDeleted", "IsVisibled", "Link", "MenuType", "ModifiedDate", "ModifiedUserId", "Name", "ParentId", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, "WebApp_TQ", null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1390), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><path d='M3,16 L5,16 C5.55228475,16 6,15.5522847 6,15 C6,14.4477153 5.55228475,14 5,14 L3,14 L3,12 L5,12 C5.55228475,12 6,11.5522847 6,11 C6,10.4477153 5.55228475,10 5,10 L3,10 L3,8 L5,8 C5.55228475,8 6,7.55228475 6,7 C6,6.44771525 5.55228475,6 5,6 L3,6 L3,4 C3,3.44771525 3.44771525,3 4,3 L10,3 C10.5522847,3 11,3.44771525 11,4 L11,19 C11,19.5522847 10.5522847,20 10,20 L4,20 C3.44771525,20 3,19.5522847 3,19 L3,16 Z' fill='#000000' opacity='0.3'></path>		<path d='M16,3 L19,3 C20.1045695,3 21,3.8954305 21,5 L21,15.2485298 C21,15.7329761 20.8241635,16.200956 20.5051534,16.565539 L17.8762883,19.5699562 C17.6944473,19.7777745 17.378566,19.7988332 17.1707477,19.6169922 C17.1540423,19.602375 17.1383289,19.5866616 17.1237117,19.5699562 L14.4948466,16.565539 C14.1758365,16.200956 14,15.7329761 14,15.2485298 L14,5 C14,3.8954305 14.8954305,3 16,3 Z' fill='#000000'></path>	</svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1391), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 1 },
                    { 2, "Index", "WebApp_TQ_TQ", "Summary", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1392), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Home/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1393), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, 1 },
                    { 3, "Index", "WebApp_TQ_O", "Order", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1396), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Order/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1396), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, 2 },
                    { 4, null, "WebApp_HHDV", null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1397), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' width='24' height='24' viewBox='0 0 24 24' fill='none'>	<path opacity='0.25' fill-rule='evenodd' clip-rule='evenodd' d='M11 4.25769C11 3.07501 9.9663 2.13515 8.84397 2.50814C4.86766 3.82961 2 7.57987 2 11.9999C2 13.6101 2.38057 15.1314 3.05667 16.4788C3.58731 17.5363 4.98303 17.6028 5.81966 16.7662L5.91302 16.6728C6.60358 15.9823 6.65613 14.9011 6.3341 13.9791C6.11766 13.3594 6 12.6934 6 11.9999C6 9.62064 7.38488 7.56483 9.39252 6.59458C10.2721 6.16952 11 5.36732 11 4.39046V4.25769ZM16.4787 20.9434C17.5362 20.4127 17.6027 19.017 16.7661 18.1804L16.6727 18.087C15.9822 17.3964 14.901 17.3439 13.979 17.6659C13.3594 17.8823 12.6934 17.9999 12 17.9999C11.3066 17.9999 10.6406 17.8823 10.021 17.6659C9.09899 17.3439 8.01784 17.3964 7.3273 18.087L7.23392 18.1804C6.39728 19.017 6.4638 20.4127 7.52133 20.9434C8.86866 21.6194 10.3899 21.9999 12 21.9999C13.6101 21.9999 15.1313 21.6194 16.4787 20.9434Z' fill='#12131A'></path>	<path fill-rule='evenodd' clip-rule='evenodd' d='M13 4.39046C13 5.36732 13.7279 6.16952 14.6075 6.59458C16.6151 7.56483 18 9.62064 18 11.9999C18 12.6934 17.8823 13.3594 17.6659 13.9791C17.3439 14.9011 17.3964 15.9823 18.087 16.6728L18.1803 16.7662C19.017 17.6028 20.4127 17.5363 20.9433 16.4788C21.6194 15.1314 22 13.6101 22 11.9999C22 7.57987 19.1323 3.82961 15.156 2.50814C14.0337 2.13515 13 3.07501 13 4.25769V4.39046Z' fill='#12131A'></path></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1398), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 2 },
                    { 5, "Index", "WebApp_HHDV_HHDV", "Product", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1399), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Product/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1399), new Guid("00000000-0000-0000-0000-000000000000"), null, 4, 1 },
                    { 6, "Index", "WebApp_HHDV_NH", "StockIn", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1400), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/StockIn/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1401), new Guid("00000000-0000-0000-0000-000000000000"), null, 4, 2 },
                    { 7, "Index", "WebApp_HHDV_W", "Warehouse", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1402), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Warehouse/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1402), new Guid("00000000-0000-0000-0000-000000000000"), null, 4, 3 },
                    { 8, null, "WebApp_KH", null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1403), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns = 'http://www.w3.org/2000/svg' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><path d = 'M18,14 C16.3431458,14 15,12.6568542 15,11 C15,9.34314575 16.3431458,8 18,8 C19.6568542,8 21,9.34314575 21,11 C21,12.6568542 19.6568542,14 18,14 Z M9,11 C6.790861,11 5,9.209139 5,7 C5,4.790861 6.790861,3 9,3 C11.209139,3 13,4.790861 13,7 C13,9.209139 11.209139,11 9,11 Z' fill='#000000' fill-rule='nonzero' opacity='0.3'></path><path d = 'M17.6011961,15.0006174 C21.0077043,15.0378534 23.7891749,16.7601418 23.9984937,20.4 C24.0069246,20.5466056 23.9984937,21 23.4559499,21 L19.6,21 C19.6,18.7490654 18.8562935,16.6718327 17.6011961,15.0006174 Z M0.00065168429,20.1992055 C0.388258525,15.4265159 4.26191235,13 8.98334134,13 C13.7712164,13 17.7048837,15.2931929 17.9979143,20.2 C18.0095879,20.3954741 17.9979143,21 17.2466999,21 C13.541124,21 8.03472472,21 0.727502227,21 C0.476712155,21 -0.0204617505,20.45918 0.00065168429,20.1992055 Z' fill='#000000' fill-rule='nonzero'></path></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1404), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 3 },
                    { 9, "Index", "WebApp_KH_KH", "Customer", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1405), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Customer/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1406), new Guid("00000000-0000-0000-0000-000000000000"), null, 8, 1 },
                    { 10, "Index", "WebApp_KH_NCC", "Supplier", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1407), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Supplier/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1408), new Guid("00000000-0000-0000-0000-000000000000"), null, 8, 2 },
                    { 11, "Index", "WebApp_KH_NKH", "CustomerType", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1409), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/CustomerType/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1409), new Guid("00000000-0000-0000-0000-000000000000"), null, 8, 3 },
                    { 12, null, "WebApp_TB", null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1410), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><g stroke='none' stroke-width='1' fill='none' fill-rule='evenodd'>	<rect x='0' y='0' width='24' height='24'></rect>	<rect fill='#000000' opacity='0.3' x='2' y='5' width='20' height='14' rx='2'></rect>	<rect fill='#000000' x='2' y='8' width='20' height='3'></rect>	<rect fill='#000000' opacity='0.3' x='16' y='14' width='4' height='2' rx='1'></rect></g></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1411), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 4 },
                    { 13, "Index", "WebApp_TB_TQ", "SummaryOfReceiptPayment", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1412), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/SummaryOfReceiptPayment/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1412), new Guid("00000000-0000-0000-0000-000000000000"), null, 12, 1 },
                    { 14, "Index", "WebApp_TB_PT", "Receipt", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1413), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Receipt/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1414), new Guid("00000000-0000-0000-0000-000000000000"), null, 12, 2 },
                    { 15, "Index", "WebApp_TB_PC", "Payment", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1415), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Payment/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1415), new Guid("00000000-0000-0000-0000-000000000000"), null, 12, 3 },
                    { 16, "Index", "WebApp_TB_SQ", "CashBook", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1416), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/CashBook/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1417), new Guid("00000000-0000-0000-0000-000000000000"), null, 12, 4 },
                    { 17, null, "WebApp_BC", null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1418), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><g stroke='none' stroke-width='1' fill='none' fill-rule='evenodd'>	<polygon points='0 0 24 0 24 24 0 24'></polygon>	<path d='M5.85714286,2 L13.7364114,2 C14.0910962,2 14.4343066,2.12568431 14.7051108,2.35473959 L19.4686994,6.3839416 C19.8056532,6.66894833 20,7.08787823 20,7.52920201 L20,20.0833333 C20,21.8738751 19.9795521,22 18.1428571,22 L5.85714286,22 C4.02044787,22 4,21.8738751 4,20.0833333 L4,3.91666667 C4,2.12612489 4.02044787,2 5.85714286,2 Z' fill='#000000' fill-rule='nonzero' opacity='0.3'></path>	<rect fill='#000000' x='6' y='11' width='9' height='2' rx='1'></rect>	<rect fill='#000000' x='6' y='15' width='5' height='2' rx='1'></rect></g></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1418), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 5 },
                    { 18, null, "WebApp_BC_DS", null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1419), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/SaleReport/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1419), new Guid("00000000-0000-0000-0000-000000000000"), null, 17, 1 },
                    { 19, "Index", "WebApp_BC_HHDV", "ProductReport", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1420), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/ProductReport/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1421), new Guid("00000000-0000-0000-0000-000000000000"), null, 17, 2 },
                    { 20, "Index", "WebApp_BC_TK", "StockReport", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1422), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/StockReport/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1422), new Guid("00000000-0000-0000-0000-000000000000"), null, 17, 3 },
                    { 21, "Index", "WebApp_BC_LN", "ProfitReport", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1423), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/ProfitReport/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1424), new Guid("00000000-0000-0000-0000-000000000000"), null, 17, 4 },
                    { 22, "Index", "WebApp_BC_LL", "ProfitAndLossReport", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1426), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/ProfitAndLossReport/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1426), new Guid("00000000-0000-0000-0000-000000000000"), null, 17, 5 },
                    { 23, "Index", "WebApp_BC_BCT", "MonthlyReport", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1427), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/MonthlyReport/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1427), new Guid("00000000-0000-0000-0000-000000000000"), null, 17, 6 },
                    { 24, null, "WebApp_DM", null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1429), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><g stroke='none' stroke-width='1' fill='none' fill-rule='evenodd'><rect x='0' y='0' width='24' height='24'></rect><rect fill='#000000' x='4' y='4' width='7' height='7' rx='1.5'></rect><path d='M5.5,13 L9.5,13 C10.3284271,13 11,13.6715729 11,14.5 L11,18.5 C11,19.3284271 10.3284271,20 9.5,20 L5.5,20 C4.67157288,20 4,19.3284271 4,18.5 L4,14.5 C4,13.6715729 4.67157288,13 5.5,13 Z M14.5,4 L18.5,4 C19.3284271,4 20,4.67157288 20,5.5 L20,9.5 C20,10.3284271 19.3284271,11 18.5,11 L14.5,11 C13.6715729,11 13,10.3284271 13,9.5 L13,5.5 C13,4.67157288 13.6715729,4 14.5,4 Z M14.5,13 L18.5,13 C19.3284271,13 20,13.6715729 20,14.5 L20,18.5 C20,19.3284271 19.3284271,20 18.5,20 L14.5,20 C13.6715729,20 13,19.3284271 13,18.5 L13,14.5 C13,13.6715729 13.6715729,13 14.5,13 Z' fill='#000000' opacity='0.3'></path></g></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1429), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 6 },
                    { 25, "Index", "WebApp_DM_NHH", "ProductType", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1430), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/ProductType/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1430), new Guid("00000000-0000-0000-0000-000000000000"), null, 24, 1 },
                    { 26, "Index", "WebApp_DM_DVT", "Unit", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1431), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Unit/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1432), new Guid("00000000-0000-0000-0000-000000000000"), null, 24, 2 },
                    { 27, null, "WebApp_BHO", null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1433), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-link'><span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><path d='M16,15.6315789 L16,12 C16,10.3431458 14.6568542,9 13,9 L6.16183229,9 L6.16183229,5.52631579 C6.16183229,4.13107011 7.29290239,3 8.68814808,3 L20.4776218,3 C21.8728674,3 23.0039375,4.13107011 23.0039375,5.52631579 L23.0039375,13.1052632 L23.0206157,17.786793 C23.0215995,18.0629336 22.7985408,18.2875874 22.5224001,18.2885711 C22.3891754,18.2890457 22.2612702,18.2363324 22.1670655,18.1421277 L19.6565168,15.6315789 L16,15.6315789 Z' fill='#000000'></path><path d='M1.98505595,18 L1.98505595,13 C1.98505595,11.8954305 2.88048645,11 3.98505595,11 L11.9850559,11 C13.0896254,11 13.9850559,11.8954305 13.9850559,13 L13.9850559,18 C13.9850559,19.1045695 13.0896254,20 11.9850559,20 L4.10078614,20 L2.85693427,21.1905292 C2.65744295,21.3814685 2.34093638,21.3745358 2.14999706,21.1750444 C2.06092565,21.0819836 2.01120804,20.958136 2.01120804,20.8293182 L2.01120804,18.32426 C1.99400175,18.2187196 1.98505595,18.1104045 1.98505595,18 Z M6.5,14 C6.22385763,14 6,14.2238576 6,14.5 C6,14.7761424 6.22385763,15 6.5,15 L11.5,15 C11.7761424,15 12,14.7761424 12,14.5 C12,14.2238576 11.7761424,14 11.5,14 L6.5,14 Z M9.5,16 C9.22385763,16 9,16.2238576 9,16.5 C9,16.7761424 9.22385763,17 9.5,17 L11.5,17 C11.7761424,17 12,16.7761424 12,16.5 C12,16.2238576 11.7761424,16 11.5,16 L9.5,16 Z' fill='#000000' opacity='0.3'></path></svg></span></span><span class='menu-title'>Chat</span><span class='menu-arrow'></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1433), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 7 }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "ActionName", "Code", "ControllerName", "CreatedDate", "CreatedUserId", "Description", "Icon", "IsDefault", "IsDeleted", "IsVisibled", "Link", "MenuType", "ModifiedDate", "ModifiedUserId", "Name", "ParentId", "SortOrder" },
                values: new object[,]
                {
                    { 28, null, "WebApp_NV", null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1434), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns = 'http://www.w3.org/2000/svg' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'><path d = 'M18,14 C16.3431458,14 15,12.6568542 15,11 C15,9.34314575 16.3431458,8 18,8 C19.6568542,8 21,9.34314575 21,11 C21,12.6568542 19.6568542,14 18,14 Z M9,11 C6.790861,11 5,9.209139 5,7 C5,4.790861 6.790861,3 9,3 C11.209139,3 13,4.790861 13,7 C13,9.209139 11.209139,11 9,11 Z' fill='#000000' fill-rule='nonzero' opacity='0.3'></path><path d = 'M17.6011961,15.0006174 C21.0077043,15.0378534 23.7891749,16.7601418 23.9984937,20.4 C24.0069246,20.5466056 23.9984937,21 23.4559499,21 L19.6,21 C19.6,18.7490654 18.8562935,16.6718327 17.6011961,15.0006174 Z M0.00065168429,20.1992055 C0.388258525,15.4265159 4.26191235,13 8.98334134,13 C13.7712164,13 17.7048837,15.2931929 17.9979143,20.2 C18.0095879,20.3954741 17.9979143,21 17.2466999,21 C13.541124,21 8.03472472,21 0.727502227,21 C0.476712155,21 -0.0204617505,20.45918 0.00065168429,20.1992055 Z' fill='#000000' fill-rule='nonzero'></path></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1435), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 8 },
                    { 29, "Index", "WebApp_NV_BL", "Payroll", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1436), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Payroll/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1436), new Guid("00000000-0000-0000-0000-000000000000"), null, 28, 1 },
                    { 30, null, "WebApp_CD", null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1437), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' width='24' height='24' viewBox='0 0 24 24' fill='none'><path opacity='0.25' d='M2 6.5C2 4.01472 4.01472 2 6.5 2H17.5C19.9853 2 22 4.01472 22 6.5V6.5C22 8.98528 19.9853 11 17.5 11H6.5C4.01472 11 2 8.98528 2 6.5V6.5Z' fill='#12131A'></path><path d='M20 6.5C20 7.88071 18.8807 9 17.5 9C16.1193 9 15 7.88071 15 6.5C15 5.11929 16.1193 4 17.5 4C18.8807 4 20 5.11929 20 6.5Z' fill='#12131A'></path><path opacity='0.25' d='M2 17.5C2 15.0147 4.01472 13 6.5 13H17.5C19.9853 13 22 15.0147 22 17.5V17.5C22 19.9853 19.9853 22 17.5 22H6.5C4.01472 22 2 19.9853 2 17.5V17.5Z' fill='#12131A'></path><path d='M9 17.5C9 18.8807 7.88071 20 6.5 20C5.11929 20 4 18.8807 4 17.5C4 16.1193 5.11929 15 6.5 15C7.88071 15 9 16.1193 9 17.5Z' fill='#12131A'></path></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1438), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 10 },
                    { 31, "Index", "WebApp_CD_NV", "Staff", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1438), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Staff/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1439), new Guid("00000000-0000-0000-0000-000000000000"), null, 30, 1 },
                    { 32, "Index", "WebApp_CD_PQ", "AppRole", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1440), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/AppRole/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1440), new Guid("00000000-0000-0000-0000-000000000000"), null, 30, 2 },
                    { 33, "Index", "WebApp_CD_CH", "Store", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1441), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Store/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1442), new Guid("00000000-0000-0000-0000-000000000000"), null, 30, 3 },
                    { 34, "Index", "WebApp_CD_MI", "DocTemplate", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1448), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/DocTemplate/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1448), new Guid("00000000-0000-0000-0000-000000000000"), null, 30, 4 },
                    { 35, null, "WebApp_CD_DMHT", null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1450), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1450), new Guid("00000000-0000-0000-0000-000000000000"), null, 30, 5 },
                    { 36, "Index", "WebApp_CD_DMHT_M", "Menu", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1451), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Menu/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1451), new Guid("00000000-0000-0000-0000-000000000000"), null, 35, 1 },
                    { 37, "Index", "WebApp_CD_DMHT_LMI", "DocTemplateType", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1452), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/DocTemplateType/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1453), new Guid("00000000-0000-0000-0000-000000000000"), null, 35, 2 },
                    { 38, null, "WebApp_QTW", null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1454), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='svg-icon svg-icon-primary svg-icon-2x'><!--begin::Svg Icon | path:/var/www/preview.keenthemes.com/metronic/releases/2021-05-14-112058/theme/html/demo2/dist/../src/media/svg/icons/Devices/iMac.svg--><svg xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' width='24px' height='24px' viewBox='0 0 24 24' version='1.1'>    <g stroke='none' stroke-width='1' fill='none' fill-rule='evenodd'>        <rect x='0' y='0' width='24' height='24'/>        <path d='M5,5 L5,16 L19,16 L19,5 L5,5 Z M5,3 L19,3 C20.4201608,3 21,3.7163444 21,4.6 L21,17.4 C21,18.2836556 20.4201608,19 19,19 L5,19 C3.57983921,19 3,18.2836556 3,17.4 L3,4.6 C3,3.7163444 3.57983921,3 5,3 Z M12,18 C12.2761424,18 12.5,17.7761424 12.5,17.5 C12.5,17.2238576 12.2761424,17 12,17 C11.7238576,17 11.5,17.2238576 11.5,17.5 C11.5,17.7761424 11.7238576,18 12,18 Z' fill='#12131A' fill-rule='nonzero'/>        <polygon fill='#12131A' opacity='0.3' points='5 5 5 16 19 16 19 5'/>        <rect fill='#12131A' opacity='0.3' x='10' y='20' width='4' height='1' rx='0.5'/>    </g></svg><!--end::Svg Icon--></span>", false, false, true, "", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1454), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 11 },
                    { 39, "Index", "WebApp_QTW_P", "Post", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1455), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Post/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1456), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 1 },
                    { 40, "Index", "WebApp_QTW_PT", "PostType", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1458), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/PostType/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1458), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 2 },
                    { 41, "Index", "WebApp_QTW_S", "Slider", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1459), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Slider/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1460), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 3 },
                    { 42, "Index", "WebApp_KH_NSX", "Manufacturer", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1461), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Manufacturer/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1461), new Guid("00000000-0000-0000-0000-000000000000"), null, 8, 3 },
                    { 43, "Index", "WebApp_DM_TT", "Attribute", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1462), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Attribute/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1463), new Guid("00000000-0000-0000-0000-000000000000"), null, 24, 1 },
                    { 44, null, "WebApp_CD_DMHT_STATUS", null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1464), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1464), new Guid("00000000-0000-0000-0000-000000000000"), null, 35, 4 },
                    { 45, "Index", "WebApp_CD_DMHT_STATUS_AUS", "AppUserStatus", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1465), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/AppUserStatus/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1465), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 1 },
                    { 46, "Index", "WebApp_CD_DMHT_STATUS_OS", "AppUsOrderStatuserStatus", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1467), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/OrderStatus/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1467), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 2 },
                    { 47, "Index", "WebApp_CD_DMHT_STATUS_PS", "PhieuKeToanStatus", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1468), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/PhieuKeToanStatus/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1468), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 2 },
                    { 48, "Index", "WebApp_CD_DMHT_STATUS_POSTS", "PostStatus", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1469), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/PostStatus/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1470), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 3 },
                    { 49, "Index", "WebApp_CD_DMHT_STATUS_POSTTYPES", "PostTypeStatus", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1471), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/PostTypeStatus/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1471), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 4 },
                    { 50, "Index", "WebApp_CD_DMHT_STATUS_PRODUCTTYPES", "ProductTypeStatus", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1472), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/ProductTypeStatus/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1473), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 5 },
                    { 51, "Index", "WebApp_CD_DMHT_STATUS_STS", "StoreStatus", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1475), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/StoreStatus/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1476), new Guid("00000000-0000-0000-0000-000000000000"), null, 44, 6 },
                    { 52, "Index", "WebApp_DM_GTTT", "AttributeValue", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1477), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/AttributeValue/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1477), new Guid("00000000-0000-0000-0000-000000000000"), null, 24, 1 },
                    { 53, "Index", "WebApp_CD_DMHT_P", "PaperSize", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1478), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/PaperSize/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1479), new Guid("00000000-0000-0000-0000-000000000000"), null, 35, 3 },
                    { 54, "Index", "WebApp_CD_DMHT_AUT", "AppUserType", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1480), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/AppUserType/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1480), new Guid("00000000-0000-0000-0000-000000000000"), null, 35, 5 },
                    { 55, null, "WebApp_BH", null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1482), new Guid("00000000-0000-0000-0000-000000000000"), null, "<span class='menu-icon'><span class='svg-icon svg-icon-2'><svg xmlns='http://www.w3.org/2000/svg' width='24' height='24' viewBox='0 0 24 24' fill='none'><path opacity='0.25' d='M2 6.5C2 4.01472 4.01472 2 6.5 2H17.5C19.9853 2 22 4.01472 22 6.5V6.5C22 8.98528 19.9853 11 17.5 11H6.5C4.01472 11 2 8.98528 2 6.5V6.5Z' fill='#12131A'></path><path d='M20 6.5C20 7.88071 18.8807 9 17.5 9C16.1193 9 15 7.88071 15 6.5C15 5.11929 16.1193 4 17.5 4C18.8807 4 20 5.11929 20 6.5Z' fill='#12131A'></path><path opacity='0.25' d='M2 17.5C2 15.0147 4.01472 13 6.5 13H17.5C19.9853 13 22 15.0147 22 17.5V17.5C22 19.9853 19.9853 22 17.5 22H6.5C4.01472 22 2 19.9853 2 17.5V17.5Z' fill='#12131A'></path><path d='M9 17.5C9 18.8807 7.88071 20 6.5 20C5.11929 20 4 18.8807 4 17.5C4 16.1193 5.11929 15 6.5 15C7.88071 15 9 16.1193 9 17.5Z' fill='#12131A'></path></svg></span></span>", false, false, true, "", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1482), new Guid("00000000-0000-0000-0000-000000000000"), null, null, 9 },
                    { 56, "Index", "WebApp_BH_P", "Promotion", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1483), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Promotion/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1484), new Guid("00000000-0000-0000-0000-000000000000"), null, 55, 1 },
                    { 57, "Index", "WebApp_BH_CD", "CommissionDiscount", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1485), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/CommissionDiscount/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1485), new Guid("00000000-0000-0000-0000-000000000000"), null, 55, 2 },
                    { 58, "Index", "WebApp_NV_BS", "BasicSalary", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1486), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/BasicSalary/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1487), new Guid("00000000-0000-0000-0000-000000000000"), null, 28, 2 },
                    { 59, "Index", "WebApp_QTW_M", "WebsiteMenu", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1488), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/WebsiteMenu/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1488), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 4 },
                    { 60, "Index", "WebApp_QTW_B", "Booking", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1489), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Booking/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1490), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 5 },
                    { 61, "Index", "WebApp_QTW_C", "Contact", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1491), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Contact/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1491), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 6 },
                    { 62, "Index", "WebApp_QTW_CI", "ContactInformation", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1492), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/ContactInformation/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1493), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 7 },
                    { 63, "Index", "WebApp_QTW_N", "Newsletter", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1494), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Newsletter/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1494), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 8 },
                    { 64, "Index", "WebApp_QTW_T", "Testimonial", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1495), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Testimonial/Index", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1496), new Guid("00000000-0000-0000-0000-000000000000"), null, 38, 9 },
                    { 65, "Print", "WebApp_HHDV_QRC", "Product", new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1497), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, true, "/Product/Print", 0, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1497), new Guid("00000000-0000-0000-0000-000000000000"), null, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "AppRoleTranslations",
                columns: new[] { "Id", "AppRoleId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3852), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý cửa hàng", false, false, true, 1, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3853), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý cửa hàng", 0 },
                    { 2, new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3855), new Guid("00000000-0000-0000-0000-000000000000"), "Store owner", false, false, true, 2, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3855), new Guid("00000000-0000-0000-0000-000000000000"), "Store manager", 0 },
                    { 3, new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3857), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý", false, false, true, 1, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3857), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý", 0 },
                    { 4, new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3858), new Guid("00000000-0000-0000-0000-000000000000"), "General manager", false, false, true, 2, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3859), new Guid("00000000-0000-0000-0000-000000000000"), "General manager", 0 },
                    { 5, new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3860), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên kho", false, false, true, 1, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3860), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên kho", 0 },
                    { 6, new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3861), new Guid("00000000-0000-0000-0000-000000000000"), "Warehouse staff", false, false, true, 2, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3862), new Guid("00000000-0000-0000-0000-000000000000"), "Warehouse staff", 0 },
                    { 7, new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3863), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên thu ngân", false, false, true, 1, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3863), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên thu ngân", 0 },
                    { 8, new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3864), new Guid("00000000-0000-0000-0000-000000000000"), "Cashier", false, false, true, 2, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3865), new Guid("00000000-0000-0000-0000-000000000000"), "Cashier", 0 },
                    { 9, new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3867), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên bán hàng", false, false, true, 1, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3867), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên bán hàng", 0 },
                    { 10, new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3868), new Guid("00000000-0000-0000-0000-000000000000"), "Shop assistant", false, false, true, 2, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3869), new Guid("00000000-0000-0000-0000-000000000000"), "Shop assistant", 0 },
                    { 11, new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3870), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý chi nhánh", false, false, true, 1, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3870), new Guid("00000000-0000-0000-0000-000000000000"), "Quản lý chi nhánh", 0 },
                    { 12, new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3871), new Guid("00000000-0000-0000-0000-000000000000"), "Branch manager", false, false, true, 2, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3872), new Guid("00000000-0000-0000-0000-000000000000"), "Branch manager", 0 },
                    { 13, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3873), new Guid("00000000-0000-0000-0000-000000000000"), "Quản trị hệ thống", false, false, true, 1, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3873), new Guid("00000000-0000-0000-0000-000000000000"), "Quản trị hệ thống", 0 },
                    { 14, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3874), new Guid("00000000-0000-0000-0000-000000000000"), "Branch Manager", false, false, true, 2, new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3875), new Guid("00000000-0000-0000-0000-000000000000"), "Branch Manager", 0 }
                });

            migrationBuilder.InsertData(
                table: "GenderTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "GenderId", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1374), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, false, false, true, 1, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1374), new Guid("00000000-0000-0000-0000-000000000000"), "Nam", 0 },
                    { 2, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1375), new Guid("00000000-0000-0000-0000-000000000000"), null, 1, false, false, true, 2, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1376), new Guid("00000000-0000-0000-0000-000000000000"), "Male", 0 },
                    { 3, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1377), new Guid("00000000-0000-0000-0000-000000000000"), null, 2, false, false, true, 1, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1377), new Guid("00000000-0000-0000-0000-000000000000"), "Nữ", 0 },
                    { 4, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1378), new Guid("00000000-0000-0000-0000-000000000000"), null, 2, false, false, true, 2, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1379), new Guid("00000000-0000-0000-0000-000000000000"), "Female", 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuAppRoles",
                columns: new[] { "Id", "AppRoleId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsAllow", "IsDefault", "IsDeleted", "IsVisibled", "MenuAppRoleType", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1743), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 1, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1744), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 2, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1745), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 1, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1746), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 3, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1746), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 1, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1747), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 4, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1748), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 2, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1748), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 5, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1749), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 2, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1749), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 6, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1750), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 2, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1750), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 7, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1751), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 3, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1752), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 8, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1752), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 3, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1753), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 9, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1757), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 3, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1758), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 10, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1758), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 4, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1759), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 11, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1760), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 4, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1760), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 12, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1761), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 4, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1761), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 13, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1762), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 5, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1762), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 14, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1763), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 5, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1764), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 15, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1764), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 5, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1765), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 16, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1765), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 6, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1766), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 17, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1767), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 6, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1767), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 18, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1768), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 6, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1768), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 19, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1770), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 7, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1770), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 20, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1771), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 7, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1771), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 21, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1772), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 7, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1772), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 22, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1773), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 8, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1774), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 23, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1774), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 8, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1775), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 24, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1775), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 8, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1776), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuAppRoles",
                columns: new[] { "Id", "AppRoleId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsAllow", "IsDefault", "IsDeleted", "IsVisibled", "MenuAppRoleType", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 25, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1777), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 9, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1777), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 26, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1778), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 9, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1778), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 27, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1779), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 9, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1779), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 28, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1780), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 10, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1780), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 29, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1781), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 10, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1782), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 30, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1782), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 10, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1783), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 31, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1784), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 11, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1784), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 32, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1786), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 11, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1787), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 33, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1787), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 11, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1788), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 34, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1789), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 12, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1789), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 35, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1790), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 12, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1790), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 36, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1791), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 12, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1791), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 37, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1792), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 13, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1792), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 38, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1793), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 13, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1794), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 39, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1794), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 13, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1795), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 40, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1796), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 14, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1797), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 41, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1798), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 14, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1798), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 42, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1799), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 14, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1799), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 43, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1800), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 15, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1800), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 44, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1801), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 15, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1801), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 45, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1802), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 15, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1802), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 46, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1803), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 16, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1804), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 47, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1804), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 16, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1805), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 48, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1805), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 16, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1806), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 49, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1807), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 17, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1807), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 50, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1808), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 17, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1808), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 51, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1809), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 17, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1809), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 52, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1810), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 18, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1810), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 53, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1811), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 18, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1812), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 54, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1812), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 18, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1813), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 55, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1813), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 19, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1814), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 56, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1815), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 19, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1815), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 57, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1816), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 19, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1816), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 58, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1817), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 20, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1817), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 59, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1818), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 20, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1818), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 60, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1819), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 20, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1820), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 61, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1821), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 21, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1821), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 62, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1822), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 21, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1823), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 63, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1823), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 21, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1824), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 64, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1825), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 22, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1825), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 65, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1826), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 22, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1826), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 66, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1830), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 22, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1831), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuAppRoles",
                columns: new[] { "Id", "AppRoleId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsAllow", "IsDefault", "IsDeleted", "IsVisibled", "MenuAppRoleType", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 67, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1832), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 23, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1832), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 68, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1833), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 23, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1833), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 69, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1834), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 23, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1834), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 70, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1835), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 24, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1835), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 71, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1836), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 24, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1837), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 72, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1837), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 24, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1838), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 73, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1838), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 25, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1839), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 74, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1840), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 25, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1840), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 75, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1841), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 25, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1841), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 76, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1842), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 26, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1842), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 77, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1843), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 26, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1843), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 78, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1844), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 26, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1844), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 79, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1845), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 27, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1846), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 80, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1846), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 27, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1847), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 81, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1848), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 27, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1849), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 82, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1849), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 28, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1850), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 83, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1850), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 28, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1851), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 84, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1852), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 28, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1852), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 85, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1853), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 29, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1853), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 86, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1854), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 29, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1854), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 87, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1855), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 29, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1856), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 88, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1856), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 30, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1857), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 89, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1857), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 30, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1858), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 90, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1859), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 30, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1859), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 91, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1860), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 31, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1860), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 92, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1861), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 31, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1861), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 93, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1862), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 31, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1862), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 94, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1865), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 32, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1865), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 95, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1866), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 32, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1866), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 96, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1867), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 32, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1867), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 97, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1868), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 33, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1868), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 98, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1869), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 33, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1870), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 99, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1870), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 33, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1871), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 100, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1872), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 34, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1872), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 101, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1873), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 34, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1873), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 102, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1875), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 34, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1875), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 103, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1876), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 35, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1876), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 104, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1877), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 35, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1877), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 105, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1878), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 35, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1878), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 106, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1879), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 36, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1880), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 107, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1880), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 36, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1881), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 108, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1881), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 36, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1882), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuAppRoles",
                columns: new[] { "Id", "AppRoleId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsAllow", "IsDefault", "IsDeleted", "IsVisibled", "MenuAppRoleType", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 109, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1883), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 37, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1883), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 110, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1884), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 37, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1884), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 111, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1885), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 37, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1885), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 112, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1886), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 38, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1886), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 113, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1887), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 38, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1888), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 114, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1888), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 38, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1889), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 115, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1889), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 39, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1890), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 116, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1891), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 39, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1891), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 117, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1892), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 39, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1892), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 118, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1893), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 40, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1893), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 119, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1894), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 40, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1894), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 120, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1895), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 40, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1896), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 121, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1896), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 41, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1897), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 122, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1898), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 41, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1898), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 123, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1903), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 41, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1904), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 124, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1904), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 42, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1905), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 125, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1906), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 42, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1906), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 126, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1907), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 42, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1907), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 127, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1908), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 43, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1908), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 128, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1909), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 43, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1909), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 129, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1910), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 43, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1911), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 130, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1911), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 44, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1912), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 131, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1912), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 44, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1913), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 132, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1914), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 44, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1914), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 133, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1915), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 45, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1915), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 134, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1916), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 45, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1916), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 135, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1917), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 45, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1917), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 136, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1918), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 46, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1919), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 137, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1919), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 46, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1920), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 138, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1920), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 46, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1921), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 139, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1922), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 47, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1922), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 140, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1923), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 47, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1923), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 141, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1924), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 47, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1924), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 142, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1925), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 48, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1925), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 143, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1926), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 48, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1927), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 144, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1928), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 48, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1928), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 145, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1929), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 49, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1930), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 146, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1930), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 49, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1931), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 147, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1932), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 49, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1932), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 148, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1933), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 50, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1933), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 149, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1934), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 50, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1934), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 150, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1935), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 50, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1935), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuAppRoles",
                columns: new[] { "Id", "AppRoleId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsAllow", "IsDefault", "IsDeleted", "IsVisibled", "MenuAppRoleType", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 151, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1936), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 51, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1936), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 152, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1937), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 51, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1938), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 153, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1938), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 51, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1939), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 154, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1940), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 52, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1940), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 155, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1941), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 52, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1941), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 156, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1942), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 52, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1942), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 157, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1944), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 53, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1944), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 158, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1945), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 53, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1945), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 159, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1946), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 53, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1946), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 160, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1947), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 54, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1948), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 161, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1948), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 54, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1949), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 162, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1950), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 54, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1950), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 163, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1951), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 55, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1951), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 164, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1952), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 55, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1952), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 165, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1954), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 55, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1954), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 166, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1955), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 56, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1955), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 167, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1956), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 56, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1956), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 168, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1957), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 56, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1958), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 169, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1958), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 57, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1959), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 170, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1959), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 57, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1960), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 171, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1961), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 57, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1961), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 172, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1962), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 58, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1962), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 173, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1963), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 58, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1963), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 174, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1964), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 58, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1964), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 175, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1965), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 59, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1966), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 176, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1966), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 59, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1967), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 177, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1967), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 59, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1968), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 178, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1969), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 60, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1969), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 179, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1973), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 60, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1974), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 180, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1975), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 60, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1975), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 181, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1976), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 61, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1977), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 182, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1977), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 61, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1978), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 183, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1978), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 61, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1979), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 184, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1980), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 62, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1980), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 185, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1981), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 62, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1981), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 186, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1982), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 62, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1982), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 187, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1983), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 63, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1983), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 188, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1984), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 63, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1985), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 189, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1985), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 63, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1986), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 190, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1986), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 64, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1987), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 191, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1988), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 64, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1988), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 192, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1989), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 64, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1989), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuAppRoles",
                columns: new[] { "Id", "AppRoleId", "Code", "CreatedDate", "CreatedUserId", "Description", "IsAllow", "IsDefault", "IsDeleted", "IsVisibled", "MenuAppRoleType", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 193, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1990), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)0, 65, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1990), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 194, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1991), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)1, 65, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1991), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 },
                    { 195, new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"), null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1992), new Guid("00000000-0000-0000-0000-000000000000"), null, true, false, false, true, (byte)2, 65, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1993), new Guid("00000000-0000-0000-0000-000000000000"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1527), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 1, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1527), new Guid("00000000-0000-0000-0000-000000000000"), "Tổng quan", 0 },
                    { 2, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1529), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 1, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1529), new Guid("00000000-0000-0000-0000-000000000000"), "Dashboard", 0 },
                    { 3, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1530), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 2, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1530), new Guid("00000000-0000-0000-0000-000000000000"), "Tổng quan", 0 },
                    { 4, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1531), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 2, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1532), new Guid("00000000-0000-0000-0000-000000000000"), "Summary", 0 },
                    { 5, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1533), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 3, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1533), new Guid("00000000-0000-0000-0000-000000000000"), "Đơn hàng", 0 },
                    { 6, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1535), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 3, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1535), new Guid("00000000-0000-0000-0000-000000000000"), "Orders", 0 },
                    { 7, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1536), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 4, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1536), new Guid("00000000-0000-0000-0000-000000000000"), "Hàng hóa & Dịch vụ", 0 },
                    { 8, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1537), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 4, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1538), new Guid("00000000-0000-0000-0000-000000000000"), "Products & Services", 0 },
                    { 9, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1539), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 5, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1539), new Guid("00000000-0000-0000-0000-000000000000"), "Hàng hóa/Dịch vụ", 0 },
                    { 10, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1540), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 5, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1540), new Guid("00000000-0000-0000-0000-000000000000"), "Products/Services", 0 },
                    { 11, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1541), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 6, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1542), new Guid("00000000-0000-0000-0000-000000000000"), "Nhập hàng", 0 },
                    { 12, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1543), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 6, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1543), new Guid("00000000-0000-0000-0000-000000000000"), "Stock in", 0 },
                    { 13, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1544), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 7, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1544), new Guid("00000000-0000-0000-0000-000000000000"), "Kho hàng", 0 },
                    { 14, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1545), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 7, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1545), new Guid("00000000-0000-0000-0000-000000000000"), "Warehouses", 0 },
                    { 15, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1546), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 8, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1547), new Guid("00000000-0000-0000-0000-000000000000"), "Khách hàng", 0 },
                    { 16, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1548), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 8, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1548), new Guid("00000000-0000-0000-0000-000000000000"), "Customers", 0 },
                    { 17, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1549), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 9, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1549), new Guid("00000000-0000-0000-0000-000000000000"), "Khách hàng", 0 },
                    { 18, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1550), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 9, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1551), new Guid("00000000-0000-0000-0000-000000000000"), "Customers", 0 },
                    { 19, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1552), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 10, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1552), new Guid("00000000-0000-0000-0000-000000000000"), "Nhà cung cấp", 0 },
                    { 20, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1553), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 10, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1553), new Guid("00000000-0000-0000-0000-000000000000"), "Suppliers", 0 },
                    { 21, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1554), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 11, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1555), new Guid("00000000-0000-0000-0000-000000000000"), "Nhóm khách hàng", 0 },
                    { 22, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1555), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 11, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1556), new Guid("00000000-0000-0000-0000-000000000000"), "Customer types", 0 },
                    { 23, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1557), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 12, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1557), new Guid("00000000-0000-0000-0000-000000000000"), "Tiền bạc", 0 },
                    { 24, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1558), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 12, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1558), new Guid("00000000-0000-0000-0000-000000000000"), "Receipts & payments", 0 },
                    { 25, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1559), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 13, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1560), new Guid("00000000-0000-0000-0000-000000000000"), "Tổng quan", 0 },
                    { 26, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1561), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 13, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1561), new Guid("00000000-0000-0000-0000-000000000000"), "Summary", 0 },
                    { 27, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1562), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 14, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1562), new Guid("00000000-0000-0000-0000-000000000000"), "Thu", 0 },
                    { 28, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1564), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 14, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1564), new Guid("00000000-0000-0000-0000-000000000000"), "Receipts", 0 },
                    { 29, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1565), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 15, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1565), new Guid("00000000-0000-0000-0000-000000000000"), "Chi", 0 },
                    { 30, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1567), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 15, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1567), new Guid("00000000-0000-0000-0000-000000000000"), "Payments", 0 },
                    { 31, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1568), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 16, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1569), new Guid("00000000-0000-0000-0000-000000000000"), "Sổ quỹ", 0 },
                    { 32, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1569), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 16, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1570), new Guid("00000000-0000-0000-0000-000000000000"), "Cash book", 0 },
                    { 33, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1571), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 17, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1571), new Guid("00000000-0000-0000-0000-000000000000"), "Báo cáo", 0 },
                    { 34, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1572), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 17, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1572), new Guid("00000000-0000-0000-0000-000000000000"), "Reports", 0 },
                    { 35, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1573), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 18, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1574), new Guid("00000000-0000-0000-0000-000000000000"), "Doanh số", 0 },
                    { 36, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1575), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 18, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1575), new Guid("00000000-0000-0000-0000-000000000000"), "Sales", 0 },
                    { 37, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1576), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 19, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1576), new Guid("00000000-0000-0000-0000-000000000000"), "Hàng hóa & Dịch vụ", 0 },
                    { 38, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1577), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 19, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1578), new Guid("00000000-0000-0000-0000-000000000000"), "Products & Services", 0 },
                    { 39, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1579), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 20, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1579), new Guid("00000000-0000-0000-0000-000000000000"), "Tồn kho", 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 40, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1580), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 20, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1580), new Guid("00000000-0000-0000-0000-000000000000"), "Stock", 0 },
                    { 41, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1581), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 21, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1582), new Guid("00000000-0000-0000-0000-000000000000"), "Lợi nhuận", 0 },
                    { 42, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1583), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 21, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1583), new Guid("00000000-0000-0000-0000-000000000000"), "Profit", 0 },
                    { 43, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1584), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 22, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1584), new Guid("00000000-0000-0000-0000-000000000000"), "Lãi lỗ", 0 },
                    { 44, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1585), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 22, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1586), new Guid("00000000-0000-0000-0000-000000000000"), "Profit & Loss", 0 },
                    { 45, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1587), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 23, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1587), new Guid("00000000-0000-0000-0000-000000000000"), "Báo cáo tháng", 0 },
                    { 46, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1588), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 23, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1588), new Guid("00000000-0000-0000-0000-000000000000"), "Monthly report", 0 },
                    { 47, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1589), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 24, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1590), new Guid("00000000-0000-0000-0000-000000000000"), "Danh mục", 0 },
                    { 48, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1590), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 24, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1591), new Guid("00000000-0000-0000-0000-000000000000"), "Directories", 0 },
                    { 49, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1592), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 25, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1592), new Guid("00000000-0000-0000-0000-000000000000"), "Nhóm hàng hóa", 0 },
                    { 50, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1593), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 25, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1594), new Guid("00000000-0000-0000-0000-000000000000"), "Product types", 0 },
                    { 51, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1595), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 26, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1595), new Guid("00000000-0000-0000-0000-000000000000"), "Đơn vị tính", 0 },
                    { 52, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1596), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 26, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1596), new Guid("00000000-0000-0000-0000-000000000000"), "Units", 0 },
                    { 53, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1597), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 27, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1598), new Guid("00000000-0000-0000-0000-000000000000"), "Bán hàng Online", 0 },
                    { 54, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1599), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 27, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1599), new Guid("00000000-0000-0000-0000-000000000000"), "Sale Online", 0 },
                    { 55, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1601), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 28, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1601), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên", 0 },
                    { 56, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1602), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 28, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1602), new Guid("00000000-0000-0000-0000-000000000000"), "Staff", 0 },
                    { 57, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1603), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 29, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1604), new Guid("00000000-0000-0000-0000-000000000000"), "Bảng lương", 0 },
                    { 58, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1605), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 29, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1605), new Guid("00000000-0000-0000-0000-000000000000"), "Payroll", 0 },
                    { 59, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1606), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 30, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1606), new Guid("00000000-0000-0000-0000-000000000000"), "Cài đặt", 0 },
                    { 60, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1612), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 30, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1612), new Guid("00000000-0000-0000-0000-000000000000"), "Setting", 0 },
                    { 61, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1613), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 31, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1614), new Guid("00000000-0000-0000-0000-000000000000"), "Nhân viên", 0 },
                    { 62, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1615), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 31, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1615), new Guid("00000000-0000-0000-0000-000000000000"), "Staffs", 0 },
                    { 63, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1616), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 32, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1617), new Guid("00000000-0000-0000-0000-000000000000"), "Phân quyền", 0 },
                    { 64, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1618), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 32, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1618), new Guid("00000000-0000-0000-0000-000000000000"), "Roles", 0 },
                    { 65, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1619), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 33, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1619), new Guid("00000000-0000-0000-0000-000000000000"), "Cửa hàng", 0 },
                    { 66, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1620), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 33, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1621), new Guid("00000000-0000-0000-0000-000000000000"), "Stores", 0 },
                    { 67, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1622), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 34, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1622), new Guid("00000000-0000-0000-0000-000000000000"), "Mẫu in", 0 },
                    { 68, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1623), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 34, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1623), new Guid("00000000-0000-0000-0000-000000000000"), "Document templates", 0 },
                    { 69, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1624), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 35, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1625), new Guid("00000000-0000-0000-0000-000000000000"), "Danh mục hệ thống", 0 },
                    { 70, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1626), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 35, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1626), new Guid("00000000-0000-0000-0000-000000000000"), "System directories", 0 },
                    { 71, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1627), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 36, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1627), new Guid("00000000-0000-0000-0000-000000000000"), "Menu", 0 },
                    { 72, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1628), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 36, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1628), new Guid("00000000-0000-0000-0000-000000000000"), "Menu", 0 },
                    { 73, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1629), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 37, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1630), new Guid("00000000-0000-0000-0000-000000000000"), "Loại mẫu in", 0 },
                    { 74, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1631), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 37, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1631), new Guid("00000000-0000-0000-0000-000000000000"), "Document printing template type", 0 },
                    { 75, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1632), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 38, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1632), new Guid("00000000-0000-0000-0000-000000000000"), "Website", 0 },
                    { 76, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1633), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 38, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1634), new Guid("00000000-0000-0000-0000-000000000000"), "Website", 0 },
                    { 77, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1635), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 39, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1635), new Guid("00000000-0000-0000-0000-000000000000"), "Bài viết", 0 },
                    { 78, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1636), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 39, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1636), new Guid("00000000-0000-0000-0000-000000000000"), "Post", 0 },
                    { 79, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1638), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 40, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1639), new Guid("00000000-0000-0000-0000-000000000000"), "Chuyên mục", 0 },
                    { 80, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1639), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 40, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1640), new Guid("00000000-0000-0000-0000-000000000000"), "Categories", 0 },
                    { 81, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1641), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 41, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1641), new Guid("00000000-0000-0000-0000-000000000000"), "Slider", 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 82, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1642), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 41, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1642), new Guid("00000000-0000-0000-0000-000000000000"), "Slider", 0 },
                    { 83, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1643), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 42, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1644), new Guid("00000000-0000-0000-0000-000000000000"), "Nhà sản xuất", 0 },
                    { 84, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1645), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 42, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1645), new Guid("00000000-0000-0000-0000-000000000000"), "Manufacturer", 0 },
                    { 85, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1646), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 43, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1646), new Guid("00000000-0000-0000-0000-000000000000"), "Thuộc tính sản phẩm", 0 },
                    { 86, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1647), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 43, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1648), new Guid("00000000-0000-0000-0000-000000000000"), "Attribute", 0 },
                    { 87, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1649), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 44, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1649), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái", 0 },
                    { 88, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1650), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 44, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1650), new Guid("00000000-0000-0000-0000-000000000000"), "Status", 0 },
                    { 89, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1651), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 45, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1652), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái người sử dụng", 0 },
                    { 90, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1653), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 45, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1653), new Guid("00000000-0000-0000-0000-000000000000"), "User status", 0 },
                    { 91, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1654), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 46, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1654), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái đơn hàng", 0 },
                    { 92, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1656), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 46, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1656), new Guid("00000000-0000-0000-0000-000000000000"), "Order status", 0 },
                    { 93, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1657), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 47, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1657), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái phiếu kế toán", 0 },
                    { 94, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1658), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 47, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1659), new Guid("00000000-0000-0000-0000-000000000000"), "Phiếu kế toán status", 0 },
                    { 95, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1660), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 48, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1660), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái bài viết", 0 },
                    { 96, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1661), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 48, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1661), new Guid("00000000-0000-0000-0000-000000000000"), "Post status", 0 },
                    { 97, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1662), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 49, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1663), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái loại bài viết", 0 },
                    { 98, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1664), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 49, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1664), new Guid("00000000-0000-0000-0000-000000000000"), "Post type status", 0 },
                    { 99, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1665), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 50, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1665), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái slide", 0 },
                    { 100, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1666), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 50, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1667), new Guid("00000000-0000-0000-0000-000000000000"), "Slide status", 0 },
                    { 101, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1668), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 51, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1668), new Guid("00000000-0000-0000-0000-000000000000"), "Trạng thái cửa hàng", 0 },
                    { 102, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1669), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 51, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1669), new Guid("00000000-0000-0000-0000-000000000000"), "Store status", 0 },
                    { 103, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1670), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 52, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1670), new Guid("00000000-0000-0000-0000-000000000000"), "Giá trị thuộc tính", 0 },
                    { 104, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1672), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 52, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1673), new Guid("00000000-0000-0000-0000-000000000000"), "Attribute value", 0 },
                    { 105, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1673), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 53, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1674), new Guid("00000000-0000-0000-0000-000000000000"), "Khổ giấy", 0 },
                    { 106, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1675), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 53, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1675), new Guid("00000000-0000-0000-0000-000000000000"), "Paper size", 0 },
                    { 107, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1676), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 54, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1676), new Guid("00000000-0000-0000-0000-000000000000"), "Loại người sử dụng", 0 },
                    { 108, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1677), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 54, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1678), new Guid("00000000-0000-0000-0000-000000000000"), "App user type", 0 },
                    { 109, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1679), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 55, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1679), new Guid("00000000-0000-0000-0000-000000000000"), "Bán hàng", 0 },
                    { 110, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1680), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 55, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1680), new Guid("00000000-0000-0000-0000-000000000000"), "Sales", 0 },
                    { 111, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1681), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 56, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1681), new Guid("00000000-0000-0000-0000-000000000000"), "Chương trình khuyến mãi", 0 },
                    { 112, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1682), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 56, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1683), new Guid("00000000-0000-0000-0000-000000000000"), "Sales Promotion", 0 },
                    { 113, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1684), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 57, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1684), new Guid("00000000-0000-0000-0000-000000000000"), "Hoa hồng - Giảm giá", 0 },
                    { 114, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1685), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 57, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1685), new Guid("00000000-0000-0000-0000-000000000000"), "Commission - Discount", 0 },
                    { 115, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1686), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 58, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1687), new Guid("00000000-0000-0000-0000-000000000000"), "Lương căn bản", 0 },
                    { 116, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1687), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 58, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1688), new Guid("00000000-0000-0000-0000-000000000000"), "Basic salary", 0 },
                    { 117, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1689), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 59, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1689), new Guid("00000000-0000-0000-0000-000000000000"), "Menu", 0 },
                    { 118, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1690), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 59, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1690), new Guid("00000000-0000-0000-0000-000000000000"), "Menu", 0 },
                    { 119, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1691), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 60, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1692), new Guid("00000000-0000-0000-0000-000000000000"), "Đặt lịch", 0 },
                    { 120, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1693), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 60, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1693), new Guid("00000000-0000-0000-0000-000000000000"), "Booking", 0 },
                    { 121, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1694), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 61, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1694), new Guid("00000000-0000-0000-0000-000000000000"), "Liên hệ", 0 },
                    { 122, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1695), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 61, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1695), new Guid("00000000-0000-0000-0000-000000000000"), "Contact", 0 },
                    { 123, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1700), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 62, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1700), new Guid("00000000-0000-0000-0000-000000000000"), "Thông tin liên hệ", 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuTranslations",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "Description", "IsDefault", "IsDeleted", "IsVisibled", "LanguageId", "MenuId", "ModifiedDate", "ModifiedUserId", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 124, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1701), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 62, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1702), new Guid("00000000-0000-0000-0000-000000000000"), "Contact information", 0 },
                    { 125, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1703), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 63, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1703), new Guid("00000000-0000-0000-0000-000000000000"), "Newsletter", 0 },
                    { 126, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1704), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 63, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1704), new Guid("00000000-0000-0000-0000-000000000000"), "Newsletter", 0 },
                    { 127, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1705), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 64, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1706), new Guid("00000000-0000-0000-0000-000000000000"), "Testimonial", 0 },
                    { 128, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1708), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 64, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1708), new Guid("00000000-0000-0000-0000-000000000000"), "Testimonial", 0 },
                    { 129, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1709), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 1, 65, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1709), new Guid("00000000-0000-0000-0000-000000000000"), "In mã QR", 0 },
                    { 130, null, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1710), new Guid("00000000-0000-0000-0000-000000000000"), null, false, false, true, 2, 65, new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1711), new Guid("00000000-0000-0000-0000-000000000000"), "Print QR code", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppRoleTranslations_AppRoleId",
                table: "AppRoleTranslations",
                column: "AppRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRoleTranslations_LanguageId",
                table: "AppRoleTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_GenderId",
                table: "AppUsers",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_GenderTranslations_GenderId",
                table: "GenderTranslations",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_GenderTranslations_LanguageId",
                table: "GenderTranslations",
                column: "LanguageId");

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
                name: "IX_Transactions_AppUserId",
                table: "Transactions",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Clinics");

            migrationBuilder.DropTable(
                name: "GenderTranslations");

            migrationBuilder.DropTable(
                name: "MenuAppRoles");

            migrationBuilder.DropTable(
                name: "MenuTranslations");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
