using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class PostImageConfiguration : IEntityTypeConfiguration<PostImage>
    {
        public void Configure(EntityTypeBuilder<PostImage> builder)
        {
            builder.ToTable("PostImages");
            
            builder.Property(x => x.Image).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.Name).HasMaxLength(200);

            builder.HasOne(x => x.Post).WithMany(x => x.PostImages).HasForeignKey(x => x.PostId);
        }
    }
}
