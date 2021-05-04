using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AAYHS.Data.Migrations
{
    public partial class addtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stall",
                columns: table => new
                {
                    StallId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    DeletedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StallNumber = table.Column<int>(nullable: false),
                    IsPortable = table.Column<bool>(nullable: false),
                    ProtableStallTypeId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stall", x => x.StallId);
                });

            migrationBuilder.CreateTable(
                name: "StallAssignment",
                columns: table => new
                {
                    StallAssignmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    DeletedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StallId = table.Column<int>(nullable: false),
                    StallAssignmentTypeId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    ExhibitorId = table.Column<int>(nullable: false),
                    BookedByType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StallAssignment", x => x.StallAssignmentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stall");

            migrationBuilder.DropTable(
                name: "StallAssignment");
        }
    }
}
