using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidX.Migrations
{
    public partial class migracijaNova : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Rezervacija testiranja za medicinsko osoblje",
                table: "Rezervacija testiranja za medicinsko osoblje");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Karton pacijenta",
                table: "Karton pacijenta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Karton osoblja",
                table: "Karton osoblja");

            migrationBuilder.DropColumn(
                name: "brojKartona",
                table: "Unos rezultata");

            migrationBuilder.DropColumn(
                name: "brojKartona",
                table: "Test");

            migrationBuilder.AddColumn<string>(
                name: "jmbgMed",
                table: "Unos rezultata",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "kartonId",
                table: "Unos rezultata",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "idTesta",
                table: "Test",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "kartonId",
                table: "Test",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "testId",
                table: "Rezervacija testiranja za medicinsko osoblje",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "idRezervacije",
                table: "Rezervacija testiranja za medicinsko osoblje",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "brojKartona",
                table: "Karton pacijenta",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "kartonId",
                table: "Karton pacijenta",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "brojKartona",
                table: "Karton osoblja",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "kartonId",
                table: "Karton osoblja",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rezervacija testiranja za medicinsko osoblje",
                table: "Rezervacija testiranja za medicinsko osoblje",
                column: "idRezervacije");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Karton pacijenta",
                table: "Karton pacijenta",
                column: "kartonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Karton osoblja",
                table: "Karton osoblja",
                column: "kartonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Rezervacija testiranja za medicinsko osoblje",
                table: "Rezervacija testiranja za medicinsko osoblje");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Karton pacijenta",
                table: "Karton pacijenta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Karton osoblja",
                table: "Karton osoblja");

            migrationBuilder.DropColumn(
                name: "jmbgMed",
                table: "Unos rezultata");

            migrationBuilder.DropColumn(
                name: "kartonId",
                table: "Unos rezultata");

            migrationBuilder.DropColumn(
                name: "kartonId",
                table: "Test");

            migrationBuilder.DropColumn(
                name: "idRezervacije",
                table: "Rezervacija testiranja za medicinsko osoblje");

            migrationBuilder.DropColumn(
                name: "kartonId",
                table: "Karton pacijenta");

            migrationBuilder.DropColumn(
                name: "kartonId",
                table: "Karton osoblja");

            migrationBuilder.AddColumn<string>(
                name: "brojKartona",
                table: "Unos rezultata",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "idTesta",
                table: "Test",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "brojKartona",
                table: "Test",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "testId",
                table: "Rezervacija testiranja za medicinsko osoblje",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "brojKartona",
                table: "Karton pacijenta",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "brojKartona",
                table: "Karton osoblja",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rezervacija testiranja za medicinsko osoblje",
                table: "Rezervacija testiranja za medicinsko osoblje",
                column: "testId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Karton pacijenta",
                table: "Karton pacijenta",
                column: "brojKartona");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Karton osoblja",
                table: "Karton osoblja",
                column: "brojKartona");
        }
    }
}
