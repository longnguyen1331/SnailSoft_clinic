using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class ManufacturerTranslationConfiguration : IEntityTypeConfiguration<ManufacturerTranslation>
    {
        public void Configure(EntityTypeBuilder<ManufacturerTranslation> builder)
        {
            builder.ToTable("ManufacturerTranslations");

            builder.Property(x => x.Name).IsRequired(true);
            builder.HasOne(x => x.Manufacturer).WithMany(x => x.ManufacturerTranslations).HasForeignKey(x => x.ManufacturerId);
            builder.HasOne(x => x.Language).WithMany(x => x.ManufactuerTranslations).HasForeignKey(x => x.LanguageId);
        }
    }
}
