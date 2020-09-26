using Microsoft.EntityFrameworkCore.Migrations;

namespace ImmoWin.DAL.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(nullable: true),
                    HouseNumber = table.Column<int>(nullable: false),
                    Floor = table.Column<int>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Zipcode = table.Column<int>(nullable: false),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "BuildingTypes",
                columns: table => new
                {
                    BuildingTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingTypes", x => x.BuildingTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    BuildingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    BuildingTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.BuildingId);
                    table.ForeignKey(
                        name: "FK_Buildings_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Buildings_BuildingTypes_BuildingTypeId",
                        column: x => x.BuildingTypeId,
                        principalTable: "BuildingTypes",
                        principalColumn: "BuildingTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "City", "Country", "Floor", "HouseNumber", "Street", "Zipcode" },
                values: new object[,]
                {
                    { 1, "Genk", "Belgium", null, 12, "NeerStraat", 3000 },
                    { 2, "Antwerpen", "Belgium", null, 32, "ZijStraat", 4510 },
                    { 3, "Mechelen", "Belgium", 1, 5, "OpStraat", 2000 },
                    { 4, "Genk", "Belgium", 2, 5, "Mechelen", 2000 }
                });

            migrationBuilder.InsertData(
                table: "BuildingTypes",
                columns: new[] { "BuildingTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Appartement" },
                    { 2, "Huis" },
                    { 3, "Rijhuis" },
                    { 4, "3-Gevel" }
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "BuildingId", "AddressId", "BuildingTypeId", "Price" },
                values: new object[,]
                {
                    { 3, 3, 1, 500000 },
                    { 4, 4, 1, 250000 },
                    { 1, 1, 2, 100000 },
                    { 2, 2, 3, 756000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_AddressId",
                table: "Buildings",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_BuildingTypeId",
                table: "Buildings",
                column: "BuildingTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "BuildingTypes");
        }
    }
}
