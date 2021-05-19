﻿using CovidX.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX
{
    public class CovidXContext : DbContext
    {
        public CovidXContext(DbContextOptions<CovidXContext> options) : base(options)
        {
        }

        public DbSet<Osoba> Osoba { get; set; }
        public DbSet<KarticnoPlacanje> KarticnoPlacanje { get; set; }
     
        public DbSet<MedicinskaSestra> MedicinskaSestra{ get; set; }
        public DbSet<Pacijent> Pacijent { get; set; }
        public DbSet<Placanje> Placanje { get; set; }
        public DbSet<PlacanjeNaLokaciji> PlacanjeNaLokaciji { get; set; }
        public DbSet<RezervacijaTestiranja> RezervacijaTestiranja { get; set; }
        public DbSet<RezervacijaTestiranjaMed> RezervacijaTestiranjaMed { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<UnosRezultata> UnosRezultata { get; set; }
        //dodati za admina i kartone nakon ispravke za liste
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Osoba>().ToTable("Osoba");
            modelBuilder.Entity<KarticnoPlacanje>().ToTable("Karticno placanje");
            modelBuilder.Entity<MedicinskaSestra>().ToTable("Medicinska sestra");
            modelBuilder.Entity<Pacijent>().ToTable("Pacijent");
            modelBuilder.Entity<Placanje>().ToTable("Placanje");
            modelBuilder.Entity<PlacanjeNaLokaciji>().ToTable("Placanje na lokaciji");
            modelBuilder.Entity<RezervacijaTestiranja>().ToTable("Rezervacija testiranja");
            modelBuilder.Entity<RezervacijaTestiranjaMed>().ToTable("Rezervacija testiranja za medicinsko osoblje");
            modelBuilder.Entity<Test>().ToTable("Test");
            modelBuilder.Entity<UnosRezultata>().ToTable("Unos rezultata");

        }

    }
}
