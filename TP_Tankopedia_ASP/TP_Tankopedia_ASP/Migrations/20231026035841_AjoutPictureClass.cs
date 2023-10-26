using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_Tankopedia_ASP.Migrations
{
    public partial class AjoutPictureClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "pictureId",
                table: "Tanks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Picture",
                columns: table => new
                {
                    pictureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfAddition = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picture", x => x.pictureId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tanks_pictureId",
                table: "Tanks",
                column: "pictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tanks_Picture_pictureId",
                table: "Tanks",
                column: "pictureId",
                principalTable: "Picture",
                principalColumn: "pictureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tanks_Picture_pictureId",
                table: "Tanks");

            migrationBuilder.DropTable(
                name: "Picture");

            migrationBuilder.DropIndex(
                name: "IX_Tanks_pictureId",
                table: "Tanks");

            migrationBuilder.DropColumn(
                name: "pictureId",
                table: "Tanks");
        }
    }
}
