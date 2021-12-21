using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class StoreTranslationConfiguration : IEntityTypeConfiguration<StoreTranslation>
    {
        public void Configure(EntityTypeBuilder<StoreTranslation> builder)
        {
            builder.ToTable("StoreTranslations");

            builder.Property(x => x.Name).IsRequired(true);

            builder.HasOne(x => x.Language).WithMany(x => x.StoreTranslations).HasForeignKey(x => x.LanguageId);
            builder.HasOne(x => x.Store).WithMany(x => x.StoreTranslations).HasForeignKey(x => x.StoreId);
        }
    }
}
