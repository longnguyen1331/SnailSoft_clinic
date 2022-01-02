using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class ProductTypeStatusTranslationConfiguration : IEntityTypeConfiguration<ProductTypeStatusTranslation>
    {
        public void Configure(EntityTypeBuilder<ProductTypeStatusTranslation> builder)
        {
            builder.ToTable("ProductTypeStatusTranslations");

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.ProductTypeStatusTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.ProductTypeStatus).WithMany(x => x.ProductTypeStatusTranslations).HasForeignKey(x => x.ProductTypeStatusId);

        }
    }
}