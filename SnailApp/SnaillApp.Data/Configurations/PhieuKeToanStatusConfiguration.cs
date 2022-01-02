using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class  PhieuKeToanStatusConfiguration : IEntityTypeConfiguration<PhieuKeToanStatus>
    {
        public void Configure(EntityTypeBuilder<PhieuKeToanStatus> builder)
        {
            builder.ToTable("PhieuKeToanStatuses");
        }
    }
}
