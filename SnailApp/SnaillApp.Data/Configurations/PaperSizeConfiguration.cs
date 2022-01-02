using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class PaperSizeConfiguration : IEntityTypeConfiguration<PaperSize>
    {
        public void Configure(EntityTypeBuilder<PaperSize> builder)
        {
            builder.ToTable("PaperSizes");

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        }
    }
}