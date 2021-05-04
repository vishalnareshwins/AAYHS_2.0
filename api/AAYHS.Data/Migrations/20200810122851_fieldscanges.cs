using Microsoft.EntityFrameworkCore.Migrations;

namespace AAYHS.Data.Migrations
{
    public partial class fieldscanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackNumber",
                table: "Horses");

            migrationBuilder.DropColumn(
                name: "JumpHeight",
                table: "Horses");

            migrationBuilder.DropColumn(
                name: "ContactEmail",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "ContactPhone",
                table: "Groups");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "TackStall",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Stall",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JumpHeightId",
                table: "Horses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "GroupName",
                table: "Groups",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactName",
                table: "Groups",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Groups",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "AmountReceived",
                table: "Groups",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Groups",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Groups",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "TackStall");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Stall");

            migrationBuilder.DropColumn(
                name: "JumpHeightId",
                table: "Horses");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "AmountReceived",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Groups");

            migrationBuilder.AddColumn<int>(
                name: "BackNumber",
                table: "Horses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "JumpHeight",
                table: "Horses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GroupName",
                table: "Groups",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactName",
                table: "Groups",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactEmail",
                table: "Groups",
                type: "varchar(255)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPhone",
                table: "Groups",
                type: "varchar(15)",
                nullable: true);
        }
    }
}
