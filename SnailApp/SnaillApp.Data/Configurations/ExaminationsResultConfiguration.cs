using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class ExaminationsResultConfiguration : IEntityTypeConfiguration<ExaminationsResult>
    {
        public void Configure(EntityTypeBuilder<ExaminationsResult> builder)
        {
            builder.ToTable("ExaminationsResults");
        }
    }
}
