using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidX.Migrations
{
    public partial class pls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Admin",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "adminId",
                table: "Admin");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Admin",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Admin",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Admin",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admin",
                table: "Admin",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Admin",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Admin");

            migrationBuilder.AddColumn<int>(
                name: "adminId",
                table: "Admin",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admin",
                table: "Admin",
                column: "adminId");
        }
    }
}
