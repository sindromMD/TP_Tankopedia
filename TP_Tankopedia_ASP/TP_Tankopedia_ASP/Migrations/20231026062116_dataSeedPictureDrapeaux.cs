using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_Tankopedia_ASP.Migrations
{
    public partial class dataSeedPictureDrapeaux : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "pictureId",
                table: "Nations",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Picture",
                columns: new[] { "pictureId", "DateOfAddition", "FileName", "MimeType" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8878), "9bdcc69e-9b0a-4aaf-b79a-8c8e5537f4b5.png", "image/png" },
                    { 2, new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8914), "984bf917-4720-4011-8d12-854f1015a33f.png", "image/png" },
                    { 3, new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8917), "253a6bfd-ccbb-4296-bff3-b655b6599ebd.png", "image/png" },
                    { 4, new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8919), "8737e698-b5da-4aef-b0dc-55d8eccaf61d.png", "image/png" },
                    { 5, new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8921), "7a1e115a-b107-4637-b2c0-1e1a86ffed7d.png", "image/png" },
                    { 6, new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8924), "fe0afbdf-9fb4-4fd8-b09a-7977dbd77bc0.png", "image/png" },
                    { 7, new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8926), "00c84d4d-a645-44f2-8b1a-eabf0e3c62d4.png", "image/png" },
                    { 8, new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8928), "c5d1102f-34bd-46a0-9e6a-ab2544cb9621.png", "image/png" },
                    { 9, new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8930), "b360c5ac-dc5e-4310-a833-15a0af7a1929.png", "image/png" },
                    { 10, new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8932), "5a428329-03db-458b-b882-5192fbd9ebe9.png", "image/png" },
                    { 11, new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8935), "8876fef9-7f61-4f1b-b2ed-aa1c03a7eb23.png", "image/png" }
                });

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 1,
                column: "pictureId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 2,
                column: "pictureId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 3,
                column: "pictureId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 4,
                column: "pictureId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 5,
                column: "pictureId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 6,
                column: "pictureId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 7,
                column: "pictureId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 8,
                column: "pictureId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 9,
                column: "pictureId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 10,
                column: "pictureId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 11,
                column: "pictureId",
                value: 11);

            migrationBuilder.CreateIndex(
                name: "IX_Nations_pictureId",
                table: "Nations",
                column: "pictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nations_Picture_pictureId",
                table: "Nations",
                column: "pictureId",
                principalTable: "Picture",
                principalColumn: "pictureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nations_Picture_pictureId",
                table: "Nations");

            migrationBuilder.DropIndex(
                name: "IX_Nations_pictureId",
                table: "Nations");

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 11);

            migrationBuilder.DropColumn(
                name: "pictureId",
                table: "Nations");
        }
    }
}
