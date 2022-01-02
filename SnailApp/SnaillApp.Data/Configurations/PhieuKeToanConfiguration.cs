using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class PhieuKeToanConfiguration : IEntityTypeConfiguration<PhieuKeToan>
    {
        public void Configure(EntityTypeBuilder<PhieuKeToan> builder)
        {
            builder.ToTable("PhieuKeToans");

            builder.HasOne(x => x.PhieuKeToanStatus).WithMany(x => x.PhieuKeToans).HasForeignKey(x => x.PhieuKeToanStatusId);
        }
    }
}
