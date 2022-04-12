using Microsoft.EntityFrameworkCore.Migrations;

namespace RebelTours.Persistence.Migrations
{
    public partial class BusClassAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusModelId = table.Column<int>(type: "int", nullable: false),
                    RegistrationPlate = table.Column<string>(type: "varchar(50)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    SeatMapping = table.Column<int>(type: "int", nullable: false),
                    DistanceTraveled = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Buses_BusModels_BusModelId",
                        column: x => x.BusModelId,
                        principalTable: "BusModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buses_BusModelId",
                table: "Buses",
                column: "BusModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buses");
        }
    }
}
