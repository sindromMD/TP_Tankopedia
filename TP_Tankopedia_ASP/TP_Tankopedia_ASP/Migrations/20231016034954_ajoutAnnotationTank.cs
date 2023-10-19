using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_Tankopedia_ASP.Migrations
{
    public partial class ajoutAnnotationTank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tanks",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tanks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2500)",
                oldMaxLength: 2500);
        }
    }
}
