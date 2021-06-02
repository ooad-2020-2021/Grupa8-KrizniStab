using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidX.Migrations
{
    public partial class m16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Unos rezultata",
                table: "Unos rezultata");

            migrationBuilder.AlterColumn<int>(
                name: "testId",
                table: "Unos rezultata",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "unosId",
                table: "Unos rezultata",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Unos rezultata",
                table: "Unos rezultata",
                column: "unosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Unos rezultata",
                table: "Unos rezultata");

            migrationBuilder.DropColumn(
                name: "unosId",
                table: "Unos rezultata");

            migrationBuilder.AlterColumn<int>(
                name: "testId",
                table: "Unos rezultata",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Unos rezultata",
                table: "Unos rezultata",
                column: "testId");
        }
    }
}
