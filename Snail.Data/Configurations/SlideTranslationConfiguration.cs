using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    class SlideTranslationConfiguration : IEntityTypeConfiguration<SlideTranslation>
    {
        public void Configure(EntityTypeBuilder<SlideTranslation> builder)
        {
            builder.ToTable("SlideTranslations");

            builder.Property(x => x.Name).IsRequired(true);

            builder.HasOne(x => x.Language).WithMany(x => x.SlideTranslations).HasForeignKey(x => x.LanguageId);
            builder.HasOne(x => x.Slide).WithMany(x => x.SlideTranslations).HasForeignKey(x => x.SlideId);
        }
    }
}
