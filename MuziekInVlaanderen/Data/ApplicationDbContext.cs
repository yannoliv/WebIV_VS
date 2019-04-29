using MuziekInVlaanderen.Models.Domain;
using Microsoft.EntityFrameworkCore;
using MuziekInVlaanderen.Data.Mappers;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MuziekInVlaanderen.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Evenement> Evenementen { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Customer>().Property(c => c.LastName).IsRequired().HasMaxLength(50);
            builder.Entity<Customer>().Property(c => c.FirstName).IsRequired().HasMaxLength(50);
            builder.Entity<Customer>().Property(c => c.Email).IsRequired().HasMaxLength(100);
            builder.Entity<Customer>().Ignore(c => c.FavoriteEvenementen);

            builder.Entity<CustomerFavorite>().HasKey(f => new { f.CustomerId, f.EvenementId });
            builder.Entity<CustomerFavorite>().HasOne(f => f.Customer).WithMany(u => u.Favorites).HasForeignKey(f => f.CustomerId);
            builder.Entity<CustomerFavorite>().HasOne(f => f.Evenement).WithMany().HasForeignKey(f => f.EvenementId);

            builder.ApplyConfiguration(new GallerijConfiguration());
            builder.ApplyConfiguration(new EvenementConfiguration());

        }

    }
}