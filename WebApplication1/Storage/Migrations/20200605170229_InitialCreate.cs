using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Storage.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCountry",
                columns: table => new
                {
                    gId = table.Column<Guid>(nullable: false),
                    szName = table.Column<string>(maxLength: 50, nullable: false),
                    szComment = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCountry", x => x.gId);
                });

            migrationBuilder.CreateTable(
                name: "tblCity",
                columns: table => new
                {
                    gId = table.Column<Guid>(nullable: false),
                    szName = table.Column<string>(maxLength: 50, nullable: false),
                    szPeople = table.Column<int>(maxLength: 50, nullable: false),
                    gCountryForId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCity", x => x.gId);
                    table.ForeignKey(
                        name: "FK_tblCity_tblCountry_gCountryForId",
                        column: x => x.gCountryForId,
                        principalTable: "tblCountry",
                        principalColumn: "gId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblRestaurant",
                columns: table => new
                {
                    gId = table.Column<Guid>(nullable: false),
                    szName = table.Column<string>(maxLength: 50, nullable: false),
                    szStars = table.Column<int>(maxLength: 50, nullable: false),
                    gCityForId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRestaurant", x => x.gId);
                    table.ForeignKey(
                        name: "FK_tblRestaurant_tblCity_gCityForId",
                        column: x => x.gCityForId,
                        principalTable: "tblCity",
                        principalColumn: "gId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblVeranda",
                columns: table => new
                {
                    gId = table.Column<Guid>(nullable: false),
                    szName = table.Column<string>(maxLength: 50, nullable: false),
                    szYearTime = table.Column<string>(maxLength: 50, nullable: false),
                    gRestaurantForId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblVeranda", x => x.gId);
                    table.ForeignKey(
                        name: "FK_tblVeranda_tblRestaurant_gRestaurantForId",
                        column: x => x.gRestaurantForId,
                        principalTable: "tblRestaurant",
                        principalColumn: "gId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblMenu",
                columns: table => new
                {
                    gId = table.Column<Guid>(nullable: false),
                    szName = table.Column<string>(maxLength: 50, nullable: false),
                    szSize = table.Column<int>(maxLength: 50, nullable: false),
                    gVerandaForId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMenu", x => x.gId);
                    table.ForeignKey(
                        name: "FK_tblMenu_tblVeranda_gVerandaForId",
                        column: x => x.gVerandaForId,
                        principalTable: "tblVeranda",
                        principalColumn: "gId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblFood",
                columns: table => new
                {
                    gId = table.Column<Guid>(nullable: false),
                    szName = table.Column<string>(maxLength: 50, nullable: false),
                    szPrice = table.Column<int>(maxLength: 50, nullable: false),
                    gMenuForId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFood", x => x.gId);
                    table.ForeignKey(
                        name: "FK_tblFood_tblMenu_gMenuForId",
                        column: x => x.gMenuForId,
                        principalTable: "tblMenu",
                        principalColumn: "gId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblProduct",
                columns: table => new
                {
                    gId = table.Column<Guid>(nullable: false),
                    szName = table.Column<string>(maxLength: 50, nullable: false),
                    szTime = table.Column<int>(maxLength: 50, nullable: false),
                    gFoodForId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProduct", x => x.gId);
                    table.ForeignKey(
                        name: "FK_tblProduct_tblFood_gFoodForId",
                        column: x => x.gFoodForId,
                        principalTable: "tblFood",
                        principalColumn: "gId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblCity_gCountryForId",
                table: "tblCity",
                column: "gCountryForId");

            migrationBuilder.CreateIndex(
                name: "IX_tblFood_gMenuForId",
                table: "tblFood",
                column: "gMenuForId");

            migrationBuilder.CreateIndex(
                name: "IX_tblMenu_gVerandaForId",
                table: "tblMenu",
                column: "gVerandaForId");

            migrationBuilder.CreateIndex(
                name: "IX_tblProduct_gFoodForId",
                table: "tblProduct",
                column: "gFoodForId");

            migrationBuilder.CreateIndex(
                name: "IX_tblRestaurant_gCityForId",
                table: "tblRestaurant",
                column: "gCityForId");

            migrationBuilder.CreateIndex(
                name: "IX_tblVeranda_gRestaurantForId",
                table: "tblVeranda",
                column: "gRestaurantForId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblProduct");

            migrationBuilder.DropTable(
                name: "tblFood");

            migrationBuilder.DropTable(
                name: "tblMenu");

            migrationBuilder.DropTable(
                name: "tblVeranda");

            migrationBuilder.DropTable(
                name: "tblRestaurant");

            migrationBuilder.DropTable(
                name: "tblCity");

            migrationBuilder.DropTable(
                name: "tblCountry");
        }
    }
}
