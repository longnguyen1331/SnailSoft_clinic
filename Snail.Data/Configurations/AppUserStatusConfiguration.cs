using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class AppUserStatusConfiguration : IEntityTypeConfiguration<AppUserStatus>
    {
        public void Configure(EntityTypeBuilder<AppUserStatus> builder)
        {
            builder.ToTable("AppUserStatuses");
        }
    }
}
