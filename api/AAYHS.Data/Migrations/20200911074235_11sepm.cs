using Microsoft.EntityFrameworkCore.Migrations;

namespace AAYHS.Data.Migrations
{
    public partial class _11sepm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeFrameType",
                table: "YearlyMaintainenceFee");

            migrationBuilder.DropColumn(
                name: "TimeFrameTypeId",
                table: "ExhibitorPaymentDetail");

            migrationBuilder.AddColumn<decimal>(
                name: "RefundPercentage",
                table: "YearlyMaintainenceFee",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "DocumentPath",
                table: "Scans",
                type: "varchar(5000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DocumentPath",
                table: "ExhibitorPaymentDetail",
                type: "varchar(5000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AmountPaid",
                table: "ExhibitorPaymentDetail",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "RefundAmount",
                table: "ExhibitorPaymentDetail",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "TimeFrameType",
                table: "ExhibitorPaymentDetail",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefundPercentage",
                table: "YearlyMaintainenceFee");

            migrationBuilder.DropColumn(
                name: "AmountPaid",
                table: "ExhibitorPaymentDetail");

            migrationBuilder.DropColumn(
                name: "RefundAmount",
                table: "ExhibitorPaymentDetail");

            migrationBuilder.DropColumn(
                name: "TimeFrameType",
                table: "ExhibitorPaymentDetail");

            migrationBuilder.AddColumn<string>(
                name: "TimeFrameType",
                table: "YearlyMaintainenceFee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DocumentPath",
                table: "Scans",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(5000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DocumentPath",
                table: "ExhibitorPaymentDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(5000)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimeFrameTypeId",
                table: "ExhibitorPaymentDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
