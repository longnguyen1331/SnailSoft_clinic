using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class ProductTypeTranslationConfiguration : IEntityTypeConfiguration<ProductTypeTranslation>
    {
        public void Configure(EntityTypeBuilder<ProductTypeTranslation> builder)
        {
            builder.ToTable("ProductTypeTranslations");

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.SeoAlias).IsRequired().HasMaxLength(200);

            builder.Property(x => x.SeoDescription).HasMaxLength(500);

            builder.Property(x => x.SeoTitle).HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.ProductTypeTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.ProductType).WithMany(x => x.ProductTypeTranslations).HasForeignKey(x => x.ProductTypeId);

        }
    }
}
