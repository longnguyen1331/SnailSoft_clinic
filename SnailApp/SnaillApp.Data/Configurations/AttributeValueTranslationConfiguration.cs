using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class AttributeValueTranslationConfiguration : IEntityTypeConfiguration<AttributeValueTranslation>
    {
        public void Configure(EntityTypeBuilder<AttributeValueTranslation> builder)
        {
            builder.ToTable("AttributeValueTranslations");

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.AttributeValueTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.AttributeValue).WithMany(x => x.AttributeValueTranslations).HasForeignKey(x => x.AttributeValueId);

        }
    }
}
