using Microsoft.EntityFrameworkCore.Migrations;

namespace AAYHS.Data.Migrations
{
    public partial class exhibitorsponsorchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HorseId",
                table: "SponsorExhibitor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "SponsorAmount",
                table: "SponsorExhibitor",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HorseId",
                table: "SponsorExhibitor");

            migrationBuilder.DropColumn(
                name: "SponsorAmount",
                table: "SponsorExhibitor");
        }
    }
}
