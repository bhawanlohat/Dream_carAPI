using Microsoft.EntityFrameworkCore.Migrations;

namespace Dream_carAPI.Migrations
{
    public partial class Car_obj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model_Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fuel_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transmission = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");
        }
    }
}
