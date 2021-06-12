using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace CovidX.Migrations
{
    public partial class mi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Admin",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "jmbg",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "brojKartona",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "datumRodjenja",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "ime",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "mail",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "prezime",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "spol",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "telefon",
                table: "Admin");

            migrationBuilder.AddColumn<int>(
                name: "adminId",
                table: "Admin",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admin",
                table: "Admin",
                column: "adminId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Admin",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "adminId",
                table: "Admin");

            migrationBuilder.AddColumn<string>(
                name: "jmbg",
                table: "Admin",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Admin",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Admin",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Admin",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Admin",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Admin",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Admin",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "brojKartona",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "datumRodjenja",
                table: "Admin",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ime",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "mail",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "prezime",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "spol",
                table: "Admin",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "telefon",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admin",
                table: "Admin",
                column: "jmbg");
        }
    }
}
