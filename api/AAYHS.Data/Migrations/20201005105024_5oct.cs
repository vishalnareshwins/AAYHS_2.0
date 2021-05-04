using Microsoft.EntityFrameworkCore.Migrations;

namespace AAYHS.Data.Migrations
{
    public partial class _5oct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StreetReturnAddressId",
                table: "AAYHSContact");

            migrationBuilder.AddColumn<int>(
                name: "ExhibitorConfirmationEntriesAddressId",
                table: "AAYHSContact",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExhibitorSponsorConfirmationAddressId",
                table: "AAYHSContact",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExhibitorSponsorRefundStatementAddressId",
                table: "AAYHSContact",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExhibitorConfirmationEntriesAddressId",
                table: "AAYHSContact");

            migrationBuilder.DropColumn(
                name: "ExhibitorSponsorConfirmationAddressId",
                table: "AAYHSContact");

            migrationBuilder.DropColumn(
                name: "ExhibitorSponsorRefundStatementAddressId",
                table: "AAYHSContact");

            migrationBuilder.AddColumn<int>(
                name: "StreetReturnAddressId",
                table: "AAYHSContact",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
