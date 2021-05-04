using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AAYHS.Data.Migrations
{
    public partial class newStatementTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YearlyStatementText",
                columns: table => new
                {
                    YearlyStatementTextId = table.Column<int>(nullable: false)
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
                    StatementName = table.Column<string>(type: "varchar(500)", nullable: true),
                    StatementNumber = table.Column<string>(type: "varchar(100)", nullable: true),
                    StatementText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearlyStatementText", x => x.YearlyStatementTextId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YearlyStatementText");
        }
    }
}
