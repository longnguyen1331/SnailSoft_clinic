using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class PhieuKeToanStatusTranslationConfiguration : IEntityTypeConfiguration<PhieuKeToanStatusTranslation>
    {
        public void Configure(EntityTypeBuilder<PhieuKeToanStatusTranslation> builder)
        {
            builder.ToTable("PhieuKeToanStatusTranslations");

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.PhieuKeToanStatusTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.PhieuKeToanStatus).WithMany(x => x.PhieuKeToanStatusTranslations).HasForeignKey(x => x.PhieuKeToanStatusId);

        }
    }
}