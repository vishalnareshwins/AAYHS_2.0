using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AAYHS.Data.Migrations
{
    public partial class feetype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SponsorPaymentDetail");

            migrationBuilder.DropColumn(
                name: "FeeId",
                table: "ExhibitorPaymentDetail");

            migrationBuilder.AddColumn<int>(
                name: "FeeTypeId",
                table: "ExhibitorPaymentDetail",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeeTypeId",
                table: "ExhibitorPaymentDetail");

            migrationBuilder.AddColumn<int>(
                name: "FeeId",
                table: "ExhibitorPaymentDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SponsorPaymentDetail",
                columns: table => new
                {
                    SponsorPaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CheckNumber = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    DeletedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    Description = table.Column<string>(type: "varchar(500)", nullable: true),
                    FeeId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    SponsorId = table.Column<int>(type: "int", nullable: false),
                    TimeFrameTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SponsorPaymentDetail", x => x.SponsorPaymentId);
                });
        }
    }
}
