﻿using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class PostTypeStatusTranslationConfiguration : IEntityTypeConfiguration<PostTypeStatusTranslation>
    {
        public void Configure(EntityTypeBuilder<PostTypeStatusTranslation> builder)
        {
            builder.ToTable("PostTypeStatusTranslations");

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.PostTypeStatusTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.PostTypeStatus).WithMany(x => x.PostTypeStatusTranslations).HasForeignKey(x => x.PostTypeStatusId);

        }
    }
}