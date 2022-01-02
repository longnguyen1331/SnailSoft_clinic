using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class PostTypeStatusConfiguration : IEntityTypeConfiguration<PostTypeStatus>
    {
        public void Configure(EntityTypeBuilder<PostTypeStatus> builder)
        {
            builder.ToTable("PostTypeStatuses");
        }
    }
}
