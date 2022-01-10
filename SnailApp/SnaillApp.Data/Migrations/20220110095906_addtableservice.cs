using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SnaillApp.Data.Migrations
{
    public partial class addtableservice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ServiceTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceTypes_Clinics_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "Clinics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Charges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServiceTypeId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_ServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceTypeId",
                table: "Services",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypes_ClinicId",
                table: "ServiceTypes",
                column: "ClinicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "ServiceTypes");

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
    }
}
