using Microsoft.EntityFrameworkCore.Migrations;

namespace apiPractice.Migrations
{
    public partial class addFieldImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "House",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "House");
        }
    }
}
