using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class AppUserFeedbackConfiguration : IEntityTypeConfiguration<AppUserFeedback>
    {
        public void Configure(EntityTypeBuilder<AppUserFeedback> builder)
        {
            builder.ToTable("AppUserFeedbacks");

            builder.HasOne(x => x.AppUser).WithMany(x => x.AppUserFeedbacks).HasForeignKey(x => x.AppUserId);
        }
    }
}