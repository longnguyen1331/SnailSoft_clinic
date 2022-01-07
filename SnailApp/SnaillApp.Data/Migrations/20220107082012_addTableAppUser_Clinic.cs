using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SnaillApp.Data.Migrations
{
    public partial class addTableAppUser_Clinic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClinicID",
                table: "AppUsers");

            migrationBuilder.CreateTable(
                name: "AppUser_Clinics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClinicID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_AppUser_Clinics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUser_Clinics_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUser_Clinics_Clinics_ClinicID",
                        column: x => x.ClinicID,
                        principalTable: "Clinics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3233), new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3236), new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3237), new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3239), new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3240), new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3242), new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3243), new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3245), new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3246), new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3248), new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3249), new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3250), new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3252), new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3253), new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "8bcc5f76-4846-49b5-b481-e478d1cf177f");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "6e93f351-d251-48ac-8f17-29b516047078");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "1658429a-469f-4029-80df-7870b0d280e6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "727ef0ff-37fa-45ec-9dab-b7fa302191fd");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "3635b8e8-de93-4f76-ad55-1a00a8c6d4a0");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "6c3daded-c533-4185-ad85-5931bcf2ab83");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "47c1098f-129b-433e-b8bf-0f69946ab3e9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e84e7916-68a6-4de2-a038-3ac6e34e8404", "AQAAAAEAACcQAAAAELTe2ofXkx0uCB8B3yl5JQArHd/hs92LlBR9XOSSOnGuzWfnRCevLbes91XD9OLxsg==" });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1829), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1831), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1832), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1834), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1808), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1815), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3056), new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3066), new DateTime(2022, 1, 7, 15, 20, 11, 601, DateTimeKind.Local).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2191), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2192), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2194), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2195), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2200), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2202), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2203), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2204), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2205), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2206), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2208), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2209), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2210), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2211), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2212), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2213), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2214), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2216), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2218), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2219), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2220), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2221), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2222), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2224), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2225), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2227), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2228), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2229), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2231), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2232), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2233), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2234), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2235), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2237), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2238), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2239), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2240), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2241), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2242), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2243), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2245), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2246), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2247), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2248), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2250), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2251), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2252), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2253), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2255), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2256), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2257), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2258) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2259), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2260), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2261), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2262), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2264), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2265), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2266), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2267), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2269), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2270), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2274), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2276), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2277), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2279), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2280), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2282), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2283), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2284), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2285), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2286), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2287), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2288), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2290), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2291), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2292), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2295), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2296), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2297), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2298), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2299), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2301), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2302), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2303), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2304), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2306), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2308), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2309), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2310), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2311), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2312), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2313), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2315), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2316), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2317), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2318), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2319), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2320), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2321), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2323), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2324), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2325), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2326), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2327), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2328), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2329), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2331), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2332), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2334), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2335), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2336), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2337), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2338), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2339), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2340), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2342), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2343), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2347), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2349), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2350), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2351), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2352) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2352), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2353), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2355), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2356), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2357), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2358), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2360), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2361), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2362), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2363) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2363), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2364), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2366), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2367), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2372), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2373), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2375), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2376), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2377), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2378), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2380), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2381), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2382), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2383), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2384), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2386), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2387), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2389), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2390), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2392), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2393), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2394), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2396), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2397), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2398), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2399), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2400), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2401), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2402), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2404), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2405), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2406), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2407), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2409), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2410), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2411), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2412), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2414), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2415), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2417), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2418), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2419), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2421), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2422), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2426), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2428), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2429), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2430), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2431), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2432), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2434), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2435), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2436), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2437), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2439), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2440), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2441), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2443), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2444), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2446), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2447), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2448), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2450), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2451) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2451), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2452), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1983), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1985), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1986) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1987), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1988), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1989), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1990), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1992), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1993), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1994), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1996), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1998), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1999), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2000), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2002), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2003), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2003) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2004), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2005), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2007), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2008), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2009), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2010), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2012), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2012) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2013), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2014), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2015), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2017), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2018), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2020), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2021), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2022), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2023), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2024), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2026), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2027), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2028), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2030), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2031) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2032), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2033), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2034), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2036), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2037), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2038), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2039), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2041), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2042), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2043), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2045), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2046), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2047), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2049), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2050), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2051), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2052), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2054), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2054) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2060), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2062), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2063), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2065), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2068), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2069), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2070), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2071), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2073), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2074), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2075), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2076), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2078), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2079), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2080), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2081), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2082) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2083), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2084), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2085), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2086), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2087), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2089), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2090), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2091), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2092), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2094), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2095), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2096), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2097), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2099), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2101), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2102), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2103), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2104), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2106), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2107), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2108), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2109), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2111), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2112), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2113), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2114), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2116), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2117), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2118), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2119), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2120), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2122), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2123), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2124), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2126), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2127), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2128), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2130), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2131), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2132), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2134), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2135), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2136), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2137), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2139), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2140), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2141), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2145), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2147), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2148), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2150), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2151), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2152), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2153), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2155), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2156), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2157), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2158), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2160), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1849), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1851), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1853), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1854), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1856), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1857), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1858), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1860), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1861), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1863), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1864), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1867), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1868), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1869), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1871), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1872), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1874), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1875), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1876), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1878), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1879), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1881), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1882), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1883), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1885), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1886), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1888), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1890), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1891), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1900), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1902), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1903), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1905), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1906), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1908), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1909), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1910), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1912), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1913), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1915), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1916), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1917), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1920), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1921), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1922), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1924), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1925), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1927), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1928), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1929), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1931), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1932), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1934), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1935), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1937), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1938), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1939), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1941), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1943), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1944), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1946), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1948), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1950), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1951), new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_Clinics_ClinicID",
                table: "AppUser_Clinics",
                column: "ClinicID");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_Clinics_UserId",
                table: "AppUser_Clinics",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUser_Clinics");

            migrationBuilder.AddColumn<int>(
                name: "ClinicID",
                table: "AppUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3852), new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3855), new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3855) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3857), new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3858), new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3860), new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3861), new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3863), new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3864), new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3867), new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3868), new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3870), new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3871), new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3873), new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3874), new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "f7bf2e76-2103-4d36-8e45-f67068becc47");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "f459237c-52ba-46c6-9a22-e9df42d66b2d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "72726dca-2684-4cf0-ab34-4a81b6f771d3");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "38e8620a-2fa3-401d-9e27-ae71fb01e347");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "cd1e7b23-9474-485a-a3cd-a48fabc99c9e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "427849ba-9233-439e-b54a-f0427a71165a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d76fa393-1a81-438b-b0d7-997897c519a9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b36d4a64-f83e-4680-9210-020b9b0519b7", "AQAAAAEAACcQAAAAEF7+dhL9vHodlxX4oE6JHVhWOsHvX13RbLSQTpPTyiSID+WU9XybK0Tq2T3NSH1dWw==" });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1374), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1375), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1377), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1378), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1356), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1362), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3668), new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3680), new DateTime(2022, 1, 6, 16, 36, 13, 760, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1743), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1745), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1746), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1748), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1749), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1750), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1751), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1752), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1757), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1758), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1760), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1761), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1762), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1762) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1763), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1764), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1765), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1767), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1768), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1770), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1771), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1772), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1773), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1774), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1775), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1777), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1778), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1779), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1780), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1780) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1781), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1782), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1784), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1786), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1787), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1789), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1790), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1791), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1792), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1793), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1794), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1796), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1798), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1799), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1800), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1801), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1802), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1803), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1804), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1805), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1807), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1808), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1809), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1810), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1811), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1812), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1813), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1815), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1816), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1817), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1818), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1819), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1821), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1822), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1823), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1825), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1826), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1830), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1832), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1833), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1834), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1835), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1836), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1837), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1838), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1840), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1841), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1842), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1843), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1844), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1845), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1846), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1848), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1849), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1850), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1852), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1853), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1854), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1855), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1856), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1857), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1859), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1860), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1861), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1862), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1865), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1866), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1867), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1868), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1869), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1870), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1872), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1873), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1875), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1876), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1877), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1878), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1879), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1880), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1881), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1883), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1884), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1885), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1886), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1887), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1888), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1889), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1891), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1892), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1893), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1894), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1895), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1896), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1898), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1903), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1904), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1906), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1907), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1908), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1909), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1910), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1911), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1912), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1914), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1915), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1916), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1917), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1918), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1919), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1920), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1922), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1923), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1924), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1925), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1926), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1928), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1929), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1930), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1932), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1932) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1934), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1935), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1936), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1937), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1938), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1940), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1941), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1942), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1944), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1945), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1946), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1948), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1950), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1951), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1952), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1954), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1955), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1956), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1957), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1958), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1959), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1961), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1962), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1963), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1964), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1965), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1966), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1967), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1969), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1973), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1975), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1976), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1977), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1978), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1980), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1981), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1982), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1983), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1984), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1985), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1986) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1986), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1988), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1989), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1990), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1991), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1992), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1527), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1529), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1530), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1531), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1533), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1535), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1536), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1537), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1538) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1539), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1540), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1541), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1543), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1544), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1545), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1546), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1548), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1549), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1550), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1552), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1553), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1554), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1555), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1557), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1558), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1559), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1561), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1562), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1564), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1565), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1567), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1568), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1569), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1571), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1572), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1573), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1575), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1576), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1577), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1579), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1580), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1581), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1583), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1584), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1585), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1587), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1588), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1589), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1590), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1592), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1593), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1595), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1596), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1597), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1599), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1601), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1602), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1603), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1605), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1606), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1612), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1613), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1615), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1616), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1618), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1619), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1620), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1622), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1623), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1624), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1626), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1627), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1628), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1629), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1631), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1632), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1633), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1635), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1636), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1638), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1639), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1641), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1642), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1643), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1645), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1646), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1647), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1649), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1650), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1651), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1653), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1654), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1656), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1657), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1658), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1660), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1661), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1662), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1664), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1665), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1666), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1668), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1669), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1670), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1672), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1673), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1675), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1676), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1677), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1678) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1679), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1680), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1681), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1682), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1684), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1684) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1685), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1685) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1686), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1687), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1689), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1690), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1691), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1693), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1694), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1695), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1700), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1701), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1703), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1704), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1705), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1708), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1709), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1710), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1390), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1392), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1396), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1397), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1399), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1400), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1402), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1403), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1405), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1407), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1409), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1410), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1411) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1412), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1413), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1415), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1416), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1417) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1418), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1419), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1419) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1420), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1422), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1423), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1426), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1426) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1427), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1429), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1429) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1430), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1431), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1432) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1433), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1434), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1436), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1437), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1438), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1440), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1441), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1448), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1450), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1451), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1452), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1454), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1455), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1456) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1458), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1459), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1461), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1461) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1462), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1464), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1465), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1467), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1468), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1468) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1469), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1471), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1472), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1475), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1477), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1477) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1478), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1480), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1482), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1482) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1483), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1485), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1486), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1488), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1489), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1491), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1491) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1492), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1494), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1495), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1496) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1497), new DateTime(2022, 1, 6, 16, 36, 13, 766, DateTimeKind.Local).AddTicks(1497) });
        }
    }
}
