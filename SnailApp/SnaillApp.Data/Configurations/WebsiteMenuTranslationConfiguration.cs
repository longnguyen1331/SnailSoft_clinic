using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class WebsiteMenuTranslationConfiguration : IEntityTypeConfiguration<WebsiteMenuTranslation>
    {
        public void Configure(EntityTypeBuilder<WebsiteMenuTranslation> builder)
        {
            builder.ToTable("WebsiteMenuTranslations");
            builder.Property(x => x.Name).IsRequired(true);
            builder.HasOne(x => x.Language).WithMany(x => x.WebsiteMenuTranslations).HasForeignKey(x => x.LanguageId);
            builder.HasOne(x => x.WebsiteMenu).WithMany(x => x.WebsiteMenuTranslations).HasForeignKey(x => x.WebsiteMenuId);
        }
    }
}
