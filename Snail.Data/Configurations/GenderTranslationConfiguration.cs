using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class GenderTranslationConfiguration : IEntityTypeConfiguration<GenderTranslation>
    {
        public void Configure(EntityTypeBuilder<GenderTranslation> builder)
        {
            builder.ToTable("GenderTranslations");

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.GenderTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.Gender).WithMany(x => x.GenderTranslations).HasForeignKey(x => x.GenderId);
        }
    }
}