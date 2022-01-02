using SnailApp.Data.Entities;
using SnailApp.ViewModels.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class BasicSalaryTranslationConfiguration : IEntityTypeConfiguration<BasicSalaryTranslation>
    {
        public void Configure(EntityTypeBuilder<BasicSalaryTranslation> builder)
        {
            builder.ToTable("BasicSalaryTranslations");

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.BasicSalaryTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.BasicSalary).WithMany(x => x.BasicSalaryTranslations).HasForeignKey(x => x.BasicSalaryId);

        }
    }
}