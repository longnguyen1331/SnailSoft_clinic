using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class ProductInProductTypeConfiguration : IEntityTypeConfiguration<ProductInProductType>
    {
        public void Configure(EntityTypeBuilder<ProductInProductType> builder)
        {
            builder.HasKey(t => new {t.ProductTypeId, t.ProductId });

            builder.ToTable("ProductInProductTypes");

            builder.HasOne(t => t.Product).WithMany(pc => pc.ProductInProductTypes)
                .HasForeignKey(pc=>pc.ProductId);

            builder.HasOne(t => t.ProductType).WithMany(pc => pc.ProductInProductTypes)
              .HasForeignKey(pc => pc.ProductTypeId);
        }
    }
}
