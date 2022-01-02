using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class CommissionDiscountTranslationConfiguration : IEntityTypeConfiguration<CommissionDiscountTranslation>
    {
        public void Configure(EntityTypeBuilder<CommissionDiscountTranslation> builder)
        {
            builder.ToTable("CommissionDiscountTranslations");

            builder.HasOne(x => x.Language).WithMany(x => x.CommissionDiscountTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.CommissionDiscount).WithMany(x => x.CommissionDiscountTranslations).HasForeignKey(x => x.CommissionDiscountId);

        }
    }
}
