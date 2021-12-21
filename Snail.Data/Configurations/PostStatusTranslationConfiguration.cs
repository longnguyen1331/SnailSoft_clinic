using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
namespace Snail.Data.Configurations
{
    public class PostStatusTranslationConfiguration : IEntityTypeConfiguration<PostStatusTranslation>
    {
        public void Configure(EntityTypeBuilder<PostStatusTranslation> builder)
        {
            builder.ToTable("PostStatusTranslations");

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.PostStatusTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.PostStatus).WithMany(x => x.PostStatusTranslations).HasForeignKey(x => x.PostStatusId);

        }
    }
}