using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SnaillApp.Data.Migrations
{
    public partial class addtableappoiment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointment_Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Charges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ServiceStatus = table.Column<bool>(type: "bit", nullable: false),
                    ServiceResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_Appointment_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountDue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    PaymentMethodNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_AppointmentPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppointmentPayments_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExaminationsResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    ExaminationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Re_Examination = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Results = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorAdvice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Examination_File = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ExaminationsResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExaminationsResults_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentPayments_AppointmentId",
                table: "AppointmentPayments",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ExaminationsResults_AppointmentId",
                table: "ExaminationsResults",
                column: "AppointmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment_Services");

            migrationBuilder.DropTable(
                name: "AppointmentPayments");

            migrationBuilder.DropTable(
                name: "ExaminationsResults");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(59), new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(61), new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(63), new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(64), new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(65), new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(67), new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(69), new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(70), new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(72), new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(73), new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(75), new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(76), new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(78), new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "AppRoleTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(79), new DateTime(2022, 1, 10, 16, 59, 4, 565, DateTimeKind.Local).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba3-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "faa79292-de11-4db8-8240-3df3573367c6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e54cb132-5889-4bdd-8f86-4fa10bb6533a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba5-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "844e9777-c2e3-427f-b88a-d38a37b054a0");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba6-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "dfdc078f-0a85-4328-bb53-251aa128d8c2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba7-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "dd20787e-fdc8-4861-ad40-498c618680e6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba8-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "dbe1267f-56d1-451d-bf45-2d3d5f3aaf5f");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba9-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "a146426c-a02c-436f-95ec-0d98d92113bf");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "228619f4-e800-4276-8a3c-4c8868f10a57", "AQAAAAEAACcQAAAAEEp4Bg9xdVxh9bN3F0awcLuhwz5PXdLooG4uicTU0qwxxr7Neovc6RjUpHvXVAaB0A==" });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3863), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3866), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3866) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3867), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "GenderTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3869), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3837), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3847), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 564, DateTimeKind.Local).AddTicks(9878), new DateTime(2022, 1, 10, 16, 59, 4, 564, DateTimeKind.Local).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 564, DateTimeKind.Local).AddTicks(9889), new DateTime(2022, 1, 10, 16, 59, 4, 564, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4246), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4247) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4248), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4249), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4250), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4252), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4253), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4254), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4255), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4255) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4256), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4257), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4258), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4260), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4261), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4262), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4263), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4264), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4265), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4266), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4267), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4268), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4270), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4271), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4272), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4273), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4274), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4276), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4277), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4281), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4282), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4284), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4285), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4286), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4287), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4289), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4290), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4291), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4292), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4293), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4294), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4295), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4296), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4298), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4299), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4300), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4301), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4302), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4304), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4305), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4306), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4307), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4309), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4310), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4311), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4312), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4313), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4314), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4315), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4316), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4318), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4319), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4320), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4321), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4322), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4323), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4324), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4326), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4326) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4327), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4329), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4331), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4332), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4333), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4333) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4334), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4335), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4336), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4338), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4339), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4340), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4341), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4341) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4342), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4343), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4344), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4346), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4347), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4351), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4352), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4353), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4354), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4356), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4357), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4358), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4359), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4360), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4362), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4363) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4363), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4365), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4366), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4367), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4368), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4369), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4370), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4371), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4374), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4375), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4375) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4376), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4377), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4378), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4379), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4381), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4382), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4384), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4385), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4386), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4387), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4388), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4389), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4390), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4392), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4393), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4394), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4395), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4396), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4397), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4398), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4399), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4400), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4402), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4402) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4403), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4404), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4406), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4407), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4407) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4408), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4409), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4410), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4411) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4411), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4412) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4413), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4414), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4415), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4416), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4417), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4421), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4422), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4423) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4424), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4425), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4426), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4427), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4428), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4429), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4430), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4431), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4433), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4435), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4436), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4437), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4438), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4441), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4443), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4444), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4446), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4447), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4448), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4450), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4451), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4452), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4453), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4454), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4455), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4456), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4458), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4458) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4459), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4461), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4461) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4462), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4463), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4464), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4464) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4465), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4466), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4467), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4469), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4470), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4471), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4472), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4473), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4474), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4475), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4476), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4478), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4479), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4480), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4481) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4482), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4483), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4484), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4486), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4487), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4487) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4488), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4488) });

            migrationBuilder.UpdateData(
                table: "MenuAppRoles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4489), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4036), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4037), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4039), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4040), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4041), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4042), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4044), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4045), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4047), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4048), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4049), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4050), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4052), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4053), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4055), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4056), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4060), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4062), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4063), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4064), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4066), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4067), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4068), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4070), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4071), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4072), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4073) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4074), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4075), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4076) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4076), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4078), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4079), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4079) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4080), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4081), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4083), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4084), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4085), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4086), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4087) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4088), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4090), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4091), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4092), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4093), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4094), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4096), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4097), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4098), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4100), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4101), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4102), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4104), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4105), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4106), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4107), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4109), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4110), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4111), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4112), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4114), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4115), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4116), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4117), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4118), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4120), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4122), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4122) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4123), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4124), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4125), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4127), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4127) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4128), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4129), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4131), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4131) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4132), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4133), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4134), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4136), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4136) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4137), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4139), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4140), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4141), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4142), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4146), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4148), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4149), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4150), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4151), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4153), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4154), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4156), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4157), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4158), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4160), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4161), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4162), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4163), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4165), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4166), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4167), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4168), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4170), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4171), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4172), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4173), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4175), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4176), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4178), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4179), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4180), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4181), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4183), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4184), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4185), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4187), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4189), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4190), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4192), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4193), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4194), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4195), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4196), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4198), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4199), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4200), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4201), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4203), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4204), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4205), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4206), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4208), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4209), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "MenuTranslations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4210), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3898), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3898) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3900), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3902), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3904), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3905), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3907), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3908), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3910), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3911), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3912) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3914), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3915), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3916) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3917), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3918), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3921), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3923), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3923) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3924), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3926), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3927), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3929), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3930), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3931), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3932) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3933), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3934), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3936), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3937), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3939), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3940), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3942), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3943), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3945), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3947), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3948), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3950), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3951), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3952), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3954), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3955), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3957), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3958), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3960), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3961), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3962) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3963), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3964), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3966), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3968), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3969), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3971), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3973), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3974), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3979), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3981), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3981) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3982), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3984), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3985), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3987), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3988), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3989), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3991), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3992), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3994), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3996), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3997), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3999), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(3999) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4000), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4002), new DateTime(2022, 1, 10, 16, 59, 4, 571, DateTimeKind.Local).AddTicks(4002) });
        }
    }
}
