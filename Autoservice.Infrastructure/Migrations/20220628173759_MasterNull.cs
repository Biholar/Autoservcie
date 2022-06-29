using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Autoservice.Infrastructure.Migrations
{
    public partial class MasterNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceCheckouts_Masters_MaserId",
                table: "ServiceCheckouts");

            migrationBuilder.AlterColumn<int>(
                name: "MaserId",
                table: "ServiceCheckouts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceCheckouts_Masters_MaserId",
                table: "ServiceCheckouts",
                column: "MaserId",
                principalTable: "Masters",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceCheckouts_Masters_MaserId",
                table: "ServiceCheckouts");

            migrationBuilder.AlterColumn<int>(
                name: "MaserId",
                table: "ServiceCheckouts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceCheckouts_Masters_MaserId",
                table: "ServiceCheckouts",
                column: "MaserId",
                principalTable: "Masters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
