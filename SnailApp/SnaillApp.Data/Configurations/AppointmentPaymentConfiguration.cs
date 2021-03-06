using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class AppointmentPaymentConfiguration : IEntityTypeConfiguration<AppointmentPayment>
    {
        public void Configure(EntityTypeBuilder<AppointmentPayment> builder)
        {
            builder.ToTable("AppointmentPayments");
        }
    }
}
