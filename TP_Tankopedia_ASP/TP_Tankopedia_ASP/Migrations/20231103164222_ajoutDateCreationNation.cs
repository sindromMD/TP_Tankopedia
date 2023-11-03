using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_Tankopedia_ASP.Migrations
{
    public partial class ajoutDateCreationNation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Nations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "Nations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6d0a6c16-083b-4784-8ccd-ed1ba660e0e9", "3c28fd19-d14c-447a-a44f-454712d84875", "TankCommander", "TANKCOMMANDER" },
                    { "78f7a581-51dc-47f0-bffb-bb179271daaa", "474e485f-19d1-486f-94ab-5c4479a5f812", "Admin", "ADMIN" },
                    { "d08aefa0-f6f5-4b24-986d-db4ad9639eee", "faa08b41-42b5-4c3f-858f-d5e8247d4550", "Visitor", "VISITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "50ba7c4f-3442-4bd1-98a7-65b0f6656a3b", 0, "0fd44817-853a-4e5e-8e2b-c8018a89a72e", "visitor@tankopedia.ca", false, false, null, "VISITOR@TANKOPEDIA.COM", "VISITOR", "AQAAAAEAACcQAAAAEBU/CYqH4SIHUpi68ShIgo2FCxmzvud3E1f2pciVttcRSTnAiSR+v6TNbvhXuNUx1g==", null, false, "9dda51f7-a02a-4b0f-9357-c9e7e44feab8", false, "Visitor" },
                    { "8648f615-57f2-43ce-8fde-d100adfd2a0c", 0, "91125833-194a-487b-b099-f26c121c84df", "commander@tankopedia.ca", false, false, null, "COMMANDER@TANKOPEDIA.COM", "COMMANDER", "AQAAAAEAACcQAAAAELYVXxGK8Rw4KHj83eJfpFU2ClZ2j4nE3s6EVAbw3Hlvgb97wZlplVaffH+FnySc9w==", null, false, "9d6fe1e6-fff7-4a9c-b181-e7430b398d05", false, "Commander" },
                    { "9ba62270-5075-477e-9cb7-63322bbb7e47", 0, "9738ee54-7e2f-4b63-9d58-43de7ded6119", "admin@tankopedia.ca", false, false, null, "ADMIN@TANKOPEDIA.COM", "ADMIN", "AQAAAAEAACcQAAAAEL/eEGxgGLzEqJqLXCU/gUdPSYnIoXn6qzVM7+4jv2Eu4uGB46Mkt7B4K74ZaPEWcQ==", null, false, "cbd94eb3-5446-4424-9482-cfc82b048937", false, "Admin" }
                });

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 1,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 2,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 3,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 4,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 5,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 6,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 7,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 8,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 9,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 10,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 11,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 12,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 13,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 14,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 15,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 16,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 17,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 18,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 19,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 20,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 21,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 22,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 23,
                column: "DateOfAddition",
                value: new DateTime(2023, 11, 3, 12, 42, 21, 925, DateTimeKind.Local).AddTicks(2048));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d0a6c16-083b-4784-8ccd-ed1ba660e0e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78f7a581-51dc-47f0-bffb-bb179271daaa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d08aefa0-f6f5-4b24-986d-db4ad9639eee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50ba7c4f-3442-4bd1-98a7-65b0f6656a3b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8648f615-57f2-43ce-8fde-d100adfd2a0c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ba62270-5075-477e-9cb7-63322bbb7e47");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Nations");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Nations");

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
    }
}
