using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace CovidX.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Pacijent",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Pacijent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Pacijent",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Pacijent",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Pacijent",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Pacijent",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Pacijent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Pacijent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Pacijent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Pacijent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Pacijent",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Pacijent",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Pacijent",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Pacijent",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Pacijent",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Medicinska sestra",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Medicinska sestra",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Medicinska sestra",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Medicinska sestra",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Medicinska sestra",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Medicinska sestra",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Medicinska sestra",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Medicinska sestra",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Medicinska sestra",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Medicinska sestra",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Medicinska sestra",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Medicinska sestra",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Medicinska sestra",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Medicinska sestra",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Medicinska sestra",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Pacijent");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Pacijent");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Pacijent");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Pacijent");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Pacijent");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Pacijent");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Pacijent");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Pacijent");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Pacijent");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Pacijent");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Pacijent");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Pacijent");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Pacijent");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Pacijent");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Pacijent");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Medicinska sestra");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Medicinska sestra");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Medicinska sestra");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Medicinska sestra");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Medicinska sestra");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Medicinska sestra");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Medicinska sestra");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Medicinska sestra");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Medicinska sestra");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Medicinska sestra");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Medicinska sestra");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Medicinska sestra");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Medicinska sestra");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Medicinska sestra");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Medicinska sestra");
        }
    }
}
