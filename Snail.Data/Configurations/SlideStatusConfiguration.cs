using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class SlideStatusConfiguration : IEntityTypeConfiguration<SlideStatus>
    {
        public void Configure(EntityTypeBuilder<SlideStatus> builder)
        {
            builder.ToTable("SlideStatuses");
        }
    }
}