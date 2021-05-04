using Microsoft.EntityFrameworkCore.Migrations;

namespace AAYHS.Data.Migrations
{
    public partial class zipcodeid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZipCode",
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

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
