using MuziekInVlaanderen.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using MuziekInVlaanderen.Data.Mappers;

namespace MuziekInVlaanderen.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Evenement> Evenementen { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EvenementConfiguration());
        }

    }
}