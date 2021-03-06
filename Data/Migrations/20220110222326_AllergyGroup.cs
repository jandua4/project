using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Data.Migrations
{
    public partial class AllergyGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodChain_Allergy_AllergyID",
                table: "FoodChain");

            migrationBuilder.DropIndex(
                name: "IX_FoodChain_AllergyID",
                table: "FoodChain");

            migrationBuilder.DropColumn(
                name: "AllergyID",
                table: "FoodChain");

            migrationBuilder.AddColumn<int>(
                name: "GroupID",
                table: "Allergy",
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

            migrationBuilder.CreateTable(
                name: "AllergyGroup",
                columns: table => new
                {
                    GroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllergyGroup", x => x.GroupID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Allergy_GroupID",
                table: "Allergy",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_AllergyFoodChain_FoodChainsFoodChainID",
                table: "AllergyFoodChain",
                column: "FoodChainsFoodChainID");

            migrationBuilder.AddForeignKey(
                name: "FK_Allergy_AllergyGroup_GroupID",
                table: "Allergy",
                column: "GroupID",
                principalTable: "AllergyGroup",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Allergy_AllergyGroup_GroupID",
                table: "Allergy");

            migrationBuilder.DropTable(
                name: "AllergyFoodChain");

            migrationBuilder.DropTable(
                name: "AllergyGroup");

            migrationBuilder.DropIndex(
                name: "IX_Allergy_GroupID",
                table: "Allergy");

            migrationBuilder.DropColumn(
                name: "GroupID",
                table: "Allergy");

            migrationBuilder.AddColumn<int>(
                name: "AllergyID",
                table: "FoodChain",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FoodChain_AllergyID",
                table: "FoodChain",
                column: "AllergyID");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodChain_Allergy_AllergyID",
                table: "FoodChain",
                column: "AllergyID",
                principalTable: "Allergy",
                principalColumn: "AllergyID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
