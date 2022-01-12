using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class Doctor_ServiceConfiguration : IEntityTypeConfiguration<Doctor_Service>
    {
        public void Configure(EntityTypeBuilder<Doctor_Service> builder)
        {
            builder.ToTable("Doctor_Services");
        }
    }
}
