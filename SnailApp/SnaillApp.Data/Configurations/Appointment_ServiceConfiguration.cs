using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class Appointment_ServiceConfiguration : IEntityTypeConfiguration<Appointment_Service>
    {
        public void Configure(EntityTypeBuilder<Appointment_Service> builder)
        {
            builder.ToTable("Appointment_Services");
        }
    }
}
