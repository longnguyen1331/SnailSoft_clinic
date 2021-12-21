using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class PostTranslationConfiguration : IEntityTypeConfiguration<PostTranslation>
    {
        public void Configure(EntityTypeBuilder<PostTranslation> builder)
        {
            builder.ToTable("PostTranslations");

            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.Content).IsRequired(true);
            builder.HasOne(x => x.Post).WithMany(x => x.PostTranslations).HasForeignKey(x => x.PostId);
            builder.HasOne(x => x.Language).WithMany(x => x.PostTranslations).HasForeignKey(x => x.LanguageId);
        }
    }
}
