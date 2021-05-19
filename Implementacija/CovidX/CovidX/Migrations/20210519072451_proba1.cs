using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidX.Migrations
{
    public partial class proba1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Osoba",
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
                    table.PrimaryKey("PK_Osoba", x => x.jmbg);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Osoba");
        }
    }
}
