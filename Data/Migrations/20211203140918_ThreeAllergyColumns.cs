using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Data.Migrations
{
    public partial class ThreeAllergyColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Allergy_FoodChain_FoodChainID",
                table: "Allergy");

            migrationBuilder.DropIndex(
                name: "IX_Allergy_FoodChainID",
                table: "Allergy");

            migrationBuilder.DropColumn(
                name: "FoodChainID",
                table: "Allergy");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "FoodChain",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "FoodChain",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AllergyID",
                table: "FoodChain",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AllergyOne",
                table: "FoodChain",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AllergyThree",
                table: "FoodChain",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AllergyTwo",
                table: "FoodChain",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Allergy",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "AllergyOne",
                table: "FoodChain");

            migrationBuilder.DropColumn(
                name: "AllergyThree",
                table: "FoodChain");

            migrationBuilder.DropColumn(
                name: "AllergyTwo",
                table: "FoodChain");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "FoodChain",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "FoodChain",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Allergy",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "FoodChainID",
                table: "Allergy",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Allergy_FoodChainID",
                table: "Allergy",
                column: "FoodChainID");

            migrationBuilder.AddForeignKey(
                name: "FK_Allergy_FoodChain_FoodChainID",
                table: "Allergy",
                column: "FoodChainID",
                principalTable: "FoodChain",
                principalColumn: "FoodChainID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
