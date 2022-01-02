using SnailApp.Data.Entities;
using SnailApp.ViewModels.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class AppRoleTranslationConfiguration : IEntityTypeConfiguration<AppRoleTranslation>
    {
        public void Configure(EntityTypeBuilder<AppRoleTranslation> builder)
        {
            builder.ToTable("AppRoleTranslations");

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.AppRoleTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.AppRole).WithMany(x => x.AppRoleTranslations).HasForeignKey(x => x.AppRoleId);
        }
    }
}