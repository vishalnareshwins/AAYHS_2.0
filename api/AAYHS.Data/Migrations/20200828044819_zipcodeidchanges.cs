using Microsoft.EntityFrameworkCore.Migrations;

namespace AAYHS.Data.Migrations
{
    public partial class zipcodeidchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZipCodes",
                table: "Addresses");

            migrationBuilder.AddColumn<int>(
                name: "ZipCodeId",
                table: "Addresses",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZipCodeId",
                table: "Addresses");

            migrationBuilder.AddColumn<int>(
                name: "ZipCodes",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
