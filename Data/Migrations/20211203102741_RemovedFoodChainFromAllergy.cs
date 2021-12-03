using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Data.Migrations
{
    public partial class RemovedFoodChainFromAllergy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Allergy_FoodChain_FoodChainID",
                table: "Allergy");

            migrationBuilder.AddForeignKey(
                name: "FK_Allergy_FoodChain_FoodChainID",
                table: "Allergy",
                column: "FoodChainID",
                principalTable: "FoodChain",
                principalColumn: "FoodChainID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Allergy_FoodChain_FoodChainID",
                table: "Allergy");

            migrationBuilder.AddForeignKey(
                name: "FK_Allergy_FoodChain_FoodChainID",
                table: "Allergy",
                column: "FoodChainID",
                principalTable: "FoodChain",
                principalColumn: "FoodChainID");
        }
    }
}
