using Microsoft.EntityFrameworkCore.Migrations;

namespace AAYHS.Data.Migrations
{
    public partial class changesInFeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeeTypeId",
                table: "YearlyMaintainenceFee");

            migrationBuilder.DropColumn(
                name: "PostEntryFee",
                table: "YearlyMaintainenceFee");

            migrationBuilder.DropColumn(
                name: "PreEntryFee",
                table: "YearlyMaintainenceFee");

            migrationBuilder.AddColumn<string>(
                name: "FeeName",
                table: "YearlyMaintainenceFee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeeType",
                table: "YearlyMaintainenceFee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TimeFrame",
                table: "YearlyMaintainenceFee",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeeName",
                table: "YearlyMaintainenceFee");

            migrationBuilder.DropColumn(
                name: "FeeType",
                table: "YearlyMaintainenceFee");

            migrationBuilder.DropColumn(
                name: "TimeFrame",
                table: "YearlyMaintainenceFee");

            migrationBuilder.AddColumn<int>(
                name: "FeeTypeId",
                table: "YearlyMaintainenceFee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PostEntryFee",
                table: "YearlyMaintainenceFee",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PreEntryFee",
                table: "YearlyMaintainenceFee",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
