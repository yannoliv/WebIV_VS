using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MuziekInVlaanderen.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuziekInVlaanderen.Data.Mappers
{
    public class LocatieConfiguration : IEntityTypeConfiguration<Locatie>
    {
        public void Configure(EntityTypeBuilder<Locatie> builder)
        {
            builder.ToTable("Locatie");
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Postcode).IsRequired();

            builder.HasOne(l => l.Evenement).WithOne(e => e.Locatie).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
