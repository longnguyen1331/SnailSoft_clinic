using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class PhieuKeToanChiTiet_AppUserConfiguration : IEntityTypeConfiguration<PhieuKeToanChiTiet_AppUser>
    {
        public void Configure(EntityTypeBuilder<PhieuKeToanChiTiet_AppUser> builder)
        {
            builder.ToTable("PhieuKeToanChiTiet_AppUsers");
            builder.HasOne(x => x.PhieuKeToanChiTiet).WithMany(x => x.PhieuKeToanChiTiets).HasForeignKey(x => x.PhieuKeToanChiTietId);
            builder.HasOne(x => x.AppUser).WithMany(x => x.PhieuKeToanChiTiet_AppUsers).HasForeignKey(x => x.AppUserId);
        }
    }
}
