using Snail.Data.Entities;
using Snail.ViewModels.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class AppUser_BasicSalaryConfiguration : IEntityTypeConfiguration<AppUser_BasicSalary>
    {
        public void Configure(EntityTypeBuilder<AppUser_BasicSalary> builder)
        {
            builder.ToTable("AppUser_BasicSalarys");

            builder.HasOne(x => x.AppUser).WithMany(x => x.AppUser_BasicSalarys).HasForeignKey(x => x.AppUserId);

            builder.HasOne(x => x.BasicSalary).WithMany(x => x.AppUser_BasicSalarys).HasForeignKey(x => x.BasicSalaryId);

        }
    }
}