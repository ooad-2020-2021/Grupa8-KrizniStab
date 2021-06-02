﻿// <auto-generated />
using System;
using CovidX.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CovidX.Migrations
{
    [DbContext(typeof(CovidXContext))]
    [Migration("20210522192757_dodaj")]
    partial class dodaj
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CovidX.Models.Admin", b =>
                {
                    b.Property<int>("adminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("adminId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("CovidX.Models.KarticnoPlacanje", b =>
                {
                    b.Property<int>("placanjeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("brojKartice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("datumIsteka")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("datumUplate")
                        .HasColumnType("datetime2");

                    b.Property<double>("iznosUplate")
                        .HasColumnType("float");

                    b.HasKey("placanjeId");

                    b.ToTable("Karticno placanje");
                });

            modelBuilder.Entity("CovidX.Models.KartonOsoblja", b =>
                {
                    b.Property<int>("kartonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("brojKartona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("kriticnaGrupa")
                        .HasColumnType("bit");

                    b.Property<int>("statusOsoblja")
                        .HasColumnType("int");

                    b.HasKey("kartonId");

                    b.ToTable("Karton osoblja");
                });

            modelBuilder.Entity("CovidX.Models.KartonPacijenta", b =>
                {
                    b.Property<int>("kartonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("brojKartona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("kriticnaGrupa")
                        .HasColumnType("bit");

                    b.Property<int>("statusPacijenta")
                        .HasColumnType("int");

                    b.HasKey("kartonId");

                    b.ToTable("Karton pacijenta");
                });

            modelBuilder.Entity("CovidX.Models.MedicinskaSestra", b =>
                {
                    b.Property<string>("jmbg")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("adminId")
                        .HasColumnType("int");

                    b.Property<string>("brojKartona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("datumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("datumZadnjegTestiranja")
                        .HasColumnType("datetime2");

                    b.Property<string>("ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("lokacija")
                        .HasColumnType("int");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("spol")
                        .HasColumnType("int");

                    b.Property<string>("telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("jmbg");

                    b.ToTable("Medicinska sestra");
                });

            modelBuilder.Entity("CovidX.Models.Pacijent", b =>
                {
                    b.Property<string>("jmbg")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("brojKartona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("datumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("spol")
                        .HasColumnType("int");

                    b.Property<string>("telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("jmbg");

                    b.ToTable("Pacijent");
                });

            modelBuilder.Entity("CovidX.Models.PlacanjeNaLokaciji", b =>
                {
                    b.Property<int>("placanjeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("datumUplate")
                        .HasColumnType("datetime2");

                    b.Property<double>("iznosUplate")
                        .HasColumnType("float");

                    b.Property<bool>("placanjeIzvrseno")
                        .HasColumnType("bit");

                    b.HasKey("placanjeId");

                    b.ToTable("Placanje na lokaciji");
                });

            modelBuilder.Entity("CovidX.Models.RezervacijaTestiranja", b =>
                {
                    b.Property<int>("idRezervacije")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("adminId")
                        .HasColumnType("int");

                    b.Property<string>("jmbgPacijenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("lokacija")
                        .HasColumnType("int");

                    b.Property<int>("placanjeId")
                        .HasColumnType("int");

                    b.Property<int>("testId")
                        .HasColumnType("int");

                    b.HasKey("idRezervacije");

                    b.ToTable("Rezervacija testiranja");
                });

            modelBuilder.Entity("CovidX.Models.RezervacijaTestiranjaMed", b =>
                {
                    b.Property<string>("idRezervacije")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("datumTestiranja")
                        .HasColumnType("datetime2");

                    b.Property<string>("jmbgMed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("namjenaTesta")
                        .HasColumnType("int");

                    b.Property<int>("testId")
                        .HasColumnType("int");

                    b.Property<int>("vrstaTesta")
                        .HasColumnType("int");

                    b.HasKey("idRezervacije");

                    b.ToTable("Rezervacija testiranja za medicinsko osoblje");
                });

            modelBuilder.Entity("CovidX.Models.Test", b =>
                {
                    b.Property<int>("idTesta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("datumTestiranja")
                        .HasColumnType("datetime2");

                    b.Property<int>("kartonId")
                        .HasColumnType("int");

                    b.Property<int>("namjenaTesta")
                        .HasColumnType("int");

                    b.Property<int>("rezultat")
                        .HasColumnType("int");

                    b.Property<int>("vrstaTesta")
                        .HasColumnType("int");

                    b.HasKey("idTesta");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("CovidX.Models.UnosRezultata", b =>
                {
                    b.Property<int>("testId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("jmbgMed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("kartonId")
                        .HasColumnType("int");

                    b.HasKey("testId");

                    b.ToTable("Unos rezultata");
                });
#pragma warning restore 612, 618
        }
    }
}
