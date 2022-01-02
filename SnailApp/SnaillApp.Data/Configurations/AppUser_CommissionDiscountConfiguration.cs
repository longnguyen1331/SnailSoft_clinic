using SnailApp.Data.Entities;
using SnailApp.ViewModels.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class AppUser_CommissionDiscountConfiguration : IEntityTypeConfiguration<AppUser_CommissionDiscount>
    {
        public void Configure(EntityTypeBuilder<AppUser_CommissionDiscount> builder)
        {
            builder.ToTable("AppUser_CommissionDiscounts");

            builder.HasOne(x => x.AppUser).WithMany(x => x.AppUser_CommissionDiscounts).HasForeignKey(x => x.AppUserId);

            builder.HasOne(x => x.CommissionDiscount).WithMany(x => x.AppUser_CommissionDiscounts).HasForeignKey(x => x.CommissionDiscountId);

        }
    }
}