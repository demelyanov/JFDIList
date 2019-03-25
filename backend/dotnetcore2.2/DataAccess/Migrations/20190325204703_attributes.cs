using Microsoft.EntityFrameworkCore.Migrations;

namespace JFDIList.DataAccess.Migrations
{
    public partial class attributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "Tasks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Important",
                table: "Tasks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Urgently",
                table: "Tasks",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Done",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Important",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Urgently",
                table: "Tasks");
        }
    }
}
