using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class UnitTranslationConfiguration : IEntityTypeConfiguration<UnitTranslation>
    {
        public void Configure(EntityTypeBuilder<UnitTranslation> builder)
        {
            builder.ToTable("UnitTranslations");
            builder.Property(x => x.Name).IsRequired(true);
            builder.HasOne(x => x.Language).WithMany(x => x.UnitTranslations).HasForeignKey(x => x.LanguageId);
            builder.HasOne(x => x.Unit).WithMany(x => x.UnitTranslations).HasForeignKey(x => x.UnitId);
        }
    }
}
