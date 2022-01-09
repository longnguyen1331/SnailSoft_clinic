using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SnaillApp.Data.Migrations
{
    public partial class updatedbappuseraddcolumntype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "AppUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(1994), new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(1997), new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(1999), new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2000), new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2002), new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2003), new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2006), new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2007), new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2008), new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2010), new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2011), new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2012) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2013), new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2014), new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2015), new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "8abed257-63ee-45ad-938e-350232ddcde0");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d8fb0537-bc19-487c-ad99-8f27966d242f");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "af8e9518-00d3-4721-b219-7a5d923d9372");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "bea5de46-d7ee-4a95-a9de-98b918cb21c7");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "8579b6b6-d690-467c-bc52-f2c7e8b53982");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "4ad8b6f6-b568-4975-bc1f-a343a07e9a19");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "cdb6d62b-b64e-4206-b07d-79db44cd6db9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e3ce2f19-bac3-4d2b-a74e-171212d9efa6", "AQAAAAEAACcQAAAAEC2KjpHCsRrGLyNCzNoOGSrDq7awUQVjHFiUB1P4WeJvl6u00A0ddxp4RWNoXSsgeg==" });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4386), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4388), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4390), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4391), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4354), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4364), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(1796), new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(1806), new DateTime(2022, 1, 9, 14, 52, 36, 471, DateTimeKind.Local).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4770), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4771), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4773), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4774), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4775), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4776), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4777), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4778), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4780), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4781), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4782), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4783), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4784), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4785), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4787), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4788), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4789), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4790), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4792), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4793), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4794), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4795), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4796), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4798), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4799), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4801), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4803), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4804), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4805), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4806), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4807), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4808), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4809), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4811), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4812), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4816), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4818), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4819), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4820), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4821) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4821), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4822), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4824), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4825), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4826), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4827), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4829), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4830), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4831), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4832), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4833), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4834), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4836), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4837), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4838), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4839), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4840), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4841), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4842), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4844), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4847), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4848), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4849), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4850), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4851), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4852), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4853), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4855), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4856), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4857) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4857), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4858) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4859), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4860), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4861), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4862), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4863), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4864), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4865), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4867), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4868), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4869), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4870), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4870) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4871), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4872) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4872), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4873), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4874) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4875), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4876), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4876) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4877), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4878), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4880), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4881), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4882), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4883) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4883), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4884), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4889), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4890), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4892), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4893), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4894), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4895), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4896), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4897), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4898), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4900), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4901), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4902), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4903), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4904), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4905) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4905), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4907), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4908), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4910), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4911), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4912), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4913), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4914), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4915), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4917), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4918), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4919), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4920), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4921), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4924), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4925), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4926), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4927), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4929), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4930), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4931), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4932), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4934), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4935), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4936) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4937), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4938), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4939), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4940), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4941), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4942), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4944), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4944) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4945), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4946), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4947), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4948), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4949), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4950), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4952), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4953), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4954), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4955), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4956), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4957), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4962), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4964), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4965), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4966), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4967), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4969), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4970), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4971), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4972), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4973), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4974), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4975), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4977), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4978), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4979), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4980), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4981), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4982), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4983), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4985), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4986), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4988), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4989), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4990), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4991), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4992), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4993), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4995), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4996), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4997), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4998), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4999), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5000), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5002), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5004), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5005), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5006), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5007), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5008), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5009), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5010), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5012), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5013), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5014), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5015), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5017), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4559), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4561), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4563), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4564), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4565), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4566), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4568), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4569), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4570), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4571), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4573), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4574), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4575), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4577), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4579), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4580), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4581), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4582), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4584), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4585), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4586), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4587), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4589), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4590), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4591), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4592), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4597), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4599), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4600), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4601), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4602) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4603), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4604), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4604) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4605), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4606), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4607), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4609), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4610), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4612), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4613), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4615), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4616), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4617), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4618), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4620), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4621), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4622), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4623), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4625), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4626), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4627), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4628), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4630), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4631), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4632), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4633), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4635), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4636), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4637), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4638), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4640), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4641), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4642), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4644), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4645), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4647), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4648), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4649), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4650), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4651), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4653), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4654), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4655), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4656), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4658), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4659), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4660), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4661), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4663), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4664), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4665), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4665) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4666), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4667), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4669), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4670), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4672), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4673), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4673) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4674), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4675), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4677), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4681), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4683), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4684), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4685), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4686), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4688), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4689), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4690), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4691), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4693), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4694), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4695), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4696), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4698), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4699), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4700), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4701), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4702), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4704), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4705), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4707), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4708), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4709), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4711), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4712), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4713), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4714), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4716), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4717), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4718), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4720), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4721), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4722), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4723), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4725), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4726), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4727), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4729), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4730), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4731), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4733), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4409), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4411), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4411) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4413), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4414), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4416), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4417), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4419), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4430), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4431), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4432), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4434), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4435), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4437), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4439), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4441), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4442), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4443), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4445), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4447), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4448), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4450), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4451), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4453), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4454), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4457), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4458), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4460), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4461), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4461) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4464), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4464) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4465), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4467), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4468), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4469), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4471), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4472), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4474), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4475), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4477), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4478), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4480), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4481), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4483), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4484), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4486), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4488), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4488) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4489), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4491), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4492), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4493), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4495), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4496), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4498), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4498) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4499), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4501), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4502), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4503), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4508), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4510), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4512), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4514), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4515), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4517), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4518), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4519), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4521), new DateTime(2022, 1, 9, 14, 52, 36, 477, DateTimeKind.Local).AddTicks(4521) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "AppUsers");

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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5517), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5519), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5520), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5522), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5523), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5525), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5526), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5527), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5528), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5529), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5531), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5532), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5533), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5534), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5535), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5536), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5537), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5538) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5539), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5540), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5541), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5542), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5543), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5545), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5546), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5547), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5548), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5550), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5551), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5552), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5556), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5558), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5559), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5560), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5561), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5562), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5563) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5564), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5565), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5566), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5567), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5568), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5569), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5570), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5572), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5573), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5574), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5575), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5577), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5578), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5579), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5580), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5582), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5582) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5583), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5584), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5585), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5586), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5587), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5588), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5590), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5591), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5592), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5593), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5593) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5594), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5595), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5597), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5598), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5599), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5600), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5602), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5603), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5605), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5606), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5607), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5608), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5609), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5610), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5612), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5613), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5614), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5615), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5616), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5617), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5619), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5620), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5621), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5622), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5622) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5626), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5628), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5629), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5632), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5633), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5634), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5635), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5637), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5638), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5639), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5640), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5641), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5642), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5643), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5645), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5646), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5647), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5648), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5649), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5650), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5652), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5653), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5654), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5656), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5657), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5658), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5659), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5660), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5661) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5662), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5663), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5664), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5665), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5667), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5668), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5669), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5670), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5671), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5673), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5674), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5675), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5676), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5677), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5678), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5679) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5679), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5681), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5682) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5683), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5684), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5684) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5685), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5686), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5687), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5688), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5690), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5691), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5692), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5693), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5694), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5695), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5700), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5701), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5703), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5704), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5705), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5706), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5707), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5710), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5712), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5713), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5714), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5715), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5716), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5717), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5718), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5720), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5721), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5722), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5723), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5724), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5725), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5727), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5728), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5729), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5730), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5731), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5732), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5733), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5735), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5737), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5738), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5739), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5740), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5741), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5742), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5743), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5745), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5746), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5747), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5748), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5749), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5750), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5752), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5753), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5754), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5755), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5756), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5757), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5758), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5760), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5761), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5762), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5763), new DateTime(2022, 1, 9, 10, 18, 16, 996, DateTimeKind.Local).AddTicks(5764) });

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
        }
    }
}
