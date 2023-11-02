using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_Tankopedia_ASP.Migrations
{
    public partial class AjoutClasseUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TankUser",
                columns: table => new
                {
                    TanksId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TankUser", x => new { x.TanksId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_TankUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TankUser_Tanks_TanksId",
                        column: x => x.TanksId,
                        principalTable: "Tanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TankUser_UsersId",
                table: "TankUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "TankUser");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 12,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 13,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 14,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 15,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 16,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 17,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 18,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 19,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 20,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 21,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 22,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Picture",
                keyColumn: "pictureId",
                keyValue: 23,
                column: "DateOfAddition",
                value: new DateTime(2023, 10, 26, 13, 27, 7, 557, DateTimeKind.Local).AddTicks(8280));
        }
    }
}
