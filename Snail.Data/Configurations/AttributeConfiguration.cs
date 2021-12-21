using Snail.Data.Entities;
using Snail.ViewModels.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class AttributeConfiguration : IEntityTypeConfiguration<Data.Entities.Attribute>
    {
        public void Configure(EntityTypeBuilder<Data.Entities.Attribute> builder)
        {
            builder.ToTable("Attributes");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
