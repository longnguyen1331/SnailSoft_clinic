using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class AppUser_PromotionConfiguration : IEntityTypeConfiguration<AppUser_Promotion>
    {
        public void Configure(EntityTypeBuilder<AppUser_Promotion> builder)
        {
            builder.ToTable("AppUser_Promotions");

            builder.HasOne(x => x.AppUser).WithMany(x => x.AppUser_Promotions).HasForeignKey(x => x.AppUserId);

            builder.HasOne(x => x.Promotion).WithMany(x => x.AppUser_Promotions).HasForeignKey(x => x.PromotionId);
        }
    }
}