using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class MenuTranslationConfiguration : IEntityTypeConfiguration<MenuTranslation>
    {
        public void Configure(EntityTypeBuilder<MenuTranslation> builder)
        {
            builder.ToTable("MenuTranslations");

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.MenuTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.Menu).WithMany(x => x.MenuTranslations).HasForeignKey(x => x.MenuId);

        }
    }
}
