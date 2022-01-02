using SnailApp.Data.Entities;
using SnailApp.ViewModels.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class AppUserStatusTranslationConfiguration : IEntityTypeConfiguration<AppUserStatusTranslation>
    {
        public void Configure(EntityTypeBuilder<AppUserStatusTranslation> builder)
        {
            builder.ToTable("AppUserStatusTranslations");

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.AppUserStatusTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.AppUserStatus).WithMany(x => x.AppUserStatusTranslations).HasForeignKey(x => x.AppUserStatusId);

        }
    }
}