using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Data.Migrations
{
    public partial class MenuLinkByte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        /*    migrationBuilder.AlterColumn<byte[]>(
                name: "MenuLink",
                table: "FoodChain",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        */
            migrationBuilder.AddColumn<byte[]>(
                name: "ColumnNameTmp",
                table: "FoodChain",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.DropColumn(
                name: "MenuLink",
                table: "FoodChain");

            migrationBuilder.RenameColumn(
                "ColumnNameTmp",
                "FoodChain",
                "MenuLink");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        /*    migrationBuilder.AlterColumn<string>(
                name: "MenuLink",
                table: "FoodChain",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);
        */    
            migrationBuilder.AddColumn<string>(
                name: "ColumnNameTmp",
                table: "FoodChain",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.DropColumn(
                name: "MenuLink",
                table: "FoodChain");

            migrationBuilder.RenameColumn(
                "ColumnNameTmp",
                "FoodChain",
                "MenuLink");

        }
    }
}
