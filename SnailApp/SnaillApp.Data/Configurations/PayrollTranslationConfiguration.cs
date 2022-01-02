using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class PayrollTranslationConfiguration : IEntityTypeConfiguration<PayrollTranslation>
    {
        public void Configure(EntityTypeBuilder<PayrollTranslation> builder)
        {
            builder.ToTable("PayrollTranslations");

            builder.HasOne(x => x.Language).WithMany(x => x.PayrollTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.Payroll).WithMany(x => x.PayrollTranslations).HasForeignKey(x => x.PayrollId);

        }
    }
}