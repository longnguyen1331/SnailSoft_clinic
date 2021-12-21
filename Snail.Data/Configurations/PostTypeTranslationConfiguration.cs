using Snail.Data.Entities;
using Snail.ViewModels.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class PostTypeTranslationConfiguration : IEntityTypeConfiguration<PostTypeTranslation>
    {
        public void Configure(EntityTypeBuilder<PostTypeTranslation> builder)
        {
            builder.ToTable("PostTypeTranslations");

            builder.Property(x => x.Name).IsRequired(true);
            builder.HasOne(x => x.Language).WithMany(x => x.PostTypeTranslations).HasForeignKey(x => x.LanguageId);
            builder.HasOne(x => x.PostType).WithMany(x => x.PostTypeTranslations).HasForeignKey(x => x.PostTypeId);
        }
    }
}
