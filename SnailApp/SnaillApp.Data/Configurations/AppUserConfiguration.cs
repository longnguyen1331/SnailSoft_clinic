using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");
            builder.HasOne(x => x.AppUserStatus).WithMany(x => x.AppUsers).HasForeignKey(x => x.AppUserStatusId);
            builder.HasOne(x => x.Country).WithMany(x => x.AppUsers).HasForeignKey(x => x.CountryId);
        }
    }
}
