using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SnaillApp.Data.Migrations
{
    public partial class updateprovince : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Regions_CitysId",
                table: "AppUsers");

            migrationBuilder.RenameColumn(
                name: "CitysId",
                table: "AppUsers",
                newName: "DistrictsId");

            migrationBuilder.RenameIndex(
                name: "IX_AppUsers_CitysId",
                table: "AppUsers",
                newName: "IX_AppUsers_DistrictsId");

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2708), new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2710), new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2713), new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2715), new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2717), new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2718), new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2720), new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2721), new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2723), new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2724), new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2726), new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2727), new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2729), new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2730), new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "1daeafeb-f286-4898-93aa-967694861d47");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "cd2cb6bf-f508-4731-ab11-ba35acf8238a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "8b4b057b-c8f8-40cf-8a3a-65255b6db5c4");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "54a4904b-11ee-40f7-a83a-40b2fa2d87ee");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "a22fbb6d-6cec-40e1-b182-f69ca7be2d2d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "973797bb-7403-49bc-9f8a-67a92bb64222");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "8cf60635-9c0f-4421-bb82-c5177fe2aa1b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f727a9a-b1c4-471b-9c83-ff39a6c38828", "AQAAAAEAACcQAAAAEDtr/CeJqPi9e0T2+5iQv0RG85lCmzz/fm8GeL/oo/LPsDUtngvVtKXFGN657qaxzQ==" });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2591), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2593), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2594), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2596), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2564), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2574), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2514), new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2525), new DateTime(2022, 1, 10, 9, 3, 22, 27, DateTimeKind.Local).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2978), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2980), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2982), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2983), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2984), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2985), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2987), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2988), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2989), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2991), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2992), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2992) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2993), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2994), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2995), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2997), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2998), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2999), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3000), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3001), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3002), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3003), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3005), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3006), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3007), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3008), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3009), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3010), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3012), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3013), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3015), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3016), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3017), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3021), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3022), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3023), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3024), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3029), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3031), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3032), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3033), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3034), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3035), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3037), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3038), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3040), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3041), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3042), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3043), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3045), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3046), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3047), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3049), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3050), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3051), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3052), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3053), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3055), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3056), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3057), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3058), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3059), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3060), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3061), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3063), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3064), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3065), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3066), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3067), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3069), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3070), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3072), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3073), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3074), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3075), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3076), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3077), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3078), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3080), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3081), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3082), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3083), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3083) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3084), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3085), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3087), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3088), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3089), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3090), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3091), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3092), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3094), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3095), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3099), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3101), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3105), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3107), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3110), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3111), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3112), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3113), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3115), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3116), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3117) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3117), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3119), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3120), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3121), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3122), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3123), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3124), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3126), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3127), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3129), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3129) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3130), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3131), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3132), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3133), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3134), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3136), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3137), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3138), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3139), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3140), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3141), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3143), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3144), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3145), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3146), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3147), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3148), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3150), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3151), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3153), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3154), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3155), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3156), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3157), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3159), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3161), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3162), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3163), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3165), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3166), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3167), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3168), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3169), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3170), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3172), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3173), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3174), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3175), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3178), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3182), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3184), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3185), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3186), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3187), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3188), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3190), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3191), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3192), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3193), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3194), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3195), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3196), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3198), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3199), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3200), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3201), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3202), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3204), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3205), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3206), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3208), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3209), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3210), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3211), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3212), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3214), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3215), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3216), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3217), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3218), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3219), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3220), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3222), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3223), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3224), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3225), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3226), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3228), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3229), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3230), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3231), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3233), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3234), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3235), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2755), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2757), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2758), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2759), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2761), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2762), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2763), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2765), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2766), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2767), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2768), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2770), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2771), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2772), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2773), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2776), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2777), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2778), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2779), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2781), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2783), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2784), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2785) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2786), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2788), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2789), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2790), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2792), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2797), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2799), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2799) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2800), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2802), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2802) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2804), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2805), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2806), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2807), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2809), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2810), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2812), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2813), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2814), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2816), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2818), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2819), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2821), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2822), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2824), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2825), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2826), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2828), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2829), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2830), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2832), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2833), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2834), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2836), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2837), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2838), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2840), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2841), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2842), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2844), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2845), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2846), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2847), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2850), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2851), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2852), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2853), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2855), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2856), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2857), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2858), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2860), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2861), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2862), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2864), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2865), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2866), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2868), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2869), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2871), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2872), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2873), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2874), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2876), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2877), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2878), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2880), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2881), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2883), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2887), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2889), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2891), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2892), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2893), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2895), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2896), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2897), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2898) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2899), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2900), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2902), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2903), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2904), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2906), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2907), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2908), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2910), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2911), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2913), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2914), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2915), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2917), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2918), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2920), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2922), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2923), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2924), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2926), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2927), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2928), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2930), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2931), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2932), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2934), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2935), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2936) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2937), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2938), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2939), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2941), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2942), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2611), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2613), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2615), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2617), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2618), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2620), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2621), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2623), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2632), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2634), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2636), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2638), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2638) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2639), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2640), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2643), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2644), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2646), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2647), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2649), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2650), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2652), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2653), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2654), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2656), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2657), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2659), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2660), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2662), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2663), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2664), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2667), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2668), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2669), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2671), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2672), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2674), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2675), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2677), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2678), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2680), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2681), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2682), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2684), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2685), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2687), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2689), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2690), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2692), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2693), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2695), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2696), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2698), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2699), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2701), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2702), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2703), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2705), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2710), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2712), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2714), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2716), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2717), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2719), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2720), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2722), new DateTime(2022, 1, 10, 9, 3, 22, 33, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Regions_DistrictsId",
                table: "AppUsers",
                column: "DistrictsId",
                principalTable: "Regions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Regions_DistrictsId",
                table: "AppUsers");

            migrationBuilder.RenameColumn(
                name: "DistrictsId",
                table: "AppUsers",
                newName: "CitysId");

            migrationBuilder.RenameIndex(
                name: "IX_AppUsers_DistrictsId",
                table: "AppUsers",
                newName: "IX_AppUsers_CitysId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Regions_CitysId",
                table: "AppUsers",
                column: "CitysId",
                principalTable: "Regions",
                principalColumn: "Id");
        }
    }
}
