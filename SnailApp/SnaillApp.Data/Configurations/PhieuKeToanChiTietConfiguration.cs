using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class PhieuKeToanChiTietConfiguration : IEntityTypeConfiguration<PhieuKeToanChiTiet>
    {
        public void Configure(EntityTypeBuilder<PhieuKeToanChiTiet> builder)
        {
            builder.ToTable("PhieuKeToanChiTiets");
         
            builder.HasOne(x => x.PhieuKeToan).WithMany(x => x.PhieuKeToanChiTiets).HasForeignKey(x => x.PhieuKeToanId);
        }
    }
}
