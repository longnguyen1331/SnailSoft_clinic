using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class NewsletterConfiguration : IEntityTypeConfiguration<Newsletter>
    {
        public void Configure(EntityTypeBuilder<Newsletter> builder)
        {
            builder.ToTable("Newsletters");
        }
    }
}