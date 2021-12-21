﻿using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
namespace Snail.Data.Configurations
{
    public class StoreStatusTranslationConfiguration : IEntityTypeConfiguration<StoreStatusTranslation>
    {
        public void Configure(EntityTypeBuilder<StoreStatusTranslation> builder)
        {
            builder.ToTable("StoreStatusTranslations");

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.StoreStatusTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.StoreStatus).WithMany(x => x.StoreStatusTranslations).HasForeignKey(x => x.StoreStatusId);

        }
    }
}