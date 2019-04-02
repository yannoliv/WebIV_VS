using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MuziekInVlaanderen.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuziekInVlaanderen.Data.Mappers
{
    public class MomentConfiguration : IEntityTypeConfiguration<Moment>
    {
        public void Configure(EntityTypeBuilder<Moment> builder)
        {
            builder.ToTable("Moment");
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Datum).IsRequired();
            
        }
    }
}
