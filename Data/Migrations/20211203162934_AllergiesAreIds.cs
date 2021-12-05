using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Data.Migrations
{
    public partial class AllergiesAreIds : Migration
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

            migrationBuilder.AlterColumn<int>(
                name: "AllergyTwo",
                table: "FoodChain",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AllergyThree",
                table: "FoodChain",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AllergyOne",
                table: "FoodChain",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                name: "IX_AllergyFoodChain_FoodChainsFoodChainID",
                table: "AllergyFoodChain",
                column: "FoodChainsFoodChainID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllergyFoodChain");

            migrationBuilder.AlterColumn<string>(
                name: "AllergyTwo",
                table: "FoodChain",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AllergyThree",
                table: "FoodChain",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AllergyOne",
                table: "FoodChain",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
