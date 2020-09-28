using Microsoft.EntityFrameworkCore.Migrations;

namespace apiPractice.Migrations
{
    public partial class addFieldsellRent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "sellRent",
                table: "House",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sellRent",
                table: "House");
        }
    }
}
