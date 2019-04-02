using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MuziekInVlaanderen.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuziekInVlaanderen.Data.Mappers
{
    public class EvenementConfiguration : IEntityTypeConfiguration<Evenement>
    {
        public void Configure(EntityTypeBuilder<Evenement> builder)
        {
            builder.ToTable("Evenementen");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Titel).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Beschrijving).IsRequired();
            builder.Property(e => e.Categorie).IsRequired();

            builder.HasOne(e => e.Locatie).WithOne().HasForeignKey<Locatie>(l => l.EvenementId).IsRequired().OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Gallerij).WithOne().HasForeignKey<Gallerij>(e => e.EvenementId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.Moment).WithOne().IsRequired().OnDelete(DeleteBehavior.Cascade);
        }
    }
}
