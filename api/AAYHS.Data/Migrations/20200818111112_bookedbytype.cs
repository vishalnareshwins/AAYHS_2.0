using Microsoft.EntityFrameworkCore.Migrations;

namespace AAYHS.Data.Migrations
{
    public partial class bookedbytype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookedBy",
                table: "StallAssignment");

            migrationBuilder.AddColumn<string>(
                name: "BookedByType",
                table: "StallAssignment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookedByType",
                table: "StallAssignment");

            migrationBuilder.AddColumn<string>(
                name: "BookedBy",
                table: "StallAssignment",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
