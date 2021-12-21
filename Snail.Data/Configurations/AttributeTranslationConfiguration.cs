using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class AttributeTranslationConfiguration : IEntityTypeConfiguration<AttributeTranslation>
    {
        public void Configure(EntityTypeBuilder<AttributeTranslation> builder)
        {
            builder.ToTable("AttributeTranslations");

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.AttributeTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.Attribute).WithMany(x => x.AttributeTranslations).HasForeignKey(x => x.AttributeId);

        }
    }
}
