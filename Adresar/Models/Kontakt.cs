using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Adresar.Models
{
    public class Kontakt
    {
        public int ID { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        public string Grad { get; set; }
        public string Adresa { get; set; }
        [Required]
        [StringLength(16)]
        public string Telefon { get; set; }
        public string Email { get; set; }
    }

    public class KontaktDBContext : DbContext
    {
        public DbSet<Kontakt> Kontakti { get; set; }
    }
}