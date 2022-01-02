using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class AppUserTypeConfiguration : IEntityTypeConfiguration<AppUserType>
    {
        public void Configure(EntityTypeBuilder<AppUserType> builder)
        {
            builder.ToTable("AppUserTypes");
        }
    }
}
