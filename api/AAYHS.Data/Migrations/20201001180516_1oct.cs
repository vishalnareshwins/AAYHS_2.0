using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AAYHS.Data.Migrations
{
    public partial class _1oct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckNumber",
                table: "RefundDetail");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "RefundDetail");

            migrationBuilder.DropColumn(
                name: "ExhibitorId",
                table: "RefundDetail");

            migrationBuilder.DropColumn(
                name: "RefundAmount",
                table: "RefundDetail");

            migrationBuilder.DropColumn(
                name: "RefundTypeId",
                table: "RefundDetail");

            migrationBuilder.DropColumn(
                name: "TotalPaid",
                table: "RefundDetail");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAfter",
                table: "RefundDetail",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateBefore",
                table: "RefundDetail",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "FeeTypeId",
                table: "RefundDetail",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearlyMaintenanceId",
                table: "RefundDetail",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAfter",
                table: "RefundDetail");

            migrationBuilder.DropColumn(
                name: "DateBefore",
                table: "RefundDetail");

            migrationBuilder.DropColumn(
                name: "FeeTypeId",
                table: "RefundDetail");

            migrationBuilder.DropColumn(
                name: "YearlyMaintenanceId",
                table: "RefundDetail");

            migrationBuilder.AddColumn<string>(
                name: "CheckNumber",
                table: "RefundDetail",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "RefundDetail",
                type: "varchar(500)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExhibitorId",
                table: "RefundDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "RefundAmount",
                table: "RefundDetail",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "RefundTypeId",
                table: "RefundDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPaid",
                table: "RefundDetail",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
