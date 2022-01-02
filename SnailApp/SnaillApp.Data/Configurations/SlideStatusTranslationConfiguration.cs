using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class SlideStatusTranslationConfiguration : IEntityTypeConfiguration<SlideStatusTranslation>
    {
        public void Configure(EntityTypeBuilder<SlideStatusTranslation> builder)
        {
            builder.ToTable("SlideStatusTranslations");

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.SlideStatusTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.SlideStatus).WithMany(x => x.SlideStatusTranslations).HasForeignKey(x => x.SlideStatusId);

        }
    }
}
