using Microsoft.EntityFrameworkCore.Migrations;

namespace Divers_Hotel.Data.Migrations
{
    public partial class thirdM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomSeasonals_RoomTypes_MealId",
                table: "RoomSeasonals");

            migrationBuilder.DropIndex(
                name: "IX_RoomSeasonals_MealId",
                table: "RoomSeasonals");

            migrationBuilder.DropColumn(
                name: "MealId",
                table: "RoomSeasonals");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomSeasonals_RoomTypes_RoomId",
                table: "RoomSeasonals",
                column: "RoomId",
                principalTable: "RoomTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomSeasonals_RoomTypes_RoomId",
                table: "RoomSeasonals");

            migrationBuilder.AddColumn<int>(
                name: "MealId",
                table: "RoomSeasonals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomSeasonals_MealId",
                table: "RoomSeasonals",
                column: "MealId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomSeasonals_RoomTypes_MealId",
                table: "RoomSeasonals",
                column: "MealId",
                principalTable: "RoomTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
