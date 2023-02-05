using Microsoft.EntityFrameworkCore.Migrations;

namespace CloudRMS.Migrations
{
    public partial class addnewcolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageThumbnailUrl",
                table: "Pies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Pies",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPieOfTheWeek",
                table: "Pies",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageThumbnailUrl",
                table: "Pies");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Pies");

            migrationBuilder.DropColumn(
                name: "IsPieOfTheWeek",
                table: "Pies");
        }
    }
}
