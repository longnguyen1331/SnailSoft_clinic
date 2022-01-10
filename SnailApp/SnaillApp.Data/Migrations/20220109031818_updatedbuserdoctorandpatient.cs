using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SnaillApp.Data.Migrations
{
    public partial class updatedbuserdoctorandpatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BloodId",
                table: "AppUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "AppUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CitysId",
                table: "AppUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClinicId",
                table: "AppUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Proifle",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "AppUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProvincesId",
                table: "AppUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WardId",
                table: "AppUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WardsId",
                table: "AppUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "AppRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Bloods",
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
                    table.PrimaryKey("PK_Bloods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8302), new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8304), new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8306), new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8308), new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8309), new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8310), new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8312), new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8314), new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8316), new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8317), new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8318), new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8320), new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8321), new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8323), new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "18bc9e00-e799-4f1a-9992-cd2c777b3a79");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "32dfd000-3923-4364-8db0-af740922935a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e51012b2-6bcd-45b9-9cdd-d0aaebe54e13");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e50aca99-6e5e-49a5-a670-6af84c700c56");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "270b17c6-1e86-432c-8282-1e90550059e3");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e2fbf007-98bc-4c35-9a79-3265ecdff71b");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d608f08b-fe6c-4112-af88-5bbe5ab7caba");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0e03c2b5-31d5-4dbf-93a7-de2fef3678a2", "AQAAAAEAACcQAAAAEKJKx7vLXkeIrC3USqKtRTLMB83SvgyaGgw+vfeUabcQSiQ2uvwBPhVEd3OgCtWyHQ==" });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5156), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5158), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5160), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5161), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5142), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5145), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8108), new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8123), new DateTime(2022, 1, 9, 10, 18, 16, 990, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5517), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5519), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5520), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5522), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5523), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5525), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5526), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5527), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5528), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5529), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5531), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5532), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5533), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5534), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5535), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5536), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5537), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5538) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5539), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5540), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5541), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5542), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5543), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5545), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5546), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5547), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5548), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5550), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5551), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5552), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5556), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5558), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5559), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5560), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5561), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5562), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5563) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5564), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5565), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5566), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5567), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5568), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5569), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5570), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5572), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5573), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5574), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5575), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5577), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5578), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5579), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5580), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5582), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5582) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5583), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5584), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5585), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5586), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5587), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5588), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5590), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5591), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5592), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5593), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5593) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5594), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5595), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5597), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5598), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5599), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5600), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5602), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5603), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5605), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5606), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5607), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5608), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5609), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5610), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5612), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5613), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5614), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5615), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5616), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5617), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5619), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5620), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5621), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5622), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5622) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5626), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5628), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5629), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5632), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5633), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5634), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5635), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5637), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5638), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5639), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5640), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5641), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5642), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5643), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5645), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5646), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5647), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5648), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5649), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5650), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5652), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5653), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5654), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5656), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5657), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5658), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5659), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5660), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5661) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5662), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5663), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5664), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5665), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5667), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5668), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5669), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5670), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5671), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5673), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5674), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5675), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5676), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5677), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5678), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5679) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5679), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5681), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5682) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5683), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5684), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5684) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5685), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5686), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5687), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5688), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5690), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5691), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5692), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5693), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5694), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5695), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5700), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5701), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5703), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5704), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5705), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5706), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5707), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5710), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5712), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5713), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5714), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5715), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5716), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5717), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5718), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5720), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5721), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5722), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5723), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5724), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5725), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5727), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5728), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5729), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5730), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5731), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5732), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5733), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5735), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5737), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5738), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5739), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5740), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5741), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5742), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5743), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5745), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5746), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5747), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5748), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5749), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5750), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5752), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5753), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5754), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5755), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5756), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5757), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5758), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5760), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5761), (byte)7, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5762), (byte)8, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5763), (byte)9, new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5307), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5309), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5310), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5312), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5313), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5314), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5316), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5317), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5318), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5320), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5321), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5322), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5323), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5325), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5326), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5327), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5329), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5330), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5334), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5336), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5338), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5339), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5340), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5342), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5343), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5344), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5345), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5347), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5348), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5350), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5351), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5352), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5353), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5355), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5356), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5357), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5358), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5360), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5363), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5364), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5366), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5367), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5368), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5370), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5371), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5372), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5373), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5375), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5375) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5376), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5377), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5378), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5380), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5381), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5382), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5383), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5385), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5385) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5386), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5387), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5387) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5388), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5390), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5391), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5392), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5394), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5395), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5397), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5398), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5399), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5399) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5400), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5401) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5402), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5403), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5404), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5405), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5407), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5408), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5409), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5410), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5412), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5413), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5414), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5415), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5417), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5421), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5423), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5424), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5425) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5425), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5427), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5427) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5428), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5430), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5431), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5432) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5432), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5434), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5435), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5436), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5438), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5439), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5441), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5442), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5443), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5444), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5446), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5447), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5448), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5449) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5450), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5451), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5452), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5453), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5454) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5455), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5456), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5457), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5458), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5460), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5462), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5463), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5464), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5466), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5466) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5467), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5468), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5470), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5471), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5472), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5473), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5475), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5476), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5477), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5479), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5480), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5481), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5482) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5482), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5484), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5484) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5174), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5177), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5184), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5185), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5187), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5188), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5190), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5191), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5193), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5194), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5195), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5196) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5197), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5198), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5200), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5202), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5204), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5206), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5207), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5209), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5210), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5211), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5213), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5214), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5216), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5217), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5219), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5220), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5221), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5223), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5225), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5226), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5228), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5228) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5229), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5231), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5232), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5234), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5235), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5236), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5238), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5242), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5243), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5244), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5246), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5247), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5250), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5251), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5253), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5254), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5255), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5257), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5262), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5264), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5265), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5267), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5268), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5269), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5271), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5272), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5274), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5276), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5277), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5279), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5280), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5282), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5283), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5284) });

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_BloodId",
                table: "AppUsers",
                column: "BloodId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_CitysId",
                table: "AppUsers",
                column: "CitysId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_ClinicId",
                table: "AppUsers",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_ProvincesId",
                table: "AppUsers",
                column: "ProvincesId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_WardsId",
                table: "AppUsers",
                column: "WardsId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Bloods_BloodId",
                table: "AppUsers",
                column: "BloodId",
                principalTable: "Bloods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Clinics_ClinicId",
                table: "AppUsers",
                column: "ClinicId",
                principalTable: "Clinics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Regions_CitysId",
                table: "AppUsers",
                column: "CitysId",
                principalTable: "Regions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Regions_ProvincesId",
                table: "AppUsers",
                column: "ProvincesId",
                principalTable: "Regions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Regions_WardsId",
                table: "AppUsers",
                column: "WardsId",
                principalTable: "Regions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Bloods_BloodId",
                table: "AppUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Clinics_ClinicId",
                table: "AppUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Regions_CitysId",
                table: "AppUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Regions_ProvincesId",
                table: "AppUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Regions_WardsId",
                table: "AppUsers");

            migrationBuilder.DropTable(
                name: "Bloods");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropIndex(
                name: "IX_AppUsers_BloodId",
                table: "AppUsers");

            migrationBuilder.DropIndex(
                name: "IX_AppUsers_CitysId",
                table: "AppUsers");

            migrationBuilder.DropIndex(
                name: "IX_AppUsers_ClinicId",
                table: "AppUsers");

            migrationBuilder.DropIndex(
                name: "IX_AppUsers_ProvincesId",
                table: "AppUsers");

            migrationBuilder.DropIndex(
                name: "IX_AppUsers_WardsId",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "BloodId",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "CitysId",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "ClinicId",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "Proifle",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "ProvincesId",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "WardId",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "WardsId",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "AppRoles");

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
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2191), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2192), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2194), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2195), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2200), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2202), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2203), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2204), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2205), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2206), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2208), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2209), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2210), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2211), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2212), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2213), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2214), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2216), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2218), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2219), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2220), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2221), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2222), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2224), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2225), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2227), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2228), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2229), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2231), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2232), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2233), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2234), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2235), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2237), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2238), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2239), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2240), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2241), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2242), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2243), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2245), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2246), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2247), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2248), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2250), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2251), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2252), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2253), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2255), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2256), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2257), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2258) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2259), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2260), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2261), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2262), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2264), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2265), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2266), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2267), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2269), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2270), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2274), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2276), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2277), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2279), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2280), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2282), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2283), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2284), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2285), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2286), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2287), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2288), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2290), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2291), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2292), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2295), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2296), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2297), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2298), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2299), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2301), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2302), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2303), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2304), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2306), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2308), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2309), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2310), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2311), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2312), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2313), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2315), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2316), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2317), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2318), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2319), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2320), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2321), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2323), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2324), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2325), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2326), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2327), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2328), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2329), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2331), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2332), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2334), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2335), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2336), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2337), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2338), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2339), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2340), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2342), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2343), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2347), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2349), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2350), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2351), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2352) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2352), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2353), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2355), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2356), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2357), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2358), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2360), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2361), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2362), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2363) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2363), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2364), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2366), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2367), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2372), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2373), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2375), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2376), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2377), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2378), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2380), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2381), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2382), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2383), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2384), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2386), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2387), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2389), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2390), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2392), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2393), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2394), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2396), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2397), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2398), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2399), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2400), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2401), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2402), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2404), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2405), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2406), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2407), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2409), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2410), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2411), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2412), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2414), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2415), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2417), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2418), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2419), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2421), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2422), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2426), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2428), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2429), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2430), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2431), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2432), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2434), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2435), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2436), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2437), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2439), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2440), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2441), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2443), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2444), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2446), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2447), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2448), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2450), (byte)0, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2451) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2451), (byte)1, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "MenuAppRoleType", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2452), (byte)2, new DateTime(2022, 1, 7, 15, 20, 11, 607, DateTimeKind.Local).AddTicks(2453) });

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
        }
    }
}
