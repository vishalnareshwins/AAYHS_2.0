using Microsoft.EntityFrameworkCore.Migrations;

namespace AAYHS.Data.Migrations
{
    public partial class stalltablechangs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "StallAssignment");

            migrationBuilder.DropColumn(
                name: "HorseId",
                table: "StallAssignment");

            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Stall");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Stall");

            migrationBuilder.DropColumn(
                name: "MaxNumberOfHorseAssignment",
                table: "Stall");

            migrationBuilder.AddColumn<string>(
                name: "BookedBy",
                table: "StallAssignment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Stall",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPortable",
                table: "Stall",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ProtableStallTypeId",
                table: "Stall",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookedBy",
                table: "StallAssignment");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Stall");

            migrationBuilder.DropColumn(
                name: "IsPortable",
                table: "Stall");

            migrationBuilder.DropColumn(
                name: "ProtableStallTypeId",
                table: "Stall");

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "StallAssignment",
                type: "varchar(5000)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "HorseId",
                table: "StallAssignment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Stall",
                type: "varchar(5000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Stall",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxNumberOfHorseAssignment",
                table: "Stall",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
