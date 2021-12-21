using Snail.Data.Entities;
using Snail.ViewModels.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class PayrollDetailConfiguration : IEntityTypeConfiguration<PayrollDetail>
    {
        public void Configure(EntityTypeBuilder<PayrollDetail> builder)
        {
            builder.ToTable("PayrollDetails");

            builder.HasOne(x => x.Payroll).WithMany(x => x.PayrollDetails).HasForeignKey(x => x.PayrollId);
            builder.HasOne(x => x.AppUser).WithMany(x => x.PayrollDetails).HasForeignKey(x => x.AppUserId);
        }
    }
}
