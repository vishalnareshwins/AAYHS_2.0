using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AAYHS.Data.Migrations
{
    public partial class newIncentiveTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "YearlyMaintainence");

            migrationBuilder.DropColumn(
                name: "LocationAddressId",
                table: "YearlyMaintainence");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "YearlyMaintainence");

            migrationBuilder.AlterColumn<string>(
                name: "StatementText",
                table: "YearlyStatementText",
                type: "varchar(5000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Incentive",
                table: "YearlyStatementText",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AAYHSContact",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AAYHSContact",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "AAYHSContact",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "AAYHSContact",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "AAYHSContact",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SponsorIncentives",
                columns: table => new
                {
                    SponsorIncentiveId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    DeletedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    YearlyMaintenanceId = table.Column<int>(nullable: false),
                    SponsorAmount = table.Column<decimal>(nullable: false),
                    Award = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SponsorIncentives", x => x.SponsorIncentiveId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SponsorIncentives");

            migrationBuilder.DropColumn(
                name: "Incentive",
                table: "YearlyStatementText");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AAYHSContact");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AAYHSContact");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "AAYHSContact");

            migrationBuilder.DropColumn(
                name: "State",
                table: "AAYHSContact");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "AAYHSContact");

            migrationBuilder.AlterColumn<string>(
                name: "StatementText",
                table: "YearlyStatementText",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(5000)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "YearlyMaintainence",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationAddressId",
                table: "YearlyMaintainence",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Year",
                table: "YearlyMaintainence",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
