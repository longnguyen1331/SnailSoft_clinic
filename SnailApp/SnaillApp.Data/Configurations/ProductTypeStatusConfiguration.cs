﻿using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class ProductTypeStatusConfiguration : IEntityTypeConfiguration<ProductTypeStatus>
    {
        public void Configure(EntityTypeBuilder<ProductTypeStatus> builder)
        {
            builder.ToTable("ProductTypeStatuses");
        }
    }
}