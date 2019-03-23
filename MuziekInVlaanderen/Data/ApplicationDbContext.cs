using MuziekInVlaanderen.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MuziekInVlaanderen.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            const string BESCHRIJVING = "Is at purse tried jokes china ready decay an. Small its shy way had woody downs power. To denoting admitted speaking learning my exercise so in. Procured shutters mr it feelings. To or three offer house begin taken am at. As dissuade cheerful overcame so of friendly he indulged unpacked. Alteration connection to so as collecting me. Difficult in delivered extensive at direction allowance. Alteration put use diminution can considered sentiments interested discretion. An seeing feebly stairs am branch income me unable.";

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Evenement>().HasKey(e => e.Id);
            modelBuilder.Entity<Evenement>().Property(e => e.Id);
            modelBuilder.Entity<Evenement>().Property(e => e.Titel).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Evenement>().Property(e => e.Beschrijving).IsRequired();
            modelBuilder.Entity<Evenement>().Property(e => e.Categorie).IsRequired();
            modelBuilder.Entity<Evenement>().Property(e => e.Locatie).IsRequired();


            //Another way to seed the database
            modelBuilder.Entity<Evenement>().HasData(
                new Evenement(1, "Michael Bublé with the Classics",Categorie.Klassiek, Plaats.Aalst, BESCHRIJVING, new DateTime(2019,5,18)),
                new Evenement(2, "Op de lijn met Pascal Cruque", Categorie.VoorDeHeleFamilie, Plaats.Brugge, BESCHRIJVING, new DateTime(2019, 9, 10)),
                new Evenement(3, "De grote opera van Jaque DePicanté", Categorie.Klassiek, Plaats.Antwerpen, BESCHRIJVING, new DateTime(2020, 1, 12)),
                new Evenement(4, "Zware Rock en Roll en Heavy Metal", Categorie.RockAndMetal, Plaats.Antwerpen, BESCHRIJVING, new DateTime(2019, 6, 9)),
                new Evenement(5, "Pinto de Janero", Categorie.Pop, Plaats.Gent, BESCHRIJVING, new DateTime(2019, 6, 15))
            );            
        }

        public DbSet<Evenement> Evenementen { get; set; }
    }
}