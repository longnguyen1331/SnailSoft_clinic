using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class ProductSKU_AttributeValueConfiguration : IEntityTypeConfiguration<ProductSKU_AttributeValue>
    {
        public void Configure(EntityTypeBuilder<ProductSKU_AttributeValue> builder)
        {
            builder.ToTable("ProductSKU_AttributeValues");
            builder.HasKey(t => new {t.Id });
            builder.HasOne(t => t.ProductSKU).WithMany(pc => pc.ProductSKU_AttributeValues)
                .HasForeignKey(pc=>pc.ProductSKUId);
        }
    }
}
