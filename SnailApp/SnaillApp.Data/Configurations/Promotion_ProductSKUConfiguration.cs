using SnailApp.Data.Entities;
using SnailApp.ViewModels.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class Promotion_ProductSKUConfiguration : IEntityTypeConfiguration<Promotion_ProductSKU>
    {
        public void Configure(EntityTypeBuilder<Promotion_ProductSKU> builder)
        {
            builder.ToTable("Promotion_ProductSKUs");

            builder.HasOne(x => x.Promotion).WithMany(x => x.Promotion_ProductSKUs).HasForeignKey(x => x.PromotionId);

            builder.HasOne(x => x.ProductSKU).WithMany(x => x.Promotion_ProductSKUs).HasForeignKey(x => x.ProductSKUId);

        }
    }
}