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
            builder.ToTable("Gallerijen");
            builder.HasKey(e => e.Id);

            //builder.HasOne(g => g.Fotograaf).WithMany().HasForeignKey(f => f.FotograafId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
