using Microsoft.EntityFrameworkCore.Migrations;

namespace Divers_Hotel.Data.Migrations
{
    public partial class defaultPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "RoomPrice",
                table: "RoomTypes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MealPrice",
                table: "MealTypes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomPrice",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "MealPrice",
                table: "MealTypes");
        }
    }
}
