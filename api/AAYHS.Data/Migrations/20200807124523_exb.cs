using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AAYHS.Data.Migrations
{
    public partial class exb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExhibitorSponser");

            migrationBuilder.AddColumn<int>(
                name: "BirthYears",
                table: "Exhibitors",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthYears",
                table: "Exhibitors");

            migrationBuilder.CreateTable(
                name: "ExhibitorSponser",
                columns: table => new
                {
                    ExhibitorSponsorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    DeletedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    ExhibitorId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    SponsorId = table.Column<int>(type: "int", nullable: false),
                    SponsorTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExhibitorSponser", x => x.ExhibitorSponsorId);
                });
        }
    }
}
