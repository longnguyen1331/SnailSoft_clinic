using SnailApp.Data.Entities;
using SnailApp.ViewModels.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts");

            builder.HasOne(x => x.PostStatus).WithMany(x => x.Posts).HasForeignKey(x => x.PostStatusId);
            builder.HasOne(x => x.PostType).WithMany(x => x.Posts).HasForeignKey(x => x.PostTypeId);
        }
    }
}
