using Snail.Data.Entities;
using Snail.ViewModels.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class AboutTranslationConfiguration : IEntityTypeConfiguration<AboutTranslation>
    {
        public void Configure(EntityTypeBuilder<AboutTranslation> builder)
        {
            builder.ToTable("AboutTranslations");

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.AboutTranslations).HasForeignKey(x => x.LanguageId);
            builder.HasOne(x => x.About).WithMany(x => x.AboutTranslations).HasForeignKey(x => x.AboutId);
        }
    }
}