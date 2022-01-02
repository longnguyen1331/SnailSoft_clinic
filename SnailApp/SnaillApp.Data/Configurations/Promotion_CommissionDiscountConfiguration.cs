using SnailApp.Data.Entities;
using SnailApp.ViewModels.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class Promotion_CommissionDiscountConfiguration : IEntityTypeConfiguration<Promotion_CommissionDiscount>
    {
        public void Configure(EntityTypeBuilder<Promotion_CommissionDiscount> builder)
        {
            builder.ToTable("Promotion_CommissionDiscounts");

            builder.HasOne(x => x.Promotion).WithMany(x => x.Promotion_CommissionDiscounts).HasForeignKey(x => x.PromotionId);

            builder.HasOne(x => x.CommissionDiscount).WithMany(x => x.Promotion_CommissionDiscounts).HasForeignKey(x => x.CommissionDiscountId);

        }
    }
}