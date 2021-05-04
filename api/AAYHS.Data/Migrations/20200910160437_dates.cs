using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AAYHS.Data.Migrations
{
    public partial class dates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeFrameTypeId",
                table: "YearlyMaintainenceFee");

            migrationBuilder.DropColumn(
                name: "PostEntryFee",
                table: "YearlyMaintainence");

            migrationBuilder.DropColumn(
                name: "PreEntryFee",
                table: "YearlyMaintainence");

            migrationBuilder.AddColumn<decimal>(
                name: "PostEntryFee",
                table: "YearlyMaintainenceFee",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PreEntryFee",
                table: "YearlyMaintainenceFee",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "TimeFrameType",
                table: "YearlyMaintainenceFee",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "StallAssignment",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Exhibitors",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DocumentPath",
                table: "ExhibitorPaymentDetail",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "ExhibitorHorse",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "ExhibitorClass",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostEntryFee",
                table: "YearlyMaintainenceFee");

            migrationBuilder.DropColumn(
                name: "PreEntryFee",
                table: "YearlyMaintainenceFee");

            migrationBuilder.DropColumn(
                name: "TimeFrameType",
                table: "YearlyMaintainenceFee");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "StallAssignment");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Exhibitors");

            migrationBuilder.DropColumn(
                name: "DocumentPath",
                table: "ExhibitorPaymentDetail");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "ExhibitorHorse");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "ExhibitorClass");

            migrationBuilder.AddColumn<int>(
                name: "TimeFrameTypeId",
                table: "YearlyMaintainenceFee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PostEntryFee",
                table: "YearlyMaintainence",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PreEntryFee",
                table: "YearlyMaintainence",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
