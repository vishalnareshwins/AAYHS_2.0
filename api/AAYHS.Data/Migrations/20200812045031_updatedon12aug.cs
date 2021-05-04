using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AAYHS.Data.Migrations
{
    public partial class updatedon12aug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupExhibitors",
                columns: table => new
                {
                    GroupExhibitorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    DeletedBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "Datetime", nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ExhibitorId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupExhibitors", x => x.GroupExhibitorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupExhibitors");
        }
    }
}
