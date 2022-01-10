using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SnaillApp.Data.Migrations
{
    public partial class updatedbprovnice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Regions",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2640), new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2643), new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2644), new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2646), new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2647), new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2649), new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2651), new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2652), new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2654), new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2655), new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2656), new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2658), new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2659), new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2660), new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "ccd11402-4c32-4f46-a9d5-5c6dd9be3ba1");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9a342d46-91ee-4925-834b-317b6e0a50b1");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "06a2d16b-ccff-432d-9d2b-2a42c6385cae");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "688953c7-ee2f-4684-9366-ab77731e30fe");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "0e8d9b93-6cc7-4a35-ae0a-d8ec07f2578e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "f03c3c55-3f87-4124-beab-f93884e032fc");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "18da9c74-5e8e-44b6-9597-43b36ff0747a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9bfb6837-edbb-4d73-98f5-d58d042cee80", "AQAAAAEAACcQAAAAEKntpD5HG7f0hcJLLdLH51nkEDDpsiwi3qj6Z6wjmjUaCqvoGk+RWg+mbFXMHkCwbQ==" });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9917), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9918), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9920), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9921), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9902), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9905), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2450), new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2462), new DateTime(2022, 1, 10, 15, 27, 50, 719, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(281), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(284), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(285), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(286), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(287), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(289), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(290), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(292), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(293), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(295), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(296), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(297), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(298), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(299), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(300), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(302), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(304), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(305), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(306), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(307), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(308), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(309), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(311), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(311) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(312), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(313), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(315), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(316), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(317), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(318), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(319), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(320), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(322), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(323), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(324), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(329), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(330), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(331), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(333), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(334), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(335), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(336), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(337), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(338), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(339), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(341), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(342), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(344), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(345), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(346), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(346) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(347), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(348), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(349), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(350), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(351), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(353), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(353) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(354), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(355), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(356), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(357), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(358), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(359), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(360), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(362), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(363), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(364), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(365), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(366), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(368), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(369), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(369) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(370), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(371), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(372), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(374), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(375), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(376), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(377), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(378), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(379), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(380), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(381), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(383), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(384), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(385), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(386), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(387), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(388), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(389), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(391), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(392), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(393), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(398), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(399), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(400), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(401), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(402), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(404), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(405), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(406), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(407), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(408), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(409), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(410), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(411), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(413), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(414), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(415), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(416), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(417), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(419), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(421), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(422), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(423), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(425), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(426), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(427), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(428), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(430), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(431), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(432), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(433), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(434), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(435), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(436), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(438), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(439), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(439) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(440), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(441), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(442), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(444), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(445), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(446), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(448), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(449), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(450), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(453), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(454), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(456), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(457), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(458), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(459), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(460), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(461), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(462), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(463), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(464), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(466), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(470), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(471), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(473), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(474), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(475), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(476), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(478), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(479), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(480), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(481), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(482), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(483), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(484), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(486), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(487), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(488), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(489), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(490), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(491), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(492), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(493), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(495), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(496), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(498), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(499), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(500), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(501), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(502), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(503), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(504), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(506), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(507), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(508), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(509), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(510), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(511), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(512), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(514), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(515), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(516), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(517), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(518), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(519), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(520), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(521), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(523), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(524), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(525), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(63), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(65), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(66), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(68), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(69), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(70), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(72), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(73), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(74), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(76), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(77), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(78), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(80), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(82), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(83), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(84), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(85), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(86), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(88), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(89), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(90), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(91), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(93), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(94), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(99), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(100), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(101), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(103), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(104), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(105), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(107), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(108), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(109), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(110), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(112), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(113), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(114), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(115), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(117), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(118), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(120), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(121), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(122), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(123), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(124) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(124), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(126), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(127), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(128), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(129), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(131), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(132), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(133), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(134), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(135), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(137), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(138), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(139), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(139) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(141), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(142), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(143), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(143) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(144), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(145) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(145), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(148), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(149), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(150), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(151), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(153), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(154), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(155), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(156), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(157), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(159), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(161), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(162), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(163), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(164), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(165) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(166), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(167), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(168), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(168) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(169), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(171), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(171) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(172), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(173), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(174), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(176), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(177), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(178), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(183), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(185), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(186), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(186) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(187), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(188), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(189) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(190), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(191), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(193), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(194), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(195), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(197), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(199), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(200), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(201), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(203), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(204), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(205), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(206), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(208), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(209), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(210), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(212), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(212) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(213), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(214), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(219), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(220), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(221), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(222), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(224), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(225), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(226), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(227), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(229), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(230), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(232), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(235), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(236), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(239), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(241), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(242), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(244), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(245), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(246), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9932), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9934), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9936), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9937), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9939), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9940), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9946), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9948), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9949), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9950), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9952), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9954), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9955), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9957), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9958), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9959), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9961), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9962), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9964), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9965), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9966), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9968), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9969), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9971), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9972), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9974), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9975), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9976), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9978), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9980), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9981), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9983), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9985), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9986), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9988), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9989), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9990), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9992), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9993), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9995), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9996), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9997), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9999), new DateTime(2022, 1, 10, 15, 27, 50, 724, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(2), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(4), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(5), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(7), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(8), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(10), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(12), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(13), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(15), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(16), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(18), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(23), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(24), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(26), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(27), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(29), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(31), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(32), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(34), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(35), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(37), new DateTime(2022, 1, 10, 15, 27, 50, 725, DateTimeKind.Local).AddTicks(37) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Regions");

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
        }
    }
}
