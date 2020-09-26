using Microsoft.EntityFrameworkCore.Migrations;

namespace ImmoWin.DAL.Migrations
{
    public partial class Correction_BuildingTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "BuildingTypes",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 4,
                column: "Street",
                value: "OpStraat");

            migrationBuilder.UpdateData(
                table: "BuildingTypes",
                keyColumn: "BuildingTypeId",
                keyValue: 1,
                column: "Type",
                value: "Studio");

            migrationBuilder.UpdateData(
                table: "BuildingTypes",
                keyColumn: "BuildingTypeId",
                keyValue: 2,
                column: "Type",
                value: "Rijhuis");

            migrationBuilder.UpdateData(
                table: "BuildingTypes",
                keyColumn: "BuildingTypeId",
                keyValue: 3,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Huis", "Alleenstaand Huis" });

            migrationBuilder.UpdateData(
                table: "BuildingTypes",
                keyColumn: "BuildingTypeId",
                keyValue: 4,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Huis", "Villa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "BuildingTypes");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 4,
                column: "Street",
                value: "Mechelen");

            migrationBuilder.UpdateData(
                table: "BuildingTypes",
                keyColumn: "BuildingTypeId",
                keyValue: 3,
                column: "Name",
                value: "Rijhuis");

            migrationBuilder.UpdateData(
                table: "BuildingTypes",
                keyColumn: "BuildingTypeId",
                keyValue: 4,
                column: "Name",
                value: "3-Gevel");
        }
    }
}
