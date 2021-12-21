using Snail.Data.Entities;
using Snail.ViewModels.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class PostTypeConfiguration : IEntityTypeConfiguration<PostType>
    {
        public void Configure(EntityTypeBuilder<PostType> builder)
        {
            builder.ToTable("PostTypes");

            builder.HasOne(x => x.PostTypeStatus).WithMany(x => x.PostTypes).HasForeignKey(x => x.PostTypeStatusId);
        }
    }
}
