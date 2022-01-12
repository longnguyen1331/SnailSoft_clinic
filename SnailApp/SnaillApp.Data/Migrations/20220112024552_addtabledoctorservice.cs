using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SnaillApp.Data.Migrations
{
    public partial class addtabledoctorservice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctor_Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    ClinicId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Doctor_Services", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2228), new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2231), new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2233), new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2234), new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2236), new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2237), new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2239), new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2240), new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2242), new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2243), new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2249), new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2252), new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2253), new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2255), new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "8086520c-4c32-4cbf-87c5-7257b1db5c13");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "11cfe318-81a4-47cb-88f3-7f16f5e263dc");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "40298dc8-fe5e-47f7-8c6e-bf0bed8579b1");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "a81cadba-34dc-455c-a2d2-f0f70aced9a2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9f4714de-7476-4648-a4e2-16414e93f450");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "205b702e-b018-490d-ad65-ef235cc56f20");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "7a9af524-9019-4637-9d24-d314444a9a89");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5c33339c-f192-4b9d-9f0a-6be4643edc39", "AQAAAAEAACcQAAAAEEBxkiiYU0F1T2ClN/ixHWXS+JBhE5noT3mzzTH327Ol5fpQbm7n7QbIu5hWd+EEaw==" });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9559), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9562), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9563), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9565), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9527), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9544), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2033), new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2050), new DateTime(2022, 1, 12, 9, 45, 50, 695, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(310), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(312), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(314), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(315), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(316), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(317), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(319), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(320), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(321), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(322), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(324), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(326), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(327), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(328), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(330), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(331), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(332), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(333), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(334), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(336), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(337), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(338), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(339), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(340), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(342), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(343), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(344), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(346), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(346) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(348), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(349), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(350), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(351), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(353), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(353) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(354), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(355), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(356), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(357), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(358), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(360), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(361), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(362), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(363), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(364), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(366), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(367), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(368), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(369) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(370), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(371), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(372), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(374), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(378), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(381), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(382), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(383), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(384), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(385), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(387), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(388), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(389), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(391), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(392), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(393), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(394), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(397), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(399), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(400), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(401), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(402), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(404), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(406), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(407), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(408), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(410), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(412), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(413), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(414), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(416), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(417), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(418), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(419), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(421), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(422), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(423), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(425), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(426), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(427), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(428), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(429), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(431), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(432), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(434), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(435), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(436), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(438), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(439) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(439), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(441), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(444), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(445), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(446), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(449), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(450), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(451), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(452), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(453), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(455), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(456), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(457), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(462), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(464), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(466), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(467), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(469), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(470), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(475), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(476), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(477), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(478), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(479), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(481), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(482), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(484), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(485), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(486), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(487), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(488), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(489), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(491), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(492), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(494), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(495), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(496), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(497), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(498), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(499), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(501), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(503), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(504), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(505), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(506), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(508), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(509), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(510), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(511), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(513), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(514), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(515), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(517), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(518), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(519), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(520), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(521), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(523), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(525), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(526), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(527), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(529), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(530), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(531), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(533), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(534), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(535), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(536), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(537), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(538), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(543), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(545), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(546), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(547), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(548), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(549), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(674), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(675), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(675) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(676), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(677), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(678), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(680), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(681), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(682) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(683), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(684), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(685), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(686), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(688), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(690), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(691), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(692), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(693), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(694), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(695), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(696), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(698), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(699), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(700), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(701), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(703), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(704), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9740), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9742), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9743), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9744), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9746), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9747), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9748), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9750), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9751), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9752), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9753), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9755), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9756), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9757), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9759), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9760), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9761), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9763), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9764), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9765), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9767), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9768), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9770), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9773), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9775), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9776), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9778), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9780), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9781), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9783), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9784), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9785), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9787), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9788), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9789), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9790), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9792), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9793), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9793) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9794), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9796), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9797), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9798), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9804), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9806), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9807), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9809), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9810), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9811), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9812), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9814), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9816), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9816) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9817), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9818), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9819) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9819), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9821), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9822), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9823), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9824), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9826), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9827), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9828), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9829), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9830), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9832), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9833), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9834), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9835), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9837), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9838), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(105), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(120), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(122), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(123), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(124) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(125), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(126), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(127), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(128) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(129), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(130), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(132), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(133), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(134), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(136), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(137), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(138), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(139) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(140), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(141), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(142), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(143) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(143), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(145), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(145) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(146), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(148), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(149), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(150), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(152), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(153), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(155), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(156), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(157), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(159), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(160), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(161), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(163), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(164), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(165), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(167), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(168), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(168) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(180), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(181), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(182) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(183), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(183) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(184), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(185), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(186) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(187), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(188), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(189), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(191), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(193), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(195), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(195) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(196), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(198), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(199), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(201), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(202), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(204), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(206), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(207), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(209), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(211), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(213), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(214), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(216), new DateTime(2022, 1, 12, 9, 45, 50, 702, DateTimeKind.Local).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9582), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9584), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9587), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9588), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9590), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9591), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9593), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9594), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9596), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9597), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9599), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9600), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9601), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9603), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9604), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9605) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9606), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9607), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9609), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9611), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9612), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9628), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9630), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9631), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9632), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9634), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9635), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9637), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9638), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9639), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9641), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9642), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9644), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9645), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9648), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9649), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9651), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9652), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9654), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9656), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9657), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9658), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9660), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9661), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9663), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9664), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9665), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9667), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9669), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9671), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9672), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9674), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9675), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9676), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9678), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9679), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9681), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9682), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9684), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9685), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9686), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9688), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9689), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9691), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9693), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9694), new DateTime(2022, 1, 12, 9, 45, 50, 701, DateTimeKind.Local).AddTicks(9695) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctor_Services");

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2326), new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2328), new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2330), new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2332), new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2333), new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2334), new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2336), new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2337), new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2339), new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2340), new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2342), new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2343), new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2344), new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2346), new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "81111030-5a26-4e1a-be98-4bdb81183933");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9a03a763-369d-4a0b-b8d1-338e4aaeb307");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "0e419c40-6014-4047-8418-a1535014c33d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "24be1174-e33d-4430-8d62-412bbff43b9e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9181d63d-6a56-4ed0-a250-c15991cd281e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "952cfd20-5e5e-4f2a-8f67-acd4084e0c7d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "f38f08cd-7267-4935-89d9-ba6297b7f6c9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f6f2fb74-b962-4bd8-9f43-74efc64ecda4", "AQAAAAEAACcQAAAAEIJ00apyRO80ugwgC6zuJgXrFjbfke9HVEfcWViT7Xed4yMeTmHkiEYsTLytTxhqRw==" });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9484), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9486), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9487), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9488), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9471), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9474), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2154), new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2166), new DateTime(2022, 1, 11, 14, 42, 45, 790, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9843), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9844), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9846), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9846) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9847), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9852), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9854), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9855), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9856), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9857), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9858), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9859), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9860), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9861), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9863), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9864), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9865), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9868), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9869), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9870), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9871), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9872), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9873), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9874), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9876), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9877), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9878), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9879), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9880), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9881), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9883), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9884), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9885), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9886), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9887), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9888), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9890), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9892), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9893), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9894), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9895), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9896), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9897), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9899), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9900), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9901), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9902), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9903), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9904), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9905), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9906), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9908), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9909), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9910), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9911), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9912), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9913), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9914), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9916), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9917), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9919), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9920), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9924), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9926), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9927), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9928), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9929), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9930), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9931), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9933), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9934), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9935), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9936), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9937), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9938), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9939), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9941), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9942), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9943), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9946), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9947), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9948), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9949), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9950), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9951), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9953), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9954), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9955), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9956), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9957), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9958), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9959), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9961), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9962), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9963), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9964), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9965), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9966), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9967), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9969), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9970), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9972), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9973), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9974), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9975), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9976), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9977), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9978), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9979), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9981), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9982), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9983), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9984), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9985), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9986), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9987), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9989), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9990), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9994), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9996), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9998), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9999), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(1), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(2), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(3), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(4), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(6), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(7), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(8), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(9), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(10), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(11), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(12), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(14), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(15), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(16), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(17), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(18), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(19), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(20), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(24), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(25), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(26), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(28), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(31), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(32), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(32) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(33), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(34), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(35), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(37), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(38), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(39), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(41), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(42), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(43), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(44), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(45), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(46), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(47), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(48), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(50), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(51) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(51), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(53), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(54), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(54) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(55), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(56), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(57), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(58), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(60), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(61), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(62), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(63), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(64), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(65), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(69), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(71), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(72), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(73), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(74), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(76), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(77), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(78), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(79), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(80), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(81), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(82), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(84), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(85), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(86), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(87), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(88), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(89), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(90), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(91), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(93), new DateTime(2022, 1, 11, 14, 42, 45, 796, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9634), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9637), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9638), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9640), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9641), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9643), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9644), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9645), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9646), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9648), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9649), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9650), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9652), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9653), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9654), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9655), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9657), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9658), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9658) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9659), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9661), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9662), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9663), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9665), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9666), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9667), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9668), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9670), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9672), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9673), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9675), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9676), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9677), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9678), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9680), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9681), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9682), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9683), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9685), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9686), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9687), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9689), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9690), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9691), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9693), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9694), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9695), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9696), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9698), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9699), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9700), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9701), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9704), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9705), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9706), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9712), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9713), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9715), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9716), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9717), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9718), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9720), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9721), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9721) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9722), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9723), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9725), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9725) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9726), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9727), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9729), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9730), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9731), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9732), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9734), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9734) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9735), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9736), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9737), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9739), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9741), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9742), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9743), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9744), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9746), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9747), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9748), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9749), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9751), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9752), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9753), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9754), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9756), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9757), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9757) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9758), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9759), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9760), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9762), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9763), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9764), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9765), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9767), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9768), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9769), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9771), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9773), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9774), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9775), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9776), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9778), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9779), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9780), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9781), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9782), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9784), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9785), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9786), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9787), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9789), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9790), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9791), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9793), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9793) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9797), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9798) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9799), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9800), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9801), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9802), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9803), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9805), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9807), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9808), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9809), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9811), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9812), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9498), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9500), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9502), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9504), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9505), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9505) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9507), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9509), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9510), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9512), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9513), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9515), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9516), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9517), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9519), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9520), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9522), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9523), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9524), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9526), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9527), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9529), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9530), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9532), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9534), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9535), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9537), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9540), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9541), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9543), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9548), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9550), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9552), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9555), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9558), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9560), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9561), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9563), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9566), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9568), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9569), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9570), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9572), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9573), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9575), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9576), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9577), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9579), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9580), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9582), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9583), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9585), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9586), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9588), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9589), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9591), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9592), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9594), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9595), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9596), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9598), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9599), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9601), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9602), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9604), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9605), new DateTime(2022, 1, 11, 14, 42, 45, 795, DateTimeKind.Local).AddTicks(9605) });
        }
    }
}
