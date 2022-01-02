using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class DocTemplateTypeTranslationConfiguration : IEntityTypeConfiguration<DocTemplateTypeTranslation>
    {
        public void Configure(EntityTypeBuilder<DocTemplateTypeTranslation> builder)
        {
            builder.ToTable("DocTemplateTypeTranslations");

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.DocTemplateTypeTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.DocTemplateType).WithMany(x => x.DocTemplateTypeTranslations).HasForeignKey(x => x.DocTemplateTypeId);

        }
    }
}