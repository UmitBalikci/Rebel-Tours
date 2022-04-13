using Microsoft.EntityFrameworkCore.Migrations;

namespace RebelTours.Persistence.Migrations
{
    public partial class BusClassAddedHasData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "Year",
                table: "Buses",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Buses",
                columns: new[] { "Id", "BusModelId", "DistanceTraveled", "RegistrationPlate", "SeatMapping", "Year" },
                values: new object[,]
                {
                    { 1, 1, 500, "34RTE61", 1, (short)2002 },
                    { 2, 2, 500, "34BTN25", 1, (short)2001 },
                    { 3, 3, 500, "34CZN53", 1, (short)1999 },
                    { 4, 4, 500, "34ASD98", 1, (short)1994 },
                    { 5, 5, 500, "34NSR54", 1, (short)1998 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "Buses",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");
        }
    }
}
