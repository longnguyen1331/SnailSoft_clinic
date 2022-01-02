using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class AppUserHelpConfiguration : IEntityTypeConfiguration<AppUserHelp>
    {
        public void Configure(EntityTypeBuilder<AppUserHelp> builder)
        {
            builder.ToTable("AppUserHelps");

            builder.HasOne(x => x.AppUser).WithMany(x => x.AppUserHelps).HasForeignKey(x => x.AppUserId);
        }
    }
}