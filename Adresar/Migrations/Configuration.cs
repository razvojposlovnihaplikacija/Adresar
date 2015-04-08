namespace Adresar.Migrations
{
    using Adresar.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Adresar.Models.KontaktDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Adresar.Models.KontaktDBContext context)
        {
            context.Kontakti.AddOrUpdate(i => i.Ime,
                new Kontakt
                {
                    Ime = "Jan",
                    Prezime = "Jereèiæ",
                    Grad = "Zagreb",
                    Adresa = "Zagrebaèka 1111",
                    Telefon = "099/1234-567",
                    Email = "jerecicjan@gmail.com" 
                },
                new Kontakt
                {
                    Ime = "Jan",
                    Prezime = "Nepoznati",
                    Grad = "Osijek",
                    Adresa = "Gajev trg 6",
                    Telefon = "098/987-654",
                    Email = "nepoznati@gmail.com" 
                },
                new Kontakt
                {
                    Ime = "Pero",
                    Prezime = "Periæ",
                    Grad = "Osijek",
                    Adresa = "Divaltova 124",
                    Telefon = "091/789-456",
                    Email = "perolaki@yahoo.com" 
                },
                new Kontakt
                {
                    Ime = "Pero",
                    Prezime = "Teški",
                    Grad = "Zagreb",
                    Adresa = "Savski most 1",
                    Telefon = "095/4567-895",
                    Email = "kraj@msn.com" 
                },
                new Kontakt
                {
                    Ime = "Zlajo",
                    Prezime = "Zlatan",
                    Grad = "Rijeka",
                    Adresa = "Riva 24",
                    Telefon = "092/1234-789",
                    Email = "zlatan@gmail.com" 
                },
                new Kontakt
                {
                    Ime = "Zlajo",
                    Prezime = "Srebrni",
                    Grad = "Rijeka",
                    Adresa = "Riva 23",
                    Telefon = "095/123-789",
                    Email = "srebrni@gmail.com" 
                },
                new Kontakt
                {
                    Ime = "Mia",
                    Prezime = "Velika",
                    Grad = "Split",
                    Adresa = "Baèva 2",
                    Telefon = "095/157-489",
                    Email = "zmija@hotmail.com" 
                },
                new Kontakt
                {
                    Ime = "Tenka",
                    Prezime = "Tenkiæ",
                    Grad = "Split",
                    Adresa = "Škura 2",
                    Telefon = "093/4567-999",
                    Email = "prozor@world.com" 
                }
            );

        }
    }
}
