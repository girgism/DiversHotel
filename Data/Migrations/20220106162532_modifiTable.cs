using Microsoft.EntityFrameworkCore.Migrations;

namespace Divers_Hotel.Data.Migrations
{
    public partial class modifiTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_MealTypes_MealTypeID",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Seasons_MealId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_MealTypeID",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "MealTypeID",
                table: "Reservations");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_MealTypes_MealId",
                table: "Reservations",
                column: "MealId",
                principalTable: "MealTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_MealTypes_MealId",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "MealTypeID",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_MealTypeID",
                table: "Reservations",
                column: "MealTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_MealTypes_MealTypeID",
                table: "Reservations",
                column: "MealTypeID",
                principalTable: "MealTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Seasons_MealId",
                table: "Reservations",
                column: "MealId",
                principalTable: "Seasons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
