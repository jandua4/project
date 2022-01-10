using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Data.Migrations
{
    public partial class SetNullConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Allergy_AllergyGroup_GroupID",
                table: "Allergy");

            migrationBuilder.AddForeignKey(
                name: "FK_Allergy_AllergyGroup_GroupID",
                table: "Allergy",
                column: "GroupID",
                principalTable: "AllergyGroup",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Allergy_AllergyGroup_GroupID",
                table: "Allergy");

            migrationBuilder.AddForeignKey(
                name: "FK_Allergy_AllergyGroup_GroupID",
                table: "Allergy",
                column: "GroupID",
                principalTable: "AllergyGroup",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
