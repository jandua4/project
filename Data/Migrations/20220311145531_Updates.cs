using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Data.Migrations
{
    public partial class Updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "AllergyFoodChain");


            migrationBuilder.DropColumn(
                name: "FoodChainID",
                table: "AllergyGroup");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FoodChainID",
                table: "AllergyGroup",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AllergyFoodChain",
                columns: table => new
                {
                    AllergiesAllergyID = table.Column<int>(type: "int", nullable: false),
                    FoodChainsFoodChainID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllergyFoodChain", x => new { x.AllergiesAllergyID, x.FoodChainsFoodChainID });
                    table.ForeignKey(
                        name: "FK_AllergyFoodChain_Allergy_AllergiesAllergyID",
                        column: x => x.AllergiesAllergyID,
                        principalTable: "Allergy",
                        principalColumn: "AllergyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AllergyFoodChain_FoodChain_FoodChainsFoodChainID",
                        column: x => x.FoodChainsFoodChainID,
                        principalTable: "FoodChain",
                        principalColumn: "FoodChainID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllergyGroup_FoodChainID",
                table: "AllergyGroup",
                column: "FoodChainID");

            migrationBuilder.CreateIndex(
                name: "IX_AllergyFoodChain_FoodChainsFoodChainID",
                table: "AllergyFoodChain",
                column: "FoodChainsFoodChainID");

            migrationBuilder.AddForeignKey(
                name: "FK_AllergyGroup_FoodChain_FoodChainID",
                table: "AllergyGroup",
                column: "FoodChainID",
                principalTable: "FoodChain",
                principalColumn: "FoodChainID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
