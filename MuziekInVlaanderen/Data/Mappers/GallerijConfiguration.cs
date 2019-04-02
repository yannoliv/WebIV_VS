using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MuziekInVlaanderen.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuziekInVlaanderen.Data.Mappers
{
    public class GallerijConfiguration : IEntityTypeConfiguration<Gallerij>
    {
        public void Configure(EntityTypeBuilder<Gallerij> builder)
        {
            builder.ToTable("Gallerij");
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Fotos).IsRequired();

            builder.HasOne(g => g.Evenement).WithOne(e => e.Gallerij).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
