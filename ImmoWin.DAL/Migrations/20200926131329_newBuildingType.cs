using Microsoft.EntityFrameworkCore.Migrations;

namespace ImmoWin.DAL.Migrations
{
    public partial class newBuildingType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 4,
                column: "City",
                value: "Mechelen");

            migrationBuilder.InsertData(
                table: "BuildingTypes",
                columns: new[] { "BuildingTypeId", "Name", "Type" },
                values: new object[] { 5, "Appartement", "Loft" });

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 3,
                column: "BuildingTypeId",
                value: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BuildingTypes",
                keyColumn: "BuildingTypeId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 4,
                column: "City",
                value: "Genk");

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "BuildingId", "AddressId", "BuildingTypeId", "Price" },
                values: new object[] { 3, 3, 1, 500000 });
        }
    }
}
