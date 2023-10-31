using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_Tankopedia_ASP.Migrations
{
    public partial class usersDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c913f9e-1fad-4a08-81ba-505fc006a08e", "bde0b98f-a359-4685-b8c9-6393a8df6047", "TankCommander", "TANKCOMMANDER" },
                    { "40e70e4c-4b65-417b-a26f-317a2e99c93e", "ddf60701-902e-4fdb-890e-7f954a661bb3", "Admin", "ADMIN" },
                    { "4fb20c39-8ae1-4e27-80f8-01bbb0c311c5", "becafbe8-0f2d-468a-83a7-defb9ac7cf18", "Visitor", "VISITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5ee110b5-3ca6-462f-8bde-886d1c6e827d", 0, "b45a4044-29dd-422c-af6b-351759e086d5", "commander@tankopedia.ca", false, false, null, "COMMANDER@TANKOPEDIA.COM", "COMMANDER", "AQAAAAEAACcQAAAAEI+IWdzBrr21AXgRyBvUofrW+MXq2soMRvOFtoFR8nIS4jzUy/IqJFq2sLQaX+w6Rw==", null, false, "92224d65-000e-4f96-85a3-4b0c0fec5abd", false, "Commander" },
                    { "a3b02db3-a70c-4cad-8940-84bb4b37ed30", 0, "068c48f0-b03a-4826-bcbf-a1662780071a", "admin@tankopedia.ca", false, false, null, "ADMIN@TANKOPEDIA.COM", "ADMIN", "AQAAAAEAACcQAAAAECPrXqnmTU6XvqZn3Z6M709VEC337RPK3oaE+LTY8pKXvlRL18bz9YT8Y9frICigug==", null, false, "c00c401c-e006-4b18-8c87-e4723e475311", false, "Admin" },
                    { "f6c880eb-13ba-49c7-a763-79f9d3bff5b1", 0, "89888b5b-75ec-4fae-9526-a27b9a578a19", "visitor@tankopedia.ca", false, false, null, "VISITOR@TANKOPEDIA.COM", "VISITOR", "AQAAAAEAACcQAAAAEJ5/Qafq4hy3nbN/Us4I9Kc/P8P4lzDBn/5Gqrohr/UsgpyD0L23ioWPaWKqnkFOZw==", null, false, "c7aee4da-6033-4f2a-a0d7-8667f052c260", false, "Visitor" }
                });

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 1,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 817, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 2,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 817, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 3,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 817, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 4,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 817, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 5,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 817, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 6,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 817, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 7,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 817, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 8,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 817, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 9,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 817, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 10,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 817, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 11,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 817, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 12,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 817, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 13,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 817, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 14,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 817, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 15,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 817, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 16,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 818, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 17,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 818, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 18,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 818, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 19,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 818, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 20,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 818, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 21,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 818, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 22,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 818, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 23,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 31, 13, 40, 8, 818, DateTimeKind.Local).AddTicks(17));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c913f9e-1fad-4a08-81ba-505fc006a08e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40e70e4c-4b65-417b-a26f-317a2e99c93e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fb20c39-8ae1-4e27-80f8-01bbb0c311c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ee110b5-3ca6-462f-8bde-886d1c6e827d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3b02db3-a70c-4cad-8940-84bb4b37ed30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6c880eb-13ba-49c7-a763-79f9d3bff5b1");

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
    }
}
