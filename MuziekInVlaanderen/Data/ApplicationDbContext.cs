using MuziekInVlaanderen.Models.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MuziekInVlaanderen.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() :
          base("OktaConnectionString")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Evenement> Evenementen { get; set; }
    }
}