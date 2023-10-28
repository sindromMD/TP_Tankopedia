using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_Tankopedia_ASP.Migrations
{
    public partial class dataSeedTanksPicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 1,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 2,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 3,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 4,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 5,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 6,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 7,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 8,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 9,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 10,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 11,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.InsertData(
                table: "Picture",
                columns: new[] { "pictureId", "DateOfAddition", "FileName", "MimeType" },
                values: new object[,]
                {
                    { 12, new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8217), "0cdd4032-0352-4254-9161-5d8f5fc33287.png", "image/png" },
                    { 13, new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8219), "b6f2b7c6-1914-4ecf-8271-791089c22b1c.png", "image/png" },
                    { 14, new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8222), "0a66050b-617b-426d-8d01-1cfdc53f6a9c.png", "image/png" },
                    { 15, new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8224), "9e04a735-2cdf-4151-81aa-f9319e5ab21a.png", "image/png" },
                    { 16, new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8264), "f90f830b-0acb-4ae3-8bfe-aee7622be9a5.png", "image/png" },
                    { 17, new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8266), "333249ff-b0a1-479b-a988-89caa173e1dc.png", "image/png" },
                    { 18, new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8268), "564e8122-f919-4b3e-a248-c5f572be4b60.png", "image/png" },
                    { 19, new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8271), "5ff17622-d961-432c-be99-66a58024a72f.png", "image/png" },
                    { 20, new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8273), "c721c906-08a7-4f73-af0d-fbf4984ad193.png", "image/png" },
                    { 21, new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8275), "4136038d-1213-4646-8d74-4bd152fa0e93.png", "image/png" },
                    { 22, new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8277), "590fbeff-440c-44c7-ac82-cdd8b879be67.png", "image/png" },
                    { 23, new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8280), "152499c3-41c5-460f-92e0-330b4462895e.png", "image/png" }
                });

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 1,
                column: "pictureId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 2,
                column: "pictureId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 3,
                column: "pictureId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 4,
                column: "pictureId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 5,
                column: "pictureId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 6,
                column: "pictureId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 7,
                column: "pictureId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 8,
                column: "pictureId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 9,
                column: "pictureId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 10,
                column: "pictureId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 11,
                column: "pictureId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 12,
                column: "pictureId",
                value: 23);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 23);

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 1,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 2,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 3,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 4,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 5,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 6,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 7,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 8,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 9,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 10,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 11,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 2, 21, 15, 887, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 1,
                column: "pictureId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 2,
                column: "pictureId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 3,
                column: "pictureId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 4,
                column: "pictureId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 5,
                column: "pictureId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 6,
                column: "pictureId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 7,
                column: "pictureId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 8,
                column: "pictureId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 9,
                column: "pictureId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 10,
                column: "pictureId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 11,
                column: "pictureId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 12,
                column: "pictureId",
                value: null);
        }
    }
}
