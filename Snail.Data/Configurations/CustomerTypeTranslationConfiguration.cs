using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class CustomerTypeTranslationConfiguration : IEntityTypeConfiguration<CustomerTypeTranslation>
    {
        public void Configure(EntityTypeBuilder<CustomerTypeTranslation> builder)
        {
            builder.ToTable("CustomerTypeTranslations");

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.CustomerTypeTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.CustomerType).WithMany(x => x.CustomerTypeTranslations).HasForeignKey(x => x.CustomerTypeId);

        }
    }
}
