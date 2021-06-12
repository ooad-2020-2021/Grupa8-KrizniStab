using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace CovidX.Migrations
{
    public partial class m : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    adminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.adminId);
                });

            migrationBuilder.CreateTable(
                name: "Karticno placanje",
                columns: table => new
                {
                    placanjeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datumUplate = table.Column<DateTime>(nullable: false),
                    iznosUplate = table.Column<double>(nullable: false),
                    brojKartice = table.Column<string>(nullable: false),
                    datumIsteka = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karticno placanje", x => x.placanjeId);
                });

            migrationBuilder.CreateTable(
                name: "Karton osoblja",
                columns: table => new
                {
                    brojKartona = table.Column<string>(nullable: false),
                    kriticnaGrupa = table.Column<bool>(nullable: false),
                    statusOsoblja = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karton osoblja", x => x.brojKartona);
                });

            migrationBuilder.CreateTable(
                name: "Karton pacijenta",
                columns: table => new
                {
                    brojKartona = table.Column<string>(nullable: false),
                    kriticnaGrupa = table.Column<bool>(nullable: false),
                    statusPacijenta = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karton pacijenta", x => x.brojKartona);
                });

            migrationBuilder.CreateTable(
                name: "Medicinska sestra",
                columns: table => new
                {
                    jmbg = table.Column<string>(nullable: false),
                    ime = table.Column<string>(nullable: false),
                    prezime = table.Column<string>(nullable: false),
                    datumRodjenja = table.Column<DateTime>(nullable: false),
                    telefon = table.Column<string>(nullable: true),
                    mail = table.Column<string>(nullable: false),
                    spol = table.Column<int>(nullable: false),
                    brojKartona = table.Column<string>(nullable: false),
                    datumZadnjegTestiranja = table.Column<DateTime>(nullable: false),
                    lokacija = table.Column<int>(nullable: false),
                    adminId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicinska sestra", x => x.jmbg);
                });

            migrationBuilder.CreateTable(
                name: "Pacijent",
                columns: table => new
                {
                    jmbg = table.Column<string>(nullable: false),
                    ime = table.Column<string>(nullable: false),
                    prezime = table.Column<string>(nullable: false),
                    datumRodjenja = table.Column<DateTime>(nullable: false),
                    telefon = table.Column<string>(nullable: true),
                    mail = table.Column<string>(nullable: false),
                    spol = table.Column<int>(nullable: false),
                    brojKartona = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacijent", x => x.jmbg);
                });

            migrationBuilder.CreateTable(
                name: "Placanje na lokaciji",
                columns: table => new
                {
                    placanjeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datumUplate = table.Column<DateTime>(nullable: false),
                    iznosUplate = table.Column<double>(nullable: false),
                    placanjeIzvrseno = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Placanje na lokaciji", x => x.placanjeId);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacija testiranja",
                columns: table => new
                {
                    idRezervacije = table.Column<string>(nullable: false),
                    lokacija = table.Column<int>(nullable: false),
                    testId = table.Column<int>(nullable: false),
                    placanjeId = table.Column<int>(nullable: false),
                    jmbgPacijenta = table.Column<string>(nullable: false),
                    adminId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija testiranja", x => x.idRezervacije);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacija testiranja za medicinsko osoblje",
                columns: table => new
                {
                    testId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datumTestiranja = table.Column<DateTime>(nullable: false),
                    vrstaTesta = table.Column<int>(nullable: false),
                    namjenaTesta = table.Column<int>(nullable: false),
                    jmbgMed = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija testiranja za medicinsko osoblje", x => x.testId);
                });

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    idTesta = table.Column<string>(nullable: false),
                    datumTestiranja = table.Column<DateTime>(nullable: false),
                    vrstaTesta = table.Column<int>(nullable: false),
                    namjenaTesta = table.Column<int>(nullable: false),
                    rezultat = table.Column<int>(nullable: false),
                    brojKartona = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.idTesta);
                });

            migrationBuilder.CreateTable(
                name: "Unos rezultata",
                columns: table => new
                {
                    testId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brojKartona = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unos rezultata", x => x.testId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Karticno placanje");

            migrationBuilder.DropTable(
                name: "Karton osoblja");

            migrationBuilder.DropTable(
                name: "Karton pacijenta");

            migrationBuilder.DropTable(
                name: "Medicinska sestra");

            migrationBuilder.DropTable(
                name: "Pacijent");

            migrationBuilder.DropTable(
                name: "Placanje na lokaciji");

            migrationBuilder.DropTable(
                name: "Rezervacija testiranja");

            migrationBuilder.DropTable(
                name: "Rezervacija testiranja za medicinsko osoblje");

            migrationBuilder.DropTable(
                name: "Test");

            migrationBuilder.DropTable(
                name: "Unos rezultata");
        }
    }
}
