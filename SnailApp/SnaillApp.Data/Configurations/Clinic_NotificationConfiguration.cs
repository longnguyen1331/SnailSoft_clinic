using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class Clinic_NotificationConfigurationConfiguration : IEntityTypeConfiguration<Clinic_Notification>
    {
        public void Configure(EntityTypeBuilder<Clinic_Notification> builder)
        {
            builder.ToTable("Clinic_Notifications");
        }
    }
}
