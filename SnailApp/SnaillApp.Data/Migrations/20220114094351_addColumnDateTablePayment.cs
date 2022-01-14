using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SnaillApp.Data.Migrations
{
    public partial class addColumnDateTablePayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "AppointmentPayments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9454), new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9456), new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9458), new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9461), new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9462), new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9464), new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9465), new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9467), new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9468), new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9471), new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9472), new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9474), new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9476), new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9477), new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "c1c15931-2bf1-458b-9a22-bf0d79930392");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "84fe90f8-97bb-4dde-ab4b-e3ec2f4e42dd");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "36a4f9d7-7433-4b82-ae24-9c9736048bff");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e4fa525b-a088-4bc7-ac46-a44461615801");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d07b68aa-6457-40dd-89da-ef40f02b1eb6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "28191246-17aa-4003-9d6e-ad882e6d15b6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "ec818513-b108-44ef-ad72-8772ace800ba");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "262a4481-0e0d-479f-a6cd-d1756fd888b0", "AQAAAAEAACcQAAAAEFRN/ZZSAfX6PAS8ld2qrK446fJs/g+zqXb74kx55hI2fTTRkQDyJvoNfS6qnUK0Yw==" });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6324), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6326), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6328), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6329), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6294), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6305), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9223), new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9244), new DateTime(2022, 1, 14, 16, 43, 49, 762, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6746), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6748), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6749), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6750), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6752), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6753), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6754), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6755), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6756), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6758), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6759), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6760), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6761), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6763), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6765), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6766), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6767), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6768), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6770), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6771), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6772), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6773), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6774), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6775), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6777), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6781), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6783), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6784), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6786), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6787), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6788), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6789), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6790), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6792), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6794), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6795), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6796), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6797), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6799), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6800), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6802), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6804), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6805), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6806), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6807), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6809), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6810), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6811), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6812), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6814), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6815), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6816), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6817), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6818), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6820), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6821), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6822), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6824), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6825), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6826), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6827), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6828), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6829), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6831), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6832), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6833), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6834), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6835), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6836), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6837), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6839), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6840), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6841), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6842), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6843), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6845), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6846) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6846), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6848), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6849), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6850), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6851), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6855), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6857), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6858), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6859), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6861), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6862), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6863), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6864), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6865), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6866), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6867), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6869), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6870), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6871), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6872), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6874), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6874) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6875), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6876), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6877), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6878) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6879), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6880), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6881), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6882), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6883), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6884), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6886), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6887), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6888), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6889), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6890), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6891) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6891), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6893), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6894), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6895), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6896), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6898), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6899), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6900), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6902), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6903), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6904), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6905), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6906), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6907), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6909), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6910), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6911), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6912), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6913), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6914) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6914), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6916), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6917), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6918), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6919), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6920), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6922), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6923), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6928), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6930), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6931), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6932), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6933), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6935), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6936), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6937), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6938), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6939), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6940), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6942), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6943), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6944), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6945), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6946), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6948), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6949), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6949) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6951), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6953), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6953) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6955), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6955) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6960), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6961), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6962), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6963), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6965), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6966), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6967), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6968), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6969), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6970), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6972), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6973), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6974), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6975), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6976), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6977), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6978) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6979), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6980), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6981), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6982), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6983), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6984), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6985), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6987), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6988), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6989), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6990), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6991), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6992), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6994), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6995), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6996), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6997), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6998), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6999), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(7001), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6508), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6509), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6511), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6513), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6514), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6515), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6517), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6518), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6519), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6520), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6522), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6522) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6523), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6524), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6529), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6531), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6532), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6533), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6535), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6536), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6537), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6538), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6540), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6541), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6543), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6544), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6545) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6546), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6548), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6550), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6551), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6553), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6554), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6556), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6557), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6558), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6560), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6561), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6562), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6563), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6565), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6566), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6566) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6567), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6568), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6570), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6571), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6572), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6573), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6575), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6576), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6578), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6579), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6580), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6582), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6583), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6584), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6584) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6585), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6586) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6587), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6588), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6589), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6590), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6591) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6592), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6592) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6594), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6595), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6595) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6596), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6597) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6598), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6599), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6600), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6601), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6603), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6604), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6605), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6606), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6608), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6610), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6611), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6612), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6613), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6615), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6620), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6622), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6623), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6625), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6626), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6628), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6629), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6630), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6632), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6633), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6634), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6636), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6637), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6638), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6640), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6641), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6642), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6643), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6644), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6646), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6647), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6649), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6650), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6651), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6652), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6654), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6655), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6656), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6658), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6659), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6660), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6661), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6663), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6664), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6665), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6666), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6668), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6669), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6672), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6673), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6674), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6676), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6677), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6678), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6695), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6696), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6697), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6698), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6700), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6701), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6701) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6702), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6703), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6705), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6364), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6366), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6368), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6370), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6372), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6374), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6376), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6377), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6379), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6380), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6382), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6383), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6384) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6385), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6386), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6387) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6388), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6388) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6389), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6391), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6392), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6393), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6395), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6397), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6398), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6400), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6401), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6405), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6406) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6407), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6409), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6410), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6412), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6413), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6414), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6416), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6418), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6420), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6421), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6423), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6424), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6426), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6427), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6429), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6430), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6432), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6433), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6435), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6436), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6438), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6439), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6445), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6445) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6446), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6448), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6450), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6452), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6453), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6455), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6456), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6458), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6460), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6461), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6463), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6464), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6465) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6466), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6467), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6469), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6470), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6472), new DateTime(2022, 1, 14, 16, 43, 49, 770, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_Services_AppointmentId",
                table: "Appointment_Services",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Services_Appointments_AppointmentId",
                table: "Appointment_Services",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Services_Appointments_AppointmentId",
                table: "Appointment_Services");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_Services_AppointmentId",
                table: "Appointment_Services");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "AppointmentPayments");

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
    }
}
