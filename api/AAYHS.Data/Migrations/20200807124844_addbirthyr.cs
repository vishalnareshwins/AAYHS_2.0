using Microsoft.EntityFrameworkCore.Migrations;

namespace AAYHS.Data.Migrations
{
    public partial class addbirthyr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthYears",
                table: "Exhibitors");

            migrationBuilder.AddColumn<int>(
                name: "BirthYear",
                table: "Exhibitors",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthYear",
                table: "Exhibitors");

            migrationBuilder.AddColumn<int>(
                name: "BirthYears",
                table: "Exhibitors",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
