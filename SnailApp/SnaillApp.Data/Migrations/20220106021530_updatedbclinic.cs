using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SnaillApp.Data.Migrations
{
    public partial class updatedbclinic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClinicConfigs");

            migrationBuilder.AddColumn<string>(
                name: "Biography",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClinicID",
                table: "AppUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Skills",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "AppUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FacebookChat",
                table: "AppConfigs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FacebookPixel",
                table: "AppConfigs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Favicon",
                table: "AppConfigs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Firebase_apiKey",
                table: "AppConfigs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Firebase_authDomain",
                table: "AppConfigs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Firebase_messagingSenderId",
                table: "AppConfigs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Firebase_projectId",
                table: "AppConfigs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Firebase_storageBucket",
                table: "AppConfigs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GoogleScript",
                table: "AppConfigs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Keyword",
                table: "AppConfigs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "AppConfigs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "AppConfigs",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6408), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6410), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6412), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6413), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6415), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6416), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6417), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6419), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6420), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6421), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6423), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6424), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6426), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6428), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "23ba4a8e-362e-43fa-9528-04cbc6bc93a0");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "34372c44-4c3b-4ca4-8daa-f98f05b3ffb2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "3e7e7de5-0391-470f-b1aa-20bfc409bad2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "6461eb4d-fee4-4b92-9f8e-33a43dfa239b");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "b1ee1958-d7ed-4ef5-9b20-278a690b1cb4");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "5255c5ed-83a6-43c6-a002-f43183916ec7");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "cd2b646a-42d0-489b-936a-a59fb250764c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a587f1fc-754f-4aa7-a4f0-8889740ffe55", "AQAAAAEAACcQAAAAEMdykQ+6VJyXEdnksh59WMUY6+46fn0MyBTJSdy81UqZK1dyR7Dyl7YQnNgUBWRw3Q==" });

            migrationBuilder.UpdateData(
                table: "AttributeTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4524), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "AttributeTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4526), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4526) });

            migrationBuilder.UpdateData(
                table: "AttributeTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4527), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "AttributeTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4529), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "AttributeValueTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4566), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "AttributeValueTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4568), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "AttributeValueTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4569), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "AttributeValueTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4570), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "AttributeValues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4545), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4545) });

            migrationBuilder.UpdateData(
                table: "AttributeValues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4546), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4509), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4511), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "BasicSalaryTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4863), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.UpdateData(
                table: "BasicSalaryTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4865), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "BasicSalaryTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4866), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "BasicSalaryTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4868), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "BasicSalaryTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4869), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "BasicSalaryTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4870), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "BasicSalarys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FromDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4839), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4841), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "BasicSalarys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FromDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4842), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4843), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "BasicSalarys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FromDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4843), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4844), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "CommissionDiscountTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4911), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "CommissionDiscountTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4913), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "CommissionDiscountTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4914), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4914) });

            migrationBuilder.UpdateData(
                table: "CommissionDiscountTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4915), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "CommissionDiscounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4891), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "CommissionDiscounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4894), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "ContactInformation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4806), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypeTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4641), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypeTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4643), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypeTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4644), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypeTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4646), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypeTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4647), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypeTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4648), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypeTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4650), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypeTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4651), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypeTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4652), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypeTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4654), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4613), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4615), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4616), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4617), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4618), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "DocTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4675), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "DocTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4677), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "DocTemplates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4678), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "DocTemplates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4680), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "DocTemplates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4681), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3789), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3791), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3792), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3793), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3772), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3773), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5664), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5676), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "ManufacturerTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4482), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "ManufacturerTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4483), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "ManufacturerTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4485), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "ManufacturerTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4486), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "ManufacturerTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4487), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4488) });

            migrationBuilder.UpdateData(
                table: "ManufacturerTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4488), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "ManufacturerTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4490), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "ManufacturerTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4491), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4460), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4461), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4461) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4462), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4463), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4464) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4163), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4165), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4166), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4167), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4168), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4170), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4171), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4172), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4173), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4174), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4176), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4177), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4178), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4179), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4180), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4181), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4182), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4184), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4185), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4186), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4188), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4189), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4191), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4192), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4193), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4194), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4195), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4196), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4197), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4199), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4200), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4201), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4202), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4203), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4204), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4205), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4206), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4207), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4209), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4210), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4211), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4213), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4214), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4215), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4215) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4216), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4217), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4221), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4224), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4225), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4226), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4227), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4228), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4229), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4230), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4231), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4233), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4234), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4235), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4236), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4239), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4239) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4240), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4241), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4242), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4243), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4245), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4246), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4247), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4247) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4248), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4249), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4250), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4251), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4253), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4254), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4255), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4255) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4256), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4257), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4258), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4259), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4260), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4262), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4263), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4264), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4265), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4267), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4268), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4269), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4270), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4272), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4273), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4274), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4275), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4276), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4277), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4278), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4279), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4281), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4282), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4283), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4284), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4285), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4286), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4287), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4289), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4293), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4296), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4297), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4298), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4299), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4300), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4301), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4303), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4304), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4305), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4306), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4308), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4309), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4310), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4311), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4312), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4314), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4317), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4319), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4320), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4321), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4322), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4324), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4325), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4326), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4327), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4328), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4330), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4331), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4332), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4333), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4333) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4334), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4334) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4335), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4336), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4338), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4339), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4340), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4341), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4341) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4342), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4343), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4344), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4346), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4347), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4349), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4350), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4351), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4352), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4353), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4354), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4355), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4357), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4358), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4359), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4360), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4361), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4362), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4363) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4363), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4368), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4369), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4370), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4372), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4374), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4376), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4377), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4378), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4379), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4380), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4381), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4383), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4384), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4385), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4386), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4387), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4388), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4389), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4391), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4392), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4393), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4395), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4396), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4397), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4398), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4399), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4401), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4402) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4402), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4403), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4405), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4406), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4407), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4407) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4408), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4409), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3943), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3945), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3946), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3948), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3949), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3950), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3951), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3952), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3954), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3956), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3957), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3958), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3959), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3961), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3962), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3962) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3963), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3964), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3965), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3967), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3968), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3969), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3970), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3972), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3972) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3973), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3974), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3975), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3977), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3978), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3979), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3981), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3981) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3982), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3983), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3985), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3986), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3988), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3989), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3990), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3991), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3996), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3997), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3999), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3999) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4000), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4001), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4002), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4004), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4005), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4006), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4008), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4009), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4010), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4011), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4012), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4014), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4015), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4016), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4016) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4017), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4019), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4021), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4022), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4023), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4024), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4026), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4027), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4028), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4029), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4030), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4032), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4033), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4035), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4036), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4037), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4038), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4039), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4041), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4042), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4043), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4044), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4046), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4047), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4048), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4049), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4052), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4053), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4054), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4056), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4057), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4058), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4059), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4061), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4062), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4063), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4064), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4065), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4067), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4068), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4069), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4071), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4072), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4072) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4073), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4074), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4076), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4076) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4083), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4085), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4086), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4087), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4089), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4091), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4092), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4093), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4094), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4095), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4097), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4098), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4099), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4100), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4102), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4103), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4104), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4105), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4106), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4107) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4108), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4109), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4111), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4112), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4113), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4115), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4116), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4117), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4118), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3812), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3814), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3816), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3817), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3818) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3819), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3820), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3821), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3823), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3824), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3825) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3826), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3828), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3829), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3830), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3832), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3833), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3835), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3836), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3841), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3843), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3845), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3846), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3847) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3849), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3850), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3852), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3853), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3855), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3855) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3857), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3858), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3859), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3861), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3862), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3863), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3865), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3866), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3868), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3868) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3869), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3871), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3872), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3873), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3875), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3876), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3878), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3879) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3880), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3881), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3883), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3884), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3886), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3887), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3889), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3890), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3891), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3893), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3894), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3896), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3897), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3898) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3898), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3901), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3902), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3904), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3905), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3907), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3908), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3910), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3911), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3912) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3913), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "OrderStatusTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5947), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "OrderStatusTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5949), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "OrderStatusTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5951), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "OrderStatusTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5952), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "OrderStatusTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5953), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "OrderStatusTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5954), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "OrderStatusTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5961), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "OrderStatusTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5963), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "OrderStatusTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5964), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "OrderStatusTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5965), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5923), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5925), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5926), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5928), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5929), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "PaperSizes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4588), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "PaperSizes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4590), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "PaperSizes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4591), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "PaperSizes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4593), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "PostStatusTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6001), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "PostStatusTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6003), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "PostStatusTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6004), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "PostStatusTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6005), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "PostStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5984), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "PostStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5986), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "PostTypeTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6038), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "PostTypeTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6040), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "PostTypeTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6041), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "PostTypeTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6043), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6022), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6023), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "ProductSKUs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5130), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "ProductSKUs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5132), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "ProductSKUs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5134), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5092), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5094), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5096), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5098), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "ProductTypeStatusTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6072), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "ProductTypeStatusTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6074), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "ProductTypeStatusTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6075), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "ProductTypeStatusTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6077), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "ProductTypeStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6058), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "ProductTypeStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6059), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "ProductTypeTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6299), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "ProductTypeTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6302), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "ProductTypeTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6303), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "ProductTypeTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6305), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6285), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6288), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5059), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5076), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "PromotionTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5011), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "PromotionTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5013), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "PromotionTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5015), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "PromotionTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5016), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Promotion_CommissionDiscounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5034), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5034) });

            migrationBuilder.UpdateData(
                table: "Promotion_CommissionDiscounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5035), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FromDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4936), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4938), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FromDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4942), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4943), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "SlideStatusTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6258), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "SlideStatusTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6263), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "SlideStatusTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6266), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "SlideStatusTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6267), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "SlideStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6247), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "SlideStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6248), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "SlideTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3674), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "SlideTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3678), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "SlideTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3680), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "SlideTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3682), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "SlideTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3683), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "SlideTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3685), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3636), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3648), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3649), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "SoDuDauKySoQuys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4700), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "StoreStatusTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6225), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "StoreStatusTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6227), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "StoreStatusTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6228), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "StoreStatusTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6229), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "StoreStatusTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6231), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "StoreStatusTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6232), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "StoreStatusTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6233), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "StoreStatusTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6234), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "StoreStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6209), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "StoreStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6211), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "StoreStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6212), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "StoreStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6213), new DateTime(2022, 1, 6, 9, 15, 25, 450, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "StoreTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3740), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3741) });

            migrationBuilder.UpdateData(
                table: "StoreTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3742), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "StoreTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3743), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "StoreTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3745), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3717), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3719), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4824), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4753), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4754), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4756), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4757), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4758), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4759), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4761), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4762), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4763), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4764), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4765), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4767), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4768), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4769), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4771), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4772), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4774), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4778), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4780), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4781), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4783), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4784), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4721), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4722), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4724), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4725), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4728), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4729), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4730), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4732), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4733), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4734), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4736), new DateTime(2022, 1, 6, 9, 15, 25, 457, DateTimeKind.Local).AddTicks(4736) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clinics");

            migrationBuilder.DropColumn(
                name: "Biography",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "ClinicID",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "Skills",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "FacebookChat",
                table: "AppConfigs");

            migrationBuilder.DropColumn(
                name: "FacebookPixel",
                table: "AppConfigs");

            migrationBuilder.DropColumn(
                name: "Favicon",
                table: "AppConfigs");

            migrationBuilder.DropColumn(
                name: "Firebase_apiKey",
                table: "AppConfigs");

            migrationBuilder.DropColumn(
                name: "Firebase_authDomain",
                table: "AppConfigs");

            migrationBuilder.DropColumn(
                name: "Firebase_messagingSenderId",
                table: "AppConfigs");

            migrationBuilder.DropColumn(
                name: "Firebase_projectId",
                table: "AppConfigs");

            migrationBuilder.DropColumn(
                name: "Firebase_storageBucket",
                table: "AppConfigs");

            migrationBuilder.DropColumn(
                name: "GoogleScript",
                table: "AppConfigs");

            migrationBuilder.DropColumn(
                name: "Keyword",
                table: "AppConfigs");

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "AppConfigs");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "AppConfigs");

            migrationBuilder.CreateTable(
                name: "ClinicConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClinicDomain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FacebookAppid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookAppname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookAppsecret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookChat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookLogin = table.Column<bool>(type: "bit", nullable: false),
                    FacebookPixel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Favicon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firebase_apiKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firebase_appId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firebase_authDomain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firebase_measurementId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firebase_messagingSenderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firebase_projectId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firebase_storageBucket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoogleApikey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoogleAppname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoogleClientid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoogleClientsecret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoogleLogin = table.Column<bool>(type: "bit", nullable: false),
                    GoogleScript = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Introduction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsVisibled = table.Column<bool>(type: "bit", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondaryColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicConfigs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3303), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3305), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3306), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3308), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3309), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3311), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3312), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3313), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3315), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3317), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3318), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3319), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3322), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3323), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "f4a5c330-d1f7-41e0-b6a8-d4fd8c5c0a77");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "ac60bdb6-a8e0-4a16-9f34-fa3b767db933");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "8fb47a33-aa6c-4ed2-93f6-5f535cdf985b");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "1f385bec-ceb9-48f6-9ef9-8ba1926fe00d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "175561ca-39d5-4069-b39e-373d7cad6f16");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9b7a4f92-49b2-4933-90f1-de9a756539bd");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d3bc3842-d5d8-4419-8c18-16edaac7d961");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "56c226d4-df33-413a-b834-1ababbc69f49", "AQAAAAEAACcQAAAAEK388fSunpFm0JBLiRwuS8onuUD28oXP9rcQNccI/L51FaSAaWyNroKoWQrX7hOPuw==" });

            migrationBuilder.UpdateData(
                table: "AttributeTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3559), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3560) });

            migrationBuilder.UpdateData(
                table: "AttributeTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3561), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "AttributeTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3562), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "AttributeTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3563), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "AttributeValueTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3594), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "AttributeValueTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3596), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "AttributeValueTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3597), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "AttributeValueTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3598), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "AttributeValues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3577), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "AttributeValues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3578), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3542), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "Attributes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3543), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3543) });

            migrationBuilder.UpdateData(
                table: "BasicSalaryTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3878), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3879) });

            migrationBuilder.UpdateData(
                table: "BasicSalaryTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3880), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "BasicSalaryTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3881), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "BasicSalaryTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3883), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "BasicSalaryTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3884), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "BasicSalaryTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3885), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "BasicSalarys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FromDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3854), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3855), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "BasicSalarys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FromDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3856), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3857), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "BasicSalarys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FromDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3858), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3859), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "CommissionDiscountTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3923), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "CommissionDiscountTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3926), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "CommissionDiscountTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3927), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "CommissionDiscountTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3928), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "CommissionDiscounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3902), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "CommissionDiscounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3906), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "ContactInformation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3821), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypeTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3667), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypeTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3669), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypeTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3671), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3671) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypeTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3672), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypeTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3673), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypeTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3675), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypeTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3676), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypeTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3678), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypeTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3679), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypeTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3680), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3648), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3650), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3651), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3652), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "DocTemplateTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3653), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "DocTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3700), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "DocTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3702), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "DocTemplates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3704), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "DocTemplates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3705), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "DocTemplates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3710), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2834), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2836), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2837), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2839), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2818), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2819), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2804), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2815), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "ManufacturerTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3510), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "ManufacturerTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3512), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "ManufacturerTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3513), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "ManufacturerTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3515), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "ManufacturerTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3516), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "ManufacturerTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3520), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "ManufacturerTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3522), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "ManufacturerTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3523), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3492), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3493), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3494), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3496), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3200), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3202), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3204), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3205), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3206), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3207), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3208), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3210), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3211), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3215), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3217), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3218), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3219), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3221), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3223), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3224), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3225), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3226), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3227), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3228), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3229), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3230), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3232), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3233), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3234), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3235), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3236), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3237), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3239), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3240), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3241), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3243), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3244), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3245), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3246), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3247), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3249), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3250), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3251), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3252), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3253), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3254), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3255), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3257), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3258), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3259), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3260), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3261), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3262), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3263), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3264), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3266), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3267), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3268), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3269), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3271), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3272), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3273), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3274), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3275), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3276), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3278), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3279), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3280), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3281), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3282), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3286), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3288), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3289), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3290), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3291), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3292), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3293), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3295), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3296), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3297), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3299), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3300), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3301), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3302), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3303), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3304), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3306), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3307), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3308), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3309), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3310), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3311), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3312), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3313), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3315), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3316), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3317), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3318), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3320), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3321), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3322), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3323), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3324), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3325), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3327), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3328), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3329), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3330), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3331), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3332), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3333), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3335), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3336), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3337), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3338), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3340), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3341), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3342), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3343), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3344), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3345), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3347), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3348), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3349), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3350), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3352), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3353), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3357), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3359), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3360), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3361), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3362), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3363), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3364), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3365), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3366), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3368), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3369), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3370), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3371), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3372), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3373), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3375), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3376), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3378), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3379), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3380), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3381), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3382), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3383), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3384), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3386), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3387), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3388), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3389), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3390), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3391), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3392), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3393), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3394), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3396), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3398), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3399), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3400), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3401), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3402), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3403), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3404), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3406), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3407), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3408), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3409), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3410), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3411), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3412), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3413), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3415), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3416), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3417), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3418), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3419), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3420), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3421), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3426), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3428), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3429), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3430), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3431), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3433), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3434), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3435), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3436), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3437), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3438), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3439), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3441), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3442), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3443), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3444), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2991), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2992) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2993), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2994), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2996), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2997), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2998), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2999), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3001), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3002), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3003), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3004), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3006), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3008), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3009), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3010), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3011), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3013), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3014), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3015), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3016), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3017), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3019), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3020), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3021), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3023), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3024), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3026), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3027), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3028), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3030), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3031), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3032), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3033), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3035), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3036), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3037), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3038), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3040), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3041), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3042), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3043), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3044), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3046), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3047), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3048), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3049), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3051), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3052), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3054), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3055), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3056), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3057), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3059), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3060), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3061), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3062), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3064), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3065), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3066), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3067), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3072), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3074), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3075), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3076), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3077), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3079), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3080), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3081), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3082), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3083) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3084), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3085), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3087), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3088), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3089), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3090), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3092), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3093), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3094), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3095), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3097), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3098), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3099), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3100), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3101), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3103), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3104), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3105), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3106), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3108), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3109), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3110), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3111), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3113), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3114), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3115), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3117), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3117) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3118), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3120), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3121), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3122), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3124), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3125), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3126), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3127), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3129), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3129) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3130), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3131), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3132), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3133), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3135), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3136), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3137), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3138), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3140), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3141), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3142), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3143), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3145), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3146), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3147), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3148), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3150), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3151), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3153), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3157), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3159), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3160), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3161), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3162), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3164), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2861), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2864), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2865), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2867), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2869), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2872), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2873), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2874), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2876), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2877), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2879), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2880), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2882), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2884), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2885), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2886), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2888), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2889), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2890), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2892), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2894), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2895), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2897), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2898), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2900), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2901), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2902), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2904), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2906), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2907), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2908), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2910), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2911), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2912), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2917), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2919), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2921), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2922), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2924), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2925), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2926), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2928), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2928) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2930), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2931), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2932), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2934), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2935), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2936) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2937), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2938), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2940), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2942), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2943), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2945), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2946), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2947), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2949), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2950), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2952), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2953), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2954), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2956), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2957), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2959), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2960), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2962), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "OrderStatusTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2959), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "OrderStatusTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2961), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "OrderStatusTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2962), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "OrderStatusTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2963), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "OrderStatusTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2965), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "OrderStatusTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2966), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "OrderStatusTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2967), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "OrderStatusTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2969), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "OrderStatusTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2970), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "OrderStatusTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2971), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2936), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2938), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2939), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2941), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2942), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "PaperSizes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3617), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "PaperSizes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3619), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "PaperSizes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3620), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "PaperSizes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3622), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "PostStatusTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3010), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "PostStatusTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3012), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "PostStatusTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3013), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "PostStatusTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3015), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "PostStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2989), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "PostStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2991), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "PostTypeTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3053), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "PostTypeTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3055), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "PostTypeTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3057), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "PostTypeTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3058), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3031), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "PostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3032), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "ProductSKUs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4093), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "ProductSKUs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4095), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "ProductSKUs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4097), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4062), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4064), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4066), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4067), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "ProductTypeStatusTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3087), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "ProductTypeStatusTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3088), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "ProductTypeStatusTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3090), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "ProductTypeStatusTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3091), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "ProductTypeStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3071), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "ProductTypeStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3073), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "ProductTypeTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3188), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "ProductTypeTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3190), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "ProductTypeTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3191), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "ProductTypeTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3193), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3175), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3177), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4037), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4048), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "PromotionTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3995), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "PromotionTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3997), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "PromotionTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3998), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3999) });

            migrationBuilder.UpdateData(
                table: "PromotionTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4000), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Promotion_CommissionDiscounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4013), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "Promotion_CommissionDiscounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4014), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FromDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3949), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3950), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FromDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3951), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3952), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "SlideStatusTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3157), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "SlideStatusTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3159), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "SlideStatusTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3160), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "SlideStatusTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3162), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "SlideStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3145), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "SlideStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3146), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "SlideTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2733), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "SlideTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2738), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "SlideTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2740), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "SlideTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2742), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "SlideTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2743), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "SlideTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2746), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2710), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2716), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "Slides",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2718), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "SoDuDauKySoQuys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3729), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "StoreStatusTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3121), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "StoreStatusTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3122), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "StoreStatusTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3124), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "StoreStatusTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3125), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "StoreStatusTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3127), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "StoreStatusTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3128), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3129) });

            migrationBuilder.UpdateData(
                table: "StoreStatusTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3129), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "StoreStatusTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3131), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "StoreStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3103), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "StoreStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3105), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "StoreStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3106), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "StoreStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3108), new DateTime(2022, 1, 3, 11, 3, 36, 886, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "StoreTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2783), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "StoreTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2793), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "StoreTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2794), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "StoreTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2796), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2765), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2767), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3837), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3772), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3773), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3775), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3776), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3777), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3778), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3779) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3780), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3782), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3783), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3784), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3785), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3786), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3787) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3788), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3789), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3790), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3792), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3793), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3794), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3796), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3797), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3798), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3799) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenuTranslations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3799), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3742), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3743) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3745), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3747), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3748), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3748) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3749), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3751), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3752), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3753), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3755), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3756), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "WebsiteMenus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3757), new DateTime(2022, 1, 3, 11, 3, 36, 892, DateTimeKind.Local).AddTicks(3758) });
        }
    }
}
