using Microsoft.EntityFrameworkCore.Migrations;

namespace AAYHS.Data.Migrations
{
    public partial class classheadertoclasshederidanddatatypestrintoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassHeader",
                table: "Classes");

            migrationBuilder.AddColumn<int>(
                name: "ClassHeaderId",
                table: "Classes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassHeaderId",
                table: "Classes");

            migrationBuilder.AddColumn<string>(
                name: "ClassHeader",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
