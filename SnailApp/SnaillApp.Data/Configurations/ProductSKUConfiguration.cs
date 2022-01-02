using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class ProductSKUConfiguration : IEntityTypeConfiguration<ProductSKU>
    {
        public void Configure(EntityTypeBuilder<ProductSKU> builder)
        {
            builder.ToTable("ProductSKUs");
            builder.HasKey(t => new {t.Id });
            builder.HasOne(t => t.Product).WithMany(pc => pc.ProductSKUs)
                .HasForeignKey(pc=>pc.ProductId);
        }
    }
}
