using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Autoservice.Infrastructure.Migrations
{
    public partial class addBoxFieldToMasted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Box",
                table: "Masters",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Box",
                table: "Masters");
        }
    }
}
