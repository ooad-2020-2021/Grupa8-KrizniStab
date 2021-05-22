﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public class Osoba : IdentityUser
    {
        public Osoba(string ime, string prezime, string jmbg, DateTime datumRodjenja, string telefon, string mail, Spol spol, string brojKartona)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.datumRodjenja = datumRodjenja;
            this.telefon = telefon;
            this.mail = mail;
            this.spol = spol;
            this.brojKartona = brojKartona;
        }
        [Required]
        [DisplayName("Ime:")]
        public string ime
        {
            get; set;
        }
        [Required]
        [DisplayName("Prezime:")]
        public string prezime
        {
            get; set;
        }
        [Key]
        [Required]
        [DisplayName("JMBG:")]
        public string jmbg
        {
            get; set;
        }
        [Required]
        [DisplayName("Datum rođenja:")]
        [DataType(DataType.Date)]
        public DateTime datumRodjenja
        {
            get; set;
        }
        [DisplayName("Telefon:")]
        public string telefon { get; set; }

        [DisplayName("Mail:")]
        [Required]
        public string mail
        {
            get; set;
        }
        [DisplayName("Spol:")]
        [EnumDataType(typeof(Spol))]
        public Spol spol { get; set; }
        [DisplayName("Broj kartona:")]
        [Required]
        public string brojKartona { get; set; }
    }
}
