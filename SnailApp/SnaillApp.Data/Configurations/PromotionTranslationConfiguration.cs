using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class PromotionTranslationConfiguration : IEntityTypeConfiguration<PromotionTranslation>
    {
        public void Configure(EntityTypeBuilder<PromotionTranslation> builder)
        {
            builder.ToTable("PromotionTranslations");

            builder.HasOne(x => x.Language).WithMany(x => x.PromotionTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.Promotion).WithMany(x => x.PromotionTranslations).HasForeignKey(x => x.PromotionId);

        }
    }
}