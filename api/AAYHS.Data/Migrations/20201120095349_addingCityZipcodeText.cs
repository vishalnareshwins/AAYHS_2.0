using Microsoft.EntityFrameworkCore.Migrations;

namespace AAYHS.Data.Migrations
{
    public partial class addingCityZipcodeText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StateId",
                table: "Addresses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Addresses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Addresses");
        }
    }
}
