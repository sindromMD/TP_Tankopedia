using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_Tankopedia_ASP.Migrations
{
    public partial class ajoutUserAdmiRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "61385cd5-a6a8-47c5-a45b-db069c418f38", "bdb814cd-6947-45c0-88a9-c6723808c044", "TankCommander", "TANKCOMMANDER" },
                    { "784abbae-5b82-4016-a36a-5670c00024a6", "acc65e8d-00d3-48dc-8811-3e948d1bc007", "Admin", "ADMIN" },
                    { "d0481012-0d52-45b5-8671-c1e42d60b184", "689e9269-e002-4751-bf3d-7b0b092e71aa", "Visitor", "VISITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "14515123-1066-8113-4317-561132168147", 0, "8eba0517-6975-4ed3-affb-48bb922f25f1", "admin@tankopedia.ca", false, false, null, "ADMIN@TANKOPEDIA.COM", "ADMIN", "AQAAAAEAACcQAAAAEI5RMj79jQHbmbNVCb9qOpgauBPxqMkDvP1J6v4UckKbJ+4XpieFpAQcsXtCLu2zzw==", null, false, "e525b986-6e99-453a-927d-bfd071373e8e", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 1,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 2,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 3,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 4,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 5,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 6,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 7,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 8,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 9,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 10,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 11,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 12,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 13,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 14,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 15,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 16,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 17,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 18,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 19,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 20,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 21,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 22,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 23,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 30, 2, 44, 5, 909, DateTimeKind.Local).AddTicks(275));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61385cd5-a6a8-47c5-a45b-db069c418f38");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "784abbae-5b82-4016-a36a-5670c00024a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0481012-0d52-45b5-8671-c1e42d60b184");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14515123-1066-8113-4317-561132168147");

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 1,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 2,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 3,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 4,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 5,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 6,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 7,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 8,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 9,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 10,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 11,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 12,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 13,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 14,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 15,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 16,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 17,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 18,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 19,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 20,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 21,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 22,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 23,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 28, 18, 16, 15, 1, DateTimeKind.Local).AddTicks(4596));
        }
    }
}
