using Snail.Data.Entities;
using Snail.ViewModels.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class AppUser_AppUserTypeConfiguration : IEntityTypeConfiguration<AppUser_AppUserType>
    {
        public void Configure(EntityTypeBuilder<AppUser_AppUserType> builder)
        {
            builder.ToTable("AppUser_AppUserTypes");

            builder.HasOne(x => x.AppUser).WithMany(x => x.AppUser_AppUserTypes).HasForeignKey(x => x.AppUserId);

            builder.HasOne(x => x.AppUserType).WithMany(x => x.AppUser_AppUserTypes).HasForeignKey(x => x.AppUserTypeId);

        }
    }
}