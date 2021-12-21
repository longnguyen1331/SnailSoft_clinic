using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class OrderStatusTranslationConfiguration : IEntityTypeConfiguration<OrderStatusTranslation>
    {
        public void Configure(EntityTypeBuilder<OrderStatusTranslation> builder)
        {
            builder.ToTable("OrderStatusTranslations");

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.OrderStatusTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.OrderStatus).WithMany(x => x.OrderStatusTranslations).HasForeignKey(x => x.OrderStatusId);

        }
    }
}