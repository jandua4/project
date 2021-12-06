using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Data.Migrations
{
    public partial class Rebuild : Migration
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

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "FoodChain",
                newName: "FoodChainName");

            migrationBuilder.RenameColumn(
                name: "Filename",
                table: "FoodChain",
                newName: "VegetarianOptions");

            migrationBuilder.RenameColumn(
                name: "AllergyTwo",
                table: "FoodChain",
                newName: "VeganOptions");

            migrationBuilder.RenameColumn(
                name: "AllergyThree",
                table: "FoodChain",
                newName: "NutFreeOptions");

            migrationBuilder.RenameColumn(
                name: "AllergyOne",
                table: "FoodChain",
                newName: "MenuLink");

            migrationBuilder.AddColumn<string>(
                name: "DairyFreeOptions",
                table: "FoodChain",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GlutenFreeOptions",
                table: "FoodChain",
                type: "nvarchar(max)",
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
                name: "UserAllergySelection",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GlutenFree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vegetarian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vegan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DairyFree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NutFree = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAllergySelection", x => x.ID);
                    table.ForeignKey(
                       name: "FK_User_AllergySelection_AllergyID",
                       column: x => x.UserID,
                       principalTable: "AspNetUsers",
                       principalColumn: "Id",
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

            migrationBuilder.DropTable(
                name: "UserAllergySelection");

            migrationBuilder.DropColumn(
                name: "DairyFreeOptions",
                table: "FoodChain");

            migrationBuilder.DropColumn(
                name: "GlutenFreeOptions",
                table: "FoodChain");

            migrationBuilder.RenameColumn(
                name: "VegetarianOptions",
                table: "FoodChain",
                newName: "Filename");

            migrationBuilder.RenameColumn(
                name: "VeganOptions",
                table: "FoodChain",
                newName: "AllergyTwo");

            migrationBuilder.RenameColumn(
                name: "NutFreeOptions",
                table: "FoodChain",
                newName: "AllergyThree");

            migrationBuilder.RenameColumn(
                name: "MenuLink",
                table: "FoodChain",
                newName: "AllergyOne");

            migrationBuilder.RenameColumn(
                name: "FoodChainName",
                table: "FoodChain",
                newName: "Name");

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
